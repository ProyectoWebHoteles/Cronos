using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronos
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "admin", "1234" },
            { "Christian", "1404" },
            { "Milagros", "6666" },
            { "Estrella", "1234" },
            { "Ariana", "6541" },
            { "Other", "1507" },
        };

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContrasena.Text;

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contraseña)
            {
                MessageBox.Show("Bienvenido " + usuario, "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //formHome principal = new formHome(usuario);
                //principal.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("Usuario o contraseña incorrecta.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
