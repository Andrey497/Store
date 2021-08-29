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
    //Главное меню у администратора
    public partial class FormAdministrator : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";
        public FormAdministrator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //Функция возвращающая доход компании
        private int GetCompanyProfit()
        {
            string sqlExpression = "IncomeCompany";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var returnValue = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = (int)returnValue.Value;
                    connection.Close();
                    return result;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }
    
        private void FormAdministrator_Load(object sender, EventArgs e)
        {
            textBox1.Text = GetCompanyProfit().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = GetCompanyProfit().ToString();
        }
     
        private void buttonChangemode_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Отделы")
            {
                FormCategory newForm = new FormCategory();
                newForm.Show();
                Hide();
            }else if(comboBox2.Text == "Продукты")
            {
                FormProduct newForm = new FormProduct();
                newForm.Show();
                Hide();
            }
            else if (comboBox2.Text == "Работники")
            {
                FormWorker newForm = new FormWorker();
                newForm.Show();
                Hide();
            }
        }
    }
}
