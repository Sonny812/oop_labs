#include "Pyramid.hpp"

double Pyramid::getHeight()
{
    return this->height;
}

void Pyramid::setHeight(double height)
{
    this->height = height;
}

double Pyramid::volume()
{
    return 1.0 / 3 * this->area() * this->height;
}

Pyramid &Pyramid::operator=(Pyramid &pyramid)
{
    this->firstSide = pyramid.firstSide;
    this->secondSide = pyramid.secondSide;
    this->thirdSide = pyramid.thirdSide;
    this->angle = pyramid.angle;

    return *this;
}

double operator+(Pyramid &leftOp, Pyramid &rightOp)
{
    return leftOp.volume() + rightOp.volume();
}

void Pyramid::show()
{
    Triangle::show();
    std::cout << "Height: " << this->height << std::endl;
    std::cout << "Volume: " << this->volume() << std::endl;
}
