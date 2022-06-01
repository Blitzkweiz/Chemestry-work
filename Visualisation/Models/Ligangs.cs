using System;
using System.Collections.Generic;

namespace Visualisation.Models
{
    public class Ligands
    {
        public Radical R1 { get; private set; }
        public Radical R2 { get; private set; }
        public double VLC { get; private set; }

        public Ligands(Radical r1, Radical r2)
        {
            R1 = r1;
            R2 = r2;
        }

        public Ligands(Radical r1, Radical r2, double volatility)
        {
            R1 = r1;
            R2 = r2;
            this.VLC = volatility;
        }

        public static void Print(Ligands[] array)
        {
            var i = 1;
            foreach (Ligands l in array)
            {
                Console.WriteLine($"Ligand {i}: {l.ToString()}");
                i++;
            }
        }

        public override string ToString()
        {
            return $"R1 = {this.R1.ToString()}, R2 = {this.R2.ToString()}, VLC = {VLC}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Ligands l)
            {
                return ((l.R1.Equals(R1)) && (l.R2.Equals(R2))) || ((l.R1.Equals(R2)) && (l.R2.Equals(R1)));
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public List<Ligands> Degrote()
        {
            List<Ligands> arrayWithF = new List<Ligands>();
            var arrayFromR1 = R1.DegroteRadical();
            var arrayFromR2 = R2.DegroteRadical();

            var count1 = arrayFromR1.Count;
            var count2 = arrayFromR2.Count;
            if (R1.Equals(R2))
            {
                for (int i = 0; i < count1; i++)
                {
                    for (int j = i; j < count2; j++)
                    {
                        arrayWithF.Add(new Ligands(arrayFromR1[i], arrayFromR2[j], VLC));
                    }
                }
            }
            else
            {
                for (int i = 0; i < count1; i++)
                {
                    for (int j = 0; j < count2; j++)
                    {
                        arrayWithF.Add(new Ligands(arrayFromR1[i], arrayFromR2[j], VLC));
                    }
                }
            }

            return arrayWithF;
        }

    }
}
