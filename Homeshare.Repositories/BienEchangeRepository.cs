﻿using Foodsharing.DAL.Repositories;
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
            string requete = "Select * from Vue_CinqDernierBiens";

            return base.Get(requete);
        }



        public BienEchangeEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(BienEchangeEntity toInsert)
        {
            string requete = @"EXEC [dbo].[sp_InsertBien] 
                                                    @titre
                                                   ,@descCourte
                                                   ,@descLong
                                                   ,@nombrePerson
                                                   ,@idPays
                                                   ,@ville
                                                   ,@rue
                                                   ,@numero
                                                   ,@codePostal
                                                   ,@photo
                                                   ,@assuranceObligatoire
                                                   ,@isEnabled
                                                   ,@disabledDate
                                                   ,@latitude
                                                   ,@longitude
                                                   ,@dateCreation
                                                   ,@idMembre";
            return base.Insert(toInsert, requete);
        }

        public bool Update(BienEchangeEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
