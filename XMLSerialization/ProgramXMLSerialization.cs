using System;
using System.IO;
using System.Xml.Serialization;

namespace XMLSerialization
{
    internal class ProgramXMLSerialization
    {
        static void Main(string[] args)
        {
            File.Delete("Fl.xml");
            //Seriaz person = new Seriaz("Tom", 12, "IIT");
            //Car car=new Car();

            //XmlSerializer ser=new XmlSerializer(typeof(Seriaz));
            //XmlSerializer sercar=new XmlSerializer(typeof(Car));

           

            using (FileStream fl=new FileStream("Fl.xml", FileMode.Append))
            {
                Seriaz person = new Seriaz("Tom", 12, "IIT");
                Car car = new Car();

                XmlSerializer ser = new XmlSerializer(typeof(Seriaz));
                XmlSerializer sercar = new XmlSerializer(typeof(Car));
                ser.Serialize(fl, person);
                sercar.Serialize(fl, car);
            }
        }
    }
}
