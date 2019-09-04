using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
    public class EventsClassBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<EventsClass> all()
        {
            return db.EventsClasses.Include("Eventsdates,EventsVanue").ToList();
            //return db.Klass.ToList();
        }
        public bool add(EventsClass model)
        {
            try
            {
                db.EventsClasses.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(EventsClass model)
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
        public bool delete(EventsClass model)
        {
            try
            {
                db.EventsClasses.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public EventsClass find_by_id(int? id)
        {
            return db.EventsClasses.Find(id);
        }

    }
}
