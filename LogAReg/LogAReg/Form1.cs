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
    public partial class authorization : Form
    {
        Connect _myConn = new Connect();
        public authorization()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Login.MaxLength = 50;
            if (Login.Text.Length > Login.MaxLength)
                MessageBox.Show("Логин не может превышать 50 символов","Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Password.MaxLength = 50;
            if (Password.Text.Length > Password.MaxLength)
                MessageBox.Show("Пароль не может превышать 50 символов", "Eror",MessageBoxButtons.OK,MessageBoxIcon.Error);

        }

        private void LogClick_Click(object sender, EventArgs e)
        {
            try
            {
                var loginUser = Login.Text;
                var passwordUser = Password.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                string jqueryString = $"Select id,a_login,a_password from accoun  where a_login='{loginUser}' and a_password = '{passwordUser}'";
                SqlCommand cmd = new SqlCommand(jqueryString, _myConn.GetConnection());

                adapter.SelectCommand = cmd;
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show($"{loginUser} Вы вошли", "Login correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Пользователя с именем {loginUser} нет", "Login Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();
            Hide();
            frm.Show();
        }

        
    }
}
