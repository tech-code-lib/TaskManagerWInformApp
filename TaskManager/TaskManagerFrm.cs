using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagerBusinessLogic;

namespace TaskManager
{
    public partial class TaskManagerFrm : Form
    {
        public TaskManagerFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string password = txtPassword.Text;
            
            //ToDo: Call Business Logic Service UserService Method Login()
            UserService userService = new UserService();
            var loginStatus = userService.Login(userId, password);            
            MessageBox.Show($"Login Status: {loginStatus.LoginSuccess}, {loginStatus.LoginMessage}");

            if (loginStatus.LoginSuccess)
            {
                grpSignIn.Visible = false;
                this.IsMdiContainer = true;
                TaskFrm newMDIChild = new TaskFrm();                
                newMDIChild.MdiParent = this;
                newMDIChild.WindowState = FormWindowState.Maximized;
                newMDIChild.MaximizeBox = false;
                newMDIChild.MinimizeBox = false;
                newMDIChild.ControlBox = false;
                newMDIChild.Dock = DockStyle.Fill;
                newMDIChild.Show();
            }
        }

        private void TaskManagerFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
