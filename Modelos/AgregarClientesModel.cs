using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class AgregarClientesModel
{
    public static string ValidarCampos(string nombreRZ, string cuilcuit)
    {
        string errores = "";

        if (string.IsNullOrWhiteSpace(nombreRZ))
        {
            errores += "El campo Nombre/Razón Social no debe estar vacío.\n";
        }
        if (nombreRZ.Length > 30)
        {
            errores += "El campo Nombre/Razón Social debe tener menos de 30 caracteres.\n";
        }
        if (string.IsNullOrWhiteSpace(cuilcuit))
        {
            errores += "El campo CUIL/CUIT no debe estar vacío.\n";
        }
        if (!long.TryParse(cuilcuit, out long salida))
        {
            errores += "El campo CUIL/CUIT debe ser un número.\n";
        }
        if (cuilcuit.Length != 11)
        {
            errores += "El campo CUIL/CUIT debe tener 11 dígitos.\n";
        }

        return errores;
    }
}
