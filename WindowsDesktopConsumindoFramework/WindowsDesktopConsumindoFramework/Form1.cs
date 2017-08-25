using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsDesktopConsumindoFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Framework.Idade.Mj.Pessoa _pessoa = new Framework.Idade.Mj.Pessoa();
            lblResultado.Text = _pessoa.calculaIdade(int.Parse(txtAno.Text)).ToString();

        }
    }
}
