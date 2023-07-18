namespace Aula07Funcoes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Click = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Main = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_valor2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Click
            // 
            this.btn_Click.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Click.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Click.Location = new System.Drawing.Point(83, 100);
            this.btn_Click.Name = "btn_Click";
            this.btn_Click.Size = new System.Drawing.Size(248, 99);
            this.btn_Click.TabIndex = 0;
            this.btn_Click.Text = "Mostra mensagem";
            this.btn_Click.UseVisualStyleBackColor = false;
            this.btn_Click.Click += new System.EventHandler(this.btn_Click_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mostra outra coisa";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Main
            // 
            this.txt_Main.Location = new System.Drawing.Point(83, 368);
            this.txt_Main.Multiline = true;
            this.txt_Main.Name = "txt_Main";
            this.txt_Main.Size = new System.Drawing.Size(248, 70);
            this.txt_Main.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.Location = new System.Drawing.Point(24, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(41, 110);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "R$ :";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Valor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Valor.Location = new System.Drawing.Point(74, 89);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(13, 13);
            this.lbl_Valor.TabIndex = 7;
            this.lbl_Valor.Text = "0";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_Valor);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txt_Valor);
            this.panel2.Location = new System.Drawing.Point(458, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 187);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_valor2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(458, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 187);
            this.panel1.TabIndex = 10;
            // 
            // lbl_valor2
            // 
            this.lbl_valor2.AutoSize = true;
            this.lbl_valor2.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_valor2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_valor2.Location = new System.Drawing.Point(74, 89);
            this.lbl_valor2.Name = "lbl_valor2";
            this.lbl_valor2.Size = new System.Drawing.Size(13, 13);
            this.lbl_valor2.TabIndex = 7;
            this.lbl_valor2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(47, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "R$ :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Location = new System.Drawing.Point(24, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Confirmar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(41, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seu Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seu limite de credito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_Main);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Click;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Main;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Valor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_valor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

