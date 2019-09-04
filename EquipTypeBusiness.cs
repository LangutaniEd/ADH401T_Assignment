using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
   public class EquipTypeBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<Equipment_Type> all()
        {
            return db.Equipment_Type.ToList();
        }
        public bool add(Equipment_Type model)
        {
            try
            {
                db.Equipment_Type.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(Equipment_Type model)
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
        public bool delete(Equipment_Type model)
        {
            try
            {
                db.Equipment_Type.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public Equipment_Type find_by_id(int? id)
        {
            return db.Equipment_Type.Find(id);
        }


    }
}
