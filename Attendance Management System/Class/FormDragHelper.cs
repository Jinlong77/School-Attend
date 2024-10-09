
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Management_System.Class
{
    public class FormDragHelper
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Form targetForm;

        public FormDragHelper(Form form)
        {
            this.targetForm = form;
            this.targetForm.MouseDown += new MouseEventHandler(Form_MouseDown);
            this.targetForm.MouseMove += new MouseEventHandler(Form_MouseMove);
            this.targetForm.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = targetForm.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                targetForm.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
