using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

using CreditRatingService;
using ValidateCardService;
namespace GrpcGreeterClient
{
    public class GrpcServicesClient
    {
        public static async Task Main(string[] args)
        {
            // This switch must be set before creating the GrpcChannel/HttpClient.
            //AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            
            /*var httpHandler = new HttpClientHandler
	        {
		        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        	};
            */
            // The port number(5001) must match the port of the gRPC server.
            //using var channel = GrpcChannel.ForAddress("https://localhost:5001",
            //new GrpcChannelOptions { HttpHandler = httpHandler });

            //await clientGreetService(channel);
            //await clientCreditRatingService(channel);
        }

        public async Task<bool> clientCreditRatingService(){
            var httpHandler = new HttpClientHandler
	        {
		        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        	};

            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001",
            new GrpcChannelOptions { HttpHandler = httpHandler });
            var client =  new CreditRatingCheck.CreditRatingCheckClient(channel);
            var creditRequest = new CreditRequest { CustomerId = "id0201", Credit = 7000};
            var reply = await client.CheckCreditRequestAsync(creditRequest);

            Console.WriteLine($"Credit for customer {creditRequest.CustomerId} {(reply.IsAccepted ? "approved" : "rejected")}!");

            return true;
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
        public bool clientValidateCardService(string numCard,string dateExp,string cvv){
            var httpHandler = new HttpClientHandler
	        {
		        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        	};

            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001",
            new GrpcChannelOptions { HttpHandler = httpHandler });
            var client =  new ValidateCardCheck.ValidateCardCheckClient(channel);
            var cardRequest = new CardRequest { NumCard = numCard, DateExp = dateExp, Cvv = cvv};
            var reply = client.CheckCardRequest(cardRequest);

            Console.WriteLine($"Credit for customer {(reply.IsAccepted ? "approved" : "rejected")}!");

            bool ret=reply.IsAccepted;
            Console.WriteLine(ret);
            return ret;
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
        public async Task<bool> clientGreetService(){
            var httpHandler = new HttpClientHandler
	        {
		        ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        	};

            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001",
            new GrpcChannelOptions { HttpHandler = httpHandler });
            var client =  new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            return true;
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
        }
    }
}