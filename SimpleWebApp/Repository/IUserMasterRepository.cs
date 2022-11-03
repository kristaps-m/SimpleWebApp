using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Repository
{
    public interface IUserMasterRepository
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        Person Add(Person item);
        bool Update(Person item);
        bool Delete(int id);
    }
}
