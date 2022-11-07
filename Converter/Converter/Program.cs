using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1
{
    class Program
    {
        class Converter
        {

            double hrn;
            public void SetHrn(double value)
            {
                hrn = value;
            }
            public double GetHrn()
            {
                return hrn;
            }
            double usd;
            public double GetUsd()
            {
                return usd;
            }
            double eur;
            public double GetEur()
            {
                return eur;
            }
            double pln;
            public double GetPln()
            {
                return pln;
            }
            public double nUsd;
            public void SetNUsd(double value)
            {
                nUsd = value;
            }
            public double GetNUsd()
            {
                return nUsd;
            }
            public double MethodUsd(double usd, double hrn, double nUsd)
            {
                nUsd = usd * hrn;
                return nUsd;
            }
            public double MethodEur(double eur, double hrn, double nEur)
            {
                nEur = eur * hrn;
                return nEur;
            }
            public double MethodPln(double pln, double hrn, double nPln)
            {
                nPln = pln * hrn;
                return nPln;
            }
            public Converter(double usd, double eur, double pln, double hrn)
            {
                this.usd = usd;
                this.eur = eur;
                this.pln = pln;
                Console.Write("Введiть суму(грн):");
                this.hrn = Convert.ToDouble(Console.ReadLine());
            }

        }
        static void Main(string[] args)
        {
            Converter money = new Converter(40.62, 42.61, 7.89, 4);
            Console.WriteLine("Курси валют: ");
            Console.WriteLine("Долар: {0}, \nЕвро: {1}, \nЗлоти: {2}, \nВведена сума: {3}", money.GetUsd(), money.GetEur(), money.GetPln(), money.GetHrn());
            money.MethodUsd(40.62, money.GetHrn(), 1);
            Console.WriteLine(money.MethodUsd(40.62, money.GetHrn(), 1));
            money.MethodEur(42.50, money.GetHrn(), 1);
            Console.WriteLine(money.MethodEur(42.61, money.GetHrn(), 1));
            money.MethodPln(7.89, money.GetHrn(), 1);
            Console.WriteLine(money.MethodPln(7.89, money.GetHrn(), 1));
            Console.ReadKey();
        }
    }
}