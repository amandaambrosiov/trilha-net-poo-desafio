using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "85998074839", modelo: "Nokia Tijolão", imei: "123", memoria: 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Temple Run");

        Console.WriteLine("Testando smartphone iPhone:");
        Smartphone iphone = new Iphone(numero: "11998345670", modelo: "Iphone 8", imei: "999", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Safari");
    }
}