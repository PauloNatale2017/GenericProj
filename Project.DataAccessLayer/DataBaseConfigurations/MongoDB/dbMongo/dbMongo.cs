using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MongoDB.Driver;
using System.Configuration;

namespace Project.DataAccessLayer.DataBaseConfigurations.MongoDB.dbMongo
{
    public  class dbMongo
    {
        public MongoDatabase Database;
        public String DataBaseName = "";
        string conexaoMongoDB = "";

        public dbMongo(string DataBaseName)
        {
            conexaoMongoDB = ConfigurationManager.ConnectionStrings["conexaoMongoDB"].ConnectionString;
            var cliente = new MongoClient(conexaoMongoDB);
            var server = cliente.GetServer();
            Database = server.GetDatabase(DataBaseName);
        }
    }
}
