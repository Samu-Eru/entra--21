﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWindowsForms.Exemplo1
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var enderecosForm = new EnderecosForm();
            enderecosForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pacientesForm = new PacientesForm();
            pacientesForm.ShowDialog();
        }
    }
}
