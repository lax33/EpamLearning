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
            Seriaz person = new Seriaz("Tom", 12, "IIT");

            XmlSerializer ser=new XmlSerializer(typeof(Seriaz));

            using (FileStream fl=new FileStream("Fl.xml", FileMode.OpenOrCreate))
            {
                
                ser.Serialize(fl, person);
            }
        }
    }
}
