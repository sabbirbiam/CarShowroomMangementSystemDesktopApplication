using CarShowRoomManagmentSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
 
namespace CarShowRoomManagmentSystem.Data
{
    class CarDataAccess
    {
   
        public int Add(Car car)
        {
            string query = string.Format("INSERT INTO Car(Name, Phone) VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}','{6}', '{7}','{8}', '{9}','{10})", car.CarId, car.CarName, car.CarManCompany, car.CarPrice, car.CarSpeed, car.CarEngineId, car.NumberOfSet, car.CarPublishedDate);
            return DataAccess.ExecuteQuery(query);
        }
        public int Remove(string id)
        {
            string query = "DELETE FROM Person WHERE id=" + id;
            return DataAccess.ExecuteQuery(query);
        }
        public int Edit(Car car)
        {
            string query = "UPDATE Person SET Name='" + car.CarId + "', Phone='" + car.CarName + "' WHERE id=" + person.Id;
            return DataAccess.ExecuteQuery(query);
        }
        public List<Car> GetAll()
        {
            string query = "SELECT Id, Name, Phone FROM Person";
            SqlDataReader reader = DataAccess.GetData(query);

            Car car = null;
            List<Car> carList = new List<Car>();
            while (reader.Read())
            {
                car = new Car(Convert.ToInt32(reader["Id"]));
                car.CarName = reader["Name"].ToString();
                car.Phone = reader["Phone"].ToString();

                carList.Add(car);
            }
            return carList;
        }

        public Car GetById(string id)
        {
            string query = "SELECT id, name, phone FROM Person WHERE id=" + id;
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Car car = null;
            if (reader.HasRows)
            {
                car = new Car(Convert.ToInt32(reader["Id"]));
                //person.Name = reader["Name"].ToString();
                //person.Phone = reader["Phone"].ToString();
            }
            return car;
        }

    }
}
