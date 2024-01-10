using LeetCode.DiscreteMathematics;

namespace LeetCode;

public class _2385_AmountOfTimeForBinaryTreeToBeInfected
{
    public int AmountOfTime(TreeNode root, int start)
    {
        Graph<int> graph = ConvertTreeToGraph(root);
        var startNode = graph.Vertices.Single(v => v.Value == start);

        return Distances(graph, startNode).Max();
    }

    private IEnumerable<int> Distances(Graph<int> graph, Vertex<int> startNode)
    {
        var queue = new Queue<(Vertex<int> v, int depth)>();
        var visited = new HashSet<Vertex<int>>();
        queue.Enqueue((startNode, 0));

        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            visited.Add(item.v);
            bool allVisited = true;
            foreach (var edge in item.v.Edges)
            {
                if (visited.Contains(edge.End)) continue;
                queue.Enqueue((edge.End, item.depth + 1));
                allVisited = false;
            }
            if (allVisited) yield return item.depth;
        }
    }

    private Graph<int> ConvertTreeToGraph(TreeNode root)
    {
        var graph = new Graph<int>();
        var map = new Dictionary<TreeNode, Vertex<int>>();
        if (root is null) return graph;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node is null) continue;

            var vertexA = GetOrCreateVertex(map, node, graph);
            var vertexLeft = GetOrCreateVertex(map, node.left, graph);
            var vertexRight = GetOrCreateVertex(map, node.right, graph);
            if (vertexA is not null && vertexLeft is not null)
            {
                graph.AddEdge(vertexA, vertexLeft);
                graph.AddEdge(vertexLeft, vertexA);
            }

            if (vertexA is not null && vertexRight is not null)
            {
                graph.AddEdge(vertexA, vertexRight);
                graph.AddEdge(vertexRight, vertexA);
            }

            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        return graph;
    }

    private Vertex<int> GetOrCreateVertex(Dictionary<TreeNode, Vertex<int>> map, TreeNode node, Graph<int> G)
    {
        if (node is null) return null;
        if (map.ContainsKey(node))
            return map[node];
        var vertex = G.AddVertex(node.val);
        map.Add(node, vertex);
        return vertex;
    }
}
