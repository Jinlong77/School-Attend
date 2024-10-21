using Attendance_Management_System.Base.Forms;
using Attendance_Management_System.Base.User_Controls;
using Attendance_Management_System.Class;
using Attendance_Management_System.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Attendance_Management_System
{
    public partial class MainForm : Form
    {
        private FormDragHelper dragHelper;
        private FormControlButtons controlButtons;
        private UserControlManager userControlManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeUserControlManager();

            dragHelper = new FormDragHelper(this);
            controlButtons = new FormControlButtons(this, false);
        }

        private void InitializeUserControlManager()
        {

            Controls.Add(userControlDashboard);
            Controls.Add(userControlAttendance);
       

            userControlDashboard.Visible = false;
            userControlAttendance.Visible = false;


            Dictionary<Button, UserControl> buttonControlMap = new Dictionary<Button, UserControl>
            {
                { btnDashboard, userControlDashboard },
                { btnAttendance, userControlAttendance },
            };

            userControlManager = new UserControlManager(buttonControlMap);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timerDateTime.Start();
            userControlDashboard.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutForm logoutForm = new LogoutForm();
            logoutForm.Show();
        }

        private void MoveSidePanel(Control button)
        {
            panelSide.Location = new Point(button.Location.X - button.Location.X, button.Location.Y);
            panelBackSide.Location = new Point(button.Location.X + 379 , button.Location.Y + 94);
            button.Location = new Point(10, button.Location.Y);
            ChangeButtonColor(button);

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            onClicked(btnDashboard);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            onClicked(btnAttendance);
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            onClicked(btnAddClass);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            onClicked(btnAddTeacher);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            onClicked(btnReport);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            onClicked(btnAddStudent);
        }

        private void ChangeButtonColor(Control clickedButton)
        {
            
            btnDashboard.BackColor = Color.FromArgb(106, 90, 205);
            btnAttendance.BackColor = Color.FromArgb(106, 90, 205);
            btnReport.BackColor = Color.FromArgb(106, 90, 205);
            btnAddClass.BackColor = Color.FromArgb(106, 90, 205);
            btnAddTeacher.BackColor = Color.FromArgb(106, 90, 205);
            btnAddStudent.BackColor = Color.FromArgb(106, 90, 205);
            btnSetting.BackColor = Color.FromArgb(106, 90, 205);

            clickedButton.BackColor = Color.FromArgb(72, 62, 139);
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F");
        }

        private void onClicked(Button buttonName)
        {
            MoveSidePanel(buttonName);
            userControlManager.ShowControl(buttonName);
        }

      
    }
}
