using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class AcountReposity : IReposity
    {
        protected AccountContext db = new AccountContext();
        public IQueryable<ACCOUNT> select()
        {
            return db.ACCOUNT;
        }
        public void Add(ACCOUNT user)
        {
            db.ACCOUNT.Add(user);
            db.SaveChanges();
        }
        public bool Delete(string name)
        {
            var delUser = db.ACCOUNT.FirstOrDefault(u => u.USER_NAME == name);
            if (delUser != null)
            {
                db.ACCOUNT.Remove(delUser);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public ACCOUNT SelectByName(string name)
        {
            return db.ACCOUNT.FirstOrDefault(u => u.USER_NAME == name);
        }
    }
}