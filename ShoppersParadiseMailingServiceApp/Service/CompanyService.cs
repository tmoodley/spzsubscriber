using MongoDB.Driver;
using ShoppersParadiseMailingServiceApp.DAL;
using ShoppersParadiseMailingServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppersParadiseMailingServiceApp.Service
{    
    public class CompanyService
    {
        private readonly MongoHelper<Company> _companys;
        public CompanyService()
        {
            _companys = new MongoHelper<Company>();
        }

        public void Create(Company company)
        {
            _companys.Collection.Save(company);
        }

        public IList<Company> GetCompanys()
        {
            try
            {
                return _companys.Collection.FindAll().ToList<Company>();
            }
            catch (MongoConnectionException)
            {
                return new List<Company>();
            }
        }

    }
}