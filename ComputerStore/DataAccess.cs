using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class DataAccess
    {
        public static List<Employee> ReadAllEmployes()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                SqlConnection conn = new SqlConnection(
                    Properties.Settings.Default.ComputerStoreConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT  Employees.IdEmployee, Employees.LastName, Employees.FirstName, Employees.IdTitle, Employees.IsActive, Titles.TitleName, Employees.IdPerson, Employees.CellPhone, Employees.Address, Employees.City " +
                                 " FROM Employees INNER JOIN Titles ON Employees.IdTitle = Titles.IdTitle ", conn);

                SqlDataReader reader = cmd.ExecuteReader();
                
                while(reader.Read() == true)
                {
                    Employee employee = new Employee();
                    employee.IdEmployee = (int)reader["IdEmployee"];
                    employee.LastName = (string)reader["LastName"];
                    employee.FirstName = (string)reader["FirstName"];
                    employee.IdTitle = (int)reader["IdTitle"];
                    employee.IsActive = (bool)reader["IsActive"];
                    employee.TitleName = (string)reader["TitleName"];
                    employee.IdPerson = (string)reader["IdPerson"];
                    employee.CellPhone = (string)reader["CellPhone"];
                    employee.Address = (string)reader["Address"];
                    employee.City = (string)reader["City"];

                    employees.Add(employee);
                }

                reader.Close();

                conn.Close();
            }
            catch(Exception ex)
            {

            }

            return employees;
        }

        public static List<Employee> ReadActiveEmployees()
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                // Kreiramo konekciju
                SqlConnection conn = new SqlConnection(
                    Properties.Settings.Default.ComputerStoreConnectionString);
                // Otvaramo konekciju:
                conn.Open();

                // Kreiramo komandu:
                SqlCommand cmd = new SqlCommand("SELECT  Employees.IdEmployee, Employees.LastName, Employees.FirstName, Employees.IdTitle, Employees.IsActive, Titles.TitleName " +
                   " FROM Employees INNER JOIN Titles ON Employees.IdTitle = Titles.IdTitle "
                   + " where isActive = 1", conn);

                // Izvrsavamo komandu:
                SqlDataReader reader = cmd.ExecuteReader();

                // Citamo rezultat:
                while (reader.Read() == true)
                {

                    Employee employee = new Employee();
                    employee.IdEmployee = Convert.ToInt32(reader["IdEmployee"]);
                    employee.LastName = reader[1].ToString();
                    employee.FirstName = (string)reader["FirstName"];
                    // employee.FirstName = reader.GetString(2);
                    // employee.IdTitle = reader["IdTitle"].ToString();
                    employee.IdTitle = (int)reader["IdTitle"];
                    employee.IsActive = (bool)reader["IsActive"];
                    employee.TitleName = (string)reader["TitleName"];
                    


                    employees.Add(employee);
                }
                reader.Close();

                // Zatvaramo konekciju:
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("greska: " + ex.Message);
            }
            return employees;
        }

        public static List<Product> ReadAllProduct(bool all )
        {

            List<Product> products = new List<Product>();
            SqlConnection conn = new SqlConnection(
                    Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                if (all == true)
                {
                    cmd = new SqlCommand("select * from product", conn);
                }
                else
                {
                    cmd = new SqlCommand("select * from product  where InStore = 1", conn);
                }
                    SqlDataReader reader = cmd.ExecuteReader();
                

                while (reader.Read() == true)
                {
                    Product product = new Product();
                    product.IdProduct = (int)reader["IdProduct"];
                    product.NameProduct = (string)reader["NameProduct"];
                    product.PriceProduct = (decimal)reader["PriceProduct"];
                    product.Description = Convert.ToString(reader["Description"]);
                    product.Brand = Convert.ToString(reader["Brand"]);
                    product.InStore = (bool)reader["InStore"];

                    product.MadeIn = Convert.ToString(reader["MadeIn"]);
                    product.BuyFromCompany = Convert.ToString(reader["BuyFromCompany"]);
                    product.CellPhoneCompany = Convert.ToString(reader["CellPhoneCompany"]);

                    products.Add(product);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return products;
        }

        public static List<OrderItem> ReadAllOrderItems()
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            SqlConnection conn = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT OrderItems.IdOrderItem, OrderItems.IdOrder, OrderItems.IdProduct, OrderItems.Quantity, OrderItems.OrderItemPrice , Product.NameProduct" +
                                    " FROM OrderItems INNER JOIN Product ON OrderItems.IdProduct = Product.IdProduct", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.IdOrderItem = (int)reader["IdOrderItem"];
                    orderItem.IdOrder = (int)reader["IdOrder"];
                    orderItem.IdProduct = (int)reader["IdProduct"];
                    orderItem.Quantity = (int)reader["Quantity"];
                    orderItem.OrderItemPrice = (decimal)reader["OrderItemPrice"];
                    orderItem.NameProduct = (string)reader["NameProduct"];


                    orderItems.Add(orderItem);
                }
                reader.Close();
            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return orderItems;
        }

        public static List<OrderItem> ReadOrderItemsForOneOrder(int idOrder)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            SqlConnection conn = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select OrderItems.IdOrderItem, OrderItems.IdOrder, OrderItems.IdProduct, OrderItems.Quantity, " +
                                                " OrderItems.OrderItemPrice, Product.NameProduct  " +
                                                " FROM OrderItems INNER JOIN Product ON OrderItems.IdProduct = Product.IdProduct where IdOrder =" + idOrder, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.IdOrderItem = (int)reader["IdOrderItem"];
                    orderItem.IdOrder = (int)reader["IdOrder"];
                    orderItem.IdProduct = (int)reader["IdProduct"];
                    orderItem.Quantity = (int)reader["Quantity"];
                    orderItem.OrderItemPrice = (decimal)reader["OrderItemPrice"];
                    orderItem.NameProduct = (string)reader["NameProduct"];

                    orderItems.Add(orderItem);
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine();
            }
            finally
            {
                conn.Close();
            }
            return orderItems;

        }

        public static List<Order> readOrdersForEmployee(int idEmployee)
        {

            List<Order> orders = new List<Order>();
            List<OrderItem> orderItems = new List<OrderItem>();
            SqlConnection conn = new SqlConnection(
               Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Orders.IdOrder, Orders.DateOrder, Orders.CashRegister, Orders.PriceOrder, Orders.IdEmployee, Orders.IdCustomer, Orders.Details, Employees.LastName, Employees.FirstName, Customers.LastNameCustomer, Customers.FirstNameCustomer" + 
                    " FROM Orders INNER JOIN Employees ON Employees.IdEmployee = Orders.IdEmployee" +
                                " INNER JOIN Customers ON Customers.IdCustomer = Orders.IdCustomer where Orders.IdEmployee =" + idEmployee, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    Order order = new Order();
                    order.IdOrder = (int)reader["IdOrder"];
                    order.DateOrder = (DateTime)reader["DateOrder"];
                    order.CashRegister = (int)reader["CashRegister"];
                    order.PriceOrder = (decimal)reader["PriceOrder"];
                    order.IdEmployee = (int)reader["IdEmployee"];
                    order.Details = Convert.ToString(reader["Details"]);
                    order.IdCustomer = (int)reader["IdCustomer"];

                    order.EmployeeName = (string)reader["LastName"] + " " + (string)reader["FirstName"];
                    order.CustomerName = (string)reader["LastNameCustomer"] + " " + (string)reader["FirstNameCustomer"];

                    orders.Add(order);
                }
                reader.Close();
            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return orders;
        }

        public static void DeleteEmployees(List<int> IDs)
        {
            // delete .... where idEmp IN (2, 5)
            // var filter = string.Join(", ", IDs);
            //Console.WriteLine(filter);
            //...
            // cmd.ExecuteNonQuery();

            SqlConnection conn = new SqlConnection(
                   Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {

                conn.Open();
                var filter = string.Join(", ", IDs);
                SqlCommand cmd = new SqlCommand("delete from Employees where IdEmployee IN ("
                    + filter + ")", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("greska: " + ex.Message);
                // ???? MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void ArchiveEmployees(List<int> IDs)
        {
            // update Employees set isActive = 0 where IdEmployee IN (2, 5)
            // var filter = string.Join(", ", IDs);
            //Console.WriteLine(filter);
            //...
            // cmd.ExecuteNonQuery();

            SqlConnection conn = new SqlConnection(
                   Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                conn.Open();
                string filter = string.Join(", ", IDs);
                SqlCommand cmd = new SqlCommand("update Employees set isActive = 0 where IdEmployee IN ("
                    + filter + ")", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("greska: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void ArchiveProducts(List<int> IDs)
        {
            SqlConnection conn = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                conn.Open();
                string filter = string.Join(", ", IDs);
                SqlCommand cmd = new SqlCommand("UPDATE Product SET InStore = 0 where IdProduct IN ("
                   + filter + ")", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Order> readAllOrders()
        {
            List<Order> orders = new List<Order>();
            SqlConnection conn = new SqlConnection(
               Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Orders.IdOrder, Orders.DateOrder, Orders.CashRegister, Orders.PriceOrder, Orders.IdEmployee, Orders.IdCustomer, Orders.Details, Employees.LastName, Employees.FirstName, Customers.LastNameCustomer, Customers.FirstNameCustomer " +
                              " FROM Orders INNER JOIN Employees ON Employees.IdEmployee = Orders.IdEmployee " + 
                                          " INNER JOIN Customers ON Customers.IdCustomer = Orders.IdCustomer", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    Order order = new Order();
                    order.IdOrder = (int)reader["IdOrder"];
                    order.DateOrder = (DateTime)reader["DateOrder"];
                    order.CashRegister = (int)reader["CashRegister"];
                    order.PriceOrder = (decimal)reader["PriceOrder"];
                    order.IdEmployee = (int)reader["IdEmployee"];
                    order.Details = Convert.ToString(reader["Details"]);
                    order.IdCustomer = (int)reader["IdCustomer"];

                    order.EmployeeName = (string)reader["LastName"] + " " + (string)reader["FirstName"];
                    order.CustomerName = (string)reader["LastNameCustomer"] + " " + (string)reader["FirstNameCustomer"];

                    orders.Add(order);
                }
                reader.Close();
            }

            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return orders;
        }

    }
}