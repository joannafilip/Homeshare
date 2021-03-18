using Foodsharing.DAL.Repositories;
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
    }
