namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _Modelo;
        public string Modelo
        {
            set{
            _Modelo = value;
            }
        }
        public string _IMEI;
        public string IMEI
        {
            set{
            _IMEI = value;
            }
        }
        private int _Memoria;
        public int Memoria
        {
            set{
            _Memoria = value;
            }
        }

        public Smartphone(string numero, string modelo, string Imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = Imei;
            Memoria = memoria;
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