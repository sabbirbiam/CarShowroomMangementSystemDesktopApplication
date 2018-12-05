using CarShowRoomManagmentSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Data
{
    class CustomerDataAccess
    {
        public int Remove(int id)
        {
            string query = "DELETE FROM Person WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Customer person)
        {
            string query = "UPDATE Person SET Name='" + person.Name + "', Phone='" + person.Phone + "' WHERE id=" + person.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Customer> GetAll()
        {
            string query = "SELECT Id, Name, Phone FROM Person";
            SqlDataReader reader = DataAccess.GetData(query);

            Customer customer= null;
            List<Customer> personList = new List<Customer>();
            while (reader.Read())
            {
                customer = new Customer(Convert.ToInt32(reader["Id"]));
                customer.Name = reader["Name"].ToString();
                customer.Phone = reader["Phone"].ToString();

                personList.Add(customer);
            }
            return personList;
        }

        public Customer GetById(int id)
        {
            string query = "SELECT id, name, phone FROM Person WHERE id=" + id;
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Customer customer= null;
            if (reader.HasRows)
            {
                customer = new Customer(Convert.ToInt32(reader["Id"]));
                customer.Name = reader["Name"].ToString();
                customer.Phone = reader["Phone"].ToString();
            }
            return customer;
        }
    }
}
