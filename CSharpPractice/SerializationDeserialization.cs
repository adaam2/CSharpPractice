using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CSharpPractice
{
    class SerializationDeserialization
    {
        public SerializationDeserialization()
        {
            Battery batt = new Battery("Duracell", 1500, ConsoleColor.Green);
            batt.SetPercentage(55);
            XmlSerializer serializer = new XmlSerializer(typeof(Battery));
            

            StringWriter writer = new StringWriter();

            serializer.Serialize(writer, batt);

            Console.WriteLine(writer.ToString());         
        }
    }
    [Serializable]
    public class Battery
    {
        public string Brand { get; set; }
        public int AmpHour { get; set; }
        public ConsoleColor Colour { get; set; }
        public decimal PercentageLeft { get; set; }

        public Battery()
        {
            // default constructor
        }
        public Battery(string brand, int power, ConsoleColor colour)
        {
            this.Brand = brand;
            this.AmpHour = power;
            this.Colour = colour;
        }
        public void SetPercentage(decimal percentage) {
            this.PercentageLeft = percentage;
        }
    }
}
