
namespace kosyat
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.vvod1 = new System.Windows.Forms.TextBox();
            this.vvod2 = new System.Windows.Forms.TextBox();
            this.vivod1 = new System.Windows.Forms.RichTextBox();
            this.vivod2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "5.1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vvod1
            // 
            this.vvod1.Location = new System.Drawing.Point(12, 12);
            this.vvod1.Name = "vvod1";
            this.vvod1.Size = new System.Drawing.Size(120, 23);
            this.vvod1.TabIndex = 1;
            // 
            // vvod2
            // 
            this.vvod2.Location = new System.Drawing.Point(12, 41);
            this.vvod2.Name = "vvod2";
            this.vvod2.Size = new System.Drawing.Size(120, 23);
            this.vvod2.TabIndex = 2;
            // 
            // vivod1
            // 
            this.vivod1.Location = new System.Drawing.Point(12, 99);
            this.vivod1.Name = "vivod1";
            this.vivod1.Size = new System.Drawing.Size(217, 120);
            this.vivod1.TabIndex = 3;
            this.vivod1.Text = "";
            // 
            // vivod2
            // 
            this.vivod2.Location = new System.Drawing.Point(235, 99);
            this.vivod2.Name = "vivod2";
            this.vivod2.Size = new System.Drawing.Size(197, 120);
            this.vivod2.TabIndex = 4;
            this.vivod2.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "5.2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vivod2);
            this.Controls.Add(this.vivod1);
            this.Controls.Add(this.vvod2);
            this.Controls.Add(this.vvod1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vvod1;
        private System.Windows.Forms.TextBox vvod2;
        private System.Windows.Forms.RichTextBox vivod1;
        private System.Windows.Forms.RichTextBox vivod2;
        private System.Windows.Forms.Button button2;
    }
}

