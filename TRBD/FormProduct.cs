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
    //Форма продуктов у администратора
    public partial class FormProduct : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.NumberOfItemsSold". При необходимости она может быть перемещена или удалена.
            this.numberOfItemsSoldTableAdapter.Fill(this.dBSHOPDataSet2.NumberOfItemsSold);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListCategory". При необходимости она может быть перемещена или удалена.
            this.listCategoryTableAdapter.Fill(this.dBSHOPDataSet1.ListCategory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListProducts". При необходимости она может быть перемещена или удалена.
            this.listProductsTableAdapter.Fill(this.dBSHOPDataSet1.ListProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);

        }
        private void AddOproduct(string Category, string type, string material, string color, string priseString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    string commandtext = $"EXEC AddProduct '{type}','{Color}','{material}',{priseString},'{Category}'";
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
        private void Deleteproduct(string Id)
        {
            string sqlExpression = "DeleteProduct";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam1 = new SqlParameter
                    {
                        ParameterName = "@Id",
                        Value = int.Parse(Id)
                    };
                    command.Parameters.Add(nameParam1);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ChangePriceproduct(string Id, string priseString)
        {
            string sqlExpression = "NewPriceProduct";
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


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddOproduct(comboBox1.Text, typeProduct.Text, material.Text, Color.Text, Price.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListProducts". При необходимости она может быть перемещена или удалена.
            this.listProductsTableAdapter.Fill(this.dBSHOPDataSet1.ListProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.NumberOfItemsSold". При необходимости она может быть перемещена или удалена.
            this.numberOfItemsSoldTableAdapter.Fill(this.dBSHOPDataSet2.NumberOfItemsSold);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListCategory". При необходимости она может быть перемещена или удалена.
            this.listCategoryTableAdapter.Fill(this.dBSHOPDataSet1.ListCategory);
        }

        private void buttonChangePrice_Click(object sender, EventArgs e)
        {
            ChangePriceproduct(codeChagePrise.Text, newPrice.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListProducts". При необходимости она может быть перемещена или удалена.
            this.listProductsTableAdapter.Fill(this.dBSHOPDataSet1.ListProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.NumberOfItemsSold". При необходимости она может быть перемещена или удалена.
            this.numberOfItemsSoldTableAdapter.Fill(this.dBSHOPDataSet2.NumberOfItemsSold);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListCategory". При необходимости она может быть перемещена или удалена.
            this.listCategoryTableAdapter.Fill(this.dBSHOPDataSet1.ListCategory);
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            Deleteproduct(codeDeleteProduct.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListProducts". При необходимости она может быть перемещена или удалена.
            this.listProductsTableAdapter.Fill(this.dBSHOPDataSet1.ListProducts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.NumberOfItemsSold". При необходимости она может быть перемещена или удалена.
            this.numberOfItemsSoldTableAdapter.Fill(this.dBSHOPDataSet2.NumberOfItemsSold);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListCategory". При необходимости она может быть перемещена или удалена.
            this.listCategoryTableAdapter.Fill(this.dBSHOPDataSet1.ListCategory);
        }

        private void back_Click(object sender, EventArgs e)
        {
            FormAdministrator newForm = new FormAdministrator();
            newForm.Show();
            Hide();
        }
    }
}
