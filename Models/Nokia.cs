namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor na subclasse chamando o da classe base
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria) { } // chama o construtor da classe abstrata

        public string nomeApp { get; set; }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em um celular Nokia.");
        }
    }
}