using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.VisualBasic.FileIO;

namespace CrudApp
{
    internal interface IDatabaseHandler
    {
        void OpenConnection();
        void Create();
        void Retrieve();
        void Update();
        void Delete();
        void CloseConnection();
    }

    internal class DatabaseHandler : IDatabaseHandler
    {
        private SqlConnection connection;
        private static Employee employee;
        public void OpenConnection()
        {
            string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;Encrypt=False";
            connection=new SqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection established successfully!");
        }

        public void Create()
        {
            Console.WriteLine("Enter the ID of an employee");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the name of an employee");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the email address of an employee");
            string email = Console.ReadLine();
            Console.WriteLine("Enter the phone number of an employee");
            string phone = Console.ReadLine();
            var employee = new Employee()
            {
                Id = id,
                Name = name,
                Email = email,
                Phone = phone
            };
            var context = new ValidationContext(employee);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(employee, context, results, true);
            if (isValid)
            {
                string insertQuery = "INSERT INTO Employee(emp_id,emp_name,emp_email,emp_phone)" +
                "VALUES(@id,@name,@email,@phone)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@email", email);
                insertCommand.Parameters.AddWithValue("@phone", phone);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("User created successfully!");
            }
            else
            {
                Console.WriteLine("Validation errors :");
                foreach(var error in results)
                {
                    Console.WriteLine($" -> {error.ErrorMessage}");
                }
            }
        }

        public void Retrieve()
        {
            string selectQuery = "SELECT * FROM Employee";
            SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
            SqlDataReader reader = selectCommand.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Id : " + reader.GetValue(0).ToString());
                Console.WriteLine("Name : " + reader.GetValue(1).ToString());
                Console.WriteLine("Email : " + reader.GetValue(2).ToString());
                Console.WriteLine("Phone Number : " + reader.GetValue(3).ToString());
                Console.WriteLine("----------------------------------------------");
            }
            reader.Close();
        }

        public void Update()
        {
            bool update = true;
            while (update)
            {
                Console.WriteLine("Enter the choice to be updated :\n1. Name\n2. Email\n3. Phone Number\n4. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        UpdateName();
                        break;
                    case 2:
                        UpdateEmail();
                        break;
                    case 3:
                        UpdatePhoneNumber();
                        break;
                    case 4:
                        update = false;
                        Console.WriteLine("Thank you! Please come again.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter valid choice.");
                        break;
                }
            }
        }

        public void UpdateName()
        {
            Console.WriteLine("Enter an employee ID to update");
            string eid = Console.ReadLine();
            Console.WriteLine("Enter the name of the employee");
            string ename = Console.ReadLine();
            var employee = new Employee()
            {
                Id = eid,
                Name = ename
            };
            var results = new List<ValidationResult>();
            var propertiesToValidate = new Dictionary<string, object>()
            {
                { nameof(employee.Id), employee.Id },
                { nameof(employee.Name), employee.Name}
            };
            bool isValid = true;
            foreach(var property in propertiesToValidate)
            {
                var context = new ValidationContext(employee)
                {
                    MemberName = property.Key
                };
                bool isPropertyValid = Validator.TryValidateProperty(property.Value, context, results);
                if (!isPropertyValid)
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                string updateNameQuery = "UPDATE Employee set emp_name=@name WHERE " +
                    "emp_id=@id";
                SqlCommand updateNameCommand = new SqlCommand(updateNameQuery, connection);
                updateNameCommand.Parameters.AddWithValue("@name", ename);
                updateNameCommand.Parameters.AddWithValue("@id", eid);
                int rowsAffected = updateNameCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Employee name updated successfully!");
                }
                else
                {
                    Console.WriteLine("Employee ID not found!");
                }
            }
        }

        public void UpdateEmail()
        {
            Console.WriteLine("Enter the employee id to be updated");
            string eid = Console.ReadLine();
            Console.WriteLine("Enter the email of an employee");
            string e_email = Console.ReadLine();
            var employee = new Employee()
            {
                Id = eid,
                Email = e_email
            };
            var results = new List<ValidationResult>();
            var propertiesToValidate = new Dictionary<string, object>()
            {
                { nameof(employee.Id), employee.Id },
                { nameof(employee.Email), employee.Email }
            };
            bool isValid = true;
            foreach(var property in propertiesToValidate)
            {
                var context = new ValidationContext(employee)
                {
                    MemberName = property.Key
                };
                bool isPropertyValid = Validator.TryValidateProperty(property.Value, context, results);
                if (!isPropertyValid)
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                string updateEmailQuery = "UPDATE Employee SET emp_email=@email WHERE emp_id=@id";
                SqlCommand updateEmailCommand = new SqlCommand(updateEmailQuery, connection);
                updateEmailCommand.Parameters.AddWithValue("@email", e_email);
                updateEmailCommand.Parameters.AddWithValue("@id", eid);
                int rowsAffected = updateEmailCommand.ExecuteNonQuery();
                if(rowsAffected > 0)
                {
                    Console.WriteLine("Employee email updated successfully");
                }
                else
                {
                    Console.WriteLine("Employee ID not found!");
                }
            }
        }

        public void UpdatePhoneNumber()
        {
            Console.WriteLine("Enter an employee id to update");
            string eid = Console.ReadLine();
            Console.WriteLine("Enter the phone number of an employee");
            string ephone = Console.ReadLine();
            var employee = new Employee()
            {
                Id = eid,
                Phone = ephone
            };
            var results = new List<ValidationResult>();
            var propertiesToValidate = new Dictionary<string, object>()
            {
                { nameof(employee.Id), employee.Id },
                { nameof(employee.Phone), employee.Phone }
            };
            bool isValid = true;
            foreach (var property in propertiesToValidate)
            {
                var context = new ValidationContext(employee)
                {
                    MemberName = property.Key
                };
                bool isPropertyValid = Validator.TryValidateProperty(property.Value, context, results);
                if (!isPropertyValid)
                {
                    isValid = false;
                }
            }
            if (isValid)
            {
                string updatePhoneQuery = "UPDATE Employee SET emp_phone=@phone WHERE emp_id=@id";
                SqlCommand updatePhoneCommand = new SqlCommand(updatePhoneQuery, connection);
                updatePhoneCommand.Parameters.AddWithValue("@phone", ephone);
                updatePhoneCommand.Parameters.AddWithValue("@id", eid);
                int rowsAffected = updatePhoneCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Employee phone number updated successfully!");
                }
                else
                {
                    Console.WriteLine("Employee ID not found!");
                }
            }
        }

        public void Delete()
        {
            Console.WriteLine("Enter an employee ID to delete");
            string eid = Console.ReadLine();
            var employee = new Employee();
            var context = new ValidationContext(employee)
            {
                MemberName = eid
            };
            var results = new List<ValidationResult>();
            bool isValid=Validator.TryValidateProperty(eid, context, results);
            if (isValid)
            {
                string deleteQuery = "DELETE FROM Employee WHERE emp_id=@id";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@id", eid);
                deleteCommand.ExecuteNonQuery();
                Console.WriteLine("Employee deleted successfully!");
            }
            else
            {
                Console.WriteLine("Validation errors :");
                foreach(var error in results)
                {
                    Console.WriteLine($" -> {error.ErrorMessage}");
                }
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }

    internal class Employee
    {
        [Required(ErrorMessage ="Employee ID is required")]
        [RegularExpression(@"^E\-[\d]{3,7}$")]
        public string Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Employee name should be in" +
            " between 3 to 15 characters")]
        [RegularExpression(@"^([A-Z][a-z]+|[A-Z][a-z]+\s[A-Z][a-z]+)$")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email address is required")]
        [RegularExpression(@"^([A-Za-z0-9]+|[A-Za-z]+\.?[A-Za-z0-9]+)\@[a-z0-9]+\.(com|org|gov|cc|in)$")]
        [EmailAddress(ErrorMessage ="Please provide valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Phone number is required")]
        [RegularExpression(@"^(\+91\d{10}|\d{10}|\+1\-\d{3}\-\d{3}\-\d{4})$")]
        [Phone]
        public string Phone { get; set; }

        public static void PerformSql()
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            dbHandler.OpenConnection();
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
                            dbHandler.Create();
                            break;
                        case 2:
                            dbHandler.Retrieve();
                            break;
                        case 3:
                            dbHandler.Update();
                            break;
                        case 4:
                            dbHandler.Delete();
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                dbHandler.CloseConnection();
            }
        }
    }
}