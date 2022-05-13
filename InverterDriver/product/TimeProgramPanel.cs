using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InverterDriver.product
{
    internal class TimeProgramPanel
    {
        public Panel panel { get; set; }
        public TextBox textBox { get; set; }
        public DateTimePicker dateTimePicker { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        

        // Construct the panel with the textbox and datetimepicker inside the panel
        public TimeProgramPanel(Panel panel, TextBox textBox, DateTimePicker dateTimePicker)
        {
            this.panel = panel;
            this.textBox = textBox;
            this.dateTimePicker = dateTimePicker;
        }

        // Set the textbox and datetimepicker to the panel
        public void SetPanel()
        {
            panel.Controls.Add(textBox);
            panel.Controls.Add(dateTimePicker);
            
        }

        // Set the textbox and datetimepicker to the panel
        public void SetPanel(int x, int y, int width, int height)
        {
            panel.Location = new System.Drawing.Point(x, y);
            panel.Size = new System.Drawing.Size(width, height);
            textBox.Location = new System.Drawing.Point(0, 0);
            textBox.Size = new System.Drawing.Size(width / 2, height);
            dateTimePicker.Location = new System.Drawing.Point(width / 2, 0);
            dateTimePicker.Size = new System.Drawing.Size(width / 2, height);
        }
    }
}
