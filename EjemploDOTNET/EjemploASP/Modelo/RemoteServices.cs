using System;
using GrpcGreeterClient;
using System.Threading.Tasks;

namespace EjemploASP.Modelo
{
    public class RemoteServices
    {
        /*public async void service1() {
            Console.WriteLine("Start Service");
            GrpcServicesClient client=new GrpcServicesClient();
            bool pls=await client.clientGreetService();
            Console.WriteLine("End Service");
            Console.WriteLine(pls);
        }*/
        public bool serviceValidarTarjeta(string numCard,string dateExp,string cvv) {
            Console.WriteLine("Start Service");
            GrpcServicesClient client=new GrpcServicesClient();
            bool pls=client.clientValidateCardService(numCard,dateExp,cvv);
            Console.WriteLine("End Service");
            Console.WriteLine(pls);
            return pls;
        } 
    }
}