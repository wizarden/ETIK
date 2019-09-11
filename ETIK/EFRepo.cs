using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ETIK
{
    public class EFRepo
    {
        private EFDbContext context;

        public EFRepo()
        {
            context = new EFDbContext(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        }

        public IEnumerable<IZD> GetIZDs()
        {
            return context.IZDs;
        }
    }
}