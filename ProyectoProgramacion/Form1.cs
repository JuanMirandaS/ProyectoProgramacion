namespace ProyectoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            limpiezaProyecto();
            limpiezaTarea();
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
