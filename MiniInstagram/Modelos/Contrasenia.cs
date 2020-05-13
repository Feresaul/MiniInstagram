using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniInstagram.Modelos
{
    public class Contrasenia
    {
        private string _texto;

        public Contrasenia(string texto)
        {
            _texto = texto;
        }

        public string Encriptar()
        {
            _texto = invertirCadena();
            return  ConvertirSHA1(); 
        }
        public string ConvertirSHA1()
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(_texto);
            byte[] outputBytes = HashAlgorithm.Create("SHA1").ComputeHash(inputBytes);
            var salida = string.Empty;
            for (int i = 0; i < outputBytes.Length; i++)
            {
                salida += outputBytes[i].ToString("X2");
            }
            return salida;
        }
        public string invertirCadena()
        {
            var temp = _texto;
            var salida = string.Empty;
            if (string.IsNullOrEmpty(temp)) return string.Empty;
            for (int i = temp.Length - 1; i >= 0; i--)
            {
                salida += temp[i];
            }
            return salida;
        }
    }
}
