using Newtonsoft.Json;
using System;

namespace JsonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            var voorbeeld = new Voorbeeld
            {
                Datum = DateTime.Now,
                Getal = rnd.Next(100),
                NogEenGetal = rnd.NextDouble() * rnd.Next(500),
                Tekst = "Alfa beta gamme",
                WaarOfNietWaar = rnd.Next(1) == 0,
            };

            Console.WriteLine("Serialisatie: C# ==> JSON");
            // 2 manier om te serialiseren naar JSON:

            // 1. Met Newtonsoft.Json (NuGet package nodig)

            Console.WriteLine("Met Newtonsoft.Json");
            //string jsonString = JsonConvert.SerializeObject(voorbeeld);
            string jsonString = JsonConvert.SerializeObject(voorbeeld, Formatting.Indented);

            Console.WriteLine(jsonString);

            // 2. Met ingebouwde standaard library System.Text.Json

            Console.WriteLine("Met System.Text.Json");
            jsonString = System.Text.Json.JsonSerializer.Serialize(voorbeeld);
            Console.WriteLine(jsonString);


            Console.WriteLine();
            Console.WriteLine("Deserialize: van JSON ==> C#");
            Console.WriteLine("Verschillende manieren om JSON terug om te zetten naar C#:");

            Console.WriteLine("1. Met Newtonsoft.JSON");
            Voorbeeld voorbeeldObject = JsonConvert.DeserializeObject<Voorbeeld>(jsonString);
            Console.WriteLine(voorbeeldObject);

            Console.WriteLine("2. Met System.Text.Json");
            voorbeeldObject = System.Text.Json.JsonSerializer.Deserialize<Voorbeeld>(jsonString);
            Console.WriteLine(voorbeeldObject);

            Console.WriteLine();

            Console.WriteLine("Deserialisatie met dynamic");

            // Voorbeeld uit https://json.org/example.html
            string jsonVoorbeeldString = @"{""widget"": {
    ""debug"": ""on"",
    ""window"": {
                ""title"": ""Sample Konfabulator Widget"",
        ""name"": ""main_window"",
        ""width"": 500,
        ""height"": 500
    },
    ""image"": {
                ""src"": ""Images/Sun.png"",
        ""name"": ""sun1"",
        ""hOffset"": 250,
        ""vOffset"": 250,
        ""alignment"": ""center""
    },
    ""text"": {
                ""data"": ""Click Here"",
        ""size"": 36,
        ""style"": ""bold"",
        ""name"": ""text1"",
        ""hOffset"": 250,
        ""vOffset"": 100,
        ""alignment"": ""center"",
        ""onMouseUp"": ""sun1.opacity = (sun1.opacity / 100) * 90;""
    }
        }
    }";
            dynamic dynamicObject = JsonConvert.DeserializeObject(jsonVoorbeeldString);
            Console.WriteLine(dynamicObject.widget.debug);

            dynamicObject.widget.debug = "off";
            string dynamicJsonString = JsonConvert.SerializeObject(dynamicObject, Formatting.Indented);
            Console.WriteLine(dynamicJsonString);

            Console.ReadKey();
        }
    }
}
