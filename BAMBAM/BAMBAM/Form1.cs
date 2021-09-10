using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace BAMBAM
{
    public partial class Principal : Form
    {
        Audios som = new Audios();
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_Conectar(object sender, EventArgs e)
        {
            Connection con = new Connection();
            con.conectar();
            menuStrip1.Enabled = true;
            lblConectar.Text = ("HORA DO SHOW PORR*");
            lblConectar.ForeColor = System.Drawing.Color.LimeGreen;
        }                                                                                                                                                                                                                                                 

        private void Principal_Load(object sender, EventArgs e)
        {
               menuStrip1.Enabled = false;
               som.strondaAudio(); 
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
