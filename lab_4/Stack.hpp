#pragma once

template <class T>
class Stack
{
private:
    int maxSize;
    int index;
    T *iternalStorage;

public:
    Stack(const int &size);
    ~Stack();
    void push(T const &item);
    T& pop();
    bool isFull() const;
    bool isEmpty() const;
};

#include "Stack.ipp"
