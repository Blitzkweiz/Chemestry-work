using QuickGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using Visualisation.Enums;

namespace Visualisation.Models
{
    public class GraphModel : BidirectionalGraph<Vertex, EdgeData>
    {
        public readonly List<Ligands> baseLigands = new List<Ligands>()
        {
            //new Ligands(new Radical(new NodeRadical(2,5)),new Radical(new NodeRadical(1, 0, 3)), 1000),
            new Ligands(new Radical(new NodeRadical(1), new NodeRadical(1, 3), new NodeRadical(1, 3), new NodeRadical(1, 3)), new Radical(new NodeRadical(3, 0, 7)), 994),
            //new Ligands(new Radical(new NodeRadical(1,1),new NodeRadical(1, 3),new NodeRadical(1,3)),new Radical(new NodeRadical(1, 0, 3)), 963),
            //new Ligands(new Radical(new NodeRadical(1), new NodeRadical(1, 3), new NodeRadical(1, 3), new NodeRadical(1, 3)), new Radical(new NodeRadical(1, 0, 3)), 949),
            new Ligands(new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), 942),
            
            //new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)),938 ),
            //new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(1,0,3)), 898),
            new Ligands(new Radical(new NodeRadical(2,5)), new Radical(new NodeRadical(2,5)), 892),
            new Ligands(new Radical(new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1,3)), 870 ),
            new Ligands(new Radical(new NodeRadical(1,3)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)),862),

            new Ligands(new Radical(new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)),852),
            new Ligands(new Radical(new NodeRadical(1,3)), new Radical(new NodeRadical(3,7)),817 ),
            new Ligands(new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)),790),
            new Ligands(new Radical(new NodeRadical(1,3)), new Radical(new NodeRadical(1,3)),671),
            //new Ligands(new Radical(new NodeRadical(1,3)), new Radical(new NodeRadical(1,0,3)),758),

            new Ligands(new Radical(new NodeRadical(1,3)), new Radical(new NodeRadical(2,5)),603),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(1,0,3)), 600),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(1, 3)),572),
            //new Ligands(new Radical(new NodeRadical(4,3,0,0,0,1)), new Radical(new NodeRadical(1,0,3)),537 ),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,0,1)), new Radical(new NodeRadical(1,3)),532),

            //new Ligands(new Radical(new NodeRadical(6,5)), new Radical(new NodeRadical(1,0,3)), 502),
            //new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(1,0,3)),486 ),
            new Ligands(new Radical(new NodeRadical(6,5)), new Radical(new NodeRadical(1,3)),407 ),
            new Ligands(new Radical(new NodeRadical(6,5)), new Radical(new NodeRadical(6,5)),312 ),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(4,3,0,0,1)),202 ),

            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(1,3)), 53),
            new Ligands(new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), new Radical(new NodeRadical(2,5)), 917),
            new Ligands(new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), 866),
            new Ligands(new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(2,5)),841 ),
            new Ligands(new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), new Radical(new NodeRadical(6,5)),627 ),

            new Ligands(new Radical(new NodeRadical(6,5)), new Radical(new NodeRadical(2,5)),602 ),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), 572),
            new Ligands(new Radical(new NodeRadical(6,5)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), 551),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(2,5)), 547),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), 496),

            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(6,5)), 257),
            //new Ligands(new Radical(new NodeRadical(3,0,7)), new Radical(new NodeRadical(3,0,7)), 1198),
            new Ligands(new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), 978),
            new Ligands(new Radical(new NodeRadical(3,7)), new Radical(new NodeRadical(3,7)), 963),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(4,3,0,1)), 473),

            //new Ligands(new Radical(new NodeRadical(4,3,0,0,0,1)), new Radical(new NodeRadical(4,3,0,0,0,1)), 393 ),
            //new Ligands(new Radical(new NodeRadical(2,5)), new Radical(new NodeRadical(3,0,7)), 1090 ),
            //new Ligands(new Radical(new NodeRadical(3,0,7)), new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), 1088),
            //new Ligands(new Radical(new NodeRadical(3,0,7)), new Radical(new NodeRadical(3,0,7)), 1081),
            //new Ligands(new Radical(new NodeRadical(3,0,7)), new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), 1070),

            //new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(3,0,7)), 1048),
            //new Ligands(new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(3,0,7)), 971),
            //new Ligands(new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), new Radical(new NodeRadical(3,0,7)), 953),
            new Ligands(new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(2,5)), 935),
            //new Ligands(new Radical(new NodeRadical(1,3)), new Radical(new NodeRadical(3,0,7)), 935),

            //new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(1,0,3)), 931),
            new Ligands(new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), 884),
            //new Ligands(new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1,0,3)), 877),
            //new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(4,3,0,1)), 836),
            new Ligands(new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(1,3)), 825),

            new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(4,3,0,0,0,1)), 796),
            new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(6,5)), 755),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), 726),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(1,0,3)), 718),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), 708),

            //new Ligands(new Radical(new NodeRadical(1,0,3)), new Radical(new NodeRadical(4,3,0,0,1)), 700),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,0,1)), new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), 686),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(2,5)), 683),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,0,1)), new Radical(new NodeRadical(4,3,0,0,0,1)), 678),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,0,1)), new Radical(new NodeRadical(1,1), new NodeRadical(1, 3), new NodeRadical(1, 3)), 668),

            new Ligands(new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), new Radical(new NodeRadical(6,5)), 645),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(2,5)), 643),
            //new Ligands(new Radical(new NodeRadical(6,5)), new Radical(new NodeRadical(3,0,7)), 638),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), 632),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), 592),

            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(1,2),new NodeRadical(1,1),new NodeRadical(1,3),new NodeRadical(1,3)), 590),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(3,7)), 583),
            new Ligands(new Radical(new NodeRadical(6,5)), new Radical(new NodeRadical(1),new NodeRadical(1,3),new NodeRadical(1,3),new NodeRadical(1,3)), 551),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(4,3,0,0,0,1)), 433),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(6,5)), 395),

            new Ligands(new Radical(new NodeRadical(4,3,0,0,0,1)), new Radical(new NodeRadical(6,5)), 353),
            new Ligands(new Radical(new NodeRadical(4,3,0,1)), new Radical(new NodeRadical(4,3,0,0,1)), 338),
            new Ligands(new Radical(new NodeRadical(4,3,0,0,1)), new Radical(new NodeRadical(4,3,0,0,0,1)), 298),
        };

        public GraphModel()
        {
            FillVertecies();
            CreateEdges();
        }

        private void FillVertecies()
        {
            List<Ligands> ligands = new List<Ligands>();
            foreach (var l in baseLigands)
            {
                ligands.AddRange(l.Degrote());
            }

            var length = ligands.Count();
            foreach (Metals Me in Enum.GetValues(typeof(Metals)))
            {
                for (int i = 0; i < length; i++)
                {
                    for (int j = i; j < length; j++)
                    {
                        AddVertex(new Vertex(ligands[i], ligands[j], Me));
                    }
                }
            }
        }
        
        private void CreateEdges()
        {
            for (int i = 0; i < Vertices.Count(); i++)
            {
                for (int j = i; j < Vertices.Count(); j++)
                {
                    var edgeType = TypeOfEdge(Vertices.ElementAt(i), Vertices.ElementAt(j));
                    if (edgeType != Enums.EdgeType.none)
                    {
                        AddEdge(new EdgeData(Vertices.ElementAt(i), Vertices.ElementAt(j), edgeType));
                    }
                }
            }
        }

        private EdgeType TypeOfEdge(Vertex el1, Vertex el2)
        {
            if ((el1.Ligand1.Equals(el2.Ligand1) && el1.Ligand2.Equals(el2.Ligand2) && (el1.Metal != el2.Metal)) ||
                (el1.Ligand1.Equals(el2.Ligand2) && el1.Ligand2.Equals(el2.Ligand1) && (el1.Metal != el2.Metal)))
            {
                return Enums.EdgeType.B;
            }
            else if ((el1.Ligand1.Equals(el2.Ligand1)))
            {
                if (el1.Ligand2.R1.Equals(el2.Ligand2.R1))
                {
                    if (el1.Ligand2.R2.IsDegroteOf(el2.Ligand2.R2) ||
                        el2.Ligand2.R2.IsDegroteOf(el1.Ligand2.R2))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                else if (el1.Ligand2.R2.Equals(el2.Ligand2.R2))
                {
                    if (el1.Ligand2.R1.IsDegroteOf(el2.Ligand2.R1) ||
                        el2.Ligand2.R1.IsDegroteOf(el1.Ligand2.R1))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                else if (el1.Ligand2.R1.Equals(el2.Ligand2.R2))
                {
                    if (el1.Ligand2.R2.IsDegroteOf(el2.Ligand2.R1) ||
                        el2.Ligand2.R1.IsDegroteOf(el1.Ligand2.R2))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                else if (el1.Ligand2.R2.Equals(el2.Ligand2.R1))
                {
                    if (el1.Ligand2.R1.IsDegroteOf(el2.Ligand2.R2) ||
                        el2.Ligand2.R2.IsDegroteOf(el1.Ligand2.R1))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                return Enums.EdgeType.none;
            }
            else if ((el1.Ligand2.Equals(el2.Ligand2)))
            {
                if (el1.Ligand1.R1.Equals(el2.Ligand1.R1))
                {
                    if (el1.Ligand1.R2.IsDegroteOf(el2.Ligand1.R2) ||
                        el2.Ligand1.R2.IsDegroteOf(el1.Ligand1.R2))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                else if (el1.Ligand1.R2.Equals(el2.Ligand1.R2))
                {
                    if (el1.Ligand1.R1.IsDegroteOf(el2.Ligand1.R1) ||
                        el2.Ligand1.R1.IsDegroteOf(el1.Ligand1.R1))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                else if (el1.Ligand1.R1.Equals(el2.Ligand1.R2))
                {
                    if (el1.Ligand1.R2.IsDegroteOf(el2.Ligand1.R1) ||
                        el2.Ligand1.R1.IsDegroteOf(el1.Ligand1.R2))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                else if (el1.Ligand1.R2.Equals(el2.Ligand1.R1))
                {
                    if (el1.Ligand1.R1.IsDegroteOf(el2.Ligand1.R2) ||
                        el2.Ligand1.R2.IsDegroteOf(el1.Ligand1.R1))
                    {
                        return Enums.EdgeType.C;
                    }
                    else return Enums.EdgeType.A;
                }
                return Enums.EdgeType.none;
            }

            return Enums.EdgeType.none;
        }
    }
}
