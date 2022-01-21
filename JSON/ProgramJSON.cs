using Newtonsoft.Json;
using System;
using JsonSerializer = System.Text.Json.JsonSerializer; // 2 works faster


namespace JSON
{
    internal class ProgramJSON
    {
        static void Main(string[] args)
        {
            // 1------------------------------------------------------------
            Console.WriteLine("1.using System.Text.Json;");

            Person tom = new Person { Name = "Tom", Age = 35 };

            string json = JsonSerializer.Serialize<Person>(tom);
            Console.WriteLine(json);

            Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restoredPerson?.Name);

            // 2---------------------------------------------------------------------------------------------
            Console.WriteLine("2.using Newtonsoft.Json;");

            string jsonnewtonSoft = JsonConvert.SerializeObject(tom);
            Console.WriteLine(jsonnewtonSoft);

            Person tomfromjson = JsonConvert.DeserializeObject<Person>(jsonnewtonSoft);
            Console.WriteLine(tomfromjson?.Name);



            Console.ReadLine();
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }


    }
}
