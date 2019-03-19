using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace Implanti.Source
{
    class Database
    {
        private static IniFile myIni = new IniFile("Settings.ini");
        private static readonly MongoClient _client = new MongoClient(myIni.Read("DatabaseUrl", "Settings"));
        //private static readonly MongoClient _client = new MongoClient("mongodb://root:%7CcSFu%405rFv%23h8*%3D@localhost:12220/admin?readPreference=primary");

        public static MongoClient GetConnection() => _client;        
    }
}