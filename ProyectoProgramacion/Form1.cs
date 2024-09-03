using ProyectoProgramacion.Modelos;
using ProyectoProgramacion.Servicios;

namespace ProyectoProgramacion
{
    public partial class Form1 : Form
    {
        private bool EditandoP = false;
        private bool EditandoT = false;

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
            txtProyecto.Text = "";
            txtDescripcion.Text = "";
            numHorasTotales.Value = 0;
            numericIDProyecto.Enabled = true;
        }

        private void limpiezaTarea()
        {
            /*
            txtTarea.Text = "";
            boxProyecto.SelectedIndex = 1;
            boxArea.SelectedIndex = 1;
            numHorasTarea.Value = 0;
            boxUsuarios.SelectedIndex = 1;
            */
        }

        private async void btnGuardarProyecto_Click(object sender, EventArgs e)
        {
            /*try
            {
                ProyectoServicio proyectoServicio = new ProyectoServicio();
                Proyecto proyecto = new Proyecto
                {
                    Name = txtProyecto.Text.Trim(),
                    Description = txtDescripcion.Text.Trim(),
                    TotalHours = numHorasTotales.Value.ToString(),
                    WorkerHours = "0",
                    Status = "Pendiente",
                    CreatedAt = DateTime.Now // Sacar Fecha actual
                };

                if (EditandoP)
                {
                    // Editar proyecto existente
                    await proyectoServicio.Update(proyecto.Id, proyecto);
                }
                else
                {
                    // Guardar nuevo proyecto (No enviar la ID si la API la genera automáticamente)
                    await proyectoServicio.Create(proyecto);
                }

                // Recargar la lista de proyectos
                List<Proyecto> proyectos = await proyectoServicio.Index();
                dataGridView1.DataSource = proyectos;

                limpiezaProyecto();
                EditandoP = false;
                btnGuardarProyecto.Text = "Guardar";
                btnLimpiarProyecto.Text = "Limpiar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar proyecto: {ex.Message}");
            }*/
        }


        private void btnLimpiarProyecto_Click(object sender, EventArgs e)
        {
            if (EditandoP)
            {
                // Cancelar la edición
                EditandoP = false;
                btnGuardarProyecto.Text = "Guardar";
                btnLimpiarProyecto.Text = "Limpiar";
                numericIDProyecto.Enabled = true;
            }
            limpiezaProyecto();
        }

        private void btnLimpiarTarea_Click(object sender, EventArgs e)
        {
            if (EditandoT)
            {
                // Cancelar la edición
                EditandoT = false;
                btnGuardarTarea.Text = "Guardar";
                btnLimpiarTarea.Text = "Limpiar";
            }
            limpiezaTarea();
        }

        private async void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            /*try
            {
                TareaServicio tareaServicio = new TareaServicio();
                Tarea tarea = new Tarea
                {
                    Description = txtTarea.Text,
                    Project_id = (int)boxProyecto.SelectedValue,
                    Area = boxArea.SelectedItem.ToString(),
                    Hours = (int)numHorasTarea.Value,
                    User_id = (int)boxUsuarios.SelectedValue,
                    Status = "Pendiente",  // Valor por defecto
                    Start_date = DateTime.Now  // Fecha del sistema
                };

                if (EditandoT)
                {
                    // Actualizar tarea existente
                    tarea.Id = int.Parse(idTarea.Text);
                    await tareaServicio.Update(tarea.Id, tarea);
                }
                else
                {
                    // Crear nueva tarea
                    await tareaServicio.Create(tarea);
                }

                // Actualizar DataGridView de tareas
                await CargarTareasDeProyecto(tarea.Project_id);

                limpiezaTarea();
                EditandoT = false;
                btnGuardarTarea.Text = "Guardar";
                btnLimpiarTarea.Text = "Limpiar";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la tarea: {ex.Message}");
            }*/
        }

        private async void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
           /* if (EditandoP)
            {
                try
                {
                    int projectId = (int)numericIDProyecto.Value;
                    ProyectoServicio proyectoServicio = new ProyectoServicio();
                    await proyectoServicio.Delete(projectId);

                    // Recargar la lista de proyectos
                    List<Proyecto> proyectos = await proyectoServicio.Index();
                    dataGridView1.DataSource = proyectos;

                    limpiezaProyecto();
                    EditandoP = false;
                    btnGuardarProyecto.Text = "Guardar";
                    btnLimpiarProyecto.Text = "Limpiar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar proyecto: {ex.Message}");
                }
            }*/
        }

        private async void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            /*if (EditandoT)
            {
                try
                {
                    int tareaId = Convert.ToInt32(idTarea.Text);
                    TareaServicio tareaServicio = new TareaServicio();
                    await tareaServicio.Delete(tareaId);

                    // Recargar las tareas del proyecto seleccionado
                    int projectId = Convert.ToInt32(numericIDProyecto.Value);
                    await CargarTareasDeProyecto(projectId);

                    limpiezaTarea();
                    EditandoT = false;
                    btnGuardarTarea.Text = "Guardar";
                    btnLimpiarTarea.Text = "Limpiar";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar tarea: {ex.Message}");
                }
            }*/
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
                EditandoT = true;
                btnGuardarTarea.Text = "Editar";
                btnLimpiarTarea.Text = "Cancelar";

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
                EditandoP = true;
                btnGuardarProyecto.Text = "Editar";
                btnLimpiarProyecto.Text = "Cancelar";
                numericIDProyecto.Enabled = false;

                try
                {
                    int projectId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    ProyectoServicio proyectoServicio = new ProyectoServicio();
                    Proyecto proyecto = await proyectoServicio.Show(projectId);

                    idProyecto.Text = proyecto.Id.ToString();
                    txtProyecto.Text = proyecto.Name;
                    txtDescripcion.Text = proyecto.Description;
                    numHorasTotales.Value = decimal.Parse(proyecto.TotalHours);
                    numericIDProyecto.Value = proyecto.Id;

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
