namespace TP1.AsyncAwait
{
    partial class FrmExercicio
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblReceita = new System.Windows.Forms.Label();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lblProcessamento = new System.Windows.Forms.Label();
            this.lblCalcPagamento = new System.Windows.Forms.Label();
            this.lblCalcImposto = new System.Windows.Forms.Label();
            this.lblCalcReceita = new System.Windows.Forms.Label();
            this.lblCalcDespesa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(174, 341);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(178, 34);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPagamento.Location = new System.Drawing.Point(38, 71);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(209, 24);
            this.lblPagamento.TabIndex = 1;
            this.lblPagamento.Text = "Folha de pagamento:";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImposto.Location = new System.Drawing.Point(38, 113);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(101, 24);
            this.lblImposto.TabIndex = 2;
            this.lblImposto.Text = "Impostos:";
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReceita.Location = new System.Drawing.Point(38, 153);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(97, 24);
            this.lblReceita.TabIndex = 3;
            this.lblReceita.Text = "Receitas:";
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDespesa.Location = new System.Drawing.Point(38, 191);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(107, 24);
            this.lblDespesa.TabIndex = 4;
            this.lblDespesa.Text = "Despesas:";
            // 
            // lblProcessamento
            // 
            this.lblProcessamento.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProcessamento.Location = new System.Drawing.Point(94, 250);
            this.lblProcessamento.Name = "lblProcessamento";
            this.lblProcessamento.Size = new System.Drawing.Size(338, 61);
            this.lblProcessamento.TabIndex = 5;
            this.lblProcessamento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCalcPagamento
            // 
            this.lblCalcPagamento.AutoSize = true;
            this.lblCalcPagamento.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalcPagamento.Location = new System.Drawing.Point(266, 71);
            this.lblCalcPagamento.Name = "lblCalcPagamento";
            this.lblCalcPagamento.Size = new System.Drawing.Size(0, 24);
            this.lblCalcPagamento.TabIndex = 6;
            // 
            // lblCalcImposto
            // 
            this.lblCalcImposto.AutoSize = true;
            this.lblCalcImposto.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalcImposto.Location = new System.Drawing.Point(159, 113);
            this.lblCalcImposto.Name = "lblCalcImposto";
            this.lblCalcImposto.Size = new System.Drawing.Size(0, 24);
            this.lblCalcImposto.TabIndex = 7;
            // 
            // lblCalcReceita
            // 
            this.lblCalcReceita.AutoSize = true;
            this.lblCalcReceita.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalcReceita.Location = new System.Drawing.Point(152, 153);
            this.lblCalcReceita.Name = "lblCalcReceita";
            this.lblCalcReceita.Size = new System.Drawing.Size(0, 24);
            this.lblCalcReceita.TabIndex = 8;
            // 
            // lblCalcDespesa
            // 
            this.lblCalcDespesa.AutoSize = true;
            this.lblCalcDespesa.Font = new System.Drawing.Font("Inter", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalcDespesa.Location = new System.Drawing.Point(162, 191);
            this.lblCalcDespesa.Name = "lblCalcDespesa";
            this.lblCalcDespesa.Size = new System.Drawing.Size(0, 24);
            this.lblCalcDespesa.TabIndex = 9;
            // 
            // FrmExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.lblCalcDespesa);
            this.Controls.Add(this.lblCalcReceita);
            this.Controls.Add(this.lblCalcImposto);
            this.Controls.Add(this.lblCalcPagamento);
            this.Controls.Add(this.lblProcessamento);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.btnCalcular);
            this.Name = "FrmExercicio";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private Label lblPagamento;
        private Label lblImposto;
        private Label lblReceita;
        private Label lblDespesa;
        private Label lblProcessamento;
        private Label lblCalcPagamento;
        private Label lblCalcImposto;
        private Label lblCalcReceita;
        private Label lblCalcDespesa;
    }
}