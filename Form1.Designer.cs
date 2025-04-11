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
            this.btn9 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnmais = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnmultip = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
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
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(134, 170);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 55);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(195, 353);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(116, 55);
            this.btnigual.TabIndex = 3;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            // 
            // btnmais
            // 
            this.btnmais.Location = new System.Drawing.Point(317, 170);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(55, 55);
            this.btnmais.TabIndex = 5;
            this.btnmais.Text = "+";
            this.btnmais.UseVisualStyleBackColor = true;
            this.btnmais.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(317, 231);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(55, 55);
            this.btnmenos.TabIndex = 9;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(134, 231);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 55);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(256, 170);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 55);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(195, 170);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 55);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(134, 292);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 55);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(256, 231);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 55);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(195, 231);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 55);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btndivisao
            // 
            this.btndivisao.Location = new System.Drawing.Point(317, 292);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(55, 55);
            this.btndivisao.TabIndex = 17;
            this.btndivisao.Text = "/";
            this.btndivisao.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(256, 292);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 55);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(195, 292);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 55);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(134, 353);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(55, 55);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.leituraBotoes);
            // 
            // btnmultip
            // 
            this.btnmultip.Location = new System.Drawing.Point(317, 353);
            this.btnmultip.Name = "btnmultip";
            this.btnmultip.Size = new System.Drawing.Size(55, 55);
            this.btnmultip.TabIndex = 19;
            this.btnmultip.Text = "X";
            this.btnmultip.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(134, 414);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(238, 55);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "DEL";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 489);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnmultip);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnmais);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btn9);
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
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnmultip;
        private System.Windows.Forms.Button btndelete;
    }
}