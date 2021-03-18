using Foodsharing.DAL.Repositories;
using Homeshare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Repositories
{
    class RegisterRepository : BaseRepository<RegisterEntity>, IConcreteRepository<RegisterEntity>
    {
        public RegisterRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(RegisterEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<RegisterEntity> Get()
        {
            throw new NotImplementedException();
        }

        public RegisterEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(RegisterEntity toInsert)
        {
            string requete = @"EXEC [dbo].[sp_InsertMember]
                                                        @nom
                                                       ,@prenom
                                                       ,@email
                                                       ,@login
                                                       ,@password
                                                       ,@telephone
                                                       ,@idPays";
            return base.Insert(toInsert, requete);
        }

        public bool Update(RegisterEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
