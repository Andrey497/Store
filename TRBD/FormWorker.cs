using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRBD
{
    public partial class FormWorker : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";

        public FormWorker()
        {
            InitializeComponent();
        }

        private void FormWorker_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.ListDriver". При необходимости она может быть перемещена или удалена.
            this.listDriverTableAdapter1.Fill(this.dBSHOPDataSet2.ListDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListDriver". При необходимости она может быть перемещена или удалена.
            this.listDriverTableAdapter.Fill(this.dBSHOPDataSet1.ListDriver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListCategory". При необходимости она может быть перемещена или удалена.
            this.listCategoryTableAdapter.Fill(this.dBSHOPDataSet1.ListCategory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTWORKER". При необходимости она может быть перемещена или удалена.
            this.lISTWORKERTableAdapter.Fill(this.dBSHOPDataSet1.LISTWORKER);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            FormAdministrator newForm = new FormAdministrator();
            newForm.Show();
            Hide();
        }

        private void AddWorkerProizvod(String FirsName, String MiddleName, String LastName, String Price, String Category)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    string commandtext = $"EXEC AddWorkerInProduction '{FirsName}','{MiddleName}','{LastName}','{Category}',{Price}";
                    SqlCommand command = new SqlCommand(commandtext, connection);
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void DeleteWorker(String Id)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectString))
                    {
                        connection.Open();
                        string commandtext = $"EXEC DeleteWorkerInProduction {int.Parse(Id)}";
                        SqlCommand command = new SqlCommand(commandtext, connection);
                        command.ExecuteReader();
                        connection.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        private void ChangePriWorker(string Id, string priseString)
        {
            string sqlExpression = "NewPriseWorker";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    var price = Decimal.Parse(priseString);
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam1 = new SqlParameter
                    {
                        ParameterName = "@Id",
                        Value = int.Parse(Id)
                    };
                    SqlParameter nameParam2 = new SqlParameter
                    {
                        ParameterName = "@newPrice",
                        Value = price
                    };
                    command.Parameters.Add(nameParam1);
                    command.Parameters.Add(nameParam2);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
        private void AddWorkerOrAdmin(String FirsName, String MiddleName, String LastName, String Price,String Type, String login,String parol)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    string commandtext = $"EXEC AddWorkerOrAdmin '{FirsName}','{MiddleName}','{LastName}',{Price},'{Type}'" +
                        $",'{login}','{Parol}'";
                    SqlCommand command = new SqlCommand(commandtext, connection);
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddDriver(String FirsName, String MiddleName, String LastName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    string commandtext = $"EXEC AddDriver '{FirsName}','{MiddleName}','{LastName}'";
                    SqlCommand command = new SqlCommand(commandtext, connection);
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteDriver(String Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    string commandtext = $"EXEC DeleteDriver {int.Parse(Id)}";
                    SqlCommand command = new SqlCommand(commandtext, connection);
                    command.ExecuteReader();
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAddWorkerProizvod_Click(object sender, EventArgs e)
        {
            AddWorkerProizvod(FirstNameWorker.Text, MiddleNameWorker.Text, LastNameWorker.Text,
               Price.Text, categoryWorker.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTWORKER". При необходимости она может быть перемещена или удалена.
            this.lISTWORKERTableAdapter.Fill(this.dBSHOPDataSet1.LISTWORKER);

        }

        private void buttonChangePice_Click(object sender, EventArgs e)
        {
            ChangePriWorker(CodeWorkerChangePrice.Text, NewPrice.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTWORKER". При необходимости она может быть перемещена или удалена.
            this.lISTWORKERTableAdapter.Fill(this.dBSHOPDataSet1.LISTWORKER);
        }

        private void AddWorkerAdmin_Click(object sender, EventArgs e)
        {
            AddWorkerOrAdmin(FirstNameWorker.Text, MiddleNameWorker.Text, LastNameWorker.Text,
               Price.Text, typeWorker.Text, Login.Text, Parol.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTWORKER". При необходимости она может быть перемещена или удалена.
            this.lISTWORKERTableAdapter.Fill(this.dBSHOPDataSet1.LISTWORKER);
        }

        private void buttonDeleteWorker_Click(object sender, EventArgs e)
        {
            DeleteWorker(CodeWorkerDelete.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTWORKER". При необходимости она может быть перемещена или удалена.
            this.lISTWORKERTableAdapter.Fill(this.dBSHOPDataSet1.LISTWORKER);

        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            AddDriver(FirstNameDriver.Text, MiddleNameDriver.Text, LastNameDriver.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.ListDriver". При необходимости она может быть перемещена или удалена.
            this.listDriverTableAdapter1.Fill(this.dBSHOPDataSet2.ListDriver);

        }

        private void buttonDeleteDriver_Click(object sender, EventArgs e)
        {
            DeleteDriver(CodeDeleteDriver.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.ListDriver". При необходимости она может быть перемещена или удалена.
            this.listDriverTableAdapter1.Fill(this.dBSHOPDataSet2.ListDriver);
        }
    }
}
