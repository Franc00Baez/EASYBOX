using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Servicio;

namespace EASYBOX
{
    public partial class UserLog : Form
    {
        private int xClic, yClic;
        public UserLog()
        {
            InitializeComponent();
        }

        private void btnEnter_MouseEnter(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.Blue;
        }

        private void btnEnter_MouseLeave(object sender, EventArgs e)
        {
            btnEnter.BackColor = Color.LightSkyBlue;
        }

        private void btnSingin_MouseEnter(object sender, EventArgs e)
        {
            btnSingin.BackColor = Color.Blue;
        }

        private void btnSingin_MouseLeave(object sender, EventArgs e)
        {
            btnSingin.BackColor = Color.LightSkyBlue;
        }

        private void btnSingin_Click(object sender, EventArgs e)
        {
            UserRegister window = new UserRegister();
            window.ShowDialog();
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Min_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) 
                this.WindowState = FormWindowState.Minimized;
        }

        private void UserLog_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                xClic = e.X; yClic = e.Y;
            }else
            {
                this.Left = this.Left + (e.X);
                this.Top = this.Top + (e.Y);
            }
        }
    }
}
