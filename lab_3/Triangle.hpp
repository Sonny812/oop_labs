#pragma once

#include <iostream>

class Triangle
{
protected:
    double firstSide;
    double secondSide;
    double thirdSide;
    double angle;
    void calculateThirdSide();

public:
    Triangle();
    Triangle(double firstSide, double secondSide, double angle);
    virtual ~Triangle(){};
    double getFirstSide();
    void setFirstSide(double length);
    double getSecondSide();
    void setSecondSide(double length);

    double getThirdSide();

    double getAngle();
    void setAngle(double angle);

    double area();
    double perimeter();

    virtual void show()
    {
        std::cout << "First side: " << this->firstSide << std::endl;
        std::cout << "Second side: " << this->secondSide << std::endl;
        std::cout << "Third side: " << this->thirdSide << std::endl;
        std::cout << "Angle: " << this->angle << std::endl;
        std::cout << "Perimeter: " << this->perimeter() << std::endl;
        std::cout << "Area: " << this->area() << std::endl;
    }

    Triangle operator*(double number);
    Triangle operator+(double number);
    Triangle operator++();
    Triangle operator++(int);
    Triangle operator--();
    friend Triangle operator--(Triangle &triangle, int);
};
