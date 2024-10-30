using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2Formulario
{
    public partial class Form1 : 
        MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroToggle1.Checked)
            {
                metroStyleManager1.Theme =
                    MetroFramework.MetroThemeStyle.Dark;
            } else
            {
                metroStyleManager1.Theme =
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;    
            }
        }
    }
}
