#include "Stack.hpp"
#include "../lab_1/Triangle.hpp"
#include <iostream>

int main()
{
    auto stackOfInts = Stack<int>(5);

    for (int i = 0; i < 10; i++)
    {
        if (!stackOfInts.isFull())
        {
            stackOfInts.push(i);
        }
    }

    std::cout << "Elements in stack of ints:" << std::endl;
    while (!stackOfInts.isEmpty())
    {
        std::cout << stackOfInts.pop() << std::endl;
    }
    std::cout << std::endl;

    auto stackOfFloats = Stack<float>(3);
    stackOfFloats.push(1.1);
    stackOfFloats.push(-3.1);
    stackOfFloats.push(0);

    std::cout << "Elements in stack of floats:" << std::endl;
    while (!stackOfFloats.isEmpty())
    {
        std::cout << stackOfFloats.pop() << std::endl;
    }
    std::cout << std::endl;

    auto stackOfObjects = Stack<Triangle>(3);
    stackOfObjects.push(Triangle());
    stackOfObjects.push(Triangle(10, 15, 40));
    stackOfObjects.push(Triangle(10, 20, 30));

    std::cout << "Triangles and their areas in stack of objects:" << std::endl;
    while (!stackOfObjects.isEmpty())
    {
        auto &trinagle = stackOfObjects.pop();
        std::cout
            << "a = " << trinagle.getFirstSide()
            << ", b = " << trinagle.getSecondSide()
            << ", c = " << trinagle.getThirdSide()
            << ". Area: " << trinagle.area() << std::endl;
    }
}