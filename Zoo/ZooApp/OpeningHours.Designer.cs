namespace ZooApp
{
    partial class OpeningHours
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnChangeHours = new Button();
            timeStart = new DateTimePicker();
            timeEnd = new DateTimePicker();
            lblSunday = new Label();
            SuspendLayout();
            // 
            // btnChangeHours
            // 
            btnChangeHours.Location = new Point(371, 396);
            btnChangeHours.Name = "btnChangeHours";
            btnChangeHours.Size = new Size(95, 30);
            btnChangeHours.TabIndex = 0;
            btnChangeHours.Text = "Change";
            btnChangeHours.UseVisualStyleBackColor = true;
            btnChangeHours.Click += btnChangeHours_Click;
            // 
            // timeStart
            // 
            timeStart.Location = new Point(180, 67);
            timeStart.Name = "timeStart";
            timeStart.Size = new Size(200, 23);
            timeStart.TabIndex = 1;
            timeStart.ValueChanged += timeStart_ValueChanged;
            // 
            // timeEnd
            // 
            timeEnd.Location = new Point(386, 67);
            timeEnd.Name = "timeEnd";
            timeEnd.Size = new Size(200, 23);
            timeEnd.TabIndex = 2;
            // 
            // lblSunday
            // 
            lblSunday.AutoSize = true;
            lblSunday.Location = new Point(113, 73);
            lblSunday.Name = "lblSunday";
            lblSunday.Size = new Size(46, 15);
            lblSunday.TabIndex = 3;
            lblSunday.Text = "Sunday";
            // 
            // OpeningHours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(lblSunday);
            Controls.Add(timeEnd);
            Controls.Add(timeStart);
            Controls.Add(btnChangeHours);
            Name = "OpeningHours";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeHours;
        private DateTimePicker timeStart;
        private DateTimePicker timeEnd;
        private Label lblSunday;
    }
}
