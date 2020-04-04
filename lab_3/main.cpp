#include "Triangle.hpp"
#include "Pyramid.hpp"
#include <iostream>

int main()
{
    auto triangle = new Triangle;
    auto pyramid = new Pyramid; 

    std::cout << "Triangle:" << std::endl;
    triangle->show();
    std::cout << std::endl;

    std::cout << "Pyramid:" << std::endl;
    pyramid->show();
    std::cout << std::endl;
     
    // pyramid = triangle;
    // cannot assign pointer on base class to pointer on derived class

    delete triangle;
    triangle = pyramid;

    std::cout << "Assign pointer on pyramid to pointer on triangle and call show method" << std::endl;
    triangle->show();
    
    delete pyramid;
}