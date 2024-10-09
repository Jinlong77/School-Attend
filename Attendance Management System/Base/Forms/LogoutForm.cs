using Attendance_Management_System.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Base.Forms
{
    public partial class LogoutForm : Form
    {
        private FormDragHelper dragHelper;
        public LogoutForm()
        {

            InitializeComponent();
            AddCloseButton();

            dragHelper = new FormDragHelper(this);
        }

        private void AddCloseButton()
        {
            Button closeButton = new Button();
            closeButton.Text = "X";
            closeButton.Font = new Font("Google Sans", 12, FontStyle.Bold);
            closeButton.BackColor = Color.Blue;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(this.Width - 40, 10);
            closeButton.Size = new Size(30, 30);
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Click += (s, e) => { Close(); };
            this.Controls.Add(closeButton);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm?.Close();

            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
