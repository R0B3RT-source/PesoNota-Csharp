using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pesoNota

{
    
    public partial class Form1 : Form
    {
        double labo, ava, exame, labo1, ava1, exame1, media;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLabo.Text = "";
            txtAva.Text = "";
            txtExame.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                labo = Convert.ToDouble(txtLabo.Text);
                ava = Convert.ToDouble(txtAva.Text);
                exame = Convert.ToDouble(txtExame.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Erro na Conversão de Valores", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            labo1 = labo * 2;
            ava1 = ava * 3;
            exame1 = exame * 5;

            media = (labo1 + ava1 + exame1) / 10;

            MessageBox.Show("A sua Média final é: " + media);

        }
    }
}
