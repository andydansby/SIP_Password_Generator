namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.generate_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SIPorOVPN = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Andy\'s Password Generator for Grandstream";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 5;
            // 
            // passwordLength
            // 
            this.passwordLength.Location = new System.Drawing.Point(5, 92);
            this.passwordLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.passwordLength.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(52, 20);
            this.passwordLength.TabIndex = 6;
            this.passwordLength.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password Length";
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(6, 127);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(75, 23);
            this.generate_button.TabIndex = 8;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // SIPorOVPN
            // 
            this.SIPorOVPN.AutoSize = true;
            this.SIPorOVPN.Checked = true;
            this.SIPorOVPN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SIPorOVPN.Location = new System.Drawing.Point(13, 48);
            this.SIPorOVPN.Name = "SIPorOVPN";
            this.SIPorOVPN.Size = new System.Drawing.Size(102, 17);
            this.SIPorOVPN.TabIndex = 11;
            this.SIPorOVPN.Text = "SIP / OpenVPN";
            this.SIPorOVPN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "SIP = Checked    OpenVPN = Unchecked";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 165);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SIPorOVPN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordLength);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown passwordLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox SIPorOVPN;
        private System.Windows.Forms.Label label4;
    }
}

