using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElevador
{
    internal class Elevador
    {
        private int CapacidadeElevador {  get; set; }
        private int TotalAndares { get; set; }

        int andarAtual;

        int totalElevador;

        public Elevador(int capacidadeElevador, int totalAndares) 
        {
            CapacidadeElevador = capacidadeElevador;
            TotalAndares = totalAndares;
            andarAtual = 0;
            totalElevador = 0;
        }

        public void Entrar(int entrar)
        {
            if (entrar <=  CapacidadeElevador)
            {
                totalElevador += entrar;
                Console.WriteLine("Concluído!");
            }
            else
            {
                Console.WriteLine("Sem capacidade!");
            }
        }

        public void Sair(int sair)
        {
            if(sair <= CapacidadeElevador)
            {
                totalElevador -= sair;
            }
            else
            {
                Console.WriteLine("O valor ultrapassou!");
            }
        }

        public void Subir(int subir)
        {
            if (andarAtual + subir <= TotalAndares)
            {
                andarAtual += subir;
                Console.WriteLine("Subiu {0} andares", subir);
            }
            else
            {
                Console.WriteLine("Não é possível subir além do último andar!");
            }     
        }

        public void Descer(int descer)
        {
            if (andarAtual + descer <= TotalAndares)
            {
                andarAtual -= descer;
                Console.WriteLine("Desceu {0} andares", descer);
            }
            else
            {
                Console.WriteLine("Não é possível descer além do térreo!");
            }
        }

        public void Deslocar(int andarDestino)
        {
            if (andarDestino > andarAtual)
            {
                Subir(andarDestino - andarAtual);
            }
            else if (andarDestino < andarAtual)
            {
                Descer(andarDestino + andarAtual);
            }
            else
            {
                Console.WriteLine("O elevador já está no andar desejado.");
            }
        }

        ~Elevador() { }
    }
}
