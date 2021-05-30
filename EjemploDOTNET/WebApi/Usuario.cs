using System;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApi
{
    public class Usuario 
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
