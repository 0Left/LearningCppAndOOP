using System;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            PF pf = new PF();
            pf.taxaEmprestimo(1000);

            PJ pj = new PJ();
            pj.taxaEmprestimo(1000);
        }
    }
}