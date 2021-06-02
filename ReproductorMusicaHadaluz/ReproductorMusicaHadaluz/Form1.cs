using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMusicaHadaluz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            personalizardiseno();
        }
        
        private void personalizardiseno() 
        {
            panelMediosSubMenu.Visible = false;
            panelListaReproduccion.Visible = false;
            panelEcualizador.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if (panelMediosSubMenu.Visible == true)
            {
                panelMediosSubMenu.Visible = false;
            }
            if (panelListaReproduccion.Visible == true)
            {
                panelListaReproduccion.Visible = false;
            }
            if (panelEcualizador.Visible == true)
            {
                panelEcualizador.Visible = false;
            }

        }
        public void mostrarsubmenu(Panel algunsubmenu)
        {
            if (algunsubmenu.Visible==false)
            {
                ocultarsubmenu();
                algunsubmenu.Visible = true;
            }
            else
            {
                algunsubmenu.Visible = false; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelMediosSubMenu);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form2());
            ocultarsubmenu();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            mostrarsubmenu(panelListaReproduccion);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form3());
            ocultarsubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }
        private void btnEcualizador_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelEcualizador);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

       private Form formularioactivo = null;
        private void abrirChildForm(Form ChildForm)
        {
            if (formularioactivo != null)
            {
                formularioactivo.Close();
            }
        formularioactivo = ChildForm;
        ChildForm.TopLevel = false;
        ChildForm.FormBorderStyle = FormBorderStyle.None;
        ChildForm.Dock = DockStyle.Fill;
        panelchildForm.Controls.Add(ChildForm);
        panelchildForm.Tag= ChildForm;
        ChildForm.BringToFront();
        ChildForm.Show();
            
        }

        
    }
}
