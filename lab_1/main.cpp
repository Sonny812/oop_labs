#include "Triangle.hpp"
#include <iostream>
#include <vector>

void printTriangle(Triangle &triangle);

int main()
{
    auto trianglePointer = new Triangle();

    const int COUNT_OF_TRIANGLES = 3;  
    Triangle arrayOfTriangles[COUNT_OF_TRIANGLES] = {
        Triangle(1, 2, 50),
        Triangle(13, 11, 43),
        Triangle(10, 15, 90)
    };

    std::vector<Triangle> collectionOfTriangles{
        Triangle(),
        Triangle(5, 6, 30),
        Triangle(1, 1, 90)
    };

    std::cout << "First triangle (created via constructor without parameters):" << std::endl;
    printTriangle(*trianglePointer);
    std::cout << std::endl;

    auto triangle = (*trianglePointer) + 2;

    std::cout << "After add 2 to first triangle: " << std::endl;
    printTriangle(triangle);
    std::cout << "Third side after another multiplication by 3: " << (triangle * 3).getThirdSide() << std::endl;
    std::cout << std::endl;

    auto triangleBeforeIncrement = triangle++;
    std::cout << "Postfix increment result (should be same as source triangle after add 2):" << std::endl;
    printTriangle(triangleBeforeIncrement);
    std::cout << std::endl;

    std::cout << "Triangle after increment:" << std::endl;
    printTriangle(triangle);
    std::cout << std::endl;

    --triangle;
    std::cout << "Triangle after decrement:" << std::endl;
    printTriangle(triangle);
    std::cout << std::endl;

    triangle.setFistSide(1);
    std::cout << "Triangle after set it's first side to 1:" << std::endl;
    printTriangle(triangle);
    std::cout << std::endl;

    std::cout << "Perimeter of each triangle in the array:" << std::endl;
    for (int i = 0; i < COUNT_OF_TRIANGLES; i++) {
        std::cout << "Triangle " << i << ": "  << arrayOfTriangles[i].Perimeter() << std::endl;
    }
    std::cout << std::endl;

    std::cout << "Area of each triangle in the collection:" << std::endl;
    for (int i = 0; i < collectionOfTriangles.size(); i++) {
        std::cout << "Triangle " << i << ": "  << collectionOfTriangles[i].Area() << std::endl;
    }

}

void printTriangle(Triangle &triangle)
{
    std::cout << "First side: " << triangle.getFirstSide() << std::endl;
    std::cout << "Second side: " << triangle.getSecondSide() << std::endl;
    std::cout << "Third side: " << triangle.getThirdSide() << std::endl;
}
