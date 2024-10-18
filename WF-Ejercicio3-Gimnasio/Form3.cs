using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Ejercicio3_Gimnasio
{
    public partial class Form3 : Form
    {
        Form1 form1;

        public class Actividad
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Sala { get; set; }
            public string DescripcionActividad { get; set; }

            public Actividad(string Codigo, string Nombre, string Sala, string DescripcionActividad)
            {
                this.Codigo = Codigo;
                this.Nombre = Nombre;
                this.Sala = Sala;
                this.DescripcionActividad = DescripcionActividad;
            }
        }

        List<Actividad> actividades = new List<Actividad>()
        {
            new Actividad("A01", "Pesas", "Sala 1", "Entrenamiento de mancuernas y pesos ligeros"),
            new Actividad("A02", "Fuerza", "Sala 2", "Entrenamiento de fuerza"),
            new Actividad("A03", "Musculación", "Sala 3", "Entrenamiento de musculación"),
            new Actividad("A04", "Cardio", "Sala 4", "Entrenamiento de cardio"),
        };

        public Form3(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Código", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Nombre", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Sala", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Descripción Actividad", 250, HorizontalAlignment.Left);

            foreach (var actividad in actividades)
            {
                ListViewItem item = new ListViewItem(actividad.Codigo);
                item.SubItems.Add(actividad.Nombre);
                item.SubItems.Add(actividad.Sala);
                item.SubItems.Add(actividad.DescripcionActividad);
                listView1.Items.Add(item);
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.form1.Show();
        }
    }
}
