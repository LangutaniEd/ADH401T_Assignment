using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
  public  class PackagesBusiness
    {

        private KFG_Db db = new KFG_Db(); 

        public List<MembershipPackages> all()
        {
            return db.MembershipPackages.ToList();
        }
        public bool add(MembershipPackages model)
        {
            try
            {
                db.MembershipPackages.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(MembershipPackages model)
        {
            try
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool delete(MembershipPackages model)
        {
            try
            {
                db.MembershipPackages.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public MembershipPackages find_by_id(int? id)
        {
            return db.MembershipPackages.Find(id);
        }
       
    


    }
}
