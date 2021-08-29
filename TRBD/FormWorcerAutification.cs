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
    public partial class FormWorcerAutification : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";

        public FormWorcerAutification()
        {
            
            InitializeComponent();
        }

        private void Parol_TextChanged(object sender, EventArgs e)
        {
            Parol.UseSystemPasswordChar = true;//делаем тест зашифрованным
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private string AutificationWorcker(String Login,String Parol)
        {
            string sqlExpression = "GetDostup";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam1 = new SqlParameter
                    {
                        ParameterName = "@Login",
                        Value = Login
                    };
                    SqlParameter nameParam2 = new SqlParameter
                    {
                        ParameterName = "@Parol",
                        Value = Parol
                    };
                    command.Parameters.Add(nameParam1);
                    command.Parameters.Add(nameParam2);
                    var returnValue = command.Parameters.Add("@Return", SqlDbType.NVarChar);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = (returnValue.Value).ToString();
                    connection.Close();
                    return result;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void buttonAutification_Click(object sender, EventArgs e)
        {
            String dostup = AutificationWorcker(Login.Text, Parol.Text);
            if (dostup == "")
            {
                MessageBox.Show("Логин или парол введены неправильно");
            }else if(dostup== "Администратор")
            {
                FormAdministrator newForm = new FormAdministrator();
                newForm.Show();
                Hide();
            }
            else if (dostup == "Специалист отдела приема и отправки")
            {
                FormOrders newForm = new FormOrders();
                newForm.Show();
                Hide();
            }
        }

        private void FormWorcerAutification_Load(object sender, EventArgs e)
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
