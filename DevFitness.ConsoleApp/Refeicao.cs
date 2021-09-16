using System;

namespace DevFitness.ConsoleApp
{
    public class Refeicao
    {
        public Refeicao(string descricao, int calorias)
        {
            Descricao = descricao;
            Calorias = calorias;
        }

        public string Descricao { get; set; }
        public int Calorias { get; set; }
        public virtual void ImprimirMensagem()
        {
            Console.WriteLine($"{Descricao}, com {Calorias} calorias.");
        }
    }
}