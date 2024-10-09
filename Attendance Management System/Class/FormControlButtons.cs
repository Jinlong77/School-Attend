using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Attendance_Management_System.Class
{
    public class FormControlButtons
    {
        private Form targetForm;
        private bool isMaximized = false;
        private bool onMaximized {  get; set; }

        public FormControlButtons(Form form, bool onMax)
        {
            this.targetForm = form;
            this.onMaximized = onMax;
            AddCloseButton();
            if (onMaximized) AddMaximizeButton();
            AddMinimizeButton();
        }

        private void AddCloseButton()
        {
            Button closeButton = new Button();
            closeButton.Text = "X";
            closeButton.Font = new Font("Google Sans", 12, FontStyle.Bold);
            closeButton.BackColor = Color.Blue;
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(targetForm.Width - 40, 10);
            closeButton.Size = new Size(30, 30);
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.Click += (s, e) => { Application.Exit(); };
            targetForm.Controls.Add(closeButton);
        }

        private void AddMinimizeButton()
        {
            Button minimizeButton = new Button();
            minimizeButton.Text = "_";
            minimizeButton.Font = new Font("Google Sans", 12, FontStyle.Bold);
            minimizeButton.BackColor = Color.White;
            minimizeButton.ForeColor = Color.Blue;
            minimizeButton.Location = new Point(targetForm.Width - (onMaximized==true ? 120 : 80), 10);
            minimizeButton.Size = new Size(30, 30);
            minimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButton.Click += (s, e) => { targetForm.WindowState = FormWindowState.Minimized; };
            targetForm.Controls.Add(minimizeButton);
        }

        private void AddMaximizeButton()
        {
            Button maximizeButton = new Button();
            maximizeButton.Text = "⬜";
            maximizeButton.Font = new Font("Google Sans", 12, FontStyle.Bold);
            maximizeButton.BackColor = Color.White;
            maximizeButton.ForeColor = Color.Blue;
            maximizeButton.Location = new Point(targetForm.Width - 80, 10);
            maximizeButton.Size = new Size(30, 30);
            maximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximizeButton.Click += (s, e) => ToggleMaximize();
            targetForm.Controls.Add(maximizeButton);
        }

        private void ToggleMaximize()
        {
            if (isMaximized)
            {
                targetForm.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                targetForm.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }
    }
}
