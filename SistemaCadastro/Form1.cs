using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboEC.Items.Add("Casado");
            comboEC.Items.Add("Solteiro");
            comboEC.Items.Add("Divorciado");
            comboEC.Items.Add("Viuvo");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa pessoa in pessoas)
            {
                lista.Items.Add(pessoa.Nome);
            }
        }
    }
}
