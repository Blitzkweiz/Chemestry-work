using GraphX.Common.Models;
using Visualisation.Enums;

namespace Visualisation.Models
{
    public class Vertex : VertexBase
    {
        public Ligands Ligand1 { get; private set; }
        public Ligands Ligand2 { get; private set; }
        public Metals Metal { get; private set; }
        public double SVC { get; private set; }

        public Vertex(Ligands l1, Ligands l2, Metals me)
        {
            Ligand1 = l1;
            Ligand2 = l2;
            Metal = me;
            this.SVC = CalculateVolatility(l1, l2);

        }
        public override string ToString()
        {
            return $"Metal = {Metal}; " +
                  $"Ligand1: {Ligand1}; " +
                  $"Ligand2: {Ligand2}; " +
                  $"Volatility = {SVC}";
        }



        public double CalculateVolatility(Ligands l1, Ligands l2)
        {
            double ML1 = 12.011 * (l1.R1.SumOfC + l1.R2.SumOfC) +
               1.008 * (l1.R1.SumOfH + l1.R2.SumOfH) +
               18.9984 * (l1.R1.SumOfF + l1.R2.SumOfF) +
               15.999 * (l1.R1.SumOfO + l1.R2.SumOfO) +
               32.06 * (l1.R1.SumOfS + l1.R2.SumOfS) +
               78.971 * (l1.R1.SumOfSe + l1.R2.SumOfSe);//молярная масса первого лиганда
            double ML2 = 12.011 * (l2.R1.SumOfC + l2.R2.SumOfC) +
               1.008 * (l2.R1.SumOfH + l2.R2.SumOfH) +
               18.9984 * (l2.R1.SumOfF + l2.R2.SumOfF) +
               15.999 * (l2.R1.SumOfO + l2.R2.SumOfO) +
               32.06 * (l2.R1.SumOfS + l2.R2.SumOfS) +
               78.971 * (l2.R1.SumOfSe + l2.R2.SumOfSe);//молярная масса второго лиганда
            double MH = MolarMassMetal() + ML1 + ML2;//молярная масса всего вещества
            var countF = l1.R1.SumOfF + l1.R2.SumOfF + l2.R1.SumOfF + l2.R2.SumOfF;
            SVC = (l1.VLC + l2.VLC) / 2 - 100 * MH / (ML1 + ML2) + (5 * countF + countF * countF);
            return SVC;
        }
        private double MolarMassMetal()
        {
            switch (this.Metal)
            {
                case Metals.Ba: return 137.327;
                case Metals.Be: return 9.01218;
                case Metals.Mg: return 24.305;
                case Metals.Ca: return 40.078;
                case Metals.Zn: return 65.38;
                case Metals.Sr: return 87.62;
                case Metals.V: return 50.9415;
                case Metals.Fe: return 55.8458;
                case Metals.Co: return 58.9332;
                case Metals.Ni: return 58.6932;
                case Metals.Cu: return 63.5467;
                case Metals.Mo: return 95.95;
                case Metals.Tc: return 98.0;
                case Metals.Ru: return 101.078;
                case Metals.Rh: return 102.906;
                case Metals.Pd: return 106.42;
                case Metals.Ta: return 180.948;
                case Metals.W: return 183.84;
                case Metals.Re: return 186.207;
                case Metals.Os: return 190.23;
                case Metals.Pt: return 195.084;
            }
            return 0;
        }
    }
}
