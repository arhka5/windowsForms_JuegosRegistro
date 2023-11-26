namespace G16_Juegos
{
    public partial class FrmDatos : Form
    {
        List<ClsLista> MiLista = new List<ClsLista>();
        public FrmDatos()
        {
            InitializeComponent();
            // Centrar el formulario en la pantalla al iniciar
            this.StartPosition = FormStartPosition.CenterScreen;
            // Carga el archivo base de informacion en el DataGrid
            LeerArchivo();
            // Da el total de puntos hasta hoy
            ActualizarSumaTotal();
            // Inicializa al menos un boton en activo
            radioButton1.Checked = true;
        }


        //ACTUALIZAR PUNTAJE TOTAL ENTRE TODOS LOS JUEGOS
        private void ActualizarSumaTotal()
        {
            Dictionary<string, float> ultimosPuntajesPorJuego = new Dictionary<string, float>();

            foreach (ClsLista Juego in MiLista)
            {
                // Actualiza el puntaje final para cada juego
                ultimosPuntajesPorJuego[Juego.Nombre] = Juego.TotalActual;
            }

            float sumaTotal = ultimosPuntajesPorJuego.Values.Sum();

            label1.Text = $"Puntaje Total:      {sumaTotal}";
        }


        //LEER ARCHIVO AL INICIAR
        private void LeerArchivo()
        {
            // Obtiene la ruta del archivo en la carpeta del proyecto
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "base_de_informacion.txt");

            // Verifica si el archivo existe antes de intentar leerlo
            if (File.Exists(filePath))
            {
                try
                {
                    // Lee el contenido del archivo y procesa cada línea
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        // Procesa la línea y agregar a MiLista 
                        string[] parts = line.Split(',');
                        if (parts.Length >= 3)
                        {
                            ClsLista Juego = new ClsLista
                            {
                                Nombre = parts[0],
                                Variacion = parts[1],
                                TotalActual = float.Parse(parts[2])
                            };
                            MiLista.Add(Juego);
                        }
                    }

                    // Actualiza el DataGridView con la nueva información
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = MiLista;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        //Validar el nombre del juego "No debe estar vacio"
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                erpError.SetError(textBox2, "DEBE INGRESAR UN JUEGO");
                return false;
            }
            else
            {
                erpError.SetError(textBox2, "");
                return true;
            }
        }
        private void LimpiarControles()
        {
            textBox2.Clear();
        }


        // INICIO RADIO BUTTON 1
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
        }

        // FIN RADIO BUTTON 1

        // INICIO RADIO BUTTON 2
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
        }




        private void tslRegistrar_Click_1(object sender, EventArgs e)
        {
            {
                if (ValidarNombre() == false) { return; }

                ClsLista G16_Juegos = new ClsLista();

                string nombre = textBox2.Text.ToLower();
                nombre = char.ToUpper(nombre[0]) + nombre.Substring(1);

                G16_Juegos.Nombre = nombre;

                ClsLista videojuegoExistente = MiLista.LastOrDefault(v => v.Nombre == G16_Juegos.Nombre);

                float G16_PuntajeHoy = 0;
                if (radioButton1.Checked)
                {
                    G16_PuntajeHoy = 100;
                    G16_Juegos.Variacion = "Ganado +100";
                }
                else
                {
                    G16_PuntajeHoy = -20;
                    G16_Juegos.Variacion = "Perdido -20";

                }

                float G16_PuntajeActualJuego = G16_PuntajeHoy;

                if (videojuegoExistente != null)
                {
                    // Busca el juego en la lista y actualiza el valo de su puntaje
                    ClsLista newEntry = new ClsLista
                    {
                        Nombre = G16_Juegos.Nombre,
                        Variacion = G16_Juegos.Variacion,
                        TotalActual = videojuegoExistente.TotalActual + G16_PuntajeActualJuego
                    };
                    MiLista.Add(newEntry);
                }
                else
                {
                    // Si no existe lo crea
                    G16_Juegos.TotalActual = G16_PuntajeActualJuego;
                    MiLista.Add(G16_Juegos);
                }

                dgvDatos.DataSource = null;
                dgvDatos.DataSource = MiLista;
                LimpiarControles();

                ActualizarSumaTotal();
            }
        }

        private void tlsGuardar_Click(object sender, EventArgs e)
        {

            //GENERADOR ARCHIVO .TXT
            // Obtiene la ruta de la carpeta del proyecto
            string directorioProyecto = AppDomain.CurrentDomain.BaseDirectory;

            // Concatena el nombre del archivo a la ruta de la carpeta del proyecto
            string filePath = Path.Combine(directorioProyecto, "base_de_informacion.txt");

            try
            {
                // Abre el archivo para escribir
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Escribe cada elemento de MiLista en el archivo
                    foreach (ClsLista Juego in MiLista)
                    {
                        writer.WriteLine($"{Juego.Nombre},{Juego.Variacion},{Juego.TotalActual}");
                    }
                }

                // Mensaje de guardado
                string G16_mensajeGuardado = $"Guardado con éxito en la carpeta: {Path.GetDirectoryName(filePath)}";

                // Mostrar el mensaje de ayuda en un MessageBox
                MessageBox.Show(G16_mensajeGuardado, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar generar la base de informacion " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
                // Mensaje de ayuda
                string mensajeAyuda = "Bienvenido a la aplicación.\n\nInstrucciones de uso:\n1. Ingrese el nombre de un juego e indique si ganó o perdió.\n2. Si el juego es nuevo se registrara un nuevo Puntaje Total para ese juego, si el juego ya ha sido jugado antes el Puntaje Total sera actualizado (+100 si se ganó o -20 si se perdió).\n3. Al hacer click en Guardar se actualizara el archivo base_de_informacion.txt con los datos presentes en la tabla. ";

                // Mostrar el mensaje de ayuda en un MessageBox
                MessageBox.Show(mensajeAyuda, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }







        // FIN RADIO BUTTON 2
    }
}