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
using DAL.Core;
using BOL.Repositories;
using BOL;

namespace BugTracker
{
    public partial class UserList : DevExpress.XtraEditors.XtraForm
    {
        public IUserManager Manager { get; set; }
        public ITaskManager TManager { get; set; }

        public UserList()
        {
            InitializeComponent();
            this.Load += UserList_Load;
            
        }

        void UserList_Load(object sender, EventArgs e)
        {
            
     
          //  string chk = this.Manager.ActiveModel.RightID.ToString();
            BindingSource bs = new BindingSource();
            bs.DataSource = this.TManager.ListModels;
            this.gridControl1.DataSource = bs;
            this.Refresh();
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = this.Manager.UserList;
            this.gridControl2.DataSource = bs1;
            this.Refresh();
        
        }

        public static void F_Show()
        {
            using (UserList dlg = new UserList())
            {
               dlg.Manager = UserManager.CreateNew();
               dlg.Manager.Refresh();
               dlg.ShowDialog();
            }
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
            this.Manager.Delete(model);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            NewTask.F_Show();
            this.TManager.Refresh();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            var model = (TaskModel)gridView1.GetFocusedRow();
            NewTask.F_Show(model.TaskID);
            this.TManager.Refresh();
        }
    }
}