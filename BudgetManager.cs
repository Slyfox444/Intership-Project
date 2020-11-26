using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyBudget
{
    class BudgetManager
    {
        //Create
        public bool AddIncome(string date, string description, float value)
        {
            string Type = "Income";
            return AddUnit(date, description, value, Type);
        }


        public bool AddCost(string date, string description, float value)
        {
            string Type = "Cost";
            return AddUnit(date, description, value, Type);
        }


        public bool AddConstantIncome(string date, string description, float value)
        {
            string Type = "Constant Income";
            return AddUnit(date, description, value, Type);
        }


        public bool AddConstantCost(string date, string description, float value)
        {
            string Type = "Constant Cost";
            return AddUnit(date, description, value, Type);
        }


        private bool AddUnit(string date,string description, float value, string type)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open)Connection.Open();

            ChechIfTableExists();

            
            string SQLQuerry= "INSERT INTO Units(date,description,value,type) VALUES('" + date + "',N'" + description + "'," + value + ",'"+type+"')";
            //
            SqlCommand Command = new SqlCommand(SQLQuerry, Connection);
            int check = Command.ExecuteNonQuery();
            Connection.Close();
            if (check!=0)
            {
                return true;
            }
            return false;
        }


        //Read
        public BudgetUnit GetUnitById(int id)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) Connection.Open();

            string SQLQuerry = "SELECT id,date,description,value,type FROM Units WHERE id=" + id;

            SqlCommand Command = new SqlCommand(SQLQuerry, Connection);
            SqlDataReader reader = Command.ExecuteReader();
            BudgetUnit unit = new BudgetUnit();
            while (reader.Read())
            {
                unit.Id = (int)reader.GetValue(0);
                unit.Date = (DateTime)reader.GetValue(1);
                unit.Description = (string)reader.GetValue(2);
                unit.Value = float.Parse(reader.GetValue(3).ToString());
                unit.Type = (string)reader.GetValue(4);
            }
            
            Connection.Close();
            
            return unit;
        }


        public List<BudgetUnit> GetAllUnits()
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) Connection.Open();

            string SQLQuerry = "SELECT id,date,description,value,type FROM Units";

            SqlCommand Command = new SqlCommand(SQLQuerry, Connection);
            SqlDataReader reader = Command.ExecuteReader();
            
            List<BudgetUnit> units = new List<BudgetUnit>();
            while (reader.Read())
            {
                BudgetUnit unit = new BudgetUnit();
                unit.Id = (int)reader.GetValue(0);
                unit.Date = (DateTime)reader.GetValue(1);
                unit.Description = (string)reader.GetValue(2);
                unit.Value = float.Parse(reader.GetValue(3).ToString());
                unit.Type = (string)reader.GetValue(4);
                units.Add(unit);
            }

            Connection.Close();

            return units;
        }


        //Update
        public bool EditUnit(int id, string date, string description, float value)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) Connection.Open();

            string SQLQuerry = "UPDATE Units SET date='" + date + "',description='" + description + "',value=" + value + " WHERE id=" + id;

            SqlCommand Command = new SqlCommand(SQLQuerry, Connection);
            int check = Command.ExecuteNonQuery();
            Connection.Close();
            if (check != 0)
            {
                return true;
            }
            return false;
        }

        //Delete
        public bool DeleteUnit(int id)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) Connection.Open();

            string SQLQuerry = "DELETE FROM Units WHERE id=" + id;
            //
            SqlCommand Command = new SqlCommand(SQLQuerry, Connection);
            int check = Command.ExecuteNonQuery();
            Connection.Close();
            if (check != 0)
            {
                return true;
            }
            return false;
        }


        private void ChechIfTableExists()
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) Connection.Open();

            string SQLQuerry = "SELECT Count(*) from INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Units'";

            SqlCommand Command = new SqlCommand(SQLQuerry, Connection);
            int check = (int)Command.ExecuteScalar();

            if (check == 0)
            {
                SQLQuerry = "CREATE TABLE Units(id int IDENTITY not null ,date date not null,description nvarchar(255) not null,value float not null, type varchar(20) not null)";
                Command.CommandText = SQLQuerry;
                Command.ExecuteNonQuery();
            }

            Connection.Close();
        }
    }
}
