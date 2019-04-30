namespace foursquarecypher
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
            this.keyOne = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plainText = new System.Windows.Forms.Label();
            this.cipherText = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.keyTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyOne
            // 
            this.keyOne.Location = new System.Drawing.Point(643, 109);
            this.keyOne.Name = "keyOne";
            this.keyOne.Size = new System.Drawing.Size(102, 48);
            this.keyOne.TabIndex = 0;
            this.keyOne.Text = "Enkripto";
            this.keyOne.UseVisualStyleBackColor = true;
            this.keyOne.Click += new System.EventHandler(this.keyOne_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(711, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // plainText
            // 
            this.plainText.AutoSize = true;
            this.plainText.Location = new System.Drawing.Point(31, 33);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(66, 17);
            this.plainText.TabIndex = 2;
            this.plainText.Text = "PlainText";
            this.plainText.Click += new System.EventHandler(this.plainText_Click);
            // 
            // cipherText
            // 
            this.cipherText.AutoSize = true;
            this.cipherText.Location = new System.Drawing.Point(31, 190);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(76, 17);
            this.cipherText.TabIndex = 5;
            this.cipherText.Text = "CipherText";
            this.cipherText.Click += new System.EventHandler(this.cipherText_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 210);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(711, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // keyTwo
            // 
            this.keyTwo.Location = new System.Drawing.Point(643, 266);
            this.keyTwo.Name = "keyTwo";
            this.keyTwo.Size = new System.Drawing.Size(102, 51);
            this.keyTwo.TabIndex = 3;
            this.keyTwo.Text = "Dekripto";
            this.keyTwo.UseVisualStyleBackColor = true;
            this.keyTwo.Click += new System.EventHandler(this.keyTwo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.keyTwo);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.keyOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keyOne;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label plainText;
        private System.Windows.Forms.Label cipherText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button keyTwo;
    }
}

