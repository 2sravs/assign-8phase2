using System;
using System.Linq;
namespace Assignment_8
{
    internal class Program
    {
        static AdvancedDbEntities db;
        static void Main(string[] args)
        {
            try
            {
                db = new AdvancedDbEntities();
            First:
                Console.WriteLine("1.Employee 2.Product 3.Order \n Enter your choice: ");
                int options = int.Parse(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        {
                            Employee();
                            break;
                        }
                    case 2:
                        {
                            Product();
                            break;
                        }
                   
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            return;
                        }
                }
                Console.WriteLine("Do you want to continue? Y/N");
                string ch = Console.ReadLine().ToLower();
                if (ch == "y")
                {
                    goto First;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


        }
        static void Employee()
        {
            try
            {
            Start:
                Console.WriteLine("1,Display,2.Insert,3.Delete,4.Search \n enter your choice");
                int Emp = int.Parse(Console.ReadLine());
                switch (Emp)
                {
                    case 1:
                        {
                            DisplayOption();
                            break;
                        }
                    case 2:
                        {
                            InsertOption();
                            break;
                        }
                    case 3:
                        {
                            DeleteOption();
                            break;
                        }
                    case 4:
                        {
                            SearchOption();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            return;
                        }
                }
                Console.WriteLine("Do you want to continue? Y/N");
                string ch = Console.ReadLine().ToLower();
                if (ch == "y")
                {
                    goto Start;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
        static void DisplayOption()
        {



            foreach (Employee emp in db.Employees)
            {
                Console.WriteLine("ID: " + emp.EmployeeId);
                Console.WriteLine("FirstName: " + emp.FirsdtName);
                Console.WriteLine("LastName: " + emp.LastName);
                Console.WriteLine("Salary: " + emp.Salary);
                Console.WriteLine("Date of Joining: " + emp.BirthDate);
                Console.WriteLine("**************************************** ");
            }
        }
        static void InsertOption()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee Id");
            emp.EmployeeId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee first name");
            emp.FirsdtName = Console.ReadLine();
            Console.WriteLine("Enter Employee Last name");
            emp.LastName = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            emp.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Birth Date");
            emp.BirthDate = DateTime.Parse(Console.ReadLine());
            db.Employees.Add(emp);
            db.SaveChanges();
            Console.WriteLine("Employee Record added");

        }
        static void SearchOption()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Id to update the Details");
            int id = int.Parse(Console.ReadLine());
            emp = db.Employees.SingleOrDefault(e => emp.EmployeeId == id);
            if (emp == null)
            {
                Console.WriteLine("No such Id " + id + " exist in AdvancedDb");

            }
            Console.WriteLine("Enter First Name:");
            emp.FirsdtName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            emp.LastName = Console.ReadLine();
            Console.WriteLine("Enter  employee Salary:");
            emp.Salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee Birth Date:");
            emp.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Designation:");

            Console.WriteLine("Employee Record Updated!!!");

        }
        static void DeleteOption()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Id to delete the Details");
            int id = int.Parse(Console.ReadLine());
            emp = db.Employees.SingleOrDefault(e => emp.EmployeeId == id);
            if (emp != null)
            {
                Console.WriteLine("No such Id " + id + " exist in AdvancedDb");
            }
            else
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
                Console.WriteLine("Employee Record Deleted!!!");
            }

        }
        static void Product()
        {
            try
            {
            Start1:
                Console.WriteLine("1,Display,2.Insert,3.Delete,4.Search \n enter your choice");
                int Emp = int.Parse(Console.ReadLine());
                switch (Emp)
                {
                    case 1:
                        {
                            Display();
                            break;
                        }
                    case 2:
                        {
                            Insert();
                            break;
                        }
                    case 3:
                        {
                            Delete();
                            break;
                        }
                    case 4:
                        {
                            Search();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            return;
                        }
                }
                Console.WriteLine("Do you want to continue? Y/N");
                string ch = Console.ReadLine().ToLower();
                if (ch == "y")
                {
                    goto Start1;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }


        }
        static void Display()
        {
            foreach (Product p in db.Products)
            {
                Console.WriteLine("ID: " + p.ProductId);
                Console.WriteLine("productName: " + p.ProductName);
                Console.WriteLine("Descripion: " + p.PDescription);
                Console.WriteLine("price: " + p.Price);
                Console.WriteLine("Realese date" + p.RealeaseDate);
                Console.WriteLine("**************************************** ");
            }
        }
        static void Insert()
        {
            Product p = new Product();
            Console.WriteLine("Enter product Id");
            p.ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product name");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Employee Last name");
            p.PDescription = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            p.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee realese date");
            p.RealeaseDate = DateTime.Parse(Console.ReadLine());
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("products Record added");

        }
        static void Search()
        {
            Product p = new Product();
            Console.WriteLine("Enter Id to update the Details");
            int id = int.Parse(Console.ReadLine());
            p = db.Products.SingleOrDefault(pro => p.ProductId == id);
            if (p == null)
            {
                Console.WriteLine("No such Id " + id + " exist in AdvancedDb");

            }
            Console.WriteLine("Enter Product Name:");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("Enter product Description:");
            p.PDescription = Console.ReadLine();
            Console.WriteLine("Enter  employee price:");
            p.Price = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee realease Date:");
            p.RealeaseDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Designation:");

            Console.WriteLine("Products Record Updated!!!");

        }
        static void Delete()
        {
            Product p = new Product();
            Console.WriteLine("Enter Id to delete the Details");
            int id = int.Parse(Console.ReadLine());
            p = db.Products.SingleOrDefault(pro => p.ProductId == id);
            if (p == null)
            {
                Console.WriteLine("No such Id " + id + " exist in AdvancedDb");
            }
            else
            {
                db.Products.Remove(p);
                db.SaveChanges();
                Console.WriteLine("product Record Deleted!!!");
            }

        }

    }
   

}





        
   
