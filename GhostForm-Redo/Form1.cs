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
    public partial class Form1 : Form
    {

        bool Hovering = false;
        int HoverTime = 0;

        int TalkTime = 0;
        
        int PetStrokes = 0;
        bool PetInLastTick = false;
        int NotPetTime = 0;

        public enum GhostState { Stand, Speak, Pet, Ask, Alarm };
        public enum TalkType { Pet, Ask, Normal, Alarm, FormMenu };
        GhostState curState = GhostState.Stand;

        List<reminder> alarms = new List<reminder>();
        reminderset Form2 = new reminderset();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            ControlBox = false;
            Text = String.Empty;
            WindowState = FormWindowState.Maximized;


            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.TransparencyKey = this.BackColor;
        }

        private void ghostbox_MouseMove(object sender, MouseEventArgs e)
        {
            Hovering = false;
            HoverTime = 0;

            PetInLastTick = true;
            PetStrokes++;
            if(PetStrokes > 100)
            {
                Say("Hey, stop that", TalkType.Pet);
            }
        }

        private void ghostbox_MouseHover(object sender, EventArgs e)
        {
            Hovering = true;
        }

        private void ghostbox_MouseLeave(object sender, EventArgs e)
        {
            Hovering = false;
            HoverTime = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            if(curState == GhostState.Pet)
            {
                if (!PetInLastTick)
                {
                    NotPetTime++;
                    if (NotPetTime > 5)
                    {
                        BackToStand();
                    }
                }
                else
                {
                    NotPetTime = 0;
                }
                PetInLastTick = false;
            }

            if(Hovering)
            {
                HoverTime++;
                if(HoverTime > 6)
                {
                    Say("What can I do for you?", TalkType.Ask);
                }
            }
            else
            {
                HoverTime = 0;
            }
            
            for(int i = 0; i < alarms.Count; i++)
            {
                if(alarms[i].IsTime())
                {
                    Say("Hey, your alarm set for now is going off!", TalkType.Alarm);
                }
            }
            
            if(curState == GhostState.Speak)
            {
                TalkTime++;
                if(TalkTime > 5)
                {
                    BackToStand();
                }
            }
        }

        public void Say(String text, TalkType type)
        {
            MainText.Text = text;
            TalkPanel.Visible = true;
            if(type == TalkType.Pet)
            {
                curState = GhostState.Pet;
                ghostbox.Image = Properties.Resources.stickPet;
            }
            else
            {
                ghostbox.Image = Properties.Resources.stickTalk;
            }

            if (type == TalkType.Ask)
            {
                curState = GhostState.Ask;
                OptionPanel.Visible = true;
            }
            else
                OptionPanel.Visible = false;

            if (type == TalkType.Normal)
            {
                curState = GhostState.Speak;
            }
            if(type == TalkType.FormMenu)
            {
                curState = GhostState.Ask;
                if(Form2.ShowDialog(this) == DialogResult.OK)
                {
                    if(Form2.remind.IsTime())
                    {
                        Say("Hey, you put in something that already happened! Try that again.", TalkType.FormMenu);
                    }
                    else
                    {
                        alarms.Add(Form2.remind);
                        Say("Okay, got it.", TalkType.Normal);
                    }
                }
                else
                {
                    Say("Oh, okay then.", TalkType.Normal);
                }
            }
        }

        void BackToStand()
        {
            TalkPanel.Visible = false;
            curState = GhostState.Stand;
            ghostbox.Image = Properties.Resources.stickStand;
            Hovering = false;
            HoverTime = 0;
            TalkTime = 0;
            PetStrokes = 0;
            PetInLastTick = false;
            NotPetTime = 0;
        }

        private void op2txt_Click(object sender, EventArgs e)
        {
            Say("Oh, okay.", TalkType.Normal);
        }

        private void op1txt_Click(object sender, EventArgs e)
        {
            Say("Alright, just fill out the form and I'll put it in.", TalkType.FormMenu);
        }
    }
}
