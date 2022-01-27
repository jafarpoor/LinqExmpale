using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Distinc
{
    class Program
    {
        static void Main(string[] args)
        {

            List<user> UserList = new List<user>() {
                new user {Id = 1 , Name = "Faezeh" } ,
                  new user {Id = 1 , Name = "Ali" } ,
                    new user {Id = 1 , Name = "Ehsan" } ,
                      new user {Id = 1 , Name = "Ehsan" } ,
                        new user {Id = 1 , Name = "mahsa" } ,
                        new user {Id = 1 , Name = "Ali" } 
            };

            List<user> UserList2 = new List<user>() {
                new user {Id = 1 , Name = "fffffff" } ,
                  new user {Id = 1 , Name = "aaaaaaa" } ,
                    new user {Id = 1 , Name = "Ehsan" } ,
                      new user {Id = 1 , Name = "Ehsan" } ,
                        new user {Id = 1 , Name = "mahsa" } ,
                        new user {Id = 1 , Name = "Faezeh" }
            };

            var ResulteDistinc = UserList.Distinct(new CompareUser());

            //foreach (var item in ResulteDistinc)
            //{
            //    Console.WriteLine(item.Name);
            //}

            var ResulteExcept = UserList.Except(UserList2 ,new CompareUser());

            foreach (var item in ResulteExcept)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
    }

    public class user
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class CompareUser : IEqualityComparer<user>
    {
        public bool Equals(user x, user y)
        {
            if (x.Name == y.Name)
                return true;
            return false;
        }

        public int GetHashCode([DisallowNull] user obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}

