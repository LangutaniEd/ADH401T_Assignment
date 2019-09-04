
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using KFP.DATA;
using KFP.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFP.BUSINESS
{
    class RoleBusiness
    {
        private RoleManager<ApplicationRole> RoleManager { get; set; }

        public RoleBusiness()
        {
            RoleManager = new RoleManager<ApplicationRole>(new RoleStore<ApplicationRole>(new IdentityDbContext()));
        }

        public bool RoleExists(string name)
        {
            return RoleManager.RoleExists(name);
        }

        public bool CreateRole(string name)
        {
            var idResult = RoleManager.Create(new ApplicationRole(name));
            return idResult.Succeeded;
        }
    }
}
