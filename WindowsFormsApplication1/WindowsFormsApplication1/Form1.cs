﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using comision;
using capaDatos;
using capaDiseño;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fEmpleado fe = new fEmpleado();
            conexion bd = new conexion();
            comisiones menu = new comisiones();
            menu.Show();
        }
    }
}
