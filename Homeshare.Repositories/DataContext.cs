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
        public List<BienEchangeModel> Get12DernierBiens()
        {
            List<BienEchangeModel> bem = new List<BienEchangeModel>();
            List<BienEchangeEntity> derniersBiens = ((BienEchangeRepository)_bienEchangeRepo).Get12DerniersBiens();

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
                b.IdMembre = bien.IdMembre;
                b.Pays = bien.Libelle;
                b.IdBien = bien.IdBien;


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
                b.DescCourte = avis.DescCourte;
                b.DescLong = avis.DescLong;
                b.Latitude = avis.Latitude;
                b.Longitude = avis.Longitude;
                b.NombrePerson = avis.NombrePerson;
                b.Photo = avis.Photo;
                b.Ville = avis.Ville;
                b.IsEnabled = avis.IsEnabled;
                b.IdMembre = avis.IdMembre;
                b.Pays = avis.Libelle;
                b.IdBien = avis.IdBien;
                bem.Add(b);
            }
            return bem;

        }
        public List<BienEchangeModel> GetAllProperties()
        {
            List<BienEchangeModel> bem = new List<BienEchangeModel>();
            List<BienEchangeEntity> allProperties = _bienEchangeRepo.Get();

            foreach (BienEchangeEntity property in allProperties)
            {
                BienEchangeModel b = new BienEchangeModel();
                b.Titre = property.Titre;
                b.Note = property.Note;
                b.DescCourte = property.DescCourte;
                b.DescLong = property.DescLong;
                b.Latitude = property.Latitude;
                b.Longitude = property.Longitude;
                b.NombrePerson = property.NombrePerson;
                b.Photo = property.Photo;
                b.Ville = property.Ville;
                b.IsEnabled = property.IsEnabled;
                b.IdMembre = property.IdMembre;
                b.Pays = property.Libelle;
                b.IdBien = property.IdBien;
                bem.Add(b);
            }
            return bem;

        }

        public List<BienEchangeModel> GetHotProperties()
        {
            List<BienEchangeModel> bem = new List<BienEchangeModel>();
            List<BienEchangeEntity> hotProperties = ((BienEchangeRepository)_bienEchangeRepo).GetHotProperties();

            foreach (BienEchangeEntity bien in hotProperties)
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
                be.Pays = bien.Libelle;
                bem.Add(be);
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
                be.Pays = bien.Libelle;
                bem.Add(be);
            }
            return bem;
        }
        public BienEchangeModel GetOneBienByPage(int PK)
        {
            BienEchangeModel be = new BienEchangeModel();
            BienEchangeEntity bien = _bienEchangeRepo.GetOne(PK);
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
                be.Pays = bien.Libelle;

            return be;
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
            bee.Libelle = bem.Pays;
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
