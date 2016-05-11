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
        public static List<Title> ReadAllTitle()
        {
            List<Title> titles = new List<Title>();
            SqlConnection conn = new SqlConnection(
                          Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                
                conn.Open();

                SqlCommand cmd = new SqlCommand("select * from Titles", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    Title title = new Title();
                    title.TitleName = (string)reader["TitleName"];
                    title.IdTitle = (int)reader["idTitle"];

                    titles.Add(title);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return titles;
        }

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

                while (reader.Read() == true)
                {
                    Employee employee = new Employee();
                    employee.IdEmployee = (int)reader["IdEmployee"];
                    employee.LastName = (string)reader["LastName"];
                    employee.firstName = (string)reader["FirstName"];
                    employee.IdTitle = (int)reader["IdTitle"];
                    employee.IsActive = (bool)reader["IsActive"];
                    employee.TitleName = (string)reader["TitleName"];

                    employee.IdPerson = Convert.ToString(reader["IdPerson"]);
                    employee.CellPhone = Convert.ToString(reader["CellPhone"]);
                    employee.Address = Convert.ToString(reader["Address"]);
                    employee.City = Convert.ToString(reader["City"]);

                    employees.Add(employee);
                }

                reader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return employees;
        }

        public static List<Order> ReadOrdersSearch(string filter)
        {
            List<Order> orders = new List<Order>();
            SqlConnection conn = new SqlConnection(
               Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Orders.IdOrder, Orders.DateOrder, Orders.CashRegister, Orders.PriceOrder, Orders.IdEmployee, Orders.IdCustomer, Orders.Details, Employees.LastName, Employees.FirstName, Customers.LastNameCustomer, Customers.FirstNameCustomer " +
                    " FROM Orders " + 
                    " INNER JOIN Employees ON Employees.IdEmployee = Orders.IdEmployee " + 
                    " INNER JOIN Customers ON Customers.IdCustomer = Orders.IdCustomer " +
                    " Where  Customers.LastNameCustomer + ' ' + Customers.FirstNameCustomer Like '" + filter + "%' or Employees.FirstName + ' ' + Employees.LastName Like '" + filter + "%'", conn);
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

            catch 
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return orders;
        }

        public static List<Product> ReadProductSearch(string filter)
        {
            List<Product> products = new List<Product>();
            try
            {
                SqlConnection connection = new SqlConnection(
                    Properties.Settings.Default.ComputerStoreConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("select * from product  where InStore = 1 AND NameProduct LIKE '" + filter + "%' ", connection);

                SqlDataReader reader = command.ExecuteReader();

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

                connection.Close();
            }
            catch
            {
                throw;
            }

            return products;
            
        }

       /// <summary>
       /// Citanje zaposlenih iz baze...
       /// </summary>
       /// <param name="filter">Deo imena ili prezimena koji trazimo.</param>
       /// <returns>Listu zaposlenih koji zadovoljavaju uslov.</returns>
        public static List<Employee> ReadEmployesSearch(string filter)
        {
            List<Employee> employees = new List<Employee>();
            try
            {
                SqlConnection conn = new SqlConnection(
                    Properties.Settings.Default.ComputerStoreConnectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT  Employees.IdEmployee, Employees.LastName, Employees.FirstName, Employees.IdTitle, Employees.IsActive, Titles.TitleName, Employees.IdPerson, Employees.CellPhone, Employees.Address, Employees.City " +
                                 " FROM Employees INNER JOIN Titles ON Employees.IdTitle = Titles.IdTitle " +
                                 " where isActive = 1 AND LastName + ' ' + FirstName LIKE '%" + filter + "%'  ", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    Employee employee = new Employee();
                    employee.IdEmployee = (int)reader["IdEmployee"];
                    employee.LastName = (string)reader["LastName"];
                    employee.firstName = (string)reader["FirstName"];
                    employee.IdTitle = (int)reader["IdTitle"];
                    employee.IsActive = (bool)reader["IsActive"];
                    employee.TitleName = (string)reader["TitleName"];

                    employee.IdPerson = Convert.ToString(reader["IdPerson"]);
                    employee.CellPhone = Convert.ToString(reader["CellPhone"]);
                    employee.Address = Convert.ToString(reader["Address"]);
                    employee.City = Convert.ToString(reader["City"]);

                    employees.Add(employee);
                }

                reader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return employees;
        }

        public static void UpdateCustomer(Customer customer)
        {
            SqlConnection connection = new SqlConnection(
               Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Customers set Customers.LastNameCustomer = '" + customer.LastNameCustomer + "', Customers.FirstNameCustomer = '" + customer.FirstNameCustomer + "' where IdCustomer = " + customer.IdCustomer  , connection);

                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

        }

        public static int GetIdEmployee(Employee employee)
        {
            SqlConnection connection = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select idEmployee from Employees where Employees.LastName + ' ' + Employees.FirstName = '" + employee.EmployeeName + "' ", connection);

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read() == true)
                {
                    employee.IdEmployee = (int)reader["idEmployee"];
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return employee.IdEmployee;
        }

        public static int GetIdTitle(Title title)
        {
            SqlConnection conn = new SqlConnection(
                  Properties.Settings.Default.ComputerStoreConnectionString);

           // Title title = new Title();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select IdTitle from Titles where TitleName = '" + title.TitleName + "' ", conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    title.IdTitle = (int)reader["idTitle"];
                    //title.TitleName = (string)reader["TitleName"];
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
               
            }
            finally
            {
                conn.Close();
            }

            return title.IdTitle;
           
        }

        public static void EditProduct(Product product)
        {
            SqlConnection connection = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("update Product set NameProduct = '" + product.NameProduct + "', PriceProduct = '" + product.PriceProduct + 
                    "', Description = '" + product.Description + "', Brand = '" + product.Brand + "', InStore = 1 , MadeIn = '" + product.MadeIn + 
                    "', BuyFromCompany = '" + product.BuyFromCompany + "', CellPhoneCompany = '" + product.CellPhoneCompany + "' where IdProduct = " + product.IdProduct, connection);
                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void EditOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(
                  Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update Orders set Details = '" + order.Details + "', IdEmployee = " + order.IdEmployee + ", IdCustomer = " + order.IdCustomer +
                                ", PriceOrder = '" + order.PriceOrder + "', CashRegister = " + order.CashRegister + ", DateOrder = '" + order.DateOrder + "' where IdOrder = " + order.IdOrder , conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public static void EditEmployee(Employee employee)
        {
            SqlConnection conn = new SqlConnection(
                   Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("update Employees set City = '" + employee.City + "', FirstName = '" + employee.firstName + "', IdTitle = '" + employee.IdTitle +
                                  "', LastName = '" + employee.LastName + "', IdPerson = '" + employee.IdPerson + "', CellPhone = '" + employee.CellPhone + "', Address = '" + employee.Address + 
                                  "' where IdEmployee = '" + employee.IdEmployee + "'", conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        public static Order GetOrderById(int idOrder)
        {
            SqlConnection connection = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);
            Order order = new Order();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Orders inner join Employees on Orders.IdEmployee = Employees.IdEmployee " 
                    + " inner join Customers on Orders.IdCustomer = Customers.IdCustomer where IdOrder = " + idOrder, connection);

                SqlDataReader reader = command.ExecuteReader();
                while(reader.Read() == true)
                {

                    order.IdOrder = (int)reader["IdOrder"];
                    order.DateOrder = (DateTime)reader["DateOrder"];
                    order.CashRegister = (int)reader["CashRegister"];
                    order.PriceOrder = (decimal)reader["PriceOrder"];
                    order.Details = Convert.ToString(reader["Details"]);
                    order.IdCustomer = (int)reader["IdCustomer"];
                    order.IdEmployee = (int)reader["IdEmployee"];

                    order.EmployeeName = (string)reader["LastName"] + ' ' + (string)reader["FirstName"];
                    order.CustomerName = (string)reader["LastNameCustomer"] + ' ' + (string)reader["FirstNameCustomer"];
                    
                }
                reader.Close();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
            return order;
        }

        public static Product GetProductById(int idProduct)
        {
            SqlConnection connection = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);
            Product product = new Product();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand(" select * from Product where IdProduct = " + idProduct, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read() == true)
                {
                    product.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                    product.NameProduct = (string)reader["NameProduct"];
                    product.PriceProduct = (decimal)reader["PriceProduct"];
                    product.Description = Convert.ToString(reader["Description"]);
                    product.Brand = Convert.ToString(reader["Brand"]);
                    product.InStore = (bool)reader["InStore"];
                    product.MadeIn = Convert.ToString(reader["MadeIn"]);
                    product.BuyFromCompany = Convert.ToString(reader["BuyFromCompany"]);
                    product.CellPhoneCompany = Convert.ToString(reader["CellPhoneCompany"]);
                }
                reader.Close();   
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return product;
        }

        public static Employee GetEmployeeById(int idEmployee)
        {
            SqlConnection conn = new SqlConnection(
                  Properties.Settings.Default.ComputerStoreConnectionString);
            Employee employee = new Employee();
            try
            {
                conn.Open();

                //select*
                //from Employees
                //where IdEmployee = 2

                SqlCommand cmd = new SqlCommand(" select * from Employees inner join Titles on Employees.IdTitle = Titles.IdTitle where IdEmployee =  " + idEmployee, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read() == true)
                {
                    employee.IdEmployee = (int)reader["IdEmployee"];
                    employee.LastName = (string)reader["LastName"];
                    employee.firstName = (string)reader["FirstName"];
                    employee.IdTitle = (int)reader["IdTitle"];
                    employee.IsActive = (bool)reader["IsActive"];
                    employee.TitleName = (string)reader["TitleName"];

                    employee.IdPerson = Convert.ToString(reader["IdPerson"]);
                    employee.CellPhone = Convert.ToString(reader["CellPhone"]);
                    employee.Address = Convert.ToString(reader["Address"]);
                    employee.City = Convert.ToString(reader["City"]);
                }

                reader.Close();
                
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return employee;
        }

        public static void CreateNewEmployee(string lastName, string firstName, int idTitle, string IdPerson, string CellPhone, string Address, string City)
        {

            SqlConnection conn = new SqlConnection(
                   Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees (LastName, FirstName, IdTitle, IdPerson, CellPhone, Address, City) " +
                    " VALUES(@LastName, '" + firstName + "', " + idTitle + ", @IdPerson, @CellPhone, @Address, @City" + ")", conn);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@IdPerson", IdPerson);
                cmd.Parameters.AddWithValue("@CellPhone", CellPhone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@City", City);
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
                    employee.firstName = (string)reader["FirstName"];
                    // employee.FirstName = reader.GetString(2);
                    // employee.IdTitle = reader["IdTitle"].ToString();
                    employee.IdTitle = (int)reader["IdTitle"];
                    employee.IsActive = (bool)reader["IsActive"];
                    employee.TitleName = (string)reader["TitleName"];

                    employee.EmployeeName = (string)reader["LastName"] + " " + (string)reader["FirstName"];

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

        public static List<Product> ReadAllProduct(bool all)
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
            }
            finally
            {
                conn.Close();
            }
        }

        public static void DeleteOrder(List<int> IDs)
        {
            SqlConnection conn = new SqlConnection(
                  Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();

                var filter = string.Join(", ", IDs);
                SqlCommand cmd = new SqlCommand("delete from OrderItems where IdOrder IN (" + filter
                                                + ") delete from Orders where IdOrder IN ("
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

        public static void InsertProduct(Product product)
        {
            SqlConnection connection = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into Product(NameProduct, PriceProduct, Description, Brand, InStore, MadeIn, BuyFromCompany, CellPhoneCompany)" 
                    + " values('" + product.NameProduct + "', " + product.PriceProduct + ", '" + product.Description + "', '" + product.Brand + "', 1, '" + product.BuyFromCompany + "', '" + product.MadeIn + "', '" + product.CellPhoneCompany + "')", connection);

                command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int InsertOrderItem(OrderItem orderItem)
        {
            //insert into OrderItems(IdOrder, IdProduct, Quantity, OrderItemPrice)
            //values(39, 5, 1, 50)
            //SELECT SCOPE_IDENTITY()

            SqlConnection conn = new SqlConnection(
                  Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderItems(IdOrder, IdProduct, Quantity, OrderItemPrice)" 
                    + " values(@IdOrder, @IdProduct, @Quantity, @OrderItemPrice); "
                    + " SELECT SCOPE_IDENTITY(); ", conn);
                cmd.Parameters.AddWithValue("IdOrder", orderItem.IdOrder);
                cmd.Parameters.AddWithValue("IdProduct", orderItem.IdProduct);
                cmd.Parameters.AddWithValue("Quantity", orderItem.Quantity);
                cmd.Parameters.AddWithValue("OrderItemPrice", orderItem.OrderItemPrice);

                return (int)(decimal)cmd.ExecuteScalar();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }

        }

        public static int InsertCustomer(Customer customer)
        {
            // INSERT INTO Customers(FirstNameCustomer, LastNameCustomer, ID)
            // VALUES(@FirstNameCustomer, @LastNameCustomer, @ID);
            SqlConnection conn = new SqlConnection(
                  Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Customers(FirstNameCustomer, LastNameCustomer, ID) "
                     + " VALUES(@FirstNameCustomer, @LastNameCustomer, @ID); "
                     + " SELECT SCOPE_IDENTITY(); ", conn); // to get the new ID value
                cmd.Parameters.AddWithValue("FirstNameCustomer", customer.FirstNameCustomer);
                cmd.Parameters.AddWithValue("LastNameCustomer", customer.LastNameCustomer);
                cmd.Parameters.AddWithValue("ID", customer.ID);

                return (int)(decimal)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        public static void UpdateOrderPrice(int idOrder, decimal priceOrder)
        {
            // Update Orders
            //set PriceOrder = '200'
            //where IdOrder in (109)

            SqlConnection conn = new SqlConnection(
               Properties.Settings.Default.ComputerStoreConnectionString);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Orders SET PriceOrder = " + priceOrder  
                                                + " WHERE IdOrder = " + idOrder, conn);


                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static int InsertOrder(Order order)
        {
            SqlConnection conn = new SqlConnection(
                  Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Orders ( DateOrder, CashRegister, IdEmployee, Details, IdCustomer, PriceOrder) "
                     + " VALUES( @DateOrder, @CashRegister, @IdEmployee, @Details, @IdCustomer, @PriceOrder); "
                     + " SELECT SCOPE_IDENTITY(); " , conn);
                cmd.Parameters.AddWithValue("DateOrder", order.DateOrder);
                cmd.Parameters.AddWithValue("CashRegister", order.CashRegister);
                cmd.Parameters.AddWithValue("IdEmployee", order.IdEmployee);
                cmd.Parameters.AddWithValue("Details", order.Details);
                cmd.Parameters.AddWithValue("IdCustomer", order.IdCustomer);
                cmd.Parameters.AddWithValue("PriceOrder", order.PriceOrder);

                return (int)(decimal)cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
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

        public static void ProductInStore(List<int> IDs)
        {
            SqlConnection conn = new SqlConnection(
                Properties.Settings.Default.ComputerStoreConnectionString);
            try
            {
                conn.Open();
                string filter = string.Join(", ", IDs);
                SqlCommand cmd = new SqlCommand("UPDATE Product SET InStore = 1 where IdProduct IN ("
                     + filter + ")", conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
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
                throw;
            }
            finally
            {
                conn.Close();
            }
            return orders;
        }

    }
}