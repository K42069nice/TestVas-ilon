using System;
using System.Collections.Generic;
using System.IO;

namespace TestVas___ilon.Handlers
{
    public class ConvertTo
    {
        public string GetXmlFromAPath(string path)
        {
            string s = "";
            if (File.Exists(path))
            {
                s = File.ReadAllText(path);

            }
            return s;
        }


        public string InvertirFecha(string fechaOld)
        {
            fechaOld = fechaOld.Trim();
            string res = "";
            res += fechaOld.Substring(6, 2);
            res += fechaOld.Substring(4, 2);
            res += fechaOld.Substring(0, 4);

            return res;
        }



        //Añadir ILogProvider
    }
}
