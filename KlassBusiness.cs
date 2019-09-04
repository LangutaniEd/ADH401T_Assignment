using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
  public  class KlassBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<Klass> all()
        {
            return db.Klass.Include("Equipment_Type,KlassType,KlassVenue").ToList();
            //return db.Klass.ToList();
        }
        public bool add(Klass model)
        {
            try
            {
                db.Klass.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(Klass model)
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
        public bool delete(Klass model)
        {
            try
            {
                db.Klass.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public Klass find_by_id(int? id)
        {
            return db.Klass.Find(id);
        }

    }
}
