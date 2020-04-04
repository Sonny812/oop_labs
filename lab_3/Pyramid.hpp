#pragma once

#include "Triangle.hpp"

class Pyramid : public Triangle
{
private:
    double height;

public:
    Pyramid() : Triangle(), height(10) {}
    Pyramid(double firstSide, double secondSide, double angle, double height) : Triangle(firstSide, secondSide, angle), height(height) {}
    double getHeight();
    void setHeight(double number);
    
    double volume();
    
    void show();
    
    Pyramid &operator=(Pyramid &pyramid);
    friend double operator+(Pyramid &leftOp, Pyramid &rightOp);
};