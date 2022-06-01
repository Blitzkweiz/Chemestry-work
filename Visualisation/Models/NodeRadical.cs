namespace Visualisation.Models
{
    public class NodeRadical
    {
        public int NumOfC { get; set; }
        public int NumOfH { get; set; }
        public int NumOfF { get; set; }
        public int NumOfO { get; set; }
        public int NumOfS { get; set; }
        public int NumOfSe { get; set; }
        public NodeRadical(int numOfC = 0, int numOfH = 0, int numOfF = 0, int numOfO = 0, int numOfS = 0, int numOfSe = 0)
        {
            NumOfC = numOfC;
            NumOfH = numOfH;
            NumOfF = numOfF;
            NumOfO = numOfO;
            NumOfS = numOfS;
            NumOfSe = numOfSe;
        }

        public void Degrote()
        {
            if (NumOfH > 0)
            {
                NumOfH--;
                NumOfF++;
            }
        }

        public override string ToString()
        {
            string countC = $"C{this.NumOfC}";
            string countFandH ="";
            if (this.NumOfH > 0 && this.NumOfF > 0)
            {
                countFandH = $"H{this.NumOfH}F{this.NumOfF}";
            }
            else if (this.NumOfH > 0)
            {
                countFandH = $"H{this.NumOfH}";
            }
            else if(this.NumOfF > 0)
            {
                countFandH = $"F{this.NumOfF}";
            }

            string countOthers = "";
            if (this.NumOfO > 0)
            {
                countOthers = $"O{this.NumOfO}";            
            }
            else if (this.NumOfS > 0)
            {
                countOthers = $"S{this.NumOfS}";
            }
            else if (this.NumOfSe > 0)
            {
                countOthers = $"Se{this.NumOfSe}";
            }
           
                return countC+countFandH+countOthers;
        }

        public override bool Equals(object obj)
        {
            if (obj is NodeRadical nd)
            {
                return ((nd.NumOfC == NumOfC) && (nd.NumOfH == NumOfH) && 
                    (nd.NumOfF == NumOfF) && (nd.NumOfO == NumOfO) && 
                    (nd.NumOfS == NumOfS) && (nd.NumOfSe == NumOfSe));
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
