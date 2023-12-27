#include <iostream>
#include <iomanip>
#include "cylindertemplate.h"
#include <string>

using namespace std;


int main()
{
	//Set up the first cylinder
	CylinderTemplate<string> cylinder;

	cylinder.setHeight(10);
	cylinder.setRadius(5);
	cylinder.setClientInfo("One");

	//Output data on the first cylinder
	cout << "Cylinder 1" << endl;
	cout << "The client info is: " << cylinder.getClientInfo() << endl;
	cout << "The volume is: " << setprecision(2) << fixed << cylinder.getVolume() << endl;
	cout << "The surface area is: " << setprecision(2) << fixed << cylinder.getSurfaceArea() << endl;
	cout << endl;

	//Set up the second cylinder
	CylinderTemplate<double> cylinder2(3, 12);
	cylinder2.setClientInfo(3.1415);

	//Output data on the second cylinder
	cout << "Cylinder 2" << endl;
	cout << "The client info is: " << cylinder2.getClientInfo() << endl;
	cout << "The radius is: " << setprecision(2) << fixed << cylinder2.getRadius() << endl;
	cout << "The height is: " << setprecision(2) << fixed << cylinder2.getHeight() << endl;
	cout << "The volume is: " << setprecision(2) << fixed << cylinder2.getVolume() << endl;
	cout << "The surface area is: " << setprecision(2) << fixed << cylinder2.getSurfaceArea() << endl;
	cout << endl;

	//Create a third cylinder.
	//Note that two cylinders have to be the same DataType for == to work properly.
	//	To make this work for ALL datatypes (so we could compare say a Cylinder<string>
	//	versus a Cylinder<double> is much more complicated.)
	CylinderTemplate<string> cylinder3(100, 200);

	//Check for equality
	cout << "Creating new cylinder for equality testing..." << endl;
	cout << "Are the cylinders equivalent? ";
	if (cylinder == cylinder3)
		cout << "Yes" << endl;
	else
		cout << "No" << endl;

	//Set new values for Cylinder 3
	cylinder3.setHeight(10);
	cylinder3.setRadius(5);

	//Re-check for equality
	cout << "I tweaked them, are they the same now? ";
	if (cylinder == cylinder3)
		cout << "Yes they are!" << endl;
	else
		cout << "Still nope!" << endl;

	return 0;
}