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
        IConcreteRepository<BienEchangeEntity> _bienEchangeRepo;

        public DataContext(string connectionString)
        {
            _paysListRepo = new PaysListRepository(connectionString);
            _registerRepo = new RegisterRepository(connectionString);
            _bienEchangeRepo = new BienEchangeRepository(connectionString);
        }
        public List<BienEchangeModel> GetCinqDernierBiens()
        {
            List<BienEchangeModel> bem = new List<BienEchangeModel>(); 
            List<BienEchangeEntity> derniersBiens = _bienEchangeRepo.Get();

            foreach (BienEchangeEntity bien in derniersBiens)
            {
                BienEchangeModel b = new BienEchangeModel();
                b.DescCourte = bien.DescCourte;
                b.DescLong = bien.DescLong;
                b.Latitude = bien.Latitude;
                b.Longitude = bien.Longitude;
                b.NombrePerson = bien.NombrePerson;
                b.Photo = bien.Photo;
                b.Ville = bien.Ville;
                b.Titre = bien.Titre;
                b.IsEnabled = bien.IsEnabled;

                bem.Add(b);
            }
            return bem;

        }
        public List<BienEchangeModel> GetMeilleursAvis()
        {
            List<BienEchangeModel> bem = new List<BienEchangeModel>();
            List<BienEchangeEntity> meilleursAvis = ((BienEchangeRepository)_bienEchangeRepo).GetMeilleursAvis();

            foreach (BienEchangeEntity avis in meilleursAvis)
            {
                BienEchangeModel b = new BienEchangeModel();
                b.Titre = avis.Titre;
                b.Note = avis.Note;
                bem.Add(b);
            }
            return bem;

        }

        public List<BienEchangeModel> GetBiensMembre(RegisterModel bm )
        {
            List<BienEchangeModel> bem = new List<BienEchangeModel>();
            List<BienEchangeEntity>biensMembre = ((BienEchangeRepository)_bienEchangeRepo).GetBienMembre(bm.IdMembre);
            foreach (BienEchangeEntity bien in biensMembre)
            {
                BienEchangeModel be = new BienEchangeModel();
                be.Titre = bien.Titre;
                be.DescCourte = bien.DescCourte;
                be.Latitude = bien.Latitude;
                be.Longitude = bien.Longitude;
                be.NombrePerson = bien.NombrePerson;
                be.Note = bien.Note;
                be.Numero = bien.Numero;
                be.Photo = bien.Photo;
                be.Numero = bien.Numero;
                be.Rue = bien.Rue;
                be.Ville = bien.Ville;
                be.DescLong = bien.DescLong;
                be.CodePostale = bien.CodePostale;
                be.DateCreation = bien.DateCreation;
                be.AssuranceObligatoire = bien.AssuranceObligatoire;
                be.IdMembre = bien.IdMembre;
                be.IdBien = bien.IdBien;
                
  
                bem.Add(be);
            }
            return bem;
        }

        public List<PaysListModel> SelectPays()
        {
            List<PaysListModel> plm = new List<PaysListModel>();
            List<PaysListEntity> allPays = _paysListRepo.Get();
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
            r.IdMembre = rm.IdMembre;
            return _registerRepo.Insert(r);

        }
        public bool InsertBien(BienEchangeModel bem)
        {

            BienEchangeEntity bee = new BienEchangeEntity();
            bee.Titre = bem.Titre;
            bee.CodePostale = bem.CodePostale;
            bee.DateCreation = bem.DateCreation;
            bee.DescCourte = bem.DescCourte;
            bee.DescLong = bem.DescLong;
            bee.DisabledDate = bem.DisabledDate;
            bee.IdMembre = bem.IdMembre;
            bee.IsEnabled = bem.IsEnabled;
            bee.Latitude = bem.Latitude;
            bee.Longitude = bem.Longitude;
            bee.NombrePerson = bem.NombrePerson;
            bee.Numero = bem.Numero;
            bee.Pays = bem.IdPays;
            bee.Photo = bem.Photo;
            bee.Rue = bem.Rue;
            bee.Ville = bem.Ville;
            bee.AssuranceObligatoire = bem.AssuranceObligatoire;
            return _bienEchangeRepo.Insert(bee);

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
                    Pays = re.Libelle,
                    IdMembre = re.IdMembre
                    
                    
                };
            }
            else
            {
                return null;
            }

        }
    }
}
