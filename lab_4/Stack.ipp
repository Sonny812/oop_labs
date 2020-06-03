#include "Stack.hpp"
#include <stdexcept>

template <class T>
Stack<T>::Stack(const int &size)
{
    this->index = 0;
    this->maxSize = size;
    this->iternalStorage = new T[size];
}

template <class T>
Stack<T>::~Stack()
{
    delete[] this->iternalStorage;
}

template <class T>
void Stack<T>::push(T const &item)
{
    if (this->isFull())
    {
        throw std::overflow_error("Stack overflow");
    }

    this->iternalStorage[this->index++] = item;
}

template <class T>
T &Stack<T>::pop()
{
    if (this->isEmpty())
    {
        throw std::underflow_error("Stack underflow");
    }

    return this->iternalStorage[--this->index];
}

template <class T>
bool Stack<T>::isEmpty() const
{
    return this->index == 0;
}

template <class T>
bool Stack<T>::isFull() const
{
    return this->index == this->maxSize;
}
