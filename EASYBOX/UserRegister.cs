﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicio;

namespace EASYBOX
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.Blue;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.LightSkyBlue;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Blue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightSkyBlue;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            UsuarioService service = new UsuarioService();

            if(TextBoxValidation())
            {

            }
        }

        private bool TextBoxValidation()
        { 

            if(string.IsNullOrEmpty(txtbUsername.Text))
            {
                lbErrorUsername.Text = "You must enter a username.";
                lbErrorUsername.Visible = true;
                return false;
            }

            if(string.IsNullOrEmpty(txtbEmail.Text))
            {
                lbErrorEmail.Text = "You must enter a email.";
                lbErrorEmail.Visible = true;
                return false;
            }

            if(string.IsNullOrEmpty(txtbPassword.Text))
            {
                lbErrorPassword.Text = "You must enter a password.";
                lbErrorPassword.Visible = true;
                return false;
            }

            return true;

        }
    }
}
