using System;
using PricePredictionML.Model;


namespace PricePrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput();

            input.Trip_distance = 10;
            input.Trip_time_in_secs = 1000;

            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine("Tahmin edilen ödenecek tutar => " + result.Score);
            Console.ReadLine();

            Console.Write("Yeni rota uzaklığı giriniz => ");
            input.Trip_distance = Single.Parse(Console.ReadLine());

            Console.Write("Yeni rota zamanınızı giriniz (Saniye) => ");
            input.Trip_time_in_secs = Single.Parse(Console.ReadLine());

            ModelOutput result2 = ConsumeModel.Predict(input);
            Console.WriteLine("Tahmin edilen ödenecek tutar => " + result2.Score);
            Console.ReadLine();

        }
    }
}
