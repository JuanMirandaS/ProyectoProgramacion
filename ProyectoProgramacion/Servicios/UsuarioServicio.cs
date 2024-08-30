using ProyectoProgramacion.Http;
using ProyectoProgramacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoProgramacion.Servicios
{
    public class UsuarioServicio:ConexionApi
    {
        private readonly string groupKey = "q7Z8s9T0";

        // Método para obtener la lista de proyectos 
        public async Task<List<Usuario>> Index()
        {
            //declarar una variable para almacenar la respuesta de la API
            //la variable debe ser del tipo de la respuesta esperada
            //en este caso, la respuesta es una lista de proyectos
            RespuestaListaDeUsuarios respuestaApi;
            try
            {
                string path = $"/users";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                // Convertir Data a cadena JSON
                string jsonRespuestaApi = response.Data.ToString();

                // Deserializar la respuesta de la API a un objeto de tipo RespuestaListaDeProyectos          
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeUsuarios>(jsonRespuestaApi);

                /* Aquí podrías validar si hay algun error con la respuesta según su código*/
                if (respuestaApi.Code != 200)
                {
                    /* cualquier cosa que quieras hacer pa mostrar el error*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

    }
}
