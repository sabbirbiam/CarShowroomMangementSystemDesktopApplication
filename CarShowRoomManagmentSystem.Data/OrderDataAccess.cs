using CarShowRoomManagmentSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Data
{
    class OrderDataAccess
    {
        public int Add(Order order)
        {
            string query = string.Format("INSERT INTO Person(Name, Phone) VALUES('{0}', '{1}')", order.Name, order.Phone);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(int id)
        {
            string query = "DELETE FROM Person WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Order person)
        {
            string query = "UPDATE Person SET Name='" + person. + "', Phone='" + person.Phone + "' WHERE id=" + person.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Order> GetAll()
        {
            string query = "SELECT Id, Name, Phone FROM Person";
            SqlDataReader reader = DataAccess.GetData(query);

            Order order= null;
            List<Order> personList = new List<Order>();
            while (reader.Read())
            {
                order = new Person(Convert.ToInt32(reader["Id"]));
                order.Name = reader["Name"].ToString();
                order.Phone = reader["Phone"].ToString();

                personList.Add(order);
            }
            return personList;
        }

        public Order GetById(int id)
        {
            string query = "SELECT id, name, phone FROM Person WHERE id=" + id;
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Order order = null;
            if (reader.HasRows)
            {
                order = new Order(Convert.ToInt32(reader["Id"]));
                order.Name = reader["Name"].ToString();
                order.Phone = reader["Phone"].ToString();
            }
            return order;
        }
    }
}
