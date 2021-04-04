using Foodsharing.DAL.Repositories;
using Homeshare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Repositories
{
    public class MessageRepository : BaseRepository<MessageEntity>, IConcreteRepository<MessageEntity>
    {
        public MessageRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(MessageEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<MessageEntity> Get()
        {
            throw new NotImplementedException();
        }

        public MessageEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MessageEntity toInsert)
        {
            string requete = @"INSERT INTO Message (Prenom, Nom, Email, Message, DateEnvoie)
                               VALUES (@Prenom, @Nom, @Email, @Message, GETDATE())";
            return base.Insert(toInsert, requete);
        }

        public bool Update(MessageEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
