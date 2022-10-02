using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model.Logs
{
    public abstract class CreateLogs
    {

        public static Exception Exceptions { get; set; }
        //cambiar el campo Release a Debug o Debug a Release segun sea el caso de ejecucion
        //Path.GetFullPath(Environment.CurrentDirectory).Replace(@"View\bin\Debug\net5.0-windows", null) + @"Logs\Logs.txt";
      
        protected static string ruta = Path.GetFullPath(Environment.CurrentDirectory) + @"\Logs.txt";

        public static void Create(Exception exception, MethodBase method)
        {
          
            try
            {
                
                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    writer.BaseStream.Seek(0, SeekOrigin.End);
                    string registro = String.Empty;
                    registro = ($"{exception.Message} in Method: {method.Name} => {DateTime.Now}");
                    writer.WriteLine(registro);
                }

            }
            catch (Exception ex)
            {
                Exceptions = ex;
            }


        }
        public static Exception GetException()
        {
            return Exceptions;
        }
    }
}
