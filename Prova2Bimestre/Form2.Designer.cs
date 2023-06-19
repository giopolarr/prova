namespace Prova2Bimestre
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_box1 = new System.Windows.Forms.TextBox();
            this.tx_box2 = new System.Windows.Forms.TextBox();
            this.cb_serviços = new System.Windows.Forms.ComboBox();
            this.cb_pagamento = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "computador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "serviço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "tipo de pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "cliente";
            // 
            // tx_box1
            // 
            this.tx_box1.Location = new System.Drawing.Point(119, 25);
            this.tx_box1.Name = "tx_box1";
            this.tx_box1.Size = new System.Drawing.Size(100, 20);
            this.tx_box1.TabIndex = 4;
            // 
            // tx_box2
            // 
            this.tx_box2.Location = new System.Drawing.Point(119, 57);
            this.tx_box2.Name = "tx_box2";
            this.tx_box2.Size = new System.Drawing.Size(100, 20);
            this.tx_box2.TabIndex = 5;
            // 
            // cb_serviços
            // 
            this.cb_serviços.FormattingEnabled = true;
            this.cb_serviços.Items.AddRange(new object[] {
            "formatação\t",
            "limpeza",
            "troca de peça"});
            this.cb_serviços.Location = new System.Drawing.Point(116, 97);
            this.cb_serviços.Name = "cb_serviços";
            this.cb_serviços.Size = new System.Drawing.Size(121, 21);
            this.cb_serviços.TabIndex = 6;
            this.cb_serviços.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_pagamento
            // 
            this.cb_pagamento.FormattingEnabled = true;
            this.cb_pagamento.Items.AddRange(new object[] {
            "dinheiro",
            "pix",
            "cartões"});
            this.cb_pagamento.Location = new System.Drawing.Point(116, 134);
            this.cb_pagamento.Name = "cb_pagamento";
            this.cb_pagamento.Size = new System.Drawing.Size(121, 21);
            this.cb_pagamento.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Location = new System.Drawing.Point(116, 171);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(55, 13);
            this.lb_resultado.TabIndex = 10;
            this.lb_resultado.Text = "valor final:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 394);
            this.Controls.Add(this.lb_resultado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_pagamento);
            this.Controls.Add(this.cb_serviços);
            this.Controls.Add(this.tx_box2);
            this.Controls.Add(this.tx_box1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_box1;
        private System.Windows.Forms.TextBox tx_box2;
        private System.Windows.Forms.ComboBox cb_serviços;
        private System.Windows.Forms.ComboBox cb_pagamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_resultado;
    }
}