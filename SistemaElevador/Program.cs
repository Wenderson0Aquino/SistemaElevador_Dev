using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador(10, 20);
            elevador.Entrar(3);
            Elevador().Subir(2);
            elevador.Descer(1);
            elevador.Deslocar(5);
            elevador.Sair(2);
            Console.ReadKey();
        }
    }
}
