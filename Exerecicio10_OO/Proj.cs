using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerecicio10_OO
{
    public class Class1
    {
#region Propriedades
        float salario { get; set;}
        int numero_filhos { get; set; }         
        String nome { get; set; }
#endregion
    }

    public override string ToString()
    {
        return "Salario :" +this.salario + "\n Numero Filhos"+ this.ToString
    }               
}
