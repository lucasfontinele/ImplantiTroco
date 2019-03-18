using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Implanti.Source.Classes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Implanti.Source
{
    class ListenerDatabase
    {        
        private List<String> collectionsNameList = new List<string>() { "Movimentacoes" };

        private static String _collectionName = "Movimentacoes";
        private IMongoDatabase _database;
        private IMongoCollection<BsonDocument> collection;
        private BsonObjectId LastId;
        private BsonObjectId ObjectId;
        private readonly BsonDocument Filter;
        private readonly BsonDocument Sort;
        public double value;

        public List<BsonDocument> GetData() => collection.Find(Filter).Sort(Sort).Limit(1).ToList();

        public ListenerDatabase()
        {
            _database = Database.GetConnection().GetDatabase("DigisatServer");
            collection = _database.GetCollection<BsonDocument>("Movimentacoes");
            Filter = new BsonDocument("_t", new BsonRegularExpression(".*PreVenda.*", "i"));
            Sort = new BsonDocument("DataHoraEmissao", -1.0);
        }

        //Todo: Trabalhar com assincronismo
        public Boolean RetrieveData()
        { 
            try
            {                
                if (LastId == null)
                {
                    LastId = this.GetData()[0]["_id"].AsObjectId;
                }

                if (LastId != this.GetData()[0]["_id"].AsObjectId)
                {
                    var ini = new IniFile("Settings.ini");

                    if (ini.Read("User", "Settings").ToLower() == GetData()[0]["Historicos"][0]["NomeUsuario"].ToString().ToLower())
                    {                  
                        LastId = this.GetData()[0]["_id"].AsObjectId;

                        GetData()[0]["ItensBase"].AsBsonArray.ToList().ForEach(x =>
                        {
                            if (!x["Cancelado"].AsBoolean)
                            {
                                value += x["Quantidade"].ToDouble() * x["PrecoUnitario"].ToDouble();
                                value += x["OutrasDespesasDigitado"].ToDouble() + x["OutrasDespesasProporcional"].ToDouble();
                                value += x["Frete"].ToDouble() + x["Seguro"].ToDouble();
                                value -= x["DescontoDigitado"].ToDouble() + x["DescontoProporcional"].ToDouble();                                
                            }
                        });

                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return false;
        }
    }
}