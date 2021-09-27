using clase102.Entidades;
using clase102.Negocio;
using clase102.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        venta Venta = new venta();
        private void button1_Click(object sender, EventArgs e)
        {
            ///persona per = new persona();
            //per.Noombre = textBox1.Text;
            //ClsPersona este = new ClsPersona();
            //string nombre = este.persona(per);
            //MessageBox.Show(nombre);
            persona perso = new persona();
            perso.Noombre = Txtusuario.Text;
            perso.Contra = int.Parse(Txtpassword.Text);
            ClsPersona personita = new ClsPersona();
            int valor = personita.acceso(perso);
            //_ = valor;

            if (valor == 1)
            {
                

                
             
                 Venta.Show();
                
                
            }
            else
            {
                MessageBox.Show("error");
            }
           
        }

        
    }
}
