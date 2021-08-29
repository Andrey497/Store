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
    //Форма для заказа продукта из магазина
    public partial class FormCustomer : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";


        public FormCustomer()
        {
            InitializeComponent();
        }
        //Процедура добавления заказа
        private void AddOrder(string FirstName, string MiddleName, string LastName, string Addres, string IdProduct)
        {
            string sqlExpression = "AddOrder";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(sqlExpression,connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam1 = new SqlParameter
                    {
                        ParameterName = "@FirstName",
                        Value = FirstName
                    };
                    SqlParameter nameParam2 = new SqlParameter
                    {
                        ParameterName = "@MiddleName",
                        Value = MiddleName
                    };
                    SqlParameter nameParam3 = new SqlParameter
                    {
                        ParameterName = "@LastName",
                        Value = LastName
                    };
                    SqlParameter nameParam4 = new SqlParameter
                    {
                        ParameterName = "@Address",
                        Value = Addres
                    };
                    SqlParameter nameParam5 = new SqlParameter
                    {
                        ParameterName = "@IDProduct",
                        Value = int.Parse(IdProduct)
                    };
                    command.Parameters.Add(nameParam1);
                    command.Parameters.Add(nameParam2);
                    command.Parameters.Add(nameParam3);
                    command.Parameters.Add(nameParam4);
                    command.Parameters.Add(nameParam5);
                    var returnValue = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = (int)returnValue.Value;
                    MessageBox.Show($"Номер Вашего заказа:{result}");
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListProducts". При необходимости она может быть перемещена или удалена.
            this.listProductsTableAdapter.Fill(this.dBSHOPDataSet1.ListProducts);

        }

        //Кнопка добовления заказа
        private void MakeOrder_Click(object sender, EventArgs e)
        {
            AddOrder(NameCustomer.Text, MiddleNameCustomer.Text,
                LastNameCustomer.Text, AddresCustomer.Text, CodProdut.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListProducts". При необходимости она может быть перемещена или удалена.
            this.listProductsTableAdapter.Fill(this.dBSHOPDataSet1.ListProducts);
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void NameCustomer_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
                Form1 newForm = new Form1();
                newForm.Show();
                Hide();
            
        }
    }
}
