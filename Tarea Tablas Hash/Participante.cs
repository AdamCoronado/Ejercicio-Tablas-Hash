using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Tablas_Hash
{
    public class Participante
    {
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public int edad {  get; set; }
        public string sexo { get; set; }
        public string fechaNacimiento { get; set; }
        public string categoria { get; set; }
        public Participante(string pNombre, string pApellido, int pEdad, string pSexo, string pFechaNacimiento, string pCategoria) 
        {
            nombre = pNombre;
            apellido = pApellido;
            edad = pEdad;
            sexo = pSexo;
            fechaNacimiento = pFechaNacimiento;
            categoria = pCategoria;
        }
    }
}
