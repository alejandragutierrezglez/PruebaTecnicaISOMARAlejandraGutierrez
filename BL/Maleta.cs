using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Maleta
    {
        public static ML.Result Add(ML.Maleta maleta)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.PruebaTecnicaISOMARCAPITALEntities context = new DL.PruebaTecnicaISOMARCAPITALEntities())
                {

                    var query = context.MaletaAdd(maleta.Id, maleta.Modelo, maleta.Marca, maleta.Altura, maleta.Ancho, maleta.Unidad);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
            }
            catch (Exception Ex)
            {
                result.Correct = false;
                result.ErrorMessage = Ex.Message;
                result.Ex= Ex;
            }
            return result;
        }
    }
}
