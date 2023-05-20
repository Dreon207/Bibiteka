using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace DesSezLibrary
{
    public class Car
    {
        public string MachineBrand { get; set; }
        public string Model { get; set; }
    }
    public class Deserialization_Serialization
    {
        public static T S <T>(T carM1)
        {
            string json1 = JsonConvert.SerializeObject(carM1);
            File.WriteAllText("C:\\Temp\\NewJS.json", json1);
            return carM1;
        }
        public static T D <T>(T carM1)
        {
           string json = File.ReadAllText("C:\\Temp\\NewJS.json");
            T itogM1 = JsonConvert.DeserializeObject<T>(json);
            return itogM1;
        }
    }
}