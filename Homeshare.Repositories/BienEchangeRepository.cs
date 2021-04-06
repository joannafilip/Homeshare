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
        public List<BienEchangeEntity> Get12DerniersBiens()
        {
            string requete = "Select * from Vue_12DernierBiens";

            return base.Get(requete);
        }
        public List<BienEchangeEntity> GetMeilleursAvis()
        {
            string requete = "Select * from Vue_MeilleursAvis";

            return base.Get(requete);
        }

        public List<BienEchangeEntity> Get()
        {
            string requete = "Select * from V_GetAllProperties";

            return base.Get(requete);
        }
        public List<BienEchangeEntity> GetHotProperties()
        {
            string requete = "Select * from V_HotProperties";

            return base.Get(requete);
        }

        public List<BienEchangeEntity> GetPropertyEntityByPage(int page, string searchString, string sortOrder)
        {
            string requete = $@"Select * from V_GetAllProperties";

            if (!String.IsNullOrEmpty(searchString))
            {
                requete += " WHERE Titre LIKE '%" + searchString + "%' ";
            }

            switch (sortOrder)
            {
                case "titre_desc":
                    requete += " ORDER BY Titre ASC ";
                    break;
                case "date_asc":
                    requete += " ORDER BY DateCreation ASC ";
                    break;
                case "date_desc":
                    requete += " ORDER BY DateCreation DESC ";
                    break;
                default:
                    requete += " ORDER BY Titre ";
                    break;
            }


            int nbPerPage = 4;
            int skip = (page - 1) * nbPerPage;
            //requete += $@" ORDER BY Titre OFFSET {skip} ROWS si sons sortOrder
            requete += $@" OFFSET {skip} ROWS 
                        FETCH NEXT {nbPerPage} ROWS ONLY ";
            return base.Get(requete);
        }
        public List<BienEchangeEntity> GetPropertiesEntitiesAllPage(int page, string searchString, string sortOrder)
        {
            string requete = $@"SELECT * from V_GetAllProperties";

            if (!String.IsNullOrEmpty(searchString))
            {
                requete += " WHERE Titre LIKE '%" + searchString + "%' ";

            }
            switch (sortOrder)
            {
                case "titre_desc":
                    requete += " ORDER BY Titre DESC ";
                    break;
                case "date_asc":
                    requete += " ORDER BY DateCreation ASC ";
                    break;
                case "date_desc":
                    requete += " ORDER BY DateCreation DESC ";
                    break;
                default:
                    requete += " ORDER BY Titre ";
                    break;
            }

            return base.Get(requete);
        }

        public BienEchangeEntity GetOne(int idBien)
        {
            string requete = "EXEC [dbo].[sp_RecupToutesInfosBien]" + @idBien;
            return base.GetOne(idBien, requete);
        }

        public bool Insert(BienEchangeEntity toInsert)
        {
            string requete = @"EXEC [dbo].[SP_InsertBien] 
                                                    @titre
                                                   ,@descCourte
                                                   ,@descLong
                                                   ,@nombrePerson
                                                   ,@pays
                                                   ,@ville
                                                   ,@rue
                                                   ,@numero
                                                   ,@codePostale
                                                   ,@photo
                                                   ,@assuranceObligatoire
                                                   ,@isEnabled
                                                   ,@latitude
                                                   ,@longitude
                                                   ,@idMembre";
            return base.Insert(toInsert, requete);
        }

        public bool Update(BienEchangeEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
