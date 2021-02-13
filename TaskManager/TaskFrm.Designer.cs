namespace TaskManager
{
    partial class TaskFrm
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
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtTaskDetail = new System.Windows.Forms.TextBox();
            this.lblTaskDetail = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.chkInternalTask = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgrdTasks = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.lblSelectedTask = new System.Windows.Forms.Label();
            this.lblSelectedTaskLabel = new System.Windows.Forms.Label();
            this.txtClosingComments = new System.Windows.Forms.TextBox();
            this.lblClosingComment = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTaskTitle.TabIndex = 0;
            this.lblTaskTitle.Text = "Title";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(69, 13);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(335, 20);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // txtTaskDetail
            // 
            this.txtTaskDetail.Location = new System.Drawing.Point(69, 39);
            this.txtTaskDetail.Multiline = true;
            this.txtTaskDetail.Name = "txtTaskDetail";
            this.txtTaskDetail.Size = new System.Drawing.Size(335, 89);
            this.txtTaskDetail.TabIndex = 3;
            // 
            // lblTaskDetail
            // 
            this.lblTaskDetail.AutoSize = true;
            this.lblTaskDetail.Location = new System.Drawing.Point(13, 39);
            this.lblTaskDetail.Name = "lblTaskDetail";
            this.lblTaskDetail.Size = new System.Drawing.Size(34, 13);
            this.lblTaskDetail.TabIndex = 2;
            this.lblTaskDetail.Text = "Detail";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cmbPriority.Location = new System.Drawing.Point(69, 145);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(131, 21);
            this.cmbPriority.TabIndex = 4;
            // 
            // chkInternalTask
            // 
            this.chkInternalTask.AutoSize = true;
            this.chkInternalTask.Location = new System.Drawing.Point(69, 182);
            this.chkInternalTask.Name = "chkInternalTask";
            this.chkInternalTask.Size = new System.Drawing.Size(94, 17);
            this.chkInternalTask.TabIndex = 5;
            this.chkInternalTask.Text = "Internal Task?";
            this.chkInternalTask.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgrdTasks
            // 
            this.dgrdTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrdTasks.Location = new System.Drawing.Point(0, 300);
            this.dgrdTasks.Name = "dgrdTasks";
            this.dgrdTasks.Size = new System.Drawing.Size(800, 150);
            this.dgrdTasks.TabIndex = 7;
            this.dgrdTasks.SelectionChanged += new System.EventHandler(this.dgrdTasks_SelectionChanged);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(172, 219);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload Data";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(613, 11);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(159, 21);
            this.cmbUsers.TabIndex = 9;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(613, 52);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(159, 21);
            this.cmbStatus.TabIndex = 10;
            // 
            // lblAssignTo
            // 
            this.lblAssignTo.AutoSize = true;
            this.lblAssignTo.Location = new System.Drawing.Point(502, 13);
            this.lblAssignTo.Name = "lblAssignTo";
            this.lblAssignTo.Size = new System.Drawing.Size(54, 13);
            this.lblAssignTo.TabIndex = 11;
            this.lblAssignTo.Text = "Assign To";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(502, 52);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(282, 219);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(75, 23);
            this.btnNewTask.TabIndex = 13;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // lblSelectedTask
            // 
            this.lblSelectedTask.AutoSize = true;
            this.lblSelectedTask.Location = new System.Drawing.Point(613, 114);
            this.lblSelectedTask.Name = "lblSelectedTask";
            this.lblSelectedTask.Size = new System.Drawing.Size(0, 13);
            this.lblSelectedTask.TabIndex = 14;
            // 
            // lblSelectedTaskLabel
            // 
            this.lblSelectedTaskLabel.AutoSize = true;
            this.lblSelectedTaskLabel.Location = new System.Drawing.Point(502, 114);
            this.lblSelectedTaskLabel.Name = "lblSelectedTaskLabel";
            this.lblSelectedTaskLabel.Size = new System.Drawing.Size(76, 13);
            this.lblSelectedTaskLabel.TabIndex = 15;
            this.lblSelectedTaskLabel.Tag = "";
            this.lblSelectedTaskLabel.Text = "Selected Task";
            // 
            // txtClosingComments
            // 
            this.txtClosingComments.Location = new System.Drawing.Point(505, 168);
            this.txtClosingComments.Multiline = true;
            this.txtClosingComments.Name = "txtClosingComments";
            this.txtClosingComments.Size = new System.Drawing.Size(267, 74);
            this.txtClosingComments.TabIndex = 16;
            // 
            // lblClosingComment
            // 
            this.lblClosingComment.AutoSize = true;
            this.lblClosingComment.Location = new System.Drawing.Point(502, 145);
            this.lblClosingComment.Name = "lblClosingComment";
            this.lblClosingComment.Size = new System.Drawing.Size(96, 13);
            this.lblClosingComment.TabIndex = 17;
            this.lblClosingComment.Tag = "";
            this.lblClosingComment.Text = "Closing Comments:";
            // 
            // TaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblClosingComment);
            this.Controls.Add(this.txtClosingComments);
            this.Controls.Add(this.lblSelectedTaskLabel);
            this.Controls.Add(this.lblSelectedTask);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAssignTo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgrdTasks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkInternalTask);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.txtTaskDetail);
            this.Controls.Add(this.lblTaskDetail);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.lblTaskTitle);
            this.Name = "TaskFrm";
            this.Text = "Manage Task";
            this.Load += new System.EventHandler(this.TaskFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDetail;
        private System.Windows.Forms.Label lblTaskDetail;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.CheckBox chkInternalTask;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgrdTasks;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Label lblSelectedTask;
        private System.Windows.Forms.Label lblSelectedTaskLabel;
        private System.Windows.Forms.TextBox txtClosingComments;
        private System.Windows.Forms.Label lblClosingComment;
    }
}