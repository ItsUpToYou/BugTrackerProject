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
using BOL.Models;
using BOL;

namespace BugTracker
{
    public partial class Users : DevExpress.XtraEditors.XtraForm
    {
        public IUserManager Manager { get; set; }
        public Users()
        {
            InitializeComponent();
            this.Load += Users_Load;
        }

        void Users_Load(object sender, EventArgs e)
        {
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = this.Manager.UserList;
            this.gridControl2.DataSource = bs1;
            this.Refresh();
           

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RegisterForm.F_Show();
            this.Manager.Refresh();// рефрешва грида след добавяне на контакт
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var model = (UserModel)gridView2.GetFocusedRow();
            RegisterForm.F_Show(model.UserID);
            this.Manager.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var model = (UserModel)gridView2.GetFocusedRow();
            if (model.UserID== Glob.User.UserID)
            {
                MessageBox.Show("Не може да изтриеш себе си");
            }
            else
            {
                this.Manager.Delete(model);
            }
            this.Manager.Refresh();
        }
        public static void F_Show()
        {
            using (Users dlg = new Users())
            {
                dlg.Manager = UserManager.CreateNew();
                dlg.Manager.ActiveModel.UserID = Glob.User.UserID;
                dlg.Manager.Refresh();
                dlg.ShowDialog();
            }
        }

        private void Users_Load_1(object sender, EventArgs e)
        {

        }

    }
}