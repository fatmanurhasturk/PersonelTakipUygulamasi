using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_PersonelTakipUygulamasi
{
    class Helper
    {
        public static void ComboBoxDoldur<T>(ComboBox comboControl, ICollection<T> collection)
        {
            comboControl.Items.Clear();
            foreach (var item in collection)
            {
                comboControl.Items.Add(item);
            }
        }

        public static void ControlTemizle(Control control)
        {
            if(control is TextBox)
            {
                control.Text = null;
            }
            else if(control is CheckBox)
            {
                ((CheckBox)control).Checked = false;
            }
            else if(control is RadioButton)
            {
                ((RadioButton)control).Checked = false;
            }
            else if (control is DateTimePicker)
            {
                ((DateTimePicker)control).Value = DateTime.Now;
            }
            else if (control is MaskedTextBox)
            {
                control.Text = null;
            }
            else if (control is NumericUpDown)
            {
                ((NumericUpDown)control).Value = 0;
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).SelectedIndex = -1;
            }
            else if (control is PictureBox)
            {
                ((PictureBox)control).Image = null;
            }

            if (control.Controls.Count>0)
            {
                foreach (Control subControl in control.Controls)
                {
                    ControlTemizle(subControl);
                }
            }
        }
    }
}
