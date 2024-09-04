using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicio;
using Dominio;

namespace EASYBOX
{
    public partial class UserRegister : Form
    {
        private UsuarioService userService;
        public UserRegister()
        {
            InitializeComponent();
            userService = new UsuarioService();
            CleanErrorMessages();
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

            if (TextBoxValidation())
            {
                Usuario user = new Usuario(0, txtbUsername.Text, txtbEmail.Text, txtbPassword.Text, 2, null, false, DateTime.Now);
                if (userService.InsertUsuario(user))
                    MessageBox.Show("Usuario Registrado con exito.");
                else
                    MessageBox.Show("Error: no se pudo registrar el usuario.");
                
            }
            this.Close();
        }

        private bool TextBoxValidation()
        {
            CleanErrorMessages();

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

            if(userService.ValidateUserName(txtbUsername.Text))
            {
                lbErrorUsername.Text = "Username already exists.";
                lbErrorUsername.Visible = true;
                return false;
            }

            if (userService.ValidateEmail(txtbEmail.Text))
            {
                lbErrorEmail.Text = "Email already exist.";
                lbErrorEmail.Visible = true;
                return false;
            }
            return true;

        }

        private void CleanErrorMessages()
        {
            lbErrorEmail.Visible = false;
            lbErrorPassword.Visible = false;
            lbErrorUsername.Visible = false;
        }
    }
}
