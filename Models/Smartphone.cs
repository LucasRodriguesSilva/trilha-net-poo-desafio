namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Implementado!
        private string _modelo;
        private string _IMEI;
        private int _memoria;
        

        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            Numero = numero;
            // Implementado!
            _modelo = modelo;
            _IMEI = IMEI;
            _memoria = memoria;
            
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

    }
}