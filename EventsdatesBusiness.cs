using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
    public class EventsdatesBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<Eventsdates> all()
        {
            return db.Eventsdates.ToList();
        }
        public bool add(Eventsdates model)
        {
            try
            {
                db.Eventsdates.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(Eventsdates model)
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
        public bool delete(Eventsdates model)
        {
            try
            {
                db.Eventsdates.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public Eventsdates find_by_id(int? id)
        {
            return db.Eventsdates.Find(id);
        }




    }
}