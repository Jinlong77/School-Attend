
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Management_System.Class
{
    public class UserControlManager
    {
        private Dictionary<Button, UserControl> buttonControlMap;

        public UserControlManager(Dictionary<Button, UserControl> buttonControlMap)
        {
            this.buttonControlMap = buttonControlMap;
        }

        public void ShowControl(Button clickedButton)
        {
            foreach (var entry in buttonControlMap)
            {
                entry.Value.Visible = false;
            }

            if (buttonControlMap.ContainsKey(clickedButton))
            {
                buttonControlMap[clickedButton].Visible = true;
            }
        }

    }

}
