namespace ControlApp
{
    partial class ConfigSettingsForm
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
        private void InitializeComponent() {
            checkBox1 = new System.Windows.Forms.CheckBox();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            confirmButton = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            button4 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            delayCombo = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(6, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(119, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Auto run sent exe";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(6, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(103, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(115, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 15);
            label1.TabIndex = 2;
            label1.Text = "File Location";
            // 
            // confirmButton
            // 
            confirmButton.Location = new System.Drawing.Point(115, 350);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new System.Drawing.Size(74, 23);
            confirmButton.TabIndex = 3;
            confirmButton.Text = "Ok";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(6, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(103, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(115, 79);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(115, 108);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(6, 105);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(103, 23);
            textBox3.TabIndex = 6;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(6, 141);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(133, 19);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Run All Outstanding";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(6, 321);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(183, 23);
            button2.TabIndex = 13;
            button2.Text = "Change Server Settings";
            button2.UseVisualStyleBackColor = true;
            button2.Click += serverSettingsButton_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(14, 27);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(54, 23);
            button3.TabIndex = 17;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += AddToStartup;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button3);
            panel1.Location = new System.Drawing.Point(6, 248);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(183, 63);
            panel1.TabIndex = 18;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(88, 27);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(65, 23);
            button4.TabIndex = 18;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            button4.Click += RemoveFromStartup;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(39, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(97, 15);
            label4.TabIndex = 0;
            label4.Text = "Windows Startup";
            // 
            // delayCombo
            // 
            delayCombo.FormattingEnabled = true;
            delayCombo.Items.AddRange(new object[] { "30s", "60s", "120s" });
            delayCombo.Location = new System.Drawing.Point(6, 166);
            delayCombo.Name = "delayCombo";
            delayCombo.Size = new System.Drawing.Size(103, 23);
            delayCombo.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(115, 169);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(36, 15);
            label5.TabIndex = 20;
            label5.Text = "Delay";
            // 
            // ConfigSettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(196, 378);
            Controls.Add(label5);
            Controls.Add(delayCombo);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(checkBox2);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(confirmButton);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Text = "Config";
            Load += ConfigSettingsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Panel panel1;
        private Button button4;
        private Label label4;
        private System.Windows.Forms.ComboBox delayCombo;
        private System.Windows.Forms.Label label5;
    }
}