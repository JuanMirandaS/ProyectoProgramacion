using ProyectoProgramacion.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoProgramacion.Http
{
    public class RespuestaBase<T>
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("message")]
        public string? Message { get; set; }

        [JsonPropertyName("data")]
        public T Data { get; set; }
    }

    public class RespuestaApi : RespuestaBase<object>
    {
        public HttpStatusCode StatusCode { get; internal set; }
    }

    public class RespuestaListaDeProyectos : RespuestaBase<List<Proyecto>>
    {
    }

    public class RespuestaProyecto : RespuestaBase<Proyecto>
    {
    }
    public class RespuestaCreacionProyecto : RespuestaBase<Proyecto>
    {
    }
    public class RespuestaCreacionTarea : RespuestaBase<Tarea>
    {

    }
    public class RespuestaListaDeTareas : RespuestaBase<List<Tarea>>
    {
    }
    public class RespuestaTarea : RespuestaBase<Tarea>
    {
    }
}