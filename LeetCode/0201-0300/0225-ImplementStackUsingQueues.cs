namespace LeetCode;

public class _0225_ImplementStackUsingQueues
{
    public class MyStack
    {
        private readonly Queue<int> _queue;
        public MyStack()
        {
            _queue = new();
        }

        public void Push(int x)
        {
            _queue.Enqueue(x);
        }

        public int Pop()
        {
            int count = _queue.Count();
            while (count-- > 1)
            {
                _queue.Enqueue(_queue.Dequeue());
            }
            return _queue.Dequeue();
        }

        public int Top()
        {
            var count = _queue.Count();
            while (count-- > 1)
            {
                _queue.Enqueue(_queue.Dequeue());
            }
            var t = _queue.Dequeue();
            _queue.Enqueue(t);
            return t;
        }

        public bool Empty()
        {
            return _queue.Count == 0;
        }
    }
}
