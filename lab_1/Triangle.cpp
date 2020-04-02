#include <cmath>
#include "Triangle.hpp"

Triangle::Triangle()
{
    this->firstSide = 3;
    this->secondSide = 4;
    this->angle = 90;

    this->calculateThirdSide();
}

Triangle::Triangle(double firstSide, double secondSide, double angle)
{
    this->firstSide = firstSide;
    this->secondSide = secondSide;
    this->angle = angle;

    this->calculateThirdSide();
}

double Triangle::getFirstSide()
{
    return this->firstSide;
}

void Triangle::setFirstSide(double length)
{
    this->firstSide = length;

    this->calculateThirdSide();
}

double Triangle::getSecondSide()
{
    return this->secondSide;
}

void Triangle::setSecondSide(double length)
{
    this->secondSide = length;

    this->calculateThirdSide();
}

double Triangle::getThirdSide()
{
    return this->thirdSide;
}

double Triangle::getAngle()
{
    return this->angle;
}

void Triangle::setAngle(double angle)
{
    this->angle = angle;
}

void Triangle::calculateThirdSide()
{
    auto radians = (this->angle * M_PI) / 180;
    
    this->thirdSide = sqrt(
        this->firstSide * this->firstSide +
        this->secondSide * this->secondSide -
        2 * this->firstSide * this->secondSide * cos(radians)
    );
}

double Triangle::perimeter()
{
    return this->firstSide + this->secondSide + this->thirdSide;
}

double Triangle::area()
{
    // Heron's formula
    auto halfPerimeter = this->perimeter() / 2;

    return sqrt(
        halfPerimeter *
        (halfPerimeter - this->firstSide) *
        (halfPerimeter - this->secondSide) *
        (halfPerimeter - this->thirdSide)
    );
}

Triangle Triangle::operator*(double number)
{
    return Triangle(this->firstSide * number, this->secondSide * number, this->angle);
}

Triangle Triangle::operator+(double number)
{
    return Triangle(this->firstSide + number, this->secondSide + number, this->angle);
}

Triangle Triangle::operator++()
{
    this->firstSide++;
    this->secondSide++;

    this->calculateThirdSide();

    return *this;
}

Triangle Triangle::operator++(int)
{
    auto that(*this);

    this->operator++();

    return that;
}

Triangle Triangle::operator--()
{
    auto that(*this);

    this->firstSide--;
    this->secondSide--;

    this->calculateThirdSide();

    return that;
}

Triangle operator--(Triangle &triangle, int)
{
    auto temp(triangle);

    --triangle;

    return temp;
}
