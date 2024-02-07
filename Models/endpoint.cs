namespace apiman.Models
    {
    public class endpoint
        {
        public string name { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public bool enabled { get; set; }
        public string[] tags { get; set; }
        public string group { get; set; }
        public string body { get; set; }   // Almacena JSON Schema
        public string response { get; set; }  // Almacena JSON Schema
        }
    }
