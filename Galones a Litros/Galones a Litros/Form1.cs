using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galones_a_Litros
{
    public partial class Form1 : Form
    {
        public double a = 0;
        public double cash;
        public double valor;
        public double gal;
        public int count = 0;
        public int id = 1;
        public double j;
        public double paso;
        public double save;
        public double numero1;
        public double numero2;
        public double numero3;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(cantidad1.Text);
            double a = Convert.ToDouble(cantidad2.Text);
            double cash = Convert.ToDouble(cantidad1.Text);
            double paso = Convert.ToDouble(catidada.Text);

            if (b < a)
            {
                string message = "el vaor de ciudad es regularmante mas alto";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

            }
            while (a <= b)
            {
                gal = b * 0.264172;
                j = gal / 100;
                valor = cash * j;
                int n = dtgv.Rows.Add();
                valor = Math.Round(valor, 2);
                gal = Math.Round(gal, 2);
                dtgv.Rows[n].Cells[0].Value = id;
                dtgv.Rows[n].Cells[1].Value = b + "/100Km";
                dtgv.Rows[n].Cells[2].Value = gal;
                dtgv.Rows[n].Cells[3].Value = "DOP$ " + valor;
                b = b - paso;
                id++;

            }
            save = id;            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cantidad1.Text = "";
            dtgv.Rows.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}