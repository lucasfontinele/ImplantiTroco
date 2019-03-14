using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Implanti.Source.Classes
{
    class Movimentacoes
    {
        [BsonId]
        public ObjectId ID { get; set; }
        [BsonElement("_t")]
        public List<String> _t { get; set; }
        [BsonElement("InformacoesPesquisa")]
        public List<String> InformacoesPesquisa { get; set; }
        [BsonElement("Versao")]
        public string Versao { get; set; }
        [BsonElement("Ativo")]
        public Boolean Ativo { get; set; }
        [BsonElement("Numero")]
        public Int64 Numero { get; set; }
        [BsonElement("DataHoraEmissao")]
        public DateTime DataHoraEmissao { get; set; }
    }    
}