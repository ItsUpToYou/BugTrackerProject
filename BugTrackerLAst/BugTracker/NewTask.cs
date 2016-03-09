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
using BOL;

namespace BugTracker
{
    public partial class NewTask : DevExpress.XtraEditors.XtraForm
    {
        ITaskManager Manager { get; set; }
        public NewTask()
        {
            InitializeComponent();
            this.Load += NewTask_Load;
        }

        public void NewTask_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Manager.ActiveModel;

            this.TaskStatusField.Properties.DataSource = this.Manager.ListStatuses;
            this.TaskStatusField.Properties.ValueMember = "ValueMember";
            this.TaskStatusField.Properties.DisplayMember = "DisplayMember";
            this.TaskStatusField.DataBindings.Add("EditValue", bs, "StatusID", true, DataSourceUpdateMode.OnPropertyChanged);

            this.TaskProjectsField.Properties.DataSource = this.Manager.ListProjects;
            this.TaskProjectsField.Properties.ValueMember = "ValueMember";
            this.TaskProjectsField.Properties.DisplayMember = "DisplayMember";
            this.TaskProjectsField.DataBindings.Add("EditValue", bs, "ProjectID", true, DataSourceUpdateMode.OnPropertyChanged);

            this.TaskPriorityField.Properties.DataSource = this.Manager.ListPriorities;
            this.TaskPriorityField.Properties.ValueMember = "ValueMember";
            this.TaskPriorityField.Properties.DisplayMember = "DisplayMember";
            this.TaskPriorityField.DataBindings.Add("EditValue", bs, "PriorityID", true, DataSourceUpdateMode.OnPropertyChanged);

            this.TaskName.DataBindings.Add("EditValue", bs, "TaskName", true, DataSourceUpdateMode.OnPropertyChanged);
            this.TaskDescription.DataBindings.Add("EditValue", bs, "TaskDescription", true, DataSourceUpdateMode.OnPropertyChanged);

           // this.TaskDateTimeStart.DataBindings.Add("EditValue", bs, "TaskDateTimeStart", true, DataSourceUpdateMode.OnPropertyChanged);
          
            this.TaskDateTimeEnd.DataBindings.Add("EditValue", bs, "TaskDateTimeEnd", true, DataSourceUpdateMode.OnPropertyChanged);
            this.TaskDateTimeEnd.DateTime = DateTime.Now;
        }

        public static void F_Show()
        {
            using (NewTask dlg = new NewTask())
            {
                dlg.Manager = TaskManager.Create();
                dlg.Manager.ActiveModel.UserID = Glob.User.UserID; // присвояваме  Ид-то на UserModela, в Таskmodel-a
                //dlg.Manager.ActiveModel.ProjectID = Glob.Task.ProjectID;
                
                dlg.Manager.SetPriorities();
                dlg.Manager.SetProjects();
                dlg.Manager.SetStatuses();
                //dlg.Manager.ActiveModel.AcceptChangers();
                dlg.ShowDialog();
            }
        }

        public static void F_Show(uint id)
        {
            using (NewTask dlg = new NewTask())
            {
                dlg.Manager = TaskManager.CreateEdit(id);
                dlg.Manager.ActiveModel.UserID = Glob.User.UserID; // присвояваме  Ид-то на UserModela, в Таskmodel-a
                dlg.Manager.ActiveModel.ProjectID = Glob.Task.ProjectID;
                dlg.Manager.ActiveModel.StatusID = Glob.Task.StatusID;
                dlg.Manager.ActiveModel.PriorityID = Glob.Task.PriorityID;

                dlg.Manager.SetPriorities();
                dlg.Manager.SetProjects();
                dlg.Manager.SetStatuses();
                //dlg.Manager.ActiveModel.AcceptChangers();
                dlg.ShowDialog();
            }
        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            if (this.Manager.ActiveModel.TaskDateTimeEnd >= DateTime.Now.AddDays(-1))
            {
                this.Manager.ActiveModel.TaskDateTimeStart = DateTime.Now;
                this.Manager.Save();
                this.Manager.Refresh();
                this.Close();
            }
            else
            {
                 MessageBox.Show("Задна дата не може да бъде избрана");
            }

        }
    }
}