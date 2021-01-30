using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csv_add_read
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            string username;

            Console.Write("insert a password: ");
            password = Console.ReadLine();
            Console.Write("insert a username: ");
            username = Console.ReadLine();
            addData(username, password, "cake.txt");

            string[] login = readData("cake.txt");
            string username2 = login[0];
            string password2 = login[1];
            Console.WriteLine(username2 + " # " + password2);

            Console.ReadLine();
        }

        public static void addData(string username, string password, string filepath)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, false))
                file.WriteLine(username + "," + password);
        }


        public static string[] readData(string filepath)
        {
            string[] dataNotFound = { "logindata not found!" };

            string[] data = System.IO.File.ReadAllLines(@filepath);
            Console.WriteLine(logindata.Length);


            for (int i = 0; i < data.Length; i++)
            {
                string[] fields = data[i].Split(',');

                return fields;
            }


            return dataNotFound;
        }



    }

}
