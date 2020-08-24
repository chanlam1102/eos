namespace SE1304_EOS
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
            this.lblTime = new System.Windows.Forms.Label();
            this.pnQuestionControl = new System.Windows.Forms.Panel();
            this.pnQuestionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.counterDown = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(866, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(46, 17);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            // 
            // pnQuestionControl
            // 
            this.pnQuestionControl.BackColor = System.Drawing.Color.LightCoral;
            this.pnQuestionControl.Location = new System.Drawing.Point(12, 45);
            this.pnQuestionControl.Name = "pnQuestionControl";
            this.pnQuestionControl.Size = new System.Drawing.Size(900, 500);
            this.pnQuestionControl.TabIndex = 1;
            // 
            // pnQuestionButtons
            // 
            this.pnQuestionButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnQuestionButtons.Location = new System.Drawing.Point(12, 551);
            this.pnQuestionButtons.Name = "pnQuestionButtons";
            this.pnQuestionButtons.Size = new System.Drawing.Size(900, 64);
            this.pnQuestionButtons.TabIndex = 2;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(837, 621);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // counterDown
            // 
            this.counterDown.Interval = 1000;
            this.counterDown.Tick += new System.EventHandler(this.counterDown_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 621);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(316, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 658);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.pnQuestionButtons);
            this.Controls.Add(this.pnQuestionControl);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnQuestionControl;
        private System.Windows.Forms.FlowLayoutPanel pnQuestionButtons;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Timer counterDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

