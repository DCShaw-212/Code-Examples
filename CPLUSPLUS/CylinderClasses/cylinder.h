//Name: Dustin Shaw
//Title: Assignment 1 - 1
//Purpose: To build the class Cylinder for the test driver



#include <iostream>
#include <string>
#include <cmath>

using namespace std;

const double PI = std::atan(1.0) * 4;


class Cylinder {

	//data members
	double radius;
	double height;
	double volume;
	double area;


public:
	//Prototypes

	//default constructor
	Cylinder() {};

	//constructor to take in radius and height for the cylinder
	Cylinder(double radius, double height) : radius(radius), height(height) { }

	//Methods 
	//build the methods

	//returns value of Radius
	double getRadius()
	{
		return radius;
	}
	//takes in a double as the parameter and sets it to Radius
	void setRadius(double radiusIn) 
	{
		radius = radiusIn;
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
	    volume = (PI * pow(radius, 2)) * height;
		return volume;
	}

	//method for returning the surface area of the cylinder
	//A = 2PIrh + 2PIr^2
	double getSurfaceArea() {

	    area = (2 * PI) * (radius * height) + (2 * PI) * pow(radius, 2);
		return area;
	}

};

