using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace LabCarlosAguila
{

    public partial class Form1 : Form
    {
        List<Persona> personass = new List<Persona>();
        List<Estudio> estudioss = new List<Estudio>();
        List<Pelicula> peliculass = new List<Pelicula>();
        List<PeliculaActor> peliculas_actoress = new List<PeliculaActor>();
        List<PeliculaProductor> peliculas_productoress = new List<PeliculaProductor>();


        public Form1()
        {
            MessageBox.Show("BIENVENIDO AL BUSCADOR DE CINE \n OPRIMA 'OK' Y ESPERE 5 SEGUNDOS");
            this.Hide();
            Thread.Sleep(5000);
            this.Show();
            Persona per = new Persona("carlos", "aguila", "hola", 1996, "tipe");
            Estudio est = new Estudio("Clinica", "aqui", 2000);
            Estudio est1 = new Estudio("Puente alto", "aqui", 2000);
            Estudio est2= new Estudio("Uandes", "aqui", 2000);
            Estudio est3 = new Estudio("UDD", "aqui", 2000);
            Estudio est4 = new Estudio("Centro", "aqui", 2000);
            Estudio est5 = new Estudio("Vitacura", "aqui", 2000);
            Estudio est6 = new Estudio("estudio2", "aqui", 2000);
            Estudio est7 = new Estudio("estudioLOH VALIENTEH", "aqui", 2000);
            Estudio est8 = new Estudio("TECNO", "aqui", 2000);
            Estudio est9 = new Estudio("Oficinas", "aqui", 2000);
            Estudio est10 = new Estudio("rivera MAYA", "aqui", 2000);
            Estudio est11 = new Estudio("INKAS", "aqui", 2000);
            Estudio est12 = new Estudio("NIKAMEINKO", "aqui", 2000);
            Estudio est13 = new Estudio("gym", "aqui", 2000);
            estudioss.Add(est1);
            estudioss.Add(est2);
            estudioss.Add(est3);
            estudioss.Add(est4);
            estudioss.Add(est5);
            estudioss.Add(est6);
            estudioss.Add(est7);
            estudioss.Add(est8);
            estudioss.Add(est9);
            estudioss.Add(est10);
            estudioss.Add(est11);
            estudioss.Add(est12);
            estudioss.Add(est13);



            Pelicula pel = new Pelicula("pelicula1", per, 1202, "nada", est, 3);
            Pelicula pel2 = new Pelicula("pelicula1", per, 1202, "nada", est, 3);
            Pelicula pel3 = new Pelicula("Transformer1", per, 2002, "autos robots",est, 100);
            Pelicula pel1 = new Pelicula("Transformer2", per, 2002, "autos robots", est, 100);
            Pelicula pel4 = new Pelicula("Transformer3", per, 2002, "autos robots", est, 100);
            Pelicula pel5 = new Pelicula("Transformer4", per, 2002, "autos robots", est, 100);
            Pelicula pel6 = new Pelicula("Transformer5", per, 2002, "autos robots", est, 100);
            Pelicula pel8 = new Pelicula("Transformer6", per, 2002, "autos robots", est, 100);
            Pelicula pel9 = new Pelicula("Transformer7", per, 2002, "autos robots", est, 100);
            Pelicula pe20 = new Pelicula("Transformer8", per, 2002, "autos robots", est, 100);
            Pelicula pe21 = new Pelicula("Transformer9", per, 2002, "autos robots", est, 100);
            Pelicula pe22 = new Pelicula("Transformer10", per, 2002, "autos robots", est, 100);
            Pelicula pe23 = new Pelicula("Transformer11", per, 2002, "autos robots", est, 100);
            Pelicula pe33 = new Pelicula("shrek", per, 2002, "autos robots", est, 100);
            Pelicula pe43 = new Pelicula("crank", per, 2002, "autos robots", est, 100);
            Pelicula pe53 = new Pelicula("shrek2", per, 2002, "autos robots", est, 100);
            Pelicula pe63 = new Pelicula("shrek3", per, 2002, "autos robots", est, 100);
            Pelicula pe73 = new Pelicula("shrek4", per, 2002, "autos robots", est, 100);
            Pelicula pe83 = new Pelicula("Transformer10", per, 2002, "autos robots", est, 100);
            Pelicula pe93 = new Pelicula("TransformerUltimate", per, 2002, "autos robots", est, 100);
            peliculass.Add(pel1);
            peliculass.Add(pel1);
            peliculass.Add(pel6);
            peliculass.Add(pel5);
            peliculass.Add(pe20);
            peliculass.Add(pel4);
            peliculass.Add(pel9);
            peliculass.Add(pe20);
            peliculass.Add(pe21);
            peliculass.Add(pe22);
            peliculass.Add(pe23);
            peliculass.Add(pe33);
            peliculass.Add(pe43);
            peliculass.Add(pe53);
            peliculass.Add(pe63);
            peliculass.Add(pe73);
            peliculass.Add(pe83);
            peliculass.Add(pe93);
            personass.Add(per);
            estudioss.Add(est);
            peliculass.Add(pel);
            peliculass.Add(pel2);
            Persona per1 = new Persona("carlos", "aguila", "hola", 1996, "Director");
            Persona per2 = new Persona("Pedro", "aguila", "hola", 1996, "Actor");
            Persona per3 = new Persona("Juan el Transformer", "aguila", "hola", 1996, "Director");
            Persona per4 = new Persona("Olivos", "aguila", "hola", 1996, "Productor");
            Persona per5 = new Persona("juanjo", "aguila", "hola", 1996, "Director");
            Persona per6 = new Persona("Rai el g fe", "aguila", "hola", 1996, "Director");
            Persona per7 = new Persona("Mah g", "aguila", "hola", 1996, "Actor");
            Persona per8 = new Persona("carlos", "aguila", "hola", 1996, "Productor");
            Persona per9 = new Persona("Tutututu", "aguila", "hola", 1996, "Actor");
            Persona per10 = new Persona("Guru-guru", "aguila", "hola", 1996, "Productor");
            Persona per11 = new Persona("Tommie", "pickles", "hola", 1996, "Director");
            Persona per12 = new Persona("carlos", "aguila", "hola", 1996, "Actor");
            Persona per13 = new Persona("HanSolo", "aguila", "hola", 1996, "Actor");
            Persona per14 = new Persona("Chubi", "aguila", "hola", 1996, "Productor");
            Persona per15 = new Persona("Ninja", "aguila", "hola", 1996, "Actor");
            Persona per16 = new Persona("MrMagu", "aguila", "hola", 1996, "Director");
            Persona per17 = new Persona("NOTcarlos", "aguila", "hola", 1996, "Actor");
            Persona per18 = new Persona("Juan ", "aguila", "hola", 1996, "Actor");
            Persona per19 = new Persona("Anguila", "aguila", "hola", 1996, "Director");
            Persona per20 = new Persona("Pezcao no pescado", "aguila", "hola", 1996, "Director");
            personass.Add(per1);
            personass.Add(per2);
            personass.Add(per3);
            personass.Add(per4);
            personass.Add(per5);
            personass.Add(per6);
            personass.Add(per7);
            personass.Add(per8);
            personass.Add(per9);
            personass.Add(per10);
            personass.Add(per11);
            personass.Add(per12);
            personass.Add(per13);
            personass.Add(per14);
            personass.Add(per15);
            personass.Add(per16);
            personass.Add(per17);
            personass.Add(per18);
            personass.Add(per19);
            personass.Add(per20);
            FileStream fh = new FileStream("dataPersonas.bin", FileMode.OpenOrCreate);
            BinaryFormatter chege = new BinaryFormatter();
            BinaryFormatter chago = new BinaryFormatter();
            chago.Serialize(fh, personass);
            fh.Close();
            Base_de_datos BD = new Base_de_datos(personass, estudioss, peliculass, peliculas_actoress, peliculas_productoress);
            InitializeComponent();
            FileStream fs = new FileStream("data.bin", FileMode.OpenOrCreate);
            chago.Serialize(fs, peliculass);
            fs.Close();
            FileStream fhj = new FileStream("dataEstudio.bin", FileMode.OpenOrCreate);
            BinaryFormatter max = new BinaryFormatter();
            max.Serialize(fhj, estudioss);
            fhj.Close();



        }


        private void button1_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            FileStream fss = new FileStream("data.bin", FileMode.Open);
            BinaryFormatter ree = new BinaryFormatter();
            List<Pelicula> peliculas = ree.Deserialize(fss) as List<Pelicula>;
            fss.Close();
            FileStream fsh = new FileStream("dataPersonas.bin", FileMode.Open);
            BinaryFormatter reee = new BinaryFormatter();
            List<Persona> personas = reee.Deserialize(fsh) as List<Persona>;
            fsh.Close();
            FileStream fhh = new FileStream("dataEstudio.bin", FileMode.Open);
            BinaryFormatter reeee = new BinaryFormatter();
            List<Estudio> estudios = reeee.Deserialize(fhh) as List<Estudio>;
            fhh.Close();
            if (text.Text.Length >=3)
            {
                listbox.Visible = true;
                foreach (Pelicula peli in peliculas)
                {
                    if (peli.nombre.Contains(text.Text))
                    {
                        if (listbox.Items.Count <= 50)
                        {
                            listbox.Items.Add(peli.nombre);

                        }

                    }
                }
            }
            if (text.Text.Length >= 3)
            {
                foreach (Estudio peli in estudios)
                {
                    if (peli.nombre.Contains(text.Text))
                    {
                        if (listbox.Items.Count <=50)
                        {
                            listbox.Items.Add(peli.nombre);

                        }

                    }
                }
            }
            if (text.Text.Length >= 3)
            {
                foreach (Persona peli in personas)
                {
                    if (peli.nombre.Contains(text.Text))
                    {
                        if (listbox.Items.Count <= 50)
                        {
                            listbox.Items.Add(peli.nombre);

                        }

                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Visible = true;
            FileStream fss = new FileStream("dataPersonas.bin", FileMode.Open);
            BinaryFormatter ree = new BinaryFormatter();
            List<Persona> peliculas = ree.Deserialize(fss) as List<Persona>;
            fss.Close();
            foreach (Persona item in peliculas)
            {
                if (listbox.Items.Count <= 50 && item.tipo == "Director")
                {
                    listbox.Items.Add(item.nombre);

                }
            }
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            listbox.ClearSelected();
            listbox.Items.Clear();
            listbox.Visible = false;
            text.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Visible = true;
            FileStream fss = new FileStream("data.bin", FileMode.Open);
            BinaryFormatter ree = new BinaryFormatter();
            List<Pelicula> peliculas = ree.Deserialize(fss) as List<Pelicula>;
            fss.Close();
            foreach (Pelicula item in peliculas)
            {
                if (listbox.Items.Count <=50)
                {
                    listbox.Items.Add(item.nombre);

                }
            }
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string hola = listbox.SelectedItem.GetType().ToString();
             MessageBox.Show(hola,"OBJETO SELECCIONADO");

        }

        private void Bactores_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Visible = true;
            FileStream fss = new FileStream("dataPersonas.bin", FileMode.Open);
            BinaryFormatter ree = new BinaryFormatter();
            List<Persona> peliculas = ree.Deserialize(fss) as List<Persona>;
            fss.Close();
            foreach (Persona item in peliculas)
            {
                if (listbox.Items.Count <= 50 && item.tipo =="Actor")
                {
                    listbox.Items.Add(item.nombre);

                }
            }
        }

        private void Bproductor_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Visible = true;
            FileStream fss = new FileStream("dataPersonas.bin", FileMode.Open);
            BinaryFormatter ree = new BinaryFormatter();
            List<Persona> peliculas = ree.Deserialize(fss) as List<Persona>;
            fss.Close();
            foreach (Persona item in peliculas)
            {
                if (listbox.Items.Count <= 50 && item.tipo == "Productor")
                {
                    listbox.Items.Add(item.nombre);

                }
            }
        }

        private void Bestudio_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            listbox.Visible = true;
            FileStream fhh = new FileStream("dataEstudio.bin", FileMode.Open);
            BinaryFormatter reeee = new BinaryFormatter();
            List<Estudio> estudios = reeee.Deserialize(fhh) as List<Estudio>;
            fhh.Close();
            foreach (Estudio item in estudios)
            {
                if (listbox.Items.Count <= 50)
                {
                    listbox.Items.Add(item.nombre);

                }
            }
        }
    }
}
