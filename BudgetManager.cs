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
        public bool AddIncome(string date, string message, float amount)
        {
            string Type = "Income";
            return AddUnit(date,message,amount,Type);
        }


        public bool AddCost(string date, string message, float amount)
        {
            string Type = "Cost";
            return AddUnit(date, message, amount, Type);
        }


        public bool AddConstantIncome(string date, string message, float amount)
        {
            string Type = "Constant Income";
            return AddUnit(date, message, amount, Type);
        }


        public bool AddConstantCost(string date, string message, float amount)
        {
            string Type = "Constant Cost";
            return AddUnit(date, message, amount, Type);
        }


        private bool AddUnit(string date,string message,float amount, string type)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open)Connection.Open();

            ChechIfTableExists();

            
            string SQLQuerry= "INSERT INTO Units(date,message,amount,type) VALUES('" + date + "','" + message + "'," + amount + ",'"+type+"')";
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
        public void GetUnitById()
        {

        }

        //Update
        public bool EditUnit(int id, string date, string message, float amount)
        {
            string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\")) + "FamilyBudgetDB.mdf;Integrated Security=True";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            if (Connection.State != ConnectionState.Open) Connection.Open();

            ChechIfTableExists();


            string SQLQuerry = "UPDATE Units SET date='" + date + "',message='" + message + "',amount=" + amount + " WHERE id=" + id;

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

            ChechIfTableExists();


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
                SQLQuerry = "CREATE TABLE Units(id int IDENTITY not null ,date date not null,message varchar(255) not null,amount float not null, type varchar(20) not null)";
                Command.CommandText = SQLQuerry;
                Command.ExecuteNonQuery();
            }

            Connection.Close();
        }
    }
}
