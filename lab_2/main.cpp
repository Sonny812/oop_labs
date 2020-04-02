#include "Pyramid.hpp"
#include <iostream>

void printPyramid(Pyramid &pyramid);

int main()
{
    Pyramid pyramids[] = {
        Pyramid(),
        Pyramid(14, 15, 90, 100),
    };

    std::cout << "First pyramid:" << std::endl;
    printPyramid(pyramids[0]);
    std::cout << "Volume: " << pyramids[0].Volume() << std::endl;
    std::cout << std::endl;

    std::cout << "Second pyramid:" << std::endl;
    printPyramid(pyramids[1]);
    std::cout << "Volume: " << pyramids[1].Volume() << std::endl;
    std::cout << std::endl;

    std::cout << "Sum of pyramids volumes: " << pyramids[0] + pyramids[1] << std::endl;
    std::cout << std::endl;

    pyramids[0] = pyramids[1];
    std::cout << "First pyramid after it was assigned the second" << std::endl;
    printPyramid(pyramids[0]);
}

void printPyramid(Pyramid &pyramid)
{
    std::cout << "First side: " << pyramid.getFirstSide() << std::endl;
    std::cout << "Second side: " << pyramid.getSecondSide() << std::endl;
    std::cout << "Third side: " << pyramid.getThirdSide() << std::endl;
    std::cout << "Angle: " << pyramid.getAngle() << std::endl;
    std::cout << "Height: " << pyramid.getHeight() << std::endl;
}
