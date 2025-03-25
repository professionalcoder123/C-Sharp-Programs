using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp
{
    internal class UserData
    {
        private static SqlConnection connection;

        public static void PerformSql()
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection established successfully!");
            try
            {
                bool sqlOperation = true;
                while (sqlOperation)
                {
                    Console.WriteLine("Enter the operation to perform :\n1. Create\n2. Retrieve\n3. Update\n4. Delete\n5. Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Create();
                            break;
                        case 2:
                            Retrieve();
                            break;
                        case 3:
                            Update();
                            break;
                        case 4:
                            Delete();
                            break;
                        case 5:
                            sqlOperation = false;
                            Console.WriteLine("Thank you! Please come again.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice! Please enter valid choice.");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        static void Create()
        {
            Console.WriteLine("Enter the name of user");
            string username = Console.ReadLine();
            Console.WriteLine("Enter the age of user");
            int age = int.Parse(Console.ReadLine());
            string insertQuery = "INSERT INTO user_details(user_name,user_age)" +
                "VALUES(" + "\'" + username + "\'" + "," + age + ")";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.ExecuteNonQuery();
            Console.WriteLine("Data inserted successfully into table!");
        }

        static void Retrieve()
        {
            string displayQuery = "SELECT * FROM user_details";
            SqlCommand displayCommand = new SqlCommand(displayQuery, connection);
            SqlDataReader reader = displayCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("User ID : " + reader.GetValue(0).ToString());
                Console.WriteLine("User Name : " + reader.GetValue(1).ToString());
                Console.WriteLine("User Age : " + reader.GetValue(2).ToString());
                Console.WriteLine("---------------------------------------");
            }
            reader.Close();
        }

        static void Update()
        {
            bool update = true;
            while (update)
            {
                Console.WriteLine("Enter the field of the user you want to update :\n1. Name\n2. Age\n3. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UpdateName();
                        break;
                    case 2:
                        UpdateAge();
                        break;
                    case 3:
                        update = false;
                        Console.WriteLine("Thank you! Come again.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter valid choice.");
                        break;
                }
            }
        }

        static void UpdateName()
        {
            Console.WriteLine("Enter an employee ID to update");
            int uid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the username");
            string uname = Console.ReadLine();
            string updateNameQuery = "UPDATE user_details SET user_name=@uname WHERE user_id=@id";
            SqlCommand updateNameCommand = new SqlCommand(updateNameQuery, connection);
            int rowsAffected = updateNameCommand.ExecuteNonQuery();
            if(rowsAffected > 0)
            {
                Console.WriteLine("User name updated successfully!");
            }
            else
            {
                Console.WriteLine("User ID not found!");
            }
        }

        static void UpdateAge()
        {
            Console.WriteLine("Enter an employee ID to update");
            int uid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the age of the user");
            int uage = int.Parse(Console.ReadLine());
            string updateAgeQuery = "UPDATE user_details SET user_age=@uage WHERE user_id=@id";
            SqlCommand updateAgeCommand = new SqlCommand(updateAgeQuery, connection);
            int rowsAffected = updateAgeCommand.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("User age updated successfully!");
            }
            else
            {
                Console.WriteLine("User ID not found!");
            }
        }

        static void Delete()
        {
            Console.WriteLine("Enter a user ID to delete");
            int uid = int.Parse(Console.ReadLine());
            string deleteQuery = "DELETE FROM user_details WHERE user_id=@id";
            SqlCommand deleteCommand=new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@id", uid);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("User deleted successfully!");
        }
    }
}