using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExmpale
{
    class Program
    {
       public static void Main(string[] args)
        {
            List<UserType> UserTypeList = new List<UserType> { 
                new UserType {Id = 1 , Name ="Customer"} ,
                new UserType {Id = 1 , Name ="Admin"} ,
                new UserType {Id = 1 , Name ="User"}
            };
            List<user> UserList = new List<user>() { 
                new user {Id = 1 , Name = "Faezeh" , UserTypeId = 1} ,
                  new user {Id = 1 , Name = "Ali" , UserTypeId = 2} ,
                    new user {Id = 1 , Name = "Ehsan" , UserTypeId = 3} ,
                      new user {Id = 1 , Name = "Taherh" , UserTypeId = 1} ,
                        new user {Id = 1 , Name = "mahsa" , UserTypeId = 2} ,
            };
            var resulte = UserList.Join(UserTypeList ,p => p.UserTypeId , c=>c.Id , (u, c)=>
            new
            {
                UserName = u.Name,
                catName = c.Name
            });
            foreach (var item in resulte)
            {
                    Console.WriteLine(item.UserName + " - "+ item.catName);
            }
            Console.ReadKey();
        }

        public class user
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public int UserTypeId { get; set; }
        }

        public class UserType
        {
            public long Id { get; set; }
            public string Name { get; set; }
        }
    }
}
