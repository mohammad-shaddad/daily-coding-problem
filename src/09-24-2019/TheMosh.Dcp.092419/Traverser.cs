using System;

namespace TheMosh.Dcp._092419
{
    public class Traverser
    {
        public static int FindLongestPathLength(Tree tree)
        {
            int distanceTravelled = ProcessNode(tree.Root);
            return distanceTravelled;
        }

        private static int ProcessNode(Node node)
        {
            int distanceStartingFromNode = TravelFromNode(node);
            int furthestTravelFromChild = 0;
            if(node.Children != null)
            {
                foreach (Node child in node.Children)
                {
                    int distanceStartingFromChild = ProcessNode(child);
                    if (distanceStartingFromChild > furthestTravelFromChild)
                        furthestTravelFromChild = distanceStartingFromChild;
                }
            }

            return distanceStartingFromNode > furthestTravelFromChild ? distanceStartingFromNode : furthestTravelFromChild;
        }

        private static int TravelFromNode(Node from)
        {
            int furthestViaChild = 0;
            if (from.Children != null && from.Children.Count > 0)
            {
                foreach (Node child in from.Children)
                {
                    int distanceViaChild = TravelSouth(from, child);
                    if (distanceViaChild > furthestViaChild)
                    {
                        furthestViaChild = distanceViaChild;
                    }
                }
            }

            int furthestViaParent = 0;
            if(from.Parent != null)
            {
                furthestViaParent = TravelNorth(from, from.Parent);
            }

            return (furthestViaChild > furthestViaParent) ? furthestViaChild : furthestViaParent;
        }

        private static int TravelSouth(Node from, Node to)
        {
            int distanceTravelled = to.ParentLinkWeight;
            int furthestViaChild = 0;
            if (to.Children != null)
            {
                foreach (Node child in to.Children)
                {
                    int distanceViaChild = TravelSouth(to, child);
                    if (distanceViaChild > furthestViaChild)
                    {
                        furthestViaChild = distanceViaChild;
                    }
                }
            }

            return distanceTravelled + furthestViaChild;
        }

        private static int TravelNorth(Node from, Node to)
        {
            int distanceTravelled = from.ParentLinkWeight;
            int distanceViaParent = 0;

            if (to.Parent != null)
            {
                distanceViaParent = TravelNorth(to, to.Parent);
            }

            int furthestViaChild = 0;
            foreach (Node child in to.Children)
            {
                if (child == from)
                {
                    continue;
                }
                int distanceViaChild = TravelSouth(from, child);
                if (distanceViaChild > furthestViaChild)
                {
                    furthestViaChild = distanceViaChild;
                }
            }

            return distanceTravelled + (furthestViaChild > distanceViaParent ? furthestViaChild : distanceViaParent);
        }
    }
}
