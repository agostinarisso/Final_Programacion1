﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Risso
{
    public partial class Form1 : Form
    {
        GestorPromedios GestorPromedios;

        public string[] simulacionAlumnos =
        {
            "01,Luis,Sosa",
            "02,Maria,Perez",
            "03,Jose,Lopez",
        };
        public string[] simulacionNotas =
        {
            "01,Calculo,10",
            "01,Lengua,8",
            "01,Historia,9",
            "02,Calculo,6",
            "02,Lengua,7",
            "02,Historia,8",
            "03,Calculo,4",
            "03,Lengua,5",
            "03,Historia,6",
        };



        public Form1()
        {
            InitializeComponent();
            GestorPromedios = new GestorPromedios(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Promedio[] promedios = GestorPromedios.GenPromedios(GestorPromedios.GenAlumnos(simulacionAlumnos), GestorPromedios.GenNotas(simulacionNotas));
            this.dataGridView1.DataSource = promedios;


            ResultadoPromedio resultado = GestorPromedios.MejorPromedio(promedios);
            double mejorPromedio = resultado.MejorPromedio;
            int legajo = resultado.Legajo;

            this.label2.Text = mejorPromedio.ToString();
            this.label4.Text = legajo.ToString();

        }
    }
}
