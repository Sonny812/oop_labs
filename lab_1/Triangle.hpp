#pragma once

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
    double getFirstSide();
    void setFistSide(double length);

    double getSecondSide();
    void setSecondSide(double length);

    double getThirdSide();

    double getAngle();
    void setAngle(double angle);

    double Area();
    double Perimeter();

    Triangle operator*(double number);
    Triangle operator+(double number);
    Triangle operator++();
    Triangle operator++(int);
    Triangle operator--();
    friend Triangle operator--(Triangle &triangle, int);
};
