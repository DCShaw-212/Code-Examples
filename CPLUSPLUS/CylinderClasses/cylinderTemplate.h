//Name: Dustin Shaw
//Title: Assignment 1 - 1
//Purpose: To build the class Cylinder for the test driver



#include <iostream>
#include <string>
#include <cmath>

using namespace std;

const double PI = std::atan(1.0) * 4;
//data members

double height;
double volume;
double area;
double circumference;

// struct for a circle

struct Circle
{
public:

	double radius;

	//returns value of Radius
	double getRadius()
	{
		return radius;
	};

	//A = PI * radius ^ 2
	double getArea()
	{
		area = PI * pow(radius, 2);
		return area;
	}
	//C = 2 * PI * radius
	double getCircumference()
	{
		circumference = 2 * PI * radius;
		return circumference;
	}
};

template <class DataType>
class CylinderTemplate {

public:


	//Prototypes

	//default constructor
1	Cylinder() {};

	//constructor to take in radius and height for the cylinder
	Cylinder(double radius, double height) : radius(radius),height(height) { }

	//template DataType
	DataType CylinderTemplate;

	//Methods 
	//build the methods

	double getRadius() 
	{
		return Circle.radius;
	}


	
	//takes in a double as the parameter and sets it to Radius
	void setRadius(double radiusIn)
	{
		Circle::getRadius = radiusIn;
	}

	//returns the value of height
	double getHeight()
	{
		return height;
	}

	//takes in a double as the parameter and sets it to radius
	void setHeight(double heightIn)
	{
		height = heightIn;
	}

	//method for returning the volume of the cylinder
	// V = PIr^2h
	double getVolume()
	{
		volume = (PI * pow(Circle::getRadius, 2)) * height;
		return volume;
	}

	//method for returning the surface area of the cylinder
	//A = 2PIrh + 2PIr^2
	double getSurfaceArea() {

		area = (2 * PI) * (Circle::getRadius * height) + (2 * PI) * pow(Circle::getRadius, 2);
		return area;
	}

	//set the cylinder template
	void setClientInfo(DataType ctIn)
	{
		CylinderTemplate = ctIn;
	}

	//get the cylinder template
	DataType getClientInfo()
	{
		return CylinderTemplate;
	}

	bool equalCheck == (Cylinder & otherCylinder)
	{
		return Circle.getRadius == otherCylinder.Circle.getRadius && Cylinder.height == otherCylinder.height;
	}



};

