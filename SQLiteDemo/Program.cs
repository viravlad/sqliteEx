using SQLiteDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.Write("Specify the last name to be changed ");
            var lastName = Console.ReadLine();

            Console.Write("Change the First name");
            var firstName = Console.ReadLine();

            var person = Update(new Person { FirstName = firstName, LastName = lastName });
            Console.WriteLine(person.Id);

            Console.ReadKey();
        }

        #region Person CRUD

        private static Person Create(Person person)
        {
            

            try
            {
                using (var databaseObj = new Database())
                {
                    string query =
                        @"INSERT INTO people (`firstName`,`lastName`) VALUES (@firstName,@lastName);
                    SELECT last_insert_rowid() AS 'Id';";

                    using (SQLiteCommand myCommand = new SQLiteCommand(query, databaseObj.myConnection))
                    {
                        myCommand.Parameters.AddWithValue("firstName", person.FirstName);
                        myCommand.Parameters.AddWithValue("lastName", person.LastName);

                        databaseObj.OpenConnection();
                        using (var reader = myCommand.ExecuteReader())
                        {
                            Console.WriteLine($"{reader.RecordsAffected} rows added");
                            if (reader.Read())
                            {
                                person.Id = reader.GetInt32(0);
                            }
                            else
                            {
                                throw new Exception("Could not insert person");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return person;
        }

        static Person GetById(int id) // Read
        {
            return null;
        }

        private static Person Update(Person person)
        {
            try
            {
                using (var databaseObj = new Database())
                {
                    string query =
                        @"UPDATE people SET firstName = @firstName WHERE lastName = @lastName"; 

                    using (SQLiteCommand updateCommand = new SQLiteCommand(query, databaseObj.myConnection))
                    {
                        updateCommand.Parameters.AddWithValue("firstName", person.FirstName);
                        updateCommand.Parameters.AddWithValue("lastName", person.LastName);

                        databaseObj.OpenConnection();
                        using (var reader = updateCommand.ExecuteReader())
                        {
                            Console.WriteLine($"{reader.RecordsAffected} rows added");
                            if (reader.Read())
                            {
                                person.Id = reader.GetInt32(0);
                            }
                            else
                            {
                                throw new Exception("Could not insert person");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return person;
      
        }


        static void Delete()
        {

        }

        #endregion
    }
}
