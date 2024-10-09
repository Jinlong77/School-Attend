using Attendance_Management_System.Class;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Attendance_Management_System
{
    public partial class Login : Form
    {
        private FormDragHelper dragHelper;
        private FormControlButtons controlButtons;

        public Login()
        {
            InitializeComponent();

            dragHelper = new FormDragHelper(this);
            controlButtons = new FormControlButtons(this, false);
        }

        private void forgetHover(object sender, EventArgs e)
        {
            lbForget.ForeColor = Color.Blue;
        }

        private void forgetLeave(object sender, EventArgs e)
        {
            lbForget.ForeColor = Color.DodgerBlue;
        }

        private void btnHover(object sender, EventArgs e)
        {
            lgBtn.BackColor = Color.Blue;
        }

        private void btnLeave(object sender, EventArgs e)
        {
            lgBtn.BackColor = Color.DodgerBlue;
        }

        private void lgBtn_Click(object sender, EventArgs e)
        {
            FormContextControl formContextControl = new FormContextControl(this);
            formContextControl.FormNavigationTo(new MainForm());
        }

        private void usernameChanged(object sender, EventArgs e)
        {

        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            btnHidePassword.Image = onChangeImage(txtPassword.UseSystemPasswordChar);
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private Image onChangeImage(bool isHide)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directoryInfo = new DirectoryInfo(baseDirectory);
            DirectoryInfo targetDirectoryInfo = directoryInfo.Parent.Parent;
            string exeFolder = targetDirectoryInfo.FullName;
            return isHide ? Image.FromFile($"{exeFolder}\\Images\\eye.png") : Image.FromFile($"{exeFolder}\\Images\\hiding.png");
        }
    }
}
