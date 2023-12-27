// Main Test Driver 1.1

#include "cylinder.h"
#include <iostream>
#include <iomanip>

using namespace std;


int main()
{
	//Set up cylinder 1
	Cylinder cylinder;

	cylinder.setHeight(10);
	cylinder.setRadius(5);

	//Output data on Cylinder 1
	cout << "Cylinder 1" << endl;
	cout << "The volume is: " << setprecision(2) << fixed << cylinder.getVolume() << endl;
	cout << "The surface area is: " << setprecision(2) << fixed << cylinder.getSurfaceArea() << endl;
	cout << endl;

	//Set up Cylinder 2
	Cylinder cylinder2(3, 12);

	//Output data on Cylinder 2
	cout << "Cylinder 2" << endl;
	cout << "The radius is: " << setprecision(2) << fixed << cylinder2.getRadius() << endl;
	cout << "The height is: " << setprecision(2) << fixed << cylinder2.getHeight() << endl;
	cout << "The volume is: " << setprecision(2) << fixed << cylinder2.getVolume() << endl;
	cout << "The surface area is: " << setprecision(2) << fixed << cylinder2.getSurfaceArea() << endl;


	return 0;
}