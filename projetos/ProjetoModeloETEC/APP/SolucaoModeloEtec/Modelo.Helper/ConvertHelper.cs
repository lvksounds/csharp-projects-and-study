using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Helper
{
    // classe criada para dar suporte a conversão de dados
    // substituira a Convert, nativa do C# que ao inves de retornar um erro, retornará um valor padrão
    public class ConvertHelper
    {
        public string ConvertToString(Object valor)
        {
            try
            {
                return Convert.ToString(valor);
            }
            catch
            {
                return "";
            }
        }

        public Int16 ConvertToInt16(object valor)
        {
            try
            {
                return Convert.ToInt16(valor);
            }
            catch
            {
                return 0;
            }
        }
        public Int32 ConvertToInt32(object valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch
            {
                return 0;
            }
        }
        public Int64 ConvertToInt64(object valor)
        {
            try
            {
                return Convert.ToInt64(valor);
            }
            catch
            {
                return 0;
            }
        }

        public decimal ConvertToDecimal(object valor)
        {
            try
            {
                return Convert.ToDecimal(valor);
            }
            catch
            {
                return 0;
            }
        }
        public bool ConvertToBoolean(object valor)
        {
            try
            {
                return Convert.ToBoolean(valor);
            }
            catch
            {
                return false;
            }
        }

        public DateTime ConvertToDateTime(object valor)
        {
            try
            {
                return Convert.ToDateTime(valor);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }
        public DateTime? ConvertToDateTimeNull(object valor)
        {
            try
            {
                return Convert.ToDateTime(valor);
            }
            catch
            {
                return null;
            }
        }
    }
}
