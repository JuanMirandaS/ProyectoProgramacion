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
    public class TareaServicio : ConexionApi
    {
        private readonly string groupKey = "q7Z8s9T0";
        // Método para obtener la lista de tareas 
        public async Task<List<Tarea>> Index()
        {
            RespuestaListaDeTareas respuestaApi;
            try
            {
                string path = $"/tasks/{groupKey}";
                string body = "";
                var response = await SendTransaction(path, body, "GET");

                // Convertir Data a cadena JSON
                string jsonRespuestaApi = response.Data.ToString();

                // Deserializar la respuesta de la API a un objeto de tipo RespuestaListaDeTareas          
                respuestaApi = JsonSerializer.Deserialize<RespuestaListaDeTareas>(jsonRespuestaApi);

                if (respuestaApi.Code != 200)
                {
                    // Manejar el error según el código de respuesta
                    throw new Exception($"Error al obtener las tareas. Código de estado: {respuestaApi.Code}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi.Data;
        }

        // Método para obtener una tarea específica por ID (Read)
        public async Task<Tarea> Show(int taskId)
        {
            try
            {
                string path = $"/tasks/{taskId}/{groupKey}";
                string body = "";
                var jsonRespuestaApi = await SendTransaction(path, body, "GET");

                RespuestaTarea respuestaApi = JsonSerializer.Deserialize<RespuestaTarea>(jsonRespuestaApi.Data.ToString());

                return respuestaApi.Data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        // Método para crear una nueva tarea (Create)
        public async Task<String> Create(object nuevaTarea)
        {
            string respuestaApi = null;
            string path = $"/tasks/{groupKey}";

            try
            {
                // Serializar el objeto anónimo a JSON
                string tareaJson = JsonSerializer.Serialize(nuevaTarea);
                var jsonRespuestaApi = await SendTransaction(path, tareaJson, "POST");

                if (jsonRespuestaApi.Code == 201) // Código HTTP 201 indica que se creó la tarea
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                /*else
                {
                    // Manejar otros códigos de estado según sea necesario
                    throw new Exception($"Error al crear la tarea. Código de estado: {jsonRespuestaApi.Code}");
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return respuestaApi;
        }

        // Método para actualizar una tarea existente (Update)
        public async Task<string> Update(int taskId, object tareaActualizada)
        {
            string respuestaApi = null;
            string path = $"/tasks/{taskId}/{groupKey}";

            try
            {
                // Serializar el objeto actualizado a JSON
                string tareaJson = JsonSerializer.Serialize(tareaActualizada);

                // Enviar la solicitud PUT con los datos actualizados
                var jsonRespuestaApi = await SendTransaction(path, tareaJson, "PUT");

                if (jsonRespuestaApi.Code == 200) // Código HTTP 200 indica que la actualización fue exitosa
                {
                    respuestaApi = jsonRespuestaApi.Message;
                }
                /* else
                 {
                     // Manejar otros códigos de estado según sea necesario
                     throw new Exception($"Error al actualizar la tarea. Código de estado: {jsonRespuestaApi.Code}");
                 }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return respuestaApi;
        }

        // Método para eliminar una tarea (Delete)
        public async Task<Tarea> Delete(int taskId)
        {
            try
            {
                // Definir la ruta para la solicitud DELETE
                string path = $"/tasks/{taskId}/{groupKey}";
                string body = ""; // No se necesita cuerpo para la solicitud DELETE

                // Enviar la solicitud DELETE
                var response = await SendTransaction(path, body, "DELETE");

                // Verificar el estado de la respuesta
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Si la respuesta contiene un cuerpo, deserializarlo
                    if (!string.IsNullOrEmpty(response.Data?.ToString()))
                    {
                        RespuestaTarea respuestaApi = JsonSerializer.Deserialize<RespuestaTarea>(response.Data.ToString());
                        return respuestaApi.Data;
                    }
                    else
                    {
                        // Manejar el caso donde no hay cuerpo en la respuesta
                        return null; // O manejarlo de otra manera según tu lógica
                    }
                }
                else
                {
                    // Manejar el error basado en el código de estado de la respuesta
                    throw new Exception($"Error al eliminar la tarea. Código de estado: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones (log o manejo del error)
                Console.WriteLine($"Se produjo un error al intentar eliminar la tarea: {ex.Message}");
                return null; // Indicando que la eliminación falló debido a una excepción
            }
        }

    }
}
