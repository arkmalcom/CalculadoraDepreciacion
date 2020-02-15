using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDepreciacion
{
    public partial class LineaRecta : Form
    {
        double costo = 0;
        double valorSalvamento = 0;
        int vidaUtil = 0;


        public LineaRecta()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            dgvResultados.Refresh();
            if (radLineaRecta.Checked)
            {
                calcularLineaRecta();
            }
            if(radDigitosAnuales.Checked)
            {
                calcularDigitosAnuales();
            }
        }

        private void calcularLineaRecta()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Periodo");
            dt.Columns.Add("Valor");
            dt.Columns.Add("Depreciacion");
            dt.Columns.Add("Depreciacion acumulada");
            dt.Columns.Add("Nuevo valor");
            try
            {
                costo = double.Parse(txtCosto.Text);
                valorSalvamento = double.Parse(txtValorSalvamento.Text);
                vidaUtil = (int)numVidaUtil.Value;
                double nuevoValor = costo;

                double depreciacionAnual = (costo - valorSalvamento) / vidaUtil;
                depreciacionAnual = Math.Truncate(depreciacionAnual * 100) / 100;
                double depreciacionAcumulada = 0;

                for (int i = 1; i <= vidaUtil; i++)
                {
                    nuevoValor -= depreciacionAnual;
                    depreciacionAcumulada += depreciacionAnual;
                    if (i == vidaUtil)
                    {
                        nuevoValor = valorSalvamento;
                    }
                    dt.Rows.Add(i, costo, depreciacionAnual, depreciacionAcumulada, nuevoValor);
                }
                dgvResultados.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show("Error." + ex);
            }
        }

        private void calcularDigitosAnuales()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Periodo");
            dt.Columns.Add("Valor");
            dt.Columns.Add("Factor");
            dt.Columns.Add("Depreciacion");
            dt.Columns.Add("Depreciacion acumulada");
            dt.Columns.Add("Nuevo valor");
            try
            {
                costo = double.Parse(txtCosto.Text);
                valorSalvamento = double.Parse(txtValorSalvamento.Text);
                vidaUtil = (int)numVidaUtil.Value;
                int factorDenominador = 0;
                double nuevoValor = costo;
                double depreciacionAcumulada = 0;
                for (int i = 1; i <= vidaUtil; i++)
                {
                    factorDenominador += i;
                }

                for (int i = 1; i <= vidaUtil; i++)
                {
                    double factor = (double) i / (double)factorDenominador;
                    double depreciacion = (costo - valorSalvamento) * factor;
                    depreciacion = Math.Truncate(depreciacion * 100) / 100;
                    depreciacionAcumulada += depreciacion;
                    nuevoValor -= depreciacion;
                    if (i == vidaUtil)
                    {
                        nuevoValor = valorSalvamento;
                    }
                    dt.Rows.Add(i, costo, i + "/" + factorDenominador, depreciacion, depreciacionAcumulada, nuevoValor);
                }
                dgvResultados.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error." + ex);
            }
        }

        private void LineaRecta_Load(object sender, EventArgs e)
        {
            radLineaRecta.Checked = true;
            this.ActiveControl = txtCosto;
        }

        private void radDigitosAnuales_CheckedChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = "Digitos Anuales";
        }

        private void radLineaRecta_CheckedChanged(object sender, EventArgs e)
        {
            lblTitulo.Text = "Linea Recta";
        }
    }
}
