namespace BugTracker
{
    partial class UserList
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.btnEditTask = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTask = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaskDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriorityID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaskDateTimeStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatusID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SecondName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RightName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(931, 458);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage1});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.btnEditTask);
            this.xtraTabPage2.Controls.Add(this.btnAddTask);
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(925, 430);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(393, 17);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(205, 29);
            this.btnEditTask.TabIndex = 2;
            this.btnEditTask.Text = "Редактирай";
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(206, 17);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(147, 29);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Нова задача";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Location = new System.Drawing.Point(8, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(910, 367);
            this.gridControl1.TabIndex = 0;
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
            this.StatusID});
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
            this.TaskName.Width = 127;
            // 
            // TaskDescription
            // 
            this.TaskDescription.Caption = "Описание";
            this.TaskDescription.FieldName = "TaskDescription";
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.Visible = true;
            this.TaskDescription.VisibleIndex = 1;
            this.TaskDescription.Width = 127;
            // 
            // ProjectID
            // 
            this.ProjectID.Caption = "Проект";
            this.ProjectID.FieldName = "ProjectName";
            this.ProjectID.Name = "ProjectID";
            this.ProjectID.Visible = true;
            this.ProjectID.VisibleIndex = 2;
            this.ProjectID.Width = 128;
            // 
            // UserID
            // 
            this.UserID.Caption = "Потребител";
            this.UserID.FieldName = "UserName";
            this.UserID.Name = "UserID";
            this.UserID.Visible = true;
            this.UserID.VisibleIndex = 3;
            this.UserID.Width = 126;
            // 
            // PriorityID
            // 
            this.PriorityID.Caption = "Приоритет";
            this.PriorityID.FieldName = "PriorityName";
            this.PriorityID.Name = "PriorityID";
            this.PriorityID.Visible = true;
            this.PriorityID.VisibleIndex = 4;
            this.PriorityID.Width = 126;
            // 
            // TaskDateTimeStart
            // 
            this.TaskDateTimeStart.Caption = "Дата на създаване";
            this.TaskDateTimeStart.FieldName = "TaskDateTimeStart";
            this.TaskDateTimeStart.Name = "TaskDateTimeStart";
            this.TaskDateTimeStart.Visible = true;
            this.TaskDateTimeStart.VisibleIndex = 5;
            this.TaskDateTimeStart.Width = 126;
            // 
            // StatusID
            // 
            this.StatusID.Caption = "Статус";
            this.StatusID.FieldName = "StatusName";
            this.StatusID.Name = "StatusID";
            this.StatusID.Visible = true;
            this.StatusID.VisibleIndex = 6;
            this.StatusID.Width = 132;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnDelete);
            this.xtraTabPage1.Controls.Add(this.btnEdit);
            this.xtraTabPage1.Controls.Add(this.btnAdd);
            this.xtraTabPage1.Controls.Add(this.gridControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(925, 430);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(609, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(437, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(113, 41);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактирай";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(260, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Добави";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Location = new System.Drawing.Point(3, 52);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(915, 371);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.UserName,
            this.UserPassword,
            this.FirstName,
            this.SecondName,
            this.LastName,
            this.RightName});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // UserName
            // 
            this.UserName.Caption = "Потребителско име";
            this.UserName.FieldName = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.Visible = true;
            this.UserName.VisibleIndex = 0;
            // 
            // UserPassword
            // 
            this.UserPassword.Caption = "Парола";
            this.UserPassword.FieldName = "UserPassword";
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Visible = true;
            this.UserPassword.VisibleIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.Caption = "Име";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 2;
            // 
            // SecondName
            // 
            this.SecondName.Caption = "Презиме";
            this.SecondName.FieldName = "SecondName";
            this.SecondName.Name = "SecondName";
            this.SecondName.Visible = true;
            this.SecondName.VisibleIndex = 3;
            // 
            // LastName
            // 
            this.LastName.Caption = "Фамилия";
            this.LastName.FieldName = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 4;
            // 
            // RightName
            // 
            this.RightName.Caption = "Права";
            this.RightName.FieldName = "RightName";
            this.RightName.Name = "RightName";
            this.RightName.Visible = true;
            this.RightName.VisibleIndex = 5;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 458);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "UserList";
            this.Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton btnEditTask;
        private DevExpress.XtraEditors.SimpleButton btnAddTask;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn TaskName;
        private DevExpress.XtraGrid.Columns.GridColumn TaskDescription;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn UserID;
        private DevExpress.XtraGrid.Columns.GridColumn PriorityID;
        private DevExpress.XtraGrid.Columns.GridColumn TaskDateTimeStart;
        private DevExpress.XtraGrid.Columns.GridColumn StatusID;
        private DevExpress.XtraGrid.Columns.GridColumn UserName;
        private DevExpress.XtraGrid.Columns.GridColumn UserPassword;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn SecondName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn RightName;
    }
}