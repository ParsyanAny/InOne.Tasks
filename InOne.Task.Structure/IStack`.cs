namespace InOne.Task.Structure
{
    public interface IStack<T>
    {
        bool IsEmpty();
        T Peek(); 
        T Pop(); 
        void Push(T data); 
        void Reverse();
        int Count();
    }
}
