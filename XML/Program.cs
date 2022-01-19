using System;
using System.Xml;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new();                   // создали объект примемающий документ xml
            xDoc.Load("user.xml");              // загрузили документ

            XmlNode xroot = xDoc.DocumentElement;    // в объект, который может хранить корневой элемент, загружаем корневой элемент 

            if (xroot != null)
            {
                foreach (XmlNode xnode in xroot)     // пробегаем по всем узлам корневого элемента
                {
                    //XmlNode attr = xnode.Attributes.GetNamedItem("name");  // в объект, который может хранить атрибут, загружается атрибут "name"
                    //Console.WriteLine(attr?.Value);     // печатаем значение атрибута "name"

                    Console.WriteLine(xnode.Attributes?.GetNamedItem("name")?.Value);    // печатаем значение атрибута "name" (более простая запись чем предыдущая)

                    foreach (XmlNode childNode in xnode) // пробегаем по дочерним узлам каждого узла
                    {
                        // реализация с помощью IF
                        //if (childNode?.Name == "company")
                        //{
                        //    Console.WriteLine($"Company - {childNode.InnerText}");
                        //}

                        //if (childNode?.Name == "age")
                        //{
                        //    Console.WriteLine($"Age - {childNode.InnerText}");
                        //}

                        // реализация с помощью switch
                        switch (childNode?.Name)
                        {
                            case "company": 
                                Console.WriteLine($"Company - {childNode.InnerText}");
                                break;

                            case "age":
                                Console.WriteLine($"Age - {childNode.InnerText}");
                                break;

                            default:
                                Console.WriteLine("---");
                                break;
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
