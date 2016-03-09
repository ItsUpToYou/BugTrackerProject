using BOL.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using DAL.Core;
using MySql.Data.MySqlClient;
using BLToolkit.Data;
using BOL.Models;
using BOL;

namespace BugTracker
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public IUserManager Manager { get; set; }
        public Login()
        {
            InitializeComponent();

            this.Manager = UserManager.CreateLogin();
           
            //this.Load += Login_Load;
        }

        public void Login_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource =this.Manager.ActiveModel;

            this.UserName.DataBindings.Add("EditValue", bs, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.UserPassword.DataBindings.Add("EditValue", bs, "UserPassword", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            if(this.Manager.LogIn(UserName.Text,UserPassword.Text))
            {
              
                  MainMenu.F_Show();                   
               
               

            }
            else
            {
                
                MessageBox.Show("Грешен потребител/парола","Внимание",MessageBoxButtons.OK,MessageBoxIcon.Error);
                UserName.Text = String.Empty;
                UserPassword.Text = string.Empty;
            }
        }
        public static void F_Show()
        {
            using (Login dlg = new Login())
            {
                dlg.Manager = UserManager.CreateNew();
                dlg.ShowDialog();
            }
        }
    }
}
