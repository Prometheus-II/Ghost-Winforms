namespace GhostForm_Redo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TalkPanel = new System.Windows.Forms.Panel();
            this.MainText = new System.Windows.Forms.Label();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.op1txt = new System.Windows.Forms.Label();
            this.quitbutton = new System.Windows.Forms.Button();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.ghostbox = new System.Windows.Forms.PictureBox();
            this.op2txt = new System.Windows.Forms.Label();
            this.TalkPanel.SuspendLayout();
            this.OptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ghostbox)).BeginInit();
            this.SuspendLayout();
            // 
            // TalkPanel
            // 
            this.TalkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TalkPanel.Controls.Add(this.MainText);
            this.TalkPanel.Controls.Add(this.OptionPanel);
            this.TalkPanel.Location = new System.Drawing.Point(435, 168);
            this.TalkPanel.Name = "TalkPanel";
            this.TalkPanel.Size = new System.Drawing.Size(200, 165);
            this.TalkPanel.TabIndex = 1;
            this.TalkPanel.Visible = false;
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.BackColor = System.Drawing.Color.LightGray;
            this.MainText.Location = new System.Drawing.Point(3, 0);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(46, 17);
            this.MainText.TabIndex = 1;
            this.MainText.Text = "label1";
            // 
            // OptionPanel
            // 
            this.OptionPanel.Controls.Add(this.op2txt);
            this.OptionPanel.Controls.Add(this.op1txt);
            this.OptionPanel.Location = new System.Drawing.Point(0, 65);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(200, 100);
            this.OptionPanel.TabIndex = 0;
            this.OptionPanel.Visible = false;
            // 
            // op1txt
            // 
            this.op1txt.AutoSize = true;
            this.op1txt.BackColor = System.Drawing.Color.LightGray;
            this.op1txt.Location = new System.Drawing.Point(0, 0);
            this.op1txt.Name = "op1txt";
            this.op1txt.Size = new System.Drawing.Size(105, 17);
            this.op1txt.TabIndex = 0;
            this.op1txt.Text = "Add a reminder";
            this.op1txt.Click += new System.EventHandler(this.op1txt_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.quitbutton.Location = new System.Drawing.Point(713, 168);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(75, 23);
            this.quitbutton.TabIndex = 2;
            this.quitbutton.Text = "QUIT";
            this.quitbutton.UseVisualStyleBackColor = true;
            this.quitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // ghostbox
            // 
            this.ghostbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ghostbox.Image = global::GhostForm_Redo.Properties.Resources.stickStand;
            this.ghostbox.Location = new System.Drawing.Point(641, 233);
            this.ghostbox.Name = "ghostbox";
            this.ghostbox.Size = new System.Drawing.Size(147, 205);
            this.ghostbox.TabIndex = 0;
            this.ghostbox.TabStop = false;
            this.ghostbox.MouseLeave += new System.EventHandler(this.ghostbox_MouseLeave);
            this.ghostbox.MouseHover += new System.EventHandler(this.ghostbox_MouseHover);
            this.ghostbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ghostbox_MouseMove);
            // 
            // op2txt
            // 
            this.op2txt.AutoSize = true;
            this.op2txt.BackColor = System.Drawing.Color.LightGray;
            this.op2txt.Location = new System.Drawing.Point(3, 42);
            this.op2txt.Name = "op2txt";
            this.op2txt.Size = new System.Drawing.Size(107, 17);
            this.op2txt.TabIndex = 1;
            this.op2txt.Text = "Nothing, thanks";
            this.op2txt.Click += new System.EventHandler(this.op2txt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.TalkPanel);
            this.Controls.Add(this.ghostbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TalkPanel.ResumeLayout(false);
            this.TalkPanel.PerformLayout();
            this.OptionPanel.ResumeLayout(false);
            this.OptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ghostbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ghostbox;
        private System.Windows.Forms.Panel TalkPanel;
        public System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.Label op1txt;
        private System.Windows.Forms.Button quitbutton;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label op2txt;
    }
}

