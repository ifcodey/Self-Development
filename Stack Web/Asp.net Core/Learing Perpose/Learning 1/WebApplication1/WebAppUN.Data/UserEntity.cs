using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppUN.Core;

namespace WebAppUN.Data
{
    public class UserEntity : IData<User>
    {
        List<User> ListOfUser;
        private User user;
        //Define ListOfUser as object of list from User.
        public UserEntity()
        {
            ListOfUser = new List<User>();
        }

        //Get All Data.
        public List<User> GetAllData()
        {
            return ListOfUser;
        }

        //Search on any Field.
        public List<User> Search(string SearchItem)
        {
            return ListOfUser.Where(x => x.Id.ToString() == SearchItem

            || x.FirstName.Contains(SearchItem)
            || x.LastName.Contains(SearchItem)
            || x.Email == SearchItem
            || x.Bio.Contains(SearchItem)
            || x.Password.Contains(SearchItem)
            || x.Phone.ToString() == SearchItem
            ).ToList();
        }

        //Find first Id that equal what enter.
        public User Find(int Id)
        {
            return ListOfUser.Where(x => x.Id == Id).First();
        }

        public void Add(User table)
        {
            ListOfUser.Add(table);
        }

        public void Delete(User table)
        {
            user =Find(table.Id);
            ListOfUser.Remove(user);
        }

        public void Edit(int Id, User table)
        {
            user = Find(Id);
            user = new User
            {
                Id = table.Id,
                FirstName = table.FirstName,
                LastName = table.LastName,
                Email = table.Email,
                Bio = table.Bio,
                Password = table.Password,
                Phone = table.Phone,
            };
        }
    }
}
