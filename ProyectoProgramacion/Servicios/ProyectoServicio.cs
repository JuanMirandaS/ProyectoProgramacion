using ProyectoProgramacion.Http;
using ProyectoProgramacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProyectoProgramacion.Servicios
{
    public class ProyectoServicio : ConexionApi
    {
        private readonly string groupKey = "q7Z8s9T0";

        // Método para obtener la lista de proyectos 
        public async Task<List<Proyecto>> Index()
        {
            //declarar una variable para almacenar la respuesta de la API
            //la variable debe ser del tipo de la respuesta esperada
            //en este caso, la respuesta es una lista de proyectos
            RespuestaListaDeProyectos respuestaApi;
            try
            {
                string path = $"/projects/{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                // Convertir Data a cadena JSON
                string jsonRespuestaApi = response.Data.ToString();

                // Deserializar la respuesta de la API a un objeto de tipo RespuestaListaDeProyectos          
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeProyectos>(jsonRespuestaApi);

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

        // Método para obtener un proyecto específico por ID (Read)
        public async Task<Proyecto> Show(int projectId)
        {
            //no agregué el try catch porque ya está en el método Index el ejemplo
            //no seas flojo, implementa el try catch en este método también
            //si no lo haces, el programa se caerá si hay un error y no tendrás idea de qué pasó

            string path = $"/projects/{projectId}/{groupKey}";
            string body = "";
            var jsonRespuestaApi = await SendTransaction(path, body, "GET");

            RespuestaProyecto RespuestaApi = JsonSerializer.Deserialize<RespuestaProyecto>(jsonRespuestaApi.Data.ToString());

            return RespuestaApi.Data;
        }

        // Método para crear un nuevo proyecto (Create)
        public async Task<String> Create(object nuevoProyecto)
        {
            string respuestaApi = null;
            string path = $"/projects/{groupKey}";

            try
            {
                // Serializar el objeto anónimo a JSON, ya que la api debe recibir ese formato, no un obj de .net
                string proyectoJson = JsonSerializer.Serialize(nuevoProyecto);
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "POST");

                if (jsonRespuestaApi.Code == 201) //codigo http quiere decir que se creó el proyecto
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi;
        }
        //implementa los métodos Update y Delete siguiendo el mismo patrón de los métodos anteriores
        public async Task<Proyecto> Delete(int projectId)
        {
            try
            {
                // Definir la ruta para la solicitud DELETE
                string path = $"/projects/{projectId}/{groupKey}";
                string body = ""; // No se necesita cuerpo para la solicitud DELETE

                // Enviar la solicitud DELETE
                var response = await SendTransaction(path, body, "DELETE");

                // Verificar el estado de la respuesta
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Si la respuesta contiene un cuerpo, deserializarlo
                    if (!string.IsNullOrEmpty(response.Data?.ToString()))
                    {
                        RespuestaProyecto respuestaApi = JsonSerializer.Deserialize<RespuestaProyecto>(response.Data.ToString());
                        return respuestaApi.Data;
                    }
                    else
                    {
                        // Manejar el caso donde no hay cuerpo en la respuesta
                        // Puede ser que la operación se realizó exitosamente pero no hay datos adicionales
                        return null; // O manejarlo de otra manera según tu lógica
                    }
                }
                else
                {
                    // Manejar el error basado en el código de estado de la respuesta
                    // Aquí puedes lanzar una excepción específica si es necesario
                    // throw new Exception($"Error al eliminar el proyecto. Código de estado: {response.StatusCode}");
                    return null; // O manejarlo de otra manera según tu lógica
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (log o manejo del error)
                Console.WriteLine($"Se produjo un error al intentar eliminar el proyecto: {ex.Message}");
                return null; // Indicando que la eliminación falló debido a una excepción
            }
        }
        // Método para actualizar un proyecto existente (Update)
        public async Task<string> Update(int projectId, object proyectoActualizado)
        {
            string respuestaApi = null;
            string path = $"/projects/{projectId}/{groupKey}";

            try
            {
                // Serializar el objeto actualizado a JSON, ya que la API espera recibir un JSON
                string proyectoJson = JsonSerializer.Serialize(proyectoActualizado);

                // Enviar la solicitud PUT con los datos actualizados
                var jsonRespuestaApi = await SendTransaction(path, proyectoJson, "PUT");

                if (jsonRespuestaApi.Code == 200) // Código HTTP 200 indica que la actualización fue exitosa
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                else
                {
                    // Manejar otros códigos de estado según sea necesario
                    // Puedes lanzar una excepción o manejar el error de alguna otra manera
                    throw new Exception($"Error al actualizar el proyecto. Código de estado: {jsonRespuestaApi.Code}");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }
    }
   }
