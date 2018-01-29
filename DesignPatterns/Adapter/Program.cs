using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.nome = "Guilherme";
            cliente.endereco = "Rua Vergueiro";
            cliente.dataNascimento = DateTime.Now;

            String xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
            Console.ReadKey();
        }
    }
}
