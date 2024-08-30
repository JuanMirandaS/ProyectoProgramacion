using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoProgramacion.Modelos
{
    public class Tarea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime Start_date { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("hours")]
        public int Hours { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }

        [JsonPropertyName("project_id")]
        public int Project_id { get; set; }

        [JsonPropertyName("user_id")]
        public int User_id { get; set; }

    }
}
