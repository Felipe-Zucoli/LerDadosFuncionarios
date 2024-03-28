using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LerDadosFuncionarios
{
    internal class Dados
    {
        public string name;
        public double salario;
        public double imposto;
        public double bonus;

        public double abateImposto()
        {
            return (salario - imposto);
        }
        public double salarioFinal ()
        {
            double d = (abateImposto()/100)*bonus;
            return abateImposto() + d;
        }
        public override string ToString()
        {
            return "Nome: "+ name+ ", Salario Bruto: " + salario + ", Imposto: " + imposto+ ", Salário líquido: " + abateImposto() + ", Salario Final: " + salarioFinal();
        }
    }
}
