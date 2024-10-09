
using System.Windows.Forms;

namespace Attendance_Management_System.Class
{
    public class FormContextControl
    {
        private Form form;

        public FormContextControl(Form form)
        {
            this.form = form;
        }

        public void FormNavigationTo(Form targetForm)
        {
/*            targetForm.FormClosed += (s, e) => Application.Exit();
*/            targetForm.Show();
            form.Hide();
        }

    }
}
