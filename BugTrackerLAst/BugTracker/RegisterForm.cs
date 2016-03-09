using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BOL.Managers;
using DAL.Core;
using BOL.Models;
using BOL;
using Joystick.BOL.Core;

namespace BugTracker
{
    public partial class RegisterForm : DevExpress.XtraEditors.XtraForm
    {
        public IUserManager Manager { get; set; }
        public RegisterForm()
        {
            InitializeComponent();
            this.Load += RegisterForm_Load;
           
        }
        public void RegisterForm_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Manager.ActiveModel;
            this.lookUpEdit1.Properties.DataSource = this.Manager.Rights;
            this.lookUpEdit1.Properties.ValueMember = "ValueMember";
            this.lookUpEdit1.Properties.DisplayMember = "DisplayMember";
            this.lookUpEdit1.DataBindings.Add("EditValue",bs,"RightID",true,DataSourceUpdateMode.OnPropertyChanged);

            this.UserName.DataBindings.Add("EditValue", bs, "UserName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.UserPassword.DataBindings.Add("EditValue", bs, "UserPassword", true, DataSourceUpdateMode.OnPropertyChanged);
            this.FirstName.DataBindings.Add("EditValue", bs, "FirstName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.SecondName.DataBindings.Add("EditValue", bs, "SecondName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.LastName.DataBindings.Add("EditValue", bs, "LastName", true, DataSourceUpdateMode.OnPropertyChanged);
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (this.UserPassword.Text != this.confirmPassword.Text)
            {

            }
            else
            {
                this.Manager.Save();
                this.Hide();
                this.Manager.Refresh();
            }
            confirmPassword.Text = "";

        }
        public static void F_Show()
        {
            using (RegisterForm dlg = new RegisterForm())
            {
                dlg.Manager = UserManager.CreateNew();
                dlg.Manager.SetRights();
                dlg.Manager.ActiveModel.AcceptChanges();
                dlg.Manager.ActiveModel.RightID = Glob.User.RightID;//Даваме правата от глобалния юзър на текущия. 
                dlg.ShowDialog();
            }
        }

        public static void F_Show(uint id)
        {
            using (RegisterForm dlg = new RegisterForm())
            {
                dlg.Manager = UserManager.CreateEdit(id);
                dlg.Manager.SetRights();
                dlg.ShowDialog();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}