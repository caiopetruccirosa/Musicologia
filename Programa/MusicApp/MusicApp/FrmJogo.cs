using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class FrmJogo : Form
    {
        private int idJogador;

        public FrmJogo(int id)
        {
            InitializeComponent();

            this.idJogador = id;
        }

        private void FrmJogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult MsgBox = MessageBox.Show("Todo o progresso não salvo será perdido!", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            e.Cancel = (MsgBox == DialogResult.No);
        }
    }
}
