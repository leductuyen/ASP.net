//using BlazorApp.Server.Interfaces;
//using BlazorApp.Server.Models;
//using BlazorApp.Shared.Models;
//using Microsoft.EntityFrameworkCore;

//namespace BlazorApp.Server.Services
//{
//    public class UserManager : IUser
//    {
//        readonly DatabaseContext _dbContext = new();

//        public UserManager(DatabaseContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        //To Get all user details   
//        public List<User> GetUserDetails()
//        {
//            try
//            {
//                return _dbContext.Users.ToList();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        //To Add new user record     
//        public void AddUser(User user)
//        {
//            try
//            {
//                _dbContext.Users.Add(user);
//                _dbContext.SaveChanges();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        //To Update the records of a particluar user    
//        public void UpdateUserDetails(User user)
//        {
//            try
//            {
//                _dbContext.Entry(user).State = EntityState.Modified;
//                _dbContext.SaveChanges();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        //Get the details of a particular user    
//        public User GetUserData(int id)
//        {
//            try
//            {
//                User? user = _dbContext.Users.Find(id);

//                if (user != null)
//                {
//                    return user;
//                }
//                else
//                {
//                    throw new ArgumentNullException();
//                }
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        //To Delete the record of a particular user    
//        public void DeleteUser(int id)
//        {
//            try
//            {
//                User? user = _dbContext.Users.Find(id);

//                if (user != null)
//                {
//                    _dbContext.Users.Remove(user);
//                    _dbContext.SaveChanges();
//                }
//                else
//                {
//                    throw new ArgumentNullException();
//                }
//            }
//            catch
//            {
//                throw;
//            }
//        }
//    }
//}
using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class UserManager : IUser
    {

        public static List<User> List1 = new List<User>();



        public UserManager()

        {
            if (List1.Count == 0)
            {
                User User1 = new User();
                User1.Address = "Trankins";
                User1.Emailid = "Biscoitos";
                User1.Cellnumber = "175";




                List1.Add(User1);
            }
            //User User1 = new User();
            //User1.Username = "Trankins";
            //User1.Address = "Biscoitos";
            //User1.Cellnumber = "1.75";
            //User1.Emailid = "abc";

            //User User2 = new User();
            //User2.Username = "Passatempo";
            //User2.Address = "Bist";
            //User2.Cellnumber = "1232";
            //User2.Emailid = "abc2";

            //User User3 = new User();
            //User3.Username = "LeThi2";
            //User3.Address = "abc2";
            //User3.Cellnumber = "1232";
            //User3.Emailid = "abc2";




            //List1.Add(User1);
            //List1.Add(User2);
            //List1.Add(User3);
        }


        //To Get all user details   
        public List<User> GetUserDetails()
        {
            return List1;

        }

        //To Add new user record     
        public void AddUser(User user)
        {
            List1.Add(user);
        }

        //To Update the records of a particluar user    
        public void UpdateUserDetails(User user)
        {
            //    User User1 = List1.FirstOrDefault(x => x.Userid == user.Userid);
            //    User1.Username = user.Username;
            //    User1.Address = user.Address;
            //    User1.Cellnumber = user.Cellnumber;
            //    User1.Emailid = user.Emailid;
            //try
            //{
            //    _dbContext.Entry(user).State = EntityState.Modified;
            //    _dbContext.SaveChanges();
            //}
            //catch
            //{
            //    throw;
            //}
        }

        //Get the details of a particular user    
        public User GetUserData(int id)
        {
            return null;
            //User User1 = List1.Find(x => x.Userid == id);
            //return User1;
            //try
            //{
            //    User? user = _dbContext.Users.Find(id);

            //    if (user != null)
            //    {
            //        return user;
            //    }
            //    else
            //    {
            //        throw new ArgumentNullException();
            //    }
            //}
            //catch
            //{
            //    throw;
            //}

        }

        //To Delete the record of a particular user    
        public void DeleteUser(int id)
        {
            //try
            //{
            //    User? user = _dbContext.Users.Find(id);

            //    if (user != null)
            //    {
            //        _dbContext.Users.Remove(user);
            //        _dbContext.SaveChanges();
            //    }
            //    else
            //    {
            //        throw new ArgumentNullException();
            //    }
            //}
            //catch
            //{
            //    throw;
            //}
        }
    }
}