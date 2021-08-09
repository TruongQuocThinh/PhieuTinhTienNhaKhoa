﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhieuTinhTienNhaKhoa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textHoTen_TextChanged(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Enabled);
        }

        private void cbTramRang_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void HoTen_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            ValidateNumber(txt);
        }
        private bool ValidateNumber(TextBox txt)
        {
            if(txt.Text == "")
            {
                errorProvider1.SetError(txt,"Tên không không được rỗng");
                return false;
            }
            try
            {
                float.Parse(txt.Text);
            }
            catch (Exception)
            {
                errorProvider1.SetError(txt, "Tên không được có số");
                return false;
            }
            return true;
        }
            
    }
}