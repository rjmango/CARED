using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CARED.Models;

namespace CARED.Services
{

    internal class JsonProcedureProvider : IProcedureProvider
    {
        private readonly string _filePath;
        public JsonProcedureProvider(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<List<Procedure>> GetProceduresAsync()
        {
            try
            {
                if (!File.Exists(_filePath)) return new List<Procedure>();

                using FileStream stream = File.OpenRead(_filePath);

                var result = await JsonSerializer.DeserializeAsync<List<Procedure>>(stream);

                return result ?? new List<Procedure>();
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework here)
                Console.WriteLine($"Error reading procedures from JSON: {ex.Message}");
                return new List<Procedure>();

            }
        }

    }
}
