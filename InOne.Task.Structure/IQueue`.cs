namespace InOne.Task.Structure
{
    public interface IQueue<T>
    {
        int Count();
        T Dequeue(); 
        void Enqueue(T data); 
        T Peek(); 
        bool IsEmpty();
        void Reverse();
    }
}
