using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoProgramacion.Modelos
{
    public class Proyecto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("workerHours")]
        public string WorkerHours { get; set; }

        [JsonPropertyName("totalHours")]
        public string TotalHours { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
