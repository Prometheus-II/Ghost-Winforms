using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhostForm_Redo
{
    public partial class reminderset : Form
    {
        public delegate void DoneWrong();
        public DoneWrong TimeWrong;

        public reminder remind { get; set; }

        public reminderset()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value < DateTime.Now)
            {
                TimeWrong();
            }
            else
            {
                if(dateTimePicker1.Value.DayOfYear == DateTime.Today.DayOfYear)
                {
                    remind = new reminder(dateTimePicker1.Value, false);
                }
                else
                {
                    remind = new reminder(dateTimePicker1.Value, true);
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
