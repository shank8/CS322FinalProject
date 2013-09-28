using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XmlConfiguration;
using System.IO;

namespace CS322Final
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlTextReader xtr = new XmlTextReader("DFA.xml");
            int indents = 0, layer = 0;

            while (xtr.Read())
            {
                //Console.WriteLine(indents);
                layer = indents;
               // while (layer != 0) { Console.Write("  "); layer--; }
                
                switch (xtr.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.WriteLine("<" + xtr.Name + ">");
                        indents++;
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine("\t"+xtr.Value);
                        break;
                    case XmlNodeType.EndElement:

                        Console.WriteLine("</" + xtr.Name + ">");
                        Console.Write('\n');
                        indents--;
                        break;
                }

            }
        }
    }
}
