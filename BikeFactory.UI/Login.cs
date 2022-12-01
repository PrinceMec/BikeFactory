using BikeFactory.Business;
using BikeFactory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeFactory.UI
{
    public partial class Login : Form
    {
        private List<User> listofusers = UserData.Load();
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool existinguser = false;
            foreach (var user in listofusers)
            {
                if (user.UserName == txtusername.Text && user.Password == txtpassword.Text)
                {
                    existinguser = true;
                    break;
                }
            }
            if (existinguser)
            {
                var frmMainForm = new MainForm();
                frmMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username and Password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
