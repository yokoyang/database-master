using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public interface IReposity {
        IQueryable<ACCOUNT> select();

        void Add(ACCOUNT user);

        bool Delete(string name);

        ACCOUNT SelectByName(string name);
    } 

}