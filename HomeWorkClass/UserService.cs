using HomeWorkClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClass
{
    internal class UserService
    {
        public void ShowUser()
        {
            var result = GetAllUsers();

            foreach (var item in result)
            {
                Console.WriteLine(item.fullName);
            }


        }

        public User GetUserById(int id)
        {
            User[] users = GetAllUsers();

            User user = users.FirstOrDefault(m=>m.id == id);

            return user;
        }


        public User[] GetAllUsers()
        {

            User user1 = new()
            {
                id = 1,
                fullName = "Aqshin Valiyev",
                age = 24

            };


            User user2 = new()
            {
                id = 2,
                fullName = "Haci Ehmedov",
                age = 28
            };


            User user3 = new()
            {
                id = 3,
                fullName = "Metanet Abbasov",
                age = 25

            };



            User user4 = new()
            {
                id = 4,
                fullName = "Meryem Eliyeva",
                age = 23

            };



            User[] people = { user1, user2, user3, user4 };


            return people;
        }
    }
}
