
using CodingChallenge.Data.Classes;
using CodingChange.FormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge.FormApp
{
    public partial class Form1 : Form
    {
        string valor = "";
        decimal total = 0;
        int tipo = 0;
        List<FormaGeometrica> figuras = new List<FormaGeometrica>();
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valor = this.cmbSelectLenguages.Text;
            if (valor == "Español")
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("Es");
                tipo = 1;
                //TODO - Castellano == Es
                
                EntrarConIdioma("Es");

            }
            else {
                tipo = 2;
                EntrarConIdioma("En"); 
            }
        }

        private void EntrarConIdioma(string v)
        {
            this.cmbSelectFigura.Items.Clear();


            if (v == "En") {
                FormaGeometrica formas = new FormaGeometrica(2,0);
                this.lblSelectLang.Text = Languages.lblSelectLang;
                this.label1.Text = "Select a Shape";
                this.lblResult.Text = Languages.lblResult;

                foreach (string figura in formas.ShapesList) {
                this.cmbSelectFigura.Items.Add(figura);
                
                }
                
            }
            else { 
                this.lblSelectLang.Text = Lenguajes.lblSelectLang;
                this.lblResult.Text = Lenguajes.lblResult;
                
                this.label1.Text = "Seleccione Figura";
                FormaGeometrica formas = new FormaGeometrica(1, 0);
                foreach (string figura in formas.listaFormas)
                {
                    this.cmbSelectFigura.Items.Add(figura);

                }
               
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int _figura = this.cmbSelectFigura.SelectedIndex;
            if (_figura !=5)
            {
                
                figuras.Clear();
                figuras.Add(new FormaGeometrica(tipo, _figura));
                this.lblSb.Text = "";
                this.lblSb.Text = FormaGeometrica.Imprimir(figuras, tipo);
            }
            else
            {
                this.lblSb.Text = "";
                this.lblSb.Text = "The connection is not available at the moment.  ";
                    
                    }
        }
    }
}
