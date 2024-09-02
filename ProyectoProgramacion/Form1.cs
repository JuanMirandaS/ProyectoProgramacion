using ProyectoProgramacion.Modelos;
using ProyectoProgramacion.Servicios;

namespace ProyectoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpiezaProyecto();
            limpiezaTarea();

            this.Load += new System.EventHandler(this.Form1_Load);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(this.ClicEnDGVProyecto);
            dataGridView2.CellDoubleClick += new DataGridViewCellEventHandler(this.ClicEnDGVTarea);
        }
        private void limpiezaProyecto()
        {
            /*
             * txtProyecto set ""
             * txtDescripcion set ""
             * numHorasTotales set 0
             */

        }

        private void limpiezaTarea()
        {
            /*
             * txtTarea set ""
             * boxProyecto index 0
             * boxTarea set index 0
             * numHorasTarea set 0
             * boxUsuarios index 0
             */
        }

        private void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            /*
             * Gestion proyecto
             *  proyecto        = txtProyecto
             *  descripcion     = txtDescripcion
             *  horas_totales   = numHorasTotales  
             *  Para la hora utilizaremos la hora actual al guardar el objeto
             *  
             *
             *  *Codigo para el guardado de los datos de objeto a la clase Proyecto
             *
            */
            limpiezaProyecto(); // Limpiamos campos luego de la insercion
        }

        private void btnLimpiarProyecto_Click(object sender, EventArgs e)
        {
            limpiezaProyecto(); // Limpiamos los campos de Proyecto
        }

        private void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            /*
             * Gestion Tarea
             *  descripcionTarea = txtTarea
             *  proyectoAsignado = boxProyecto // Rellenar box un select de proyectos
             *  areaAsiganada    = boxArea 
             *  horas            = numHorasTarea
             *  usuarioAsignado  = boxUsuarios // Rellenar box un select de usuarios
             */
        }

        private void btnLimpiarTarea_Click(object sender, EventArgs e)
        {
            limpiezaTarea(); // Limpiamos campos de Tarea
        }

        private async Task CargarTareasDeProyecto(int projectId)
        {
            try
            {
                TareaServicio tareaServicio = new TareaServicio();
                List<Tarea> tareas = await tareaServicio.Index();

                // Filtrar tareas por ID del proyecto
                var tareasFiltradas = tareas.Where(t => t.Project_id == projectId).ToList();

                if (tareasFiltradas.Count == 0)
                {
                    MessageBox.Show("Este proyecto no tiene tareas asociadas.", "No hay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar el DataGridView de tareas cuando se seleccione otro proyecto que no tenga tareas
                    dataGridView2.DataSource = null;
                }
                else
                {
                    // Llenar DataGridView de tareas
                    dataGridView2.DataSource = tareasFiltradas;
                    dataGridView2.Columns["Id"].HeaderText = "ID";
                    dataGridView2.Columns["Description"].HeaderText = "Descripción";
                    dataGridView2.Columns["Start_date"].HeaderText = "Fecha de Inicio";
                    dataGridView2.Columns["Status"].HeaderText = "Estado";
                    dataGridView2.Columns["Hours"].HeaderText = "Horas";
                    dataGridView2.Columns["Area"].HeaderText = "Área";
                    dataGridView2.Columns["project_id"].HeaderText = "ID de proyecto";
                    dataGridView2.Columns["User_id"].HeaderText = "ID de Usuario";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ClicEnDGVTarea(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Obtener ID de tarea seleccionada
                    int tareaId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Id"].Value);

                    TareaServicio tareaServicio = new TareaServicio();
                    Tarea tarea = await tareaServicio.Show(tareaId);

                    // Mostrar datos en los campos que corresponden
                    idTarea.Text = tarea.Id.ToString();
                    txtTarea.Text = tarea.Description;
                    boxProyecto.SelectedValue = tarea.Project_id;
                    numHorasTarea.Value = tarea.Hours;
                    boxUsuarios.SelectedValue = tarea.User_id;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar tarea/s: {ex.Message}");
                }
            }
        }

        private async void ClicEnDGVProyecto(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Obtener ID de proyecto seleccionado
                    int projectId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    ProyectoServicio proyectoServicio = new ProyectoServicio();
                    Proyecto proyecto = await proyectoServicio.Show(projectId);

                    // Mostrar datos del proyecto en los campos que corresponden
                    idProyecto.Text = proyecto.Id.ToString();
                    txtProyecto.Text = proyecto.Name;
                    txtDescripcion.Text = proyecto.Description;
                    numHorasTotales.Value = decimal.Parse(proyecto.TotalHours);

                    // Cargar tareas relacionadas al proyecto seleccionado
                    await CargarTareasDeProyecto(projectId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar proyecto/s: {ex.Message}");
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar proyectos en ComboBox de Proyectos
                ProyectoServicio proyectoServicio = new ProyectoServicio();
                List<Proyecto> proyectos = await proyectoServicio.Index();
                boxProyecto.DataSource = proyectos;
                boxProyecto.DisplayMember = "Id";
                boxProyecto.ValueMember = "Id";

                // Cargar usuarios en ComboBox de Usuarios
                UsuarioServicio usuarioServicio = new UsuarioServicio();
                List<Usuario> usuarios = await usuarioServicio.Index();
                boxUsuarios.DataSource = usuarios;
                boxUsuarios.DisplayMember = "Name";
                boxUsuarios.ValueMember = "Id";

                // Llenar DataGridView1 (la de los proyectos) con datos de proyectos
                dataGridView1.DataSource = proyectos;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Nombre";
                dataGridView1.Columns["Description"].HeaderText = "Descripción";
                dataGridView1.Columns["Status"].HeaderText = "Estado";
                dataGridView1.Columns["WorkerHours"].HeaderText = "Horas Trabajadas";
                dataGridView1.Columns["TotalHours"].HeaderText = "Horas Totales";
                dataGridView1.Columns["CreatedAt"].HeaderText = "Fecha de Creación";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proyectos y/o usuarios: {ex.Message}");
            }
        }
    }
}
