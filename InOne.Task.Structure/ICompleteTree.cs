namespace InOne.Task.Structure
{
    public interface ICompleteTree<T>
    {
        void Add(T data);
        T RemoveMin();
        T GetMin();
        T[] ToArray();
    }
}
