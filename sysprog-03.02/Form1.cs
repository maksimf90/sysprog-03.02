using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace sysprog_03._02
{
    public partial class Form1 : Form
    {
        private int loginAttempts = 0;
        private bool isFormLocked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            string connectionstring = "host=localhost;port=5432;username=postgres;password=11111;database=people";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionstring))
            {
                connection.Open();

                string query = "SELECT COUNT (*) FROM users WHERE Login = @Login and Password = @Password";
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("Login", login);
                        command.Parameters.AddWithValue("Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Авторизация прошла успешно");
                            loginAttempts = 0;
                            Form2 form2 = new Form2(login);
                            form2.Show();
                            //this.Close();
                        }

                        else
                        {
                            MessageBox.Show("Данные неверны, попробуйте еще раз");
                            loginAttempts++;

                            
                                if (loginAttempts > 3)
                                { 
                                MessageBox.Show("Попробуйте еще через 20 секунд");
                                isFormLocked = true;
                                button1.Enabled = false;
                                Login.Enabled = false;
                                Password.Enabled = false;

                                await Task.Delay(20000);
                                isFormLocked = false;
                                button1.Enabled = true;
                                Login.Enabled = true;
                                Password.Enabled = true;
                                }
                        }



                    }
                }

            }
        }
    }
}
