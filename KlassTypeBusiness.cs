using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
   public class KlassTypeBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<KlassType> all()
        {
            return db.KlassType.ToList();
        }
        public bool add(KlassType model)
        {
            try
            {
                db.KlassType.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(KlassType model)
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
        public bool delete(KlassType model)
        {
            try
            {
                db.KlassType.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public KlassType find_by_id(int? id)
        {
            return db.KlassType.Find(id);
        }




    }
}
