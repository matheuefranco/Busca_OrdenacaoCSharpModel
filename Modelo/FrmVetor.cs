using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo
{
    public partial class FrmVetor : Form
    {
        List<String> nomes = new List<String>();

        public FrmVetor()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVetor_Load(object sender, EventArgs e)
        {

        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            nomes.Sort();
            mostra();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int p = nomes.IndexOf(txtEntrada.Text);
            if (p == -1)
                MessageBox.Show("Não encontrado :(");
            else
                MessageBox.Show("Encontrado na posicao:" + p);
        }

        private void BtnBuscaBinaria_Click(object sender, EventArgs e)
        {
            int p = nomes.BinarySearch(txtEntrada.Text);
            if (p < 0)
                MessageBox.Show("Não encontrado :(");
            else
                MessageBox.Show("Encontrado na posicao:" + p);

        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           
        }

        private void listCidades_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        void mostra()
        {
            listDados.Items.Clear();
            foreach (String n in nomes)
                listDados.Items.Add(n);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nomes.Add(txtEntrada.Text);
            mostra();
            txtEntrada.Clear();
            txtEntrada.Focus();
        }
    }
}
