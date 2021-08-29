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
{//Форма главного меню
    public partial class Form1 : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //Переход в меню покуупки товара
        private void userMenu_Click(object sender, EventArgs e)
        {
            FormCustomer newForm = new FormCustomer();
            newForm.Show();
            Hide();
        }
        //Кнопка для перехода в меню входа для работников
        private void CustomerButton_Click(object sender, EventArgs e)
        {
            FormWorcerAutification newForm = new FormWorcerAutification();
            newForm.Show();
            Hide();
        }
        //Кнопка проверки статуса товара
        private void StatusByIdOrder_Click(object sender, EventArgs e)
        {
            string sqlExpression = "OrderCustomerStautus";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam1 = new SqlParameter
                    {
                        ParameterName = "@IdOrder",
                        Value = int.Parse(IdOrder.Text)
                    };
                    command.Parameters.Add(nameParam1);
                    var returnValue = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = (returnValue.Value).ToString();
                    if(result=="")
                    MessageBox.Show($"Заказа под номером :{IdOrder.Text} нет");
                    else
                    MessageBox.Show($"Статус вашего заказа:{result}");
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
