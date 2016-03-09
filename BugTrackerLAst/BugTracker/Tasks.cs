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

namespace BugTracker
{
    public partial class Tasks : DevExpress.XtraEditors.XtraForm
    {
        public ITaskManager TManager { get; set; }
        public Tasks()
        {
            InitializeComponent();
            this.Load += Tasks_Load;
        }

        void Tasks_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = this.TManager.ListModels;
            this.gridControl1.DataSource = bs;
            this.Refresh();
            
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
        public static void F_Show()
        {
            using (Tasks dlg = new Tasks())
            {
                dlg.TManager = TaskManager.Create();  
                dlg.TManager.Refresh();
                dlg.ShowDialog();

            }
        }
    }
}