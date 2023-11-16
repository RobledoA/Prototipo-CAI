using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipo_CAI;

internal class CrearReservaModel
{
    public string ValidarCampos(string nombreApellido, string dni, DateTime fechaNac, string nacionalidad, string genero)
    {
        string errores = "";

        //Nombre y Apellido
        if (string.IsNullOrWhiteSpace(nombreApellido))
        {
            errores += "El Nombre y Apellido no debe estar vacío.\n";
        }
        else if(!(Regex.IsMatch(nombreApellido, @"^[a-zA-Z]+$")))
        {
            errores += "El Nombre y Apellido no debe contener caracteres numéricos o símbolos.\n";
            
        }
        if (nombreApellido.Length > 45)
        {
            errores += "El Nombre y Apellido no puede tener más de 45 caracteres.\n";
        }
        //DNI
        if (string.IsNullOrWhiteSpace(dni))
        {
            errores += "El DNI no debe estar vacío.\n";
        }
        if (dni.Length < 7 || dni.Length > 8)
        {
            errores += "El DNI debe tener entre 7 y 8 dígitos.\n";
        }
        if (!int.TryParse(dni, out int salida))
        {
            errores += "El DNI debe ser numérico.";
        }
        //Fecha de Nacimiento
        if (fechaNac > DateTime.Now)
        {
            errores += "La Fecha de Nacimiento debe ser menor a la fecha actual.";
        }
        //Nacionalidad
        if(string.IsNullOrWhiteSpace(nacionalidad))
        {
            errores += "La Nacionalidad no debe estar vacía.\n";
        }
        //Género
        if (string.IsNullOrWhiteSpace(genero))
        {
            errores += "El Género no debe estar vacía.\n";
        }

        return errores;
    }
}
