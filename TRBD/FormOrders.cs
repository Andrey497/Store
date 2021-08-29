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
    public partial class FormOrders : Form
    {
        static String ConnectString = "Data Source=DESKTOP-900BQME;Initial Catalog=DBSHOP;Integrated Security=True";
        public FormOrders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.ListDriverOpen". При необходимости она может быть перемещена или удалена.
            this.listDriverOpenTableAdapter.Fill(this.dBSHOPDataSet2.ListDriverOpen);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);

        }

        private  void ReadyOrder(String idOrder)
        {
            string sqlExpression = "OrderAreManufactured";
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
                        Value = int.Parse(idOrder)
                    };
                    command.Parameters.Add(nameParam1);
                    var returnValue = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = (int)returnValue.Value;
                    if (result ==-1)
                    MessageBox.Show($"Неверный номер заказа");
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void GoDevilary(String idOrder,String IdDriver)
        {
            string sqlExpression = "OrderDevileryBegin";
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
                        Value = int.Parse(idOrder)
                    };
                      
                    SqlParameter nameParam2 = new SqlParameter
                     {
                        ParameterName = "@IdDriver",
                        Value = int.Parse(idOrder)
                     };
                    command.Parameters.Add(nameParam1);
                    command.Parameters.Add(nameParam2);

                    var returnValue = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = (int)returnValue.Value;
                    if (result == -1)
                        MessageBox.Show($"Неверные данные");
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderDevileryFinish(String idOrder)
        {
            string sqlExpression = "OrderDevileryEnd";
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
                        Value = int.Parse(idOrder)
                    };
                    command.Parameters.Add(nameParam1);
                    var returnValue = command.Parameters.Add("@Return", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;
                    command.ExecuteNonQuery();
                    var result = (int)returnValue.Value;
                    if (result == -1)
                        MessageBox.Show($"Неверный номер заказа");
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadyDriver_Click(object sender, EventArgs e)
        {
            
            ReadyOrder(CodeOrder.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.ListDriverOpen". При необходимости она может быть перемещена или удалена.
            this.listDriverOpenTableAdapter.Fill(this.dBSHOPDataSet2.ListDriverOpen);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);
        }

        private void buttonGoDevillery_Click(object sender, EventArgs e)
        {
            GoDevilary(CodeOrder.Text, CodeDriver.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.ListDriverOpen". При необходимости она может быть перемещена или удалена.
            this.listDriverOpenTableAdapter.Fill(this.dBSHOPDataSet2.ListDriverOpen);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);
        }

        private void buttonFinnishDevillery_Click(object sender, EventArgs e)
        {
            OrderDevileryFinish(CodeOrder.Text);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet2.ListDriverOpen". При необходимости она может быть перемещена или удалена.
            this.listDriverOpenTableAdapter.Fill(this.dBSHOPDataSet2.ListDriverOpen);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBSHOPDataSet1.LISTORDER". При необходимости она может быть перемещена или удалена.
            this.lISTORDERTableAdapter.Fill(this.dBSHOPDataSet1.LISTORDER);
        }
    }
}
