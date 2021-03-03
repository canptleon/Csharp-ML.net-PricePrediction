using System;
using PricePredictionML.Model;

namespace PricePredictionML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelInput sampleData = new ModelInput()
            {
                Vendor_id = @"CMT",
                Rate_code = 1F,
                Passenger_count = 1F,
                Trip_time_in_secs = 1271F,
                Trip_distance = 3.8F,
                Payment_type = @"CRD",
            };

            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Fare_amount with predicted Fare_amount from sample data...\n\n");
            Console.WriteLine($"Vendor_id: {sampleData.Vendor_id}");
            Console.WriteLine($"Rate_code: {sampleData.Rate_code}");
            Console.WriteLine($"Passenger_count: {sampleData.Passenger_count}");
            Console.WriteLine($"Trip_time_in_secs: {sampleData.Trip_time_in_secs}");
            Console.WriteLine($"Trip_distance: {sampleData.Trip_distance}");
            Console.WriteLine($"Payment_type: {sampleData.Payment_type}");
            Console.WriteLine($"\n\nPredicted Fare_amount: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
