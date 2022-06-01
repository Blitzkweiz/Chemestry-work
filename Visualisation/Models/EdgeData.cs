using GraphX.Common.Models;
using Visualisation.Enums;

namespace Visualisation.Models
{
    public class EdgeData : EdgeBase<Vertex>
    {
        public string Text { get; set; }

        public EdgeData(Vertex source, Vertex target, EdgeType edgeType = EdgeType.none, double weight = 1) : base(source, target, weight) 
        {
            Text = edgeType.ToString();
        }

        public EdgeData() : base(null, null, 1) { }

        public override string ToString()
        {
            return Text;
        }
    }
}
