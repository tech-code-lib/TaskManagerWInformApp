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
using TaskManagerBusinessLogic.BusinessEntities;

namespace TaskManager
{
    public partial class TaskFrm : Form
    {
        TaskManagerService taskManagerService = new TaskManagerService();
        UserService userService = new UserService();
        List<BaseTask> allTasks = new List<BaseTask>();
        BaseTask selectedTask = null;
        
        public TaskFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text;
            string detail = txtTaskDetail.Text;
            TaskPriority priority = (TaskPriority) Enum.Parse(typeof(TaskPriority), cmbPriority.SelectedItem.ToString());

            int selectedTaskId;
            int.TryParse(lblSelectedTask.Text, out selectedTaskId);
            BaseTask task;
            if (selectedTaskId > 0)
            {
                int assignToUserId = (cmbUsers.SelectedItem as User).Id;
                //ToDo: Call Business Logic Service TaskManagerService Method AssignATask to Assign an User to the Task.
                selectedTask = taskManagerService.AssignATask(selectedTask, assignToUserId);

                var status = (TaskManagerBusinessLogic.BusinessEntities.TaskStatus)Enum.Parse(typeof(TaskManagerBusinessLogic.BusinessEntities.TaskStatus), cmbStatus.SelectedItem.ToString());

                if (status == TaskManagerBusinessLogic.BusinessEntities.TaskStatus.Closed)
                {
                    string closingComments = txtClosingComments.Text;
                    //ToDo: Call Business Logic Service TaskManagerService Method ResolveTask to Resolve a Task with comment.
                    selectedTask = taskManagerService.ResolveTask(selectedTask, $"Resolved with comments: {closingComments}");
                }
                else
                {
                    //ToDo: Call Business Logic Service TaskManagerService Method UpdateStatus to Update Status of a Task
                    selectedTask = taskManagerService.UpdateStatus(selectedTask, status);
                }
                
            }
            else
            {
                //ToDo: Call Business Logic Service TaskManagerService Method CreateATask to create a new Task
                task = taskManagerService.CreateATask(title, detail, priority, chkInternalTask.Checked);
            }
            ClearData();
            BindAllTasks();
        }

        /// <summary>
        /// Form Load events. Initialize all data and controls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskFrm_Load(object sender, EventArgs e)
        {
            cmbPriority.DataSource = new List<TaskPriority> 
                { 
                    TaskManagerBusinessLogic.BusinessEntities.TaskPriority.High,
                    TaskManagerBusinessLogic.BusinessEntities.TaskPriority.Medium,
                    TaskManagerBusinessLogic.BusinessEntities.TaskPriority.Low 
                };

            BindAllTasks();
            dgrdTasks.Dock = DockStyle.Bottom;

            cmbUsers.DataSource = userService.GetAllUsers();
            cmbUsers.DisplayMember = "FirstName";
            cmbUsers.ValueMember = "Id";
            cmbStatus.DataSource = new List<TaskManagerBusinessLogic.BusinessEntities.TaskStatus> { TaskManagerBusinessLogic.BusinessEntities.TaskStatus.Open, TaskManagerBusinessLogic.BusinessEntities.TaskStatus.InProgress, TaskManagerBusinessLogic.BusinessEntities.TaskStatus.Closed };

            ClearData();

        }

        /// <summary>
        /// Fetch all the tasks and bind to the data grid.
        /// </summary>
        private void BindAllTasks()
        {
            //ToDo: Call Business Logic Service TaskManagerService Method GetAllTasks() to fetch all tasks
            allTasks = taskManagerService.GetAllTasks();
            foreach (BaseTask task in allTasks)
            {
                if (task.AssignedToId > 0)
                    task.AssignedTo = userService.GetUser(task.AssignedToId);
            }
            dgrdTasks.DataSource = allTasks;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            BindAllTasks();
        }

        /// <summary>
        /// DataGrid Selection change event. Get the bound task object with this event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgrdTasks_SelectionChanged(object sender, EventArgs e)
        {
            var rows = dgrdTasks.SelectedRows;
            if (rows != null && rows.Count > 0)
            {
                var selectedRow = rows[0];

                var task = selectedRow.DataBoundItem as BaseTask;
                cmbUsers.Visible = true;
                cmbStatus.Visible = true;
                lblAssignTo.Visible = true;
                lblStatus.Visible = true;
                chkInternalTask.Checked = (typeof(OrganizationTask) == task.GetType());
                txtTaskTitle.Text = task.Title;
                txtTaskDetail.Text = task.Description;
                cmbPriority.SelectedIndex = cmbPriority.Items.IndexOf(task.TaskPriority);
                cmbStatus.SelectedIndex = cmbStatus.Items.IndexOf(task.TaskStatus);
                lblSelectedTask.Text = task.TaskId.ToString();
                selectedTask = task;
                lblSelectedTaskLabel.Visible = true;
                lblClosingComment.Visible = true;
                txtClosingComments.Visible = true;
                if (task.TaskStatus == TaskManagerBusinessLogic.BusinessEntities.TaskStatus.Closed)
                {
                    txtClosingComments.Enabled = false;
                    cmbStatus.Enabled = false;
                }
                else
                {
                    txtClosingComments.Enabled = true;
                    cmbStatus.Enabled = true;
                }
                txtClosingComments.Text = task.ResolutionRemarks;
                if (task.AssignedToId == 0)
                {
                    cmbUsers.SelectedIndex = 0;
                }
                else
                {
                    for (int i = 0; i < cmbUsers.Items.Count; i++)
                    {
                        User user = cmbUsers.Items[i] as User;
                        if (user.Id == task.AssignedToId)
                        {
                            cmbUsers.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }   
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        /// <summary>
        /// Private Method to clear all data.
        /// </summary>
        private void ClearData()
        {
            cmbUsers.Visible = false;
            cmbStatus.Visible = false;
            lblAssignTo.Visible = false;
            lblStatus.Visible = false;
            txtTaskTitle.Text = "";
            txtTaskDetail.Text = "";
            lblSelectedTask.Text = "0";
            cmbPriority.SelectedIndex = cmbPriority.Items.IndexOf(TaskManagerBusinessLogic.BusinessEntities.TaskPriority.Medium);
            lblSelectedTask.Text = "";
            lblSelectedTaskLabel.Visible = false;
            lblClosingComment.Visible = false;
            txtClosingComments.Visible = false;
            txtClosingComments.Text = "";
            txtClosingComments.Enabled = true;
            cmbStatus.Enabled = true;
        }
    }
}
