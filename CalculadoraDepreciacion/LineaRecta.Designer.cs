namespace CalculadoraDepreciacion
{
    partial class LineaRecta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numVidaUtil = new System.Windows.Forms.NumericUpDown();
            this.txtValorSalvamento = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.radLineaRecta = new System.Windows.Forms.RadioButton();
            this.radDigitosAnuales = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numVidaUtil)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor salvamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vida util";
            // 
            // numVidaUtil
            // 
            this.numVidaUtil.Location = new System.Drawing.Point(62, 64);
            this.numVidaUtil.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVidaUtil.Name = "numVidaUtil";
            this.numVidaUtil.Size = new System.Drawing.Size(38, 20);
            this.numVidaUtil.TabIndex = 3;
            this.numVidaUtil.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtValorSalvamento
            // 
            this.txtValorSalvamento.Location = new System.Drawing.Point(97, 36);
            this.txtValorSalvamento.Name = "txtValorSalvamento";
            this.txtValorSalvamento.Size = new System.Drawing.Size(100, 20);
            this.txtValorSalvamento.TabIndex = 2;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(50, 9);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radDigitosAnuales);
            this.panel1.Controls.Add(this.radLineaRecta);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numVidaUtil);
            this.panel1.Controls.Add(this.txtValorSalvamento);
            this.panel1.Controls.Add(this.txtCosto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 100);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvResultados);
            this.panel3.Location = new System.Drawing.Point(12, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 257);
            this.panel3.TabIndex = 8;
            // 
            // dgvResultados
            // 
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(4, 4);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(675, 248);
            this.dgvResultados.TabIndex = 0;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(301, 141);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(75, 23);
            this.cmdCalcular.TabIndex = 6;
            this.cmdCalcular.Text = "&Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // radLineaRecta
            // 
            this.radLineaRecta.AutoSize = true;
            this.radLineaRecta.Location = new System.Drawing.Point(443, 10);
            this.radLineaRecta.Name = "radLineaRecta";
            this.radLineaRecta.Size = new System.Drawing.Size(83, 17);
            this.radLineaRecta.TabIndex = 4;
            this.radLineaRecta.TabStop = true;
            this.radLineaRecta.Text = "Linea Recta";
            this.radLineaRecta.UseVisualStyleBackColor = true;
            this.radLineaRecta.CheckedChanged += new System.EventHandler(this.radLineaRecta_CheckedChanged);
            // 
            // radDigitosAnuales
            // 
            this.radDigitosAnuales.AutoSize = true;
            this.radDigitosAnuales.Location = new System.Drawing.Point(443, 62);
            this.radDigitosAnuales.Name = "radDigitosAnuales";
            this.radDigitosAnuales.Size = new System.Drawing.Size(98, 17);
            this.radDigitosAnuales.TabIndex = 5;
            this.radDigitosAnuales.TabStop = true;
            this.radDigitosAnuales.Text = "Digitos Anuales";
            this.radDigitosAnuales.UseVisualStyleBackColor = true;
            this.radDigitosAnuales.CheckedChanged += new System.EventHandler(this.radDigitosAnuales_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(301, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 13);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Linea Recta";
            // 
            // LineaRecta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 439);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LineaRecta";
            this.Text = "Calculadora Depreciacion Activos Fijos";
            this.Load += new System.EventHandler(this.LineaRecta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numVidaUtil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numVidaUtil;
        private System.Windows.Forms.TextBox txtValorSalvamento;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.RadioButton radDigitosAnuales;
        private System.Windows.Forms.RadioButton radLineaRecta;
        private System.Windows.Forms.Label lblTitulo;
    }
}

