
namespace Primeiro_forms
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
            this.btndivisao = new System.Windows.Forms.Button();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.btnmultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndivisao
            // 
            this.btndivisao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btndivisao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btndivisao.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btndivisao.Location = new System.Drawing.Point(546, 82);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(169, 37);
            this.btndivisao.TabIndex = 0;
            this.btndivisao.Text = "DIVIDIR";
            this.btndivisao.UseVisualStyleBackColor = false;
            this.btndivisao.Click += new System.EventHandler(this.btnSomaTudo_click);
            // 
            // txtnumero1
            // 
            this.txtnumero1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.txtnumero1.Location = new System.Drawing.Point(132, 53);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(127, 23);
            this.txtnumero1.TabIndex = 1;
            this.txtnumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnmultiplicacao
            // 
            this.btnmultiplicacao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnmultiplicacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmultiplicacao.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnmultiplicacao.Location = new System.Drawing.Point(371, 82);
            this.btnmultiplicacao.Name = "btnmultiplicacao";
            this.btnmultiplicacao.Size = new System.Drawing.Size(169, 37);
            this.btnmultiplicacao.TabIndex = 2;
            this.btnmultiplicacao.Text = "MULTIPLICAR";
            this.btnmultiplicacao.UseVisualStyleBackColor = false;
            this.btnmultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSubtracao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtracao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSubtracao.Location = new System.Drawing.Point(196, 82);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(169, 37);
            this.btnSubtracao.TabIndex = 3;
            this.btnSubtracao.Text = "DIMINUIR";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnMultiplicacao_click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSoma.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSoma.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSoma.Location = new System.Drawing.Point(21, 82);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(169, 37);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "SOMAR";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSomaTudo_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(179, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(478, 53);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(146, 23);
            this.txtnumero2.TabIndex = 6;
            this.txtnumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtnumero2.Leave += new System.EventHandler(this.txtnumero2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(526, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "N° 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnmultiplicacao);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.btndivisao);
            this.Name = "Form1";
            this.Text = "Itamar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Button btnmultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label label2;
    }
}

