using SimpleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebApp.Repository
{
    public class UserMasterRepository : IUserMasterRepository
    {
        //private List<UserMaster> users = new List<UserMaster>();
        private List<Person> users = new List<Person>();
        private int Id = 1;

        public UserMasterRepository()
        {
            // Add products for the Demonstration  
            //Add(new Person { Name = "User1", EmailID = "user1@test.com", MobileNo = "1234567890" });
            //Add(new UserMaster { Name = "User2", EmailID = "user2@test.com", MobileNo = "1234567890" });
            //Add(new UserMaster { Name = "User3", EmailID = "user3@test.com", MobileNo = "1234567890" });
        }

        public Person Add(Person item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.Id = Id++;
            users.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            users.RemoveAll(p => p.Id == id);
            return true;
        }

        public Person Get(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return users;
        }

        public bool Update(Person item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            //int index = users.FindIndex(p => p.ID == item.ID);
            int index = users.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            users.RemoveAt(index);
            users.Add(item);
            return true;
        }
    }
}