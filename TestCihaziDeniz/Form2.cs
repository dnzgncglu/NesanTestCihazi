﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCihaziDeniz
{
    public partial class Form2 : Form
    {
        Form1 objForm1;

        private void RefreshAndShowDataOnDataGridView()
        {
            try
            {

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void EventFromForm1(object sender, Form1.UpdateDataEventArgs args)
        {
            RefreshAndShowDataOnDataGridView();
        }

        public Form2(Form1 obj)
        {
            InitializeComponent();
            objForm1 = obj;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshAndShowDataOnDataGridView();
            objForm1.UpdateDataEventHandler += EventFromForm1;
        }
    }
}
