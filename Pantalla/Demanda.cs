using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Demanda : Form
    {
        private bool conValoresPorDefecto;
        private List<int> valores = new List<int>();

        public List<int> Valores { get { return valores; } set { valores = value; } }

        public Demanda(bool conValoresDefecto)
        {
            InitializeComponent();
            this.conValoresPorDefecto = conValoresDefecto;
        }

        private void Demanda_Load(object sender, EventArgs e)
        {
            if (conValoresPorDefecto)
            {
                int[] combo = { 100, 200, 300, 400, 500 };
                for (int k = 0; k < combo.Count(); k++)
                    ((DataGridViewComboBoxColumn)dgv_valoresDemanda.Columns[0]).Items.Add(combo[k].ToString());
                dgv_valoresDemanda.Columns[0].Visible = true;
            }
            else
                dgv_valoresDemanda.Columns[1].Visible = true;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_valoresDemanda.Rows)
            {
                if (conValoresPorDefecto)
                {
                    if (row.Cells[0].Value != null)
                        valores.Add(int.Parse(row.Cells[0].Value.ToString()));
                }
                else
                {
                    if (row.Cells[1].Value != null)
                        valores.Add(int.Parse(row.Cells[1].Value.ToString()));
                }
            }
            this.Close();
        }

        public void dgv_valoresDemanda_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (!conValoresPorDefecto)
            {
                DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
                if (dText != null)
                {
                    dText.KeyPress -= new KeyPressEventHandler(dgv_valoresDemanda_KeyPress);
                    dText.KeyPress += new KeyPressEventHandler(dgv_valoresDemanda_KeyPress);
                }
            }
        }

        private void dgv_valoresDemanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
