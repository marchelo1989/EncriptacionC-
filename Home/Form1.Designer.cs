namespace Home
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEncripBase64 = new System.Windows.Forms.TextBox();
            this.txtDesenBase64 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEncripAES = new System.Windows.Forms.TextBox();
            this.txtDesmAES = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEncripCode = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDenseCode = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMd5
            // 
            this.txtMd5.Location = new System.Drawing.Point(179, 32);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.Size = new System.Drawing.Size(125, 20);
            this.txtMd5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encriptar en MD5:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Encriptar &MD5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.FormattingEnabled = true;
            this.lblMensaje.Location = new System.Drawing.Point(31, 327);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(459, 95);
            this.lblMensaje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encriptar en SHA1:";
            // 
            // txtSha1
            // 
            this.txtSha1.Location = new System.Drawing.Point(179, 64);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.Size = new System.Drawing.Size(125, 20);
            this.txtSha1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Encriptar &SHA1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Encriptar En BASE64:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Desencripta en BASE64:";
            // 
            // txtEncripBase64
            // 
            this.txtEncripBase64.Location = new System.Drawing.Point(179, 97);
            this.txtEncripBase64.Name = "txtEncripBase64";
            this.txtEncripBase64.Size = new System.Drawing.Size(125, 20);
            this.txtEncripBase64.TabIndex = 10;
            // 
            // txtDesenBase64
            // 
            this.txtDesenBase64.Location = new System.Drawing.Point(179, 126);
            this.txtDesenBase64.Name = "txtDesenBase64";
            this.txtDesenBase64.Size = new System.Drawing.Size(125, 20);
            this.txtDesenBase64.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(329, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Encriptar BASE64";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(329, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Desencripta BASE64";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Encriptar en AES:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Desencripta en AES:";
            // 
            // txtEncripAES
            // 
            this.txtEncripAES.Location = new System.Drawing.Point(179, 167);
            this.txtEncripAES.Name = "txtEncripAES";
            this.txtEncripAES.Size = new System.Drawing.Size(125, 20);
            this.txtEncripAES.TabIndex = 16;
            // 
            // txtDesmAES
            // 
            this.txtDesmAES.Location = new System.Drawing.Point(179, 193);
            this.txtDesmAES.Name = "txtDesmAES";
            this.txtDesmAES.Size = new System.Drawing.Size(125, 20);
            this.txtDesmAES.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Encriptar AES";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(329, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(125, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Desencripta AES";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Encriptar:";
            // 
            // txtEncripCode
            // 
            this.txtEncripCode.Location = new System.Drawing.Point(179, 229);
            this.txtEncripCode.Name = "txtEncripCode";
            this.txtEncripCode.Size = new System.Drawing.Size(125, 20);
            this.txtEncripCode.TabIndex = 21;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(329, 227);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 23);
            this.button7.TabIndex = 22;
            this.button7.Text = "Encriptar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Desencriptar:";
            // 
            // txtDenseCode
            // 
            this.txtDenseCode.Location = new System.Drawing.Point(179, 256);
            this.txtDenseCode.Name = "txtDenseCode";
            this.txtDenseCode.Size = new System.Drawing.Size(125, 20);
            this.txtDenseCode.TabIndex = 24;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(329, 254);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 23);
            this.button8.TabIndex = 25;
            this.button8.Text = "Desencriptar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 434);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtDenseCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtEncripCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtDesmAES);
            this.Controls.Add(this.txtEncripAES);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDesenBase64);
            this.Controls.Add(this.txtEncripBase64);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtSha1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMd5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSha1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEncripBase64;
        private System.Windows.Forms.TextBox txtDesenBase64;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEncripAES;
        private System.Windows.Forms.TextBox txtDesmAES;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEncripCode;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDenseCode;
        private System.Windows.Forms.Button button8;
    }
}

