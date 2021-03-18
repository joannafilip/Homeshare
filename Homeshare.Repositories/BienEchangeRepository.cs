using Foodsharing.DAL.Repositories;
using Homeshare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Repositories
{
    class BienEchangeRepository : BaseRepository<BienEchangeEntity>, IConcreteRepository<BienEchangeEntity>
    {
        public BienEchangeRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(BienEchangeEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<BienEchangeEntity> GetBienMembre(int idMembre)
        {
            string requete = "EXEC [dbo].[sp_RecupBienMembre]" + @idMembre;

            return base.Get(requete);
        }
        public List<BienEchangeEntity> Get()
        {
            throw new NotImplementedException();
        }



        public BienEchangeEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BienEchangeEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(BienEchangeEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
