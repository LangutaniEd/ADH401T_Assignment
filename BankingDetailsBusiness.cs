using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KFP.DATA;
using System.Data.Entity;

namespace KFP.BUSINESS
{
   public class BankingDetailsBusiness
    {
        private KFG_Db db = new KFG_Db();

        public List<BankingDetails> all()
        {
            return db.BankingDetails.ToList();
        }
        public bool add(BankingDetails model)
        {
            try
            {
                db.BankingDetails.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public bool edit(BankingDetails model)
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
        public bool delete(BankingDetails model)
        {
            try
            {
                db.BankingDetails.Remove(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            { return false; }
        }
        public BankingDetails find_by_id(int? id)
        {
            return db.BankingDetails.Find(id);
        }





    }
}
