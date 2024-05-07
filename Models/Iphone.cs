namespace DesafioPOO.Models
{
    public class Iphone : Smartphone 
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"Modelo: {modelo}, Número: {numero}, IMEI: {imei}, Total Mémoria: {memoria}");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
          Console.WriteLine("Instalando Aplicativo... " + nomeApp);
        }
            
    }
}