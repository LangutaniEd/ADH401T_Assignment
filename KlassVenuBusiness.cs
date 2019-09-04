using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
   public class KlassVenuBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<KlassVenue> all()
        {
            return db.KlassVenue.ToList();
        }
        public bool add(KlassVenue model)
        {
            try
            {
                db.KlassVenue.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(KlassVenue model)
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
        public bool delete(KlassVenue model)
        {
            try
            {
                db.KlassVenue.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public KlassVenue find_by_id(int? id)
        {
            return db.KlassVenue.Find(id);
        }

    }
}
