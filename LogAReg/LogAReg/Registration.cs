using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LogAReg
{
    public partial class Registration : Form
    {
        Connect _myconn = new Connect();
        public Registration()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            authorization frm = new authorization();
            Close();
            frm.Show();
        }

        private void LogClick_Click(object sender, EventArgs e)
        {
            try
            {
                
                string cmdString = $"INSERT INTO accoun (a_login,a_password)VALUES('{Login.Text}','{Password.Text}')";
                SqlCommand cmd = new SqlCommand(cmdString, _myconn.GetConnection());

                _myconn.OpenConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show($"Аккаунт {Login.Text} создан", "Account create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    authorization frm = new authorization();
                    Close();
                    frm.Show();
                }
                else 
                {
                    MessageBox.Show("Аккаунт не создан", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (CheckUser())

                {
                    return;
                }
                _myconn.ClosedConnection();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private Boolean CheckUser()
        {
            var loginUser = Login.Text;
            var passwordUser = Password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string jqueryString = $"Select id,a_login,a_password from accoun  where a_login='{loginUser}' and a_password = '{passwordUser}'";
            SqlCommand cmd = new SqlCommand(jqueryString, _myconn.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show($"Аккаунт {Login.Text} уже существует", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
            Login.MaxLength = 50;
            if (Login.Text.Length > Login.MaxLength)
                MessageBox.Show("Логин не может превышать 50 символов", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Password.MaxLength = 50;
            if (Password.Text.Length > Password.MaxLength)
                MessageBox.Show("Пароль не может превышать 50 символов", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      
    }
}
