using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExmpale
{
    public class GroupExmpale
    {
        //var resulte = UserList.GroupBy(p => p.UserTypeId).ToList();
        //    foreach (var item in resulte)
        //    {
        //        foreach (var detail in item)
        //        {
        //          //  Console.WriteLine(detail.Name + " - "+  detail.UserTypeId);
        //        }

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
