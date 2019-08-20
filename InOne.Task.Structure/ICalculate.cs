using InOne.Task.Structure.IMPL;

namespace InOne.Task.Structure
{
    public interface ICalculate
    {
        MyLinkedList<int> Sum(int first, int second);
        MyLinkedList<int> Subtraction(int first, int second);
        MyLinkedList<int> Multiplication(int first, int second);
        MyLinkedList<int> Division(int first, int second);
    }
}
