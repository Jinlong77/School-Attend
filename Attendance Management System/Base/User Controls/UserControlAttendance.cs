using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_Management_System.Base.User_Controls
{
    public partial class UserControlAttendance : UserControl
    {
        private const string HintText = "Search Student...";
        public UserControlAttendance()
        {
            InitializeComponent();
            SetHintText();
        }

        private void SetHintText()
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = HintText;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.Blue;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            SetHintText();
        }
    }
}
