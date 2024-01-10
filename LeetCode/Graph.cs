namespace LeetCode.DiscreteMathematics;

public class Graph<T>
{
    private readonly HashSet<Vertex<T>> _vertices = new();
    private readonly HashSet<Edge<T>> _edges = new();

    public Graph()
    {
    }

    public IReadOnlyCollection<Vertex<T>> Vertices => _vertices;

    public IReadOnlyCollection<Edge<T>> Edges => _edges;

    public Vertex<T> AddVertex(T value)
    {
        var v = new Vertex<T>(value);
        _vertices.Add(v);
        return v;
    }

    public void AddEdge(Vertex<T> a, Vertex<T> b)
    {
        AddEdge(a, b, 0);
    }
    public void AddEdge(Vertex<T> from, Vertex<T> to, int weight)
    {
        var e = new Edge<T>(from, to, weight);
        _edges.Add(e);
        from.AttachEdge(e);
    }
}

public class Vertex<T>
{
    private readonly HashSet<Edge<T>> _edges = new();

    public Vertex(T value)
    {
        Value = value;
    }

    public T Value { get; init; }
    public IReadOnlyCollection<Edge<T>> Edges => _edges;
    public void AttachEdge(Edge<T> edge)
    {
        _edges.Add(edge);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

public class Edge<T> : IEquatable<Edge<T>>
{
    public Edge(Vertex<T> start, Vertex<T> end) : this(start, end, 0)
    {
    }

    public Edge(Vertex<T> start, Vertex<T> end, int weight)
    {
        Start = start;
        End = end;
        Weight = weight;
    }

    public Vertex<T> Start { get; init; }
    public Vertex<T> End { get; init; }
    public int Weight { get; init; }

    public bool Equals(Edge<T> other)
    {
        if (other is null) return false;
        return Start.Equals(other.Start) && End.Equals(other.End);
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Edge<T>);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start.GetHashCode(), End.GetHashCode());
    }

    public override string ToString()
    {
        return string.Format("{0}->{1}", Start, End);
    }
}
