using Foodsharing.DAL.Repositories;
using Homeshare.Entities;
using Homeshare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Repositories
{
    public class DataContext
    {
        IConcreteRepository<PaysListEntity> _paysListRepo;
        IConcreteRepository<RegisterEntity> _registerRepo;

        public DataContext(string connectionString)
        {
            _paysListRepo = new PaysListRepository(connectionString);
            _registerRepo = new RegisterRepository(connectionString);
        }

        public List<PaysListModel> SelectPays()
        {
            List<PaysListModel> plm = new List<PaysListModel>();
            List<PaysListEntity> allPays = _paysListRepo.Get();//Récupération mon entity
            foreach (PaysListEntity pays in allPays)
            {
                PaysListModel pl = new PaysListModel();
                pl.IdPays = pays.IdPays;
                pl.Libelle = pays.Libelle;
                plm.Add(pl);
            }
            return plm;
        }
        public bool SaveSignUp(RegisterModel rm, PaysListModel plm)
        {

            RegisterEntity r = new RegisterEntity();
            r.Nom= rm.Nom;
            r.Prenom = rm.Prenom;
            r.Email = rm.Email;
            r.Login = rm.Login;
            r.Password = rm.Password;
            r.Telephone = rm.Telephone;
            r.IdPays = plm.IdPays;
            return _registerRepo.Insert(r);

        }

        public RegisterModel UserAuth(LoginModel lm)
        {
            RegisterEntity re = ((RegisterRepository)_registerRepo).GetFromLogin(lm.Login, lm.Password);
            if (re == null) return null;
            if (re != null)
            {
                PaysListModel plm = new PaysListModel();
                return new RegisterModel()
                {
                   
                    Nom = re.Nom,
                    Prenom = re.Prenom,
                    Login = re.Login,
                    Email = re.Email,
                    Telephone = re.Telephone,
                    Pays = re.Libelle
                    
                    
                };
            }
            else
            {
                return null;
            }

        }
    }
}
