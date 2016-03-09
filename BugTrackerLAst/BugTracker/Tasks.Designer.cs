namespace BugTracker
{
    partial class Tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaskDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriorityID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaskDateTimeStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaskDateTimeEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditTask = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTask = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(12, 81);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(890, 425);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TaskName,
            this.TaskDescription,
            this.ProjectID,
            this.UserID,
            this.PriorityID,
            this.TaskDateTimeStart,
            this.StatusID,
            this.TaskDateTimeEnd});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // TaskName
            // 
            this.TaskName.Caption = "Име задача";
            this.TaskName.FieldName = "TaskName";
            this.TaskName.Name = "TaskName";
            this.TaskName.Visible = true;
            this.TaskName.VisibleIndex = 0;
            // 
            // TaskDescription
            // 
            this.TaskDescription.Caption = "Описание";
            this.TaskDescription.FieldName = "TaskDescription";
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.Visible = true;
            this.TaskDescription.VisibleIndex = 1;
            // 
            // ProjectID
            // 
            this.ProjectID.Caption = "Проект";
            this.ProjectID.FieldName = "ProjectName";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Visible = true;
            this.ProjectID.VisibleIndex = 2;
            // 
            // UserID
            // 
            this.UserID.Caption = "Потребител";
            this.UserID.FieldName = "UserName";
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 3;
            // 
            // PriorityID
            // 
            this.PriorityID.Caption = "Приоритет";
            this.PriorityID.FieldName = "PriorityName";
            this.PriorityID.Name = "PriorityID";
            this.PriorityID.Visible = true;
            this.PriorityID.VisibleIndex = 4;
            // 
            // TaskDateTimeStart
            // 
            this.TaskDateTimeStart.Caption = "Дата на създаване";
            this.TaskDateTimeStart.Name = "TaskDateTimeStart";
            this.TaskDateTimeStart.Visible = true;
            this.TaskDateTimeStart.VisibleIndex = 5;
            // 
            // StatusID
            // 
            this.StatusID.Caption = "Статус";
            this.StatusID.FieldName = "StatusName";
            this.StatusID.Name = "StatusID";
            this.StatusID.Visible = true;
            this.StatusID.VisibleIndex = 6;
            // 
            // TaskDateTimeEnd
            // 
            this.TaskDateTimeEnd.Caption = "Краен срок";
            this.TaskDateTimeEnd.FieldName = "TaskDateTimeEnd";
            this.TaskDateTimeEnd.Name = "TaskDateTimeEnd";
            this.TaskDateTimeEnd.Visible = true;
            this.TaskDateTimeEnd.VisibleIndex = 7;
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(423, 24);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(204, 34);
            this.btnEditTask.TabIndex = 4;
            this.btnEditTask.Text = "Редактирай";
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(236, 24);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(146, 34);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Нова задача";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 531);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.gridControl1);
            this.Name = "Tasks";
            this.Text = "Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn TaskName;
        private DevExpress.XtraGrid.Columns.GridColumn TaskDescription;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn PriorityID;
        private DevExpress.XtraGrid.Columns.GridColumn TaskDateTimeStart;
        private DevExpress.XtraGrid.Columns.GridColumn StatusID;
        private DevExpress.XtraEditors.SimpleButton btnEditTask;
        private DevExpress.XtraEditors.SimpleButton btnAddTask;
        private DevExpress.XtraGrid.Columns.GridColumn TaskDateTimeEnd;
    }
}