using FEI.Extension.Datos;
using Models.Modelos;
using System.Net.Http;

namespace FEI.Extension.Triggers
{
    public class EntityData
    {
        private HttpClient Client;
        public clsEntityUsers User;
        public clsEntityDatabaseLocal LocalDB;
        private clsEntityAccount Profile;
        private clsEntityDeclarant Company;

        public EntityData(HttpClient client, clsEntityUsers user, clsEntityDatabaseLocal localDB, clsEntityAccount profile, clsEntityDeclarant company)
        {
            Client  = client;
            User    = user;
            LocalDB = localDB;
            Profile = profile;
            Company = company;
        }
    }
}
