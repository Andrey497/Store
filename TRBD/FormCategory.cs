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
    public partial class FormCategory : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.ListCategory". При необходимости она может быть перемещена или удалена.
            this.listCategoryTableAdapter.Fill(this.dBSHOPDataSet1.ListCategory);

        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            string sqlExpression = "DeleteCategory";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam1 = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = textBox1.Text
                    };
                    command.Parameters.Add(nameParam1);
                    command.ExecuteNonQuery();
                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.listCategoryTableAdapter.Fill(this.dBSHOPDataSet1.ListCategory);
        }
        
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string sqlExpression = "AddCategory";
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter nameParam1 = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = textBox1.Text
                    };
                    command.Parameters.Add(nameParam1);
                    command.ExecuteNonQuery();
                  
              
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
