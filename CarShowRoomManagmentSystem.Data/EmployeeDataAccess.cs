using CarShowRoomManagmentSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowRoomManagmentSystem.Data
{
    class EmployeeDataAccess
    {
        public int Add(Employee emp)
        {
            string query = string.Format("INSERT INTO Car(Name, Phone) VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}','{6}', '{7}','{8}', '{9}','{10})", emp.Id, emp.N, car.CarPrice, car.CarSpeed, car.CarEngineId, car.NumberOfSet, car.CarPublishedDate);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(int id)
        {
            string query = "DELETE FROM Person WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Employee emp)
        {
            string query = "UPDATE Person SET Name='" + person.Name + "', Phone='" + person.Phone + "' WHERE id=" + person.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Employee> GetAll()
        {
            string query = "SELECT Id, Name, Phone FROM Person";
            SqlDataReader reader = DataAccess.GetData(query);

            Employee emp= null;
            List<Employee> personList = new List<Employee>();
            while (reader.Read())
            {
                emp = new Employee.ToString(reader["Id"]);
                emp.Name = reader["Name"].ToString();
                emp.Phone = reader["Phone"].ToString();

                personList.Add(emp);
            }
            return personList;
        }

        public Employee GetById(int id)
        {
            string query = "SELECT id, name, phone FROM Person WHERE id=" + id;
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Employee emp= null;
            if (reader.HasRows)
            {
                emp = new Employee(Convert.ToInt32(reader["Id"]));
                emp.Name = reader["Name"].ToString();
                emp.Phone = reader["Phone"].ToString();
            }
            return emp;
        }
    }
}
