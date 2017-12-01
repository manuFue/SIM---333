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
    public partial class Pantalla : Form
    {
        //  VARIABLES   //
        private int tiempoSimulacion;
        private int tamañoLote;
        private int puntoReposicion;
        private int stockInicial;
        private int costoKO;
        private int costoKM;
        private int costoKS;
        private List<int> valoresDemanda = new List<int>();
        private double probabilidad_1_10;
        private double probabilidad_11_20;
        private double probabilidad_21_30;
        private Int64 diaDesde;
        private Int64 diaHasta;

        private string[] vectorActual = new string[19];
        private string[] vectorAnterior = new string[19];
        private int indiceRangoDeDemora;
        private Random random = new Random();

        //  CONTROLES    //
        public Pantalla()
        {
            InitializeComponent();
            deshabilitarOrdenar();
        }

        private void txt_TiempoSimulacion_TextChanged(object sender, EventArgs e)
        {
            if (lbl_demoraError.Visible == false && lbl_DemandaError.Visible == false)
                Estado_btnSimular(txt_TiempoSimulacion.Text != "");
            Estado_TxtBox_DesdeHasta(txt_TiempoSimulacion.Text != "");
        }

        private void txt_tamañoLote_LostFocus(object sender, EventArgs e)
        {
            if (txt_TamañoLote.Text != "")
            {
                if (int.Parse(txt_TamañoLote.Text) > 2000)
                    txt_TamañoLote.Text = "2000";
                if (int.Parse(txt_TamañoLote.Text) < 1000)
                    txt_TamañoLote.Text = "1000";
            }
            else
                txt_TamañoLote.Text = "1000";
        }

        private void txt_puntoReposicion_LostFocus(object sender, EventArgs e)
        {
            if (txt_PuntoReposicion.Text != "")
            {
                if (int.Parse(txt_PuntoReposicion.Text) > 1000)
                    txt_PuntoReposicion.Text = "1000";
                if (int.Parse(txt_PuntoReposicion.Text) < 500)
                    txt_PuntoReposicion.Text = "500";
            }
            else
                txt_PuntoReposicion.Text = "500";
        }

        private void txt_stockInicial_LostFocus(object sender, EventArgs e)
        {
            if (txt_Stock.Text == "")
                txt_Stock.Text = "1000";
        }

        private void txt_costos_LostFocus(object sender, EventArgs e)
        {
            if (txt_ko.Text == "")
                txt_ko.Text = "500";
            if (txt_km.Text == "")
                txt_km.Text = "3";
            if (txt_ks.Text == "")
                txt_ks.Text = "5";
        }

        private void txt_probabilidad_LostFocus(object sender, EventArgs e)
        {
            if (txt_Entre1_10.Text == "")
                txt_Entre1_10.Text = "0.00";
            if (txt_Entre11_20.Text == "")
                txt_Entre11_20.Text = "0.00";
            if (txt_Entre21_30.Text == "")
                txt_Entre21_30.Text = "0.00";

            double entre1 = double.Parse(txt_Entre1_10.Text);
            double entre2 = double.Parse(txt_Entre11_20.Text);
            double entre3 = double.Parse(txt_Entre21_30.Text);
            setVisibleErrores(2, !((entre1 + entre2 + entre3) == 1));
        }

        private void txt_TiempoSimulacion_LostFocus(object sender, EventArgs e)
        {
            if (txt_TiempoSimulacion.Text != "")
            {
                if (Int64.Parse(txt_TiempoSimulacion.Text) >= 1000000)
                    txt_TiempoSimulacion.Text = "999999";
            }
        }

        private void txt_Desde_LostFocus(object sender, EventArgs e)
        {
            if (Int64.Parse(txt_aPartir.Text) > Int64.Parse(txt_TiempoSimulacion.Text))
            {
                txt_aPartir.Text = txt_hasta.Text;
                return;
            }

            if (Int64.Parse(txt_aPartir.Text) > Int64.Parse(txt_hasta.Text))
                txt_aPartir.Text = txt_hasta.Text;
        }

        private void txt_Hasta_LostFocus(object sender, EventArgs e)
        {
            if (Int64.Parse(txt_hasta.Text) > Int64.Parse(txt_TiempoSimulacion.Text))
            {
                txt_hasta.Text = txt_TiempoSimulacion.Text;
                return;
            }

            if (Int64.Parse(txt_hasta.Text) < Int64.Parse(txt_aPartir.Text))
                txt_hasta.Text = txt_aPartir.Text;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((TextBox)sender) == txt_Entre1_10 || ((TextBox)sender) == txt_Entre11_20 || ((TextBox)sender) == txt_Entre21_30)
            {
                if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back || e.KeyChar == ',' || e.KeyChar == '.')
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else
            {
                if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void radioButton_Manual_CheckedChanged(object sender, EventArgs e)
        {
            Estado_btnCargar(radioButton_Manual.Checked == true);
            valoresDemanda.Clear();
            setVisibleErrores(1, radioButton_Automatico.Checked != true);
        }

        private void Estado_TxtBox_DesdeHasta(bool estado)
        {
            txt_aPartir.Enabled = estado;
            txt_hasta.Enabled = estado;
            if (estado)
            {
                if (Int64.Parse(txt_TiempoSimulacion.Text) > 100)
                    txt_aPartir.Text = (Int64.Parse(txt_TiempoSimulacion.Text) - 100).ToString();
                else
                    txt_aPartir.Text = "0";
                txt_hasta.Text = txt_TiempoSimulacion.Text;
            }
            else
            {
                txt_aPartir.Text = "";
                txt_hasta.Text = "";
            }
        }


        //  FUNCOINES   //
        private void cargarValoresPorDefecto()
        {
            txt_TamañoLote.Text = "1000";
            txt_PuntoReposicion.Text = "500";
            txt_Stock.Text = "1000";
            txt_TiempoSimulacion.Text = "";
            txt_ko.Text = "500";
            txt_km.Text = "3";
            txt_ks.Text = "5";
            txt_Entre1_10.Text = "0,25";
            txt_Entre11_20.Text = "0,40";
            txt_Entre21_30.Text = "0,35";
            txt_aPartir.Text = "";
            txt_hasta.Text = "";
        }

        private void deshabilitarOrdenar()
        {
            foreach (DataGridViewColumn column in dgv_Montecarlo.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void resetearVector()
        {
            for (int i = 0; i < vectorAnterior.Length; i++)
            {
                if (i == 1 || i == 11 ||  i == 15 || i == 16 || i == 17)
                    vectorAnterior[i] = "0";
                else
                    vectorAnterior[i] = "-";
            }
            vectorAnterior[10] = stockInicial.ToString();
        }

        private void intercambiarVectores(string[] vectorFila)
        {
            for (int i = 0; i < vectorAnterior.Length; i++)
                vectorAnterior[i] = vectorFila[i];
            vectorFila = new string[19];
        }

        private void agregarPrimeraFila()
        {
            dgv_Montecarlo.Rows.Add("0", "-", "-", "-", "-", "-", "-", "-", "-", "-", stockInicial, "0", "-", "-", "-", "-", "0", "0", "0");
            dgv_Montecarlo.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.Khaki;
        }

        private void agregarNuevaFila(string[] vectorFila)
        {
            dgv_Montecarlo.Rows.Add(vectorFila[0], vectorFila[1], vectorFila[2], vectorFila[3], vectorFila[4], vectorFila[5],
                                    vectorFila[6], vectorFila[7], vectorFila[8], vectorFila[9], vectorFila[10], vectorFila[11],
                                    vectorFila[12], vectorFila[13], vectorFila[14], vectorFila[15], vectorFila[16], vectorFila[17], vectorFila[18]);
        }

        private void asignarVariables()
        {
            tiempoSimulacion = int.Parse(txt_TiempoSimulacion.Text);
            tamañoLote = int.Parse(txt_TamañoLote.Text);
            puntoReposicion = int.Parse(txt_PuntoReposicion.Text);
            stockInicial = int.Parse(txt_Stock.Text);
            costoKO = int.Parse(txt_ko.Text);
            costoKM = int.Parse(txt_km.Text);
            costoKS = int.Parse(txt_ks.Text);
            probabilidad_1_10 = double.Parse(txt_Entre1_10.Text);
            probabilidad_11_20 = double.Parse(txt_Entre11_20.Text);
            probabilidad_21_30 = double.Parse(txt_Entre21_30.Text);
            diaDesde = Int64.Parse(txt_aPartir.Text);
            diaHasta = Int64.Parse(txt_hasta.Text);
        }

        private void setVisibleErrores(int indice, bool setVisible)
        {
            switch (indice)
            {
                case 1:
                    lbl_DemandaError.Visible = setVisible; ;
                    break;
                case 2:
                    lbl_demoraError.Visible = setVisible;
                    break;
            }

            validarSimular();
        }

        private void validarSimular()
        {
            if (lbl_DemandaError.Visible == false && lbl_demoraError.Visible == false && txt_TiempoSimulacion.Text != "")
                Estado_btnSimular(true);
            else
                Estado_btnSimular(false);

        }

        private string obtenerDemanda(double rnd)
        {
            if (rnd < 0.20)
                return "100";
            else if (rnd < 0.40)
                return "200";
            else if (rnd < 0.60)
                return "300";
            else if (rnd < 0.80)
                return "400";
            else
                return "500";
        }

        private string obtenerRangoDeDemora(double rnd)
        {
            if (rnd <= probabilidad_1_10)
            {
                indiceRangoDeDemora = 1;
                return "1 - 10 Días";
            }
            else if (rnd <= (probabilidad_1_10 + probabilidad_11_20))
            {
                indiceRangoDeDemora = 2;
                return "11 - 20 Días";
            }
            else
            {
                indiceRangoDeDemora = 3;
                return "21 - 30 Días";
            }
        }

        private string calcularDiasDeDemoraUniforme(double rnd)
        {
            return Math.Round(Distribuciones.Uniforme(1, 10, rnd)).ToString();
        }

        private string[] calcularDiasDemoraExponencial()
        {
            string[] retorno = new string[2];
            double lambda = (double)1 / 13;
            double auxiliar = 0;
            double rnd;

            while (auxiliar < 11 || auxiliar > 20)
            {
                rnd = random.NextDouble();
                retorno[0] = Math.Round(rnd, 4).ToString();
                auxiliar = Math.Round(Distribuciones.Exponencial(lambda, rnd));
            }
            retorno[1] = auxiliar.ToString();
            return retorno;
        }

        private string[] calcularDiasDeDemoraNormal()
        {
            string[] retorno = new string[3];
            double auxiliar = 0;
            double rnd1;
            double rnd2;

            while (auxiliar < 21 || auxiliar > 30)
            {
                rnd1 = random.NextDouble();
                rnd2 = random.NextDouble();
                retorno[0] = Math.Round(rnd1, 4).ToString();
                retorno[1] = Math.Round(rnd2, 4).ToString();
                auxiliar = Math.Round(Distribuciones.Normal(25, 5, rnd1, rnd2)[0]);
            }
            retorno[2] = auxiliar.ToString();
            return retorno;
        }

        private void calcularResultadosEstadísticos(string[] vectorFila)
        {
            gbx_Resultado.Visible = true;
            txt_CostoPromedio.Text = ((double)(int.Parse(vectorFila[16]) / int.Parse(vectorFila[0]))).ToString();
            txt_CostoMaximo.Text = vectorFila[17];
            txt_CostoMinimo.Text = vectorFila[18];
        }

        //  BOTONES     //
        private void btn_Simular_Click(object sender, EventArgs e)
        {
            int contadorDias = 1;
            int contadorListaValoresDemanda = 0;
            bool existePedidoPendiente = false;

            dgv_Montecarlo.Rows.Clear();
            asignarVariables();
            agregarPrimeraFila();
            resetearVector();


            while (contadorDias <= tiempoSimulacion)
            {
                bool hayPedidoActual = false;
                bool hayFaltante = false;
                int stockPedido = 0;

                //  RELOJ
                vectorActual[0] = contadorDias.ToString();

                //  DEMANDA
                if (radioButton_Automatico.Checked)
                {
                    vectorActual[1] = Math.Round(random.NextDouble(), 4).ToString();
                    vectorActual[2] = obtenerDemanda(double.Parse(vectorActual[1]));
                }
                else
                {
                    vectorActual[1] = "-";
                    if (contadorListaValoresDemanda < valoresDemanda.Count)
                    {
                        vectorActual[2] = valoresDemanda[contadorListaValoresDemanda].ToString();
                        contadorListaValoresDemanda++;
                    }
                    else
                    {
                        vectorActual[2] = valoresDemanda[0].ToString();
                        contadorListaValoresDemanda = 1;
                    }
                }

                //  HACER Y LLEGADA DE PEDIDO
                if (vectorActual[0] == vectorAnterior[9])
                {
                    stockPedido = tamañoLote;
                    existePedidoPendiente = false;
                }

                if (!existePedidoPendiente)
                {
                    if ((int.Parse(vectorAnterior[10]) - int.Parse(vectorActual[2])) <= puntoReposicion)
                    {
                        hayPedidoActual = true;
                        vectorActual[3] = Math.Round(random.NextDouble(), 4).ToString();
                        vectorActual[4] = obtenerRangoDeDemora(double.Parse(vectorActual[3]));

                        if (indiceRangoDeDemora == 3)
                        {
                            string[] auxiliar = calcularDiasDeDemoraNormal();
                            vectorActual[5] = auxiliar[0];
                            vectorActual[6] = auxiliar[1];
                            vectorActual[7] = auxiliar[2];
                        }
                        else if (indiceRangoDeDemora == 2)
                        {
                            string[] auxiliar = calcularDiasDemoraExponencial();
                            vectorActual[5] = auxiliar[0];
                            vectorActual[6] = "-";
                            vectorActual[7] = auxiliar[1];
                        }
                        else
                        {
                            vectorActual[5] = Math.Round(random.NextDouble(), 4).ToString();
                            vectorActual[6] = "-";
                            vectorActual[7] = calcularDiasDeDemoraUniforme(double.Parse(vectorActual[5]));
                        }

                        vectorActual[8] = vectorActual[0];
                        vectorActual[9] = (int.Parse(vectorActual[0].ToString()) + int.Parse(vectorActual[7].ToString())).ToString();
                        existePedidoPendiente = true;
                    }
                    else
                    {
                        hayPedidoActual = false;
                        vectorActual[3] = "-";
                        vectorActual[4] = "-";
                        vectorActual[5] = "-";
                        vectorActual[6] = "-";
                        vectorActual[7] = "-";
                        vectorActual[8] = "-";
                        vectorActual[9] = vectorAnterior[9];
                    }
                }
                else
                {
                    hayPedidoActual = false;
                    vectorActual[3] = "-";
                    vectorActual[4] = "-";
                    vectorActual[5] = "-";
                    vectorActual[6] = "-";
                    vectorActual[7] = "-";
                    vectorActual[8] = "-";
                    vectorActual[9] = vectorAnterior[9];
                }


                //  STOCK Y FALTANTE
                if ((stockPedido + int.Parse(vectorAnterior[10])) < int.Parse(vectorActual[2].ToString()))
                {
                    vectorActual[10] = "0";
                    vectorActual[11] = (int.Parse(vectorActual[2]) - int.Parse(vectorAnterior[10]) + stockPedido).ToString();
                }
                else
                {
                    vectorActual[10] = (stockPedido + int.Parse(vectorAnterior[10]) - int.Parse(vectorActual[2])).ToString();
                    vectorActual[11] = "0";
                }

                //  COSTOS
                if (hayPedidoActual)
                    vectorActual[12] = costoKO.ToString();
                else
                    vectorActual[12] = "0";

                vectorActual[13] = (costoKM * int.Parse(vectorActual[10])).ToString();

                vectorActual[14] = (int.Parse(vectorActual[11]) * (costoKS)).ToString();

                vectorActual[15] = (int.Parse(vectorActual[12].ToString()) + int.Parse(vectorActual[13].ToString()) + int.Parse(vectorActual[14].ToString())).ToString();

                vectorActual[16] = (int.Parse(vectorAnterior[16]) + int.Parse(vectorActual[15])).ToString();

                if (int.Parse(vectorActual[15]) > int.Parse(vectorAnterior[17]))
                    vectorActual[17] = vectorActual[15];
                else
                    vectorActual[17] = vectorAnterior[17];

                if (vectorActual[0] == "1")
                    vectorActual[18] = vectorActual[15];
                else
                {
                    if (int.Parse(vectorActual[15]) < int.Parse(vectorAnterior[18]))
                        vectorActual[18] = vectorActual[15];
                    else
                        vectorActual[18] = vectorAnterior[18];
                }

                if (contadorDias >= diaDesde && contadorDias <= diaHasta)
                    agregarNuevaFila(vectorActual);

                intercambiarVectores(vectorActual);
                contadorDias++;
            }

            calcularResultadosEstadísticos(vectorActual);
        }

        private void btn_Reiniciar_Click(object sender, EventArgs e)
        {
            Estado_btnSimular(false);
            radioButton_Automatico.Checked = true;
            dgv_Montecarlo.Rows.Clear();
            gbx_Resultado.Visible = false;

            cargarValoresPorDefecto();
        }

        private void btn_cargarValores_Click(object sender, EventArgs e)
        {
            bool conValoresPorDefecto = false;

            if (MessageBox.Show("¿Desea cargar los valores de demanda desde una lista de valores por defecto?", "Cargar valores de demanda", MessageBoxButtons.YesNo) == DialogResult.Yes)
                conValoresPorDefecto = true;

            Demanda window = new Demanda(conValoresPorDefecto);
            window.ShowDialog();
            if (window.Valores.Count == 0)
                setVisibleErrores(1, true);
            else
            {
                setVisibleErrores(1, false);
                valoresDemanda = window.Valores;
            }
        }

        private void Estado_btnCargar(bool estado)
        {
            btn_cargarValores.Enabled = estado;
            if (estado)
                btn_cargarValores.BackColor = System.Drawing.Color.Khaki;
            else
                btn_cargarValores.BackColor = System.Drawing.Color.DarkGray;
        }

        private void Estado_btnSimular(bool estado)
        {
            btn_Simular.Enabled = estado;
            if (estado)
                btn_Simular.BackColor = System.Drawing.Color.Khaki;
            else
                btn_Simular.BackColor = System.Drawing.Color.DarkGray;
        }
    }
}
