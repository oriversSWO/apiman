using apiman.Models;
using System.Text.Json;

namespace apiman.Utils
    {
    public class Search
        {
        private List<endpoint> _endpoints;

        public Search()
            {
            string jsonFilePath = "Data/endpoints.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            _endpoints = JsonSerializer.Deserialize<List<endpoint>>(jsonContent!);
            }

        public List<endpoint> ListByTag(string tag, bool enabled = true)
            {
            return _endpoints.Where(e => e.tags.Contains(tag) && e.enabled == enabled).ToList();
            }

        public List<endpoint> ListByGroup(string group, bool enabled = true)
            {
            return _endpoints.Where(e => e.group == group && e.enabled == enabled).ToList();
            }

        public List<endpoint> ListByEnabled(bool enabled)
            {
            return _endpoints.Where(e => e.enabled == enabled).ToList();
            }
        }
    }
