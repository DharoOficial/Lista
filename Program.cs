using System;
using System.Collections.Generic;

namespace lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cartao> Cartoes = new List<cartao>();

            Cartoes.Add(new cartao("Erick", 78236137, "ELO", 2023 , 132));
            Cartoes.Add(new cartao("Erick", 31345544, "VISA" , 2024 , 452));
            Cartoes.Add(new cartao("Erick", 31214412, "MasterCard" , 2026, 754));
            Cartoes.Add(new cartao("Erick", 14124134, "aelo" , 2025, 234));
            Cartoes.Add(new cartao("Erick", 45512321, "VR" , 2026 , 532));

            foreach(cartao p in Cartoes){
                System.Console.WriteLine($" {p.titular} - {p.numero} - {p.bandeira} - {p.vencimento} - {p.cvv} ");
            }





        }
    }
}
