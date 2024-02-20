using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UI_Project.Models
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModel user);
        void Edit(UserModel user);
        void Remove(UserModel user);

        UserModel GetById(int id);
        UserModel GetByUserName(string name);
        IEnumerable<UserModel> GetAll();
        //...
    }
}
