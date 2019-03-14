using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public ListenerDatabase()
        {
             RetrieveData().Wait();
        }

        //Todo: Trabalhar com assincronismo
        public async Task RetrieveData()
        {
            try
            {
                _database = Database.GetConnection().GetDatabase("DigisatServer");
                collection = _database.GetCollection<BsonDocument>("Movimentacoes");

                BsonDocument filter = new BsonDocument();
                filter.Add("_t", new BsonRegularExpression(".*PreVenda.*", "i"));
                filter.Add("$and", new BsonArray()
                    .Add(new BsonDocument()
                        .Add("Historicos.NomeUsuario", "admin")
                    )
                );

                BsonDocument projection = new BsonDocument();
                projection.Add("ItensBase", 1.0);
                projection.Add("Historicos", 1.0);

                var options = new FindOptions<BsonDocument>()
                {
                    Projection = projection
                };

                var cursor = collection.Find(filter).Sort(new BsonDocument("Historicos.NomeUsuario", -1)).Limit(1).ToList();

                cursor.ForEach(x =>
                {
                    MessageBox.Show(x["_t"].ToString());
                });

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}