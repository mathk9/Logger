using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterLog.Log(String.Format($"{"Log criado em "} : {DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss:fff")}"), "ArquivoLog");
            RegisterLog.Log("Registro de log de auditoria");

            Console.WriteLine("Log criado e registrado com sucesso");
            Console.ReadLine();
        }
    }
}
