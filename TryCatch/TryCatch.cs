using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class TryCatch
    {        static void FazTryCatch<T>(Action<T> action, T caminho)
        {
            try
            {
                action(caminho);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
