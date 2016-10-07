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
using System.Configuration;

namespace KimBap
{
    public partial class Login : Form
    {
        string str = ConfigurationManager.ConnectionStrings["KIMBAP"].ConnectionString;

        public Login()
        {
            InitializeComponent();
            registevent();
        }

        private void registevent()
        {
            KeyDown += new KeyEventHandler(Login_KeyDown);
            FormClosing += new FormClosingEventHandler(Login_FormClosing);
            //btnLogin.Click += new EventHandler(btnLogin_Click);
            //btnLogout.Click += new EventHandler(btnLogout_Click);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnLogin_Click(sender, null);
                    break;
                case Keys.Escape:
                    btnLogout_Click(sender, null);
                    break;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || lbPW.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(str);
                string Query = "Select * from KimBapMemberList where uID=@UserName and uPW=@Password and uServerIP = @uServerIP and uServerPort = @uServerPort";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@UserName", txtID.Text);
                cmd.Parameters.AddWithValue("@Password", txtPW.Text);
                cmd.Parameters.AddWithValue("@uServerIP", txtSvIP.Text);
                cmd.Parameters.AddWithValue("@uServerPort", txtSvPort.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                con.Close();
                int count = dt.Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    DialogResult result = MessageBox.Show("Login Successful!", "Confirmation", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Hide();
                        Option fm = new Option();
                        fm.ShowDialog();
                    }
                    
                        //txtSvIP.Text = dt.Rows[0]["uServerIP"].ToString();
                        //txtSvPort.Text = dt.Rows[0]["uServerPort"].ToString();
                }
                else
                {
                    MessageBox.Show("Wrong User Or Password Or Another Device Use This User !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            this.Close();
            txtID.Clear();
            txtPW.Clear();
            txtSvIP.Clear();
            txtSvPort.Clear();
        }        
    }
}
