namespace ZooApp
{
    partial class AnimalsManagement
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
            button1 = new Button();
            txtAnimalName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(222, 246);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAnimalName
            // 
            txtAnimalName.Location = new Point(397, 152);
            txtAnimalName.Name = "txtAnimalName";
            txtAnimalName.Size = new Size(100, 23);
            txtAnimalName.TabIndex = 1;
            // 
            // AnimalsManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAnimalName);
            Controls.Add(button1);
            Name = "AnimalsManagement";
            Text = "AnimalsManagement";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtAnimalName;
    }
}