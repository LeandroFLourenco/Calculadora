namespace Projeto_Cadastramento
{
    partial class Calculadora
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
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.tbConta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(134, 12);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbResultado.Size = new System.Drawing.Size(238, 52);
            this.tbResultado.TabIndex = 0;
            this.tbResultado.Text = "Resultado";
            // 
            // tbConta
            // 
            this.tbConta.Location = new System.Drawing.Point(134, 70);
            this.tbConta.Multiline = true;
            this.tbConta.Name = "tbConta";
            this.tbConta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbConta.Size = new System.Drawing.Size(238, 89);
            this.tbConta.TabIndex = 1;
            this.tbConta.Text = "Conta";
            this.tbConta.TextChanged += new System.EventHandler(this.tbConta_TextChanged);
            this.tbConta.Enter += new System.EventHandler(this.tbConta_Enter);
            this.tbConta.Leave += new System.EventHandler(this.tbConta_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "9";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 5;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(317, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 9;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(134, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(256, 170);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(195, 170);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 55);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(134, 292);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 55);
            this.button10.TabIndex = 12;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(256, 231);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 55);
            this.button11.TabIndex = 11;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(195, 231);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 55);
            this.button12.TabIndex = 10;
            this.button12.Text = "5";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(317, 292);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 55);
            this.button13.TabIndex = 17;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(256, 292);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 55);
            this.button14.TabIndex = 16;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(195, 292);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(55, 55);
            this.button16.TabIndex = 14;
            this.button16.Text = "2";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(134, 353);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 55);
            this.button9.TabIndex = 18;
            this.button9.Text = "0";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(317, 353);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 55);
            this.button15.TabIndex = 19;
            this.button15.Text = "X";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 55);
            this.button4.TabIndex = 20;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(317, 414);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(55, 55);
            this.button17.TabIndex = 21;
            this.button17.Text = "Salvar";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 501);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbConta);
            this.Controls.Add(this.tbResultado);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.TextBox tbConta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button17;
    }
}