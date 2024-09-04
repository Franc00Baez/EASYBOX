
namespace EASYBOX
{
    partial class UserLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnSingin = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.Cross = new FontAwesome.Sharp.IconPictureBox();
            this.Min = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Location = new System.Drawing.Point(386, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 350);
            this.panel1.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgLogo.BackgroundImage")));
            this.imgLogo.Location = new System.Drawing.Point(32, 32);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(371, 284);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Azure;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(77, 75);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(135, 57);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Log In";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 59;
            this.iconPictureBox1.Location = new System.Drawing.Point(207, 75);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(59, 60);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(40, 161);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(98, 16);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "Username or Email";
            // 
            // txtbUser
            // 
            this.txtbUser.Location = new System.Drawing.Point(43, 180);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.Size = new System.Drawing.Size(306, 23);
            this.txtbUser.TabIndex = 4;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(43, 236);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.Size = new System.Drawing.Size(306, 23);
            this.txtbPassword.TabIndex = 6;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(40, 217);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(55, 16);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // btnSingin
            // 
            this.btnSingin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSingin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingin.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingin.Location = new System.Drawing.Point(274, 287);
            this.btnSingin.Name = "btnSingin";
            this.btnSingin.Size = new System.Drawing.Size(75, 29);
            this.btnSingin.TabIndex = 7;
            this.btnSingin.Text = "Sing in";
            this.btnSingin.UseVisualStyleBackColor = false;
            this.btnSingin.Click += new System.EventHandler(this.btnSingin_Click);
            this.btnSingin.MouseEnter += new System.EventHandler(this.btnSingin_MouseEnter);
            this.btnSingin.MouseLeave += new System.EventHandler(this.btnSingin_MouseLeave);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEnter.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(43, 287);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 29);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.MouseEnter += new System.EventHandler(this.btnEnter_MouseEnter);
            this.btnEnter.MouseLeave += new System.EventHandler(this.btnEnter_MouseLeave);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // Cross
            // 
            this.Cross.BackColor = System.Drawing.Color.White;
            this.Cross.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cross.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.Cross.IconColor = System.Drawing.SystemColors.ControlText;
            this.Cross.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cross.IconSize = 16;
            this.Cross.Location = new System.Drawing.Point(0, -1);
            this.Cross.Name = "Cross";
            this.Cross.Size = new System.Drawing.Size(16, 23);
            this.Cross.TabIndex = 9;
            this.Cross.TabStop = false;
            this.Cross.Click += new System.EventHandler(this.Cross_Click);
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.Color.White;
            this.Min.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Min.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.Min.IconColor = System.Drawing.SystemColors.ControlText;
            this.Min.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Min.IconSize = 14;
            this.Min.Location = new System.Drawing.Point(12, -1);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(14, 23);
            this.Min.TabIndex = 10;
            this.Min.TabStop = false;
            this.Min.Click += new System.EventHandler(this.Min_Click);
            // 
            // UserLog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 349);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Cross);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSingin);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UserLog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBox";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserLog_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lbTitulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnSingin;
        private System.Windows.Forms.Button btnEnter;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconPictureBox Cross;
        private FontAwesome.Sharp.IconPictureBox Min;
    }
}