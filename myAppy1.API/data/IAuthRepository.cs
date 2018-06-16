
using System.Threading.Tasks;
using myAppy1.API.models;

namespace myAppy1.API.data
{
    public interface IAuthRepository
    {
         Task<User>  Register(User user,string password);

         Task<User>  Login(string username,string password);

         Task<bool> UserExists(string username);
         

    }
}