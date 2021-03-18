using Foodsharing.DAL.Repositories;
using Homeshare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Repositories
{
    public class PaysListRepository : BaseRepository<PaysListEntity>, IConcreteRepository<PaysListEntity>
    {
        public PaysListRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(PaysListEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<PaysListEntity> Get()
        {
            string requete = "Select IdPays, Libelle from Pays";

            return base.Get(requete);
        }

        public PaysListEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(PaysListEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaysListEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
