using System;
using System.Collections.Generic;
using System.Linq;

namespace Visualisation.Models
{
    public class Radical: ICloneable
    {
        public List<NodeRadical> NodeRadicals { get; set; }
        public int SumOfC { get; set; } = 0;
        public int SumOfH { get; set; } = 0;
        public int SumOfF { get; set; } = 0;
        public int SumOfO { get; set; } = 0;
        public int SumOfS { get; set; } = 0;
        public int SumOfSe { get; set; } = 0;

        public Radical (params NodeRadical[] nodes)
        {
            NodeRadicals = new List<NodeRadical>();
            foreach (var nodeRadical in nodes)
            {
                Add(nodeRadical);
            }
        }

        private void Add(NodeRadical node)
        {
            NodeRadicals.Add(node);
            SumOfC += node.NumOfC;
            SumOfH += node.NumOfH;
            SumOfF += node.NumOfF;
            SumOfO += node.NumOfO;
            SumOfS += node.NumOfS;
            SumOfSe += node.NumOfSe;
        }

        public object Clone()
        {
            var newRadical = new Radical();
            foreach(var node in NodeRadicals)
            {
                newRadical.Add(new NodeRadical(node.NumOfC, node.NumOfH, node.NumOfF, node.NumOfO, node.NumOfS, node.NumOfSe));
            }
            return newRadical;
        }

        public override string ToString()
        {
            var count = NodeRadicals.ToArray().Length;
            string result = NodeRadicals[0].ToString();
            for (int i = 1; i < count; i++ )
            {
                result +=("-" + NodeRadicals[i].ToString());
            }
            return result;
        }

        public List<Radical> DegroteRadical()
        {
            List<Radical> radicals = new List<Radical> { (Radical)this.Clone() };
            foreach (NodeRadical node in NodeRadicals)
            {
                while (node.NumOfH > 0)
                {
                    node.Degrote();
                    Radical temp = (Radical)this.Clone();
                    radicals.Add(temp);
                }
            }
            return radicals;
        }

        public override bool Equals(object obj)
        {
            if (obj is Radical rad)
            {
                return ((rad.NodeRadicals.SequenceEqual(NodeRadicals)));
            }
            return false;
        }
    }
}
