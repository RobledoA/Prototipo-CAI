using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class CrearReservaModel
{
    public string ValidarCampos(string nombreApellido, string dni, string nroPas, DateTime fechaNac, string nacionalidad, string genero)
    {
        string errores = "";

        if (string.IsNullOrWhiteSpace(nombreApellido))
        {
            errores += "El campo Nombre y Apellido no debe estar vacío.\n";
        }
        if (nombreApellido.Length > 45)
        {
            errores += "El campo Nombre y Apellido no puede tener más de 45 caracteres.\n";
        }
        if (!(Regex.IsMatch(nombreApellido, @"^[a-zA-Z]+$")))
        {
            errores += "El campo Nombre y Apellido no debe ser numérico.\n";
        }
        if()
        {

        }




        /*
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
        }*/

        return errores;
    }
}
