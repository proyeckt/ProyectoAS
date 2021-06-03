// Services/RutaService.cs

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

using System.Net;
using System.IO;
using System.Text;

using Newtonsoft.Json;

namespace RutaService
{
    public class RutaCheckService: RutaCheck.RutaCheckBase
    {
        private readonly ILogger<RutaCheckService> _logger;
        
        public RutaCheckService(ILogger<RutaCheckService> logger)
        {
            _logger = logger;
        }

        public override Task<RutaReply> CheckRutaRequest(RutaRequest request, ServerCallContext context)
        {
            return Task.FromResult(new RutaReply
            {
                IsAccepted = IsRutaInfoValid(request.Origen, request.Destino)
            });
        }

        private string IsRutaInfoValid(string origen, string destino) {
            string url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins="+origen+"&destinations="+destino+"&sensor=false&key=AIzaSyCPgGBVtdIdcO6tbwimh0fWnT6A3AgFtJ4";
            //string url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins="+pedido.Direccion+"&destinations="+pedido.DireccionTienda+"&sensor=false&key=AIzaSyCPgGBVtdIdcO6tbwimh0fWnT6A3AgFtJ4";
            Console.WriteLine(url);
            //var url = "https://maps.googleapis.com/maps/api/distancematrix/json?origins=75+9th+Ave+New+York,+NY&destinations=MetLife+Stadium+1+MetLife+Stadium+Dr+East+Rutherford,+NJ+07073&sensor=false&key=AIzaSyCPgGBVtdIdcO6tbwimh0fWnT6A3AgFtJ4";
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream data = response.GetResponseStream();
            StreamReader reader = new StreamReader(data);
            string responseFromServer = reader.ReadToEnd();
            Console.WriteLine(responseFromServer);
            RequestCepViewModel viewModel = JsonConvert.DeserializeObject<RequestCepViewModel>(responseFromServer);
            Console.WriteLine("ViewModel: -- "+viewModel.rows[0].elements[0].distance.text);
            Console.WriteLine("ViewModel: -- "+viewModel.rows[0].elements[0].distance.value);
            response.Close();
            string st = viewModel.rows[0].elements[0].distance.text;

            return st;
        }
    }
}