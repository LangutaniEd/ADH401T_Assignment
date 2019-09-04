using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
    public class EventsVanueBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<EventsVanue> all()
        {
            return db.EventsVanues.ToList();
        }
        public bool add(EventsVanue model)
        {
            try
            {
                db.EventsVanues.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(EventsVanue model)
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
        public bool delete(EventsVanue model)
        {
            try
            {
                db.EventsVanues.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public EventsVanue find_by_id(int? id)
        {
            return db.EventsVanues.Find(id);
        }

    }
}