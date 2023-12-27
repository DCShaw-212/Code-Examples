#include <iostream>
#include <string>
#include "queue.h"

using namespace std;

int main()
{
	//Start with queue of ints
	Queue<int> q;

	//Check if empty
	if (q.isEmpty())
		cout << "Queue is empty" << endl;

	//Check enqueueing
	int x = 1;
	q.enqueue(x);
	if (!q.isEmpty())
		cout << "Queue is no longer empty" << endl;

	//Some more enqueues
	x = 2;
	q.printQueue();
	q.enqueue(x);
	q.printQueue();

	//Peeking and dequeuing
	int element, element2;
	if (q.peek(element2))
		cout << "first peek: " << element2 << endl;
	if (q.dequeue(element))
		cout << "first dequeue: " << element << endl;
	q.printQueue();
	if (q.dequeue(element))
		cout << "second dequeue: " << element << endl;
	q.printQueue();
	if (!q.dequeue(element))
		cout << "Can no longer dequeue" << endl;
	if (!q.peek(element))
		cout << "Can no longer peek" << endl;
	if (q.isEmpty())
		cout << "Queue is empty again" << endl;

	//More enqueues
	x = 2;
	q.enqueue(x);
	x = 3;
	q.enqueue(x);
	q.dequeue(x);
	x = 4;
	q.enqueue(x);
	x = 5;
	q.enqueue(x);
	q.printQueue();

	//Emptying the queue
	if (!q.isEmpty())
		cout << "Queue is not empty" << endl;

	cout << "Emptying queue" << endl;
	//q.makeEmpty();
	if (!q.dequeue(element))
		cout << "Nothing to dequeue" << endl;

	//Does everything work after emptying?
	x = 7;
	q.enqueue(x);
	x = 8;
	q.enqueue(x);
	x = 9;
	q.enqueue(x);
	q.printQueue();

	if (q.isEmpty())
		cout << "Queue is empty" << endl;

	//Test template by making a coord struct and using that
	struct Coord
	{
		int x;
		int y;
	};

	//Make a queue of our coords
	Queue<Coord> q2;

	//Set up a coord
	Coord p1, p2;
	p1.x = 10;
	p1.y = 20;

	//Test enqueueing and dequeuing the coords
	q2.enqueue(p1);
	q2.enqueue(p1); // again
	q2.dequeue(p2);

	//Note that we never test printing this second queue... this is because coords arent easy to print!
	//Instead, we dequeue and then print each element of the struct to show that it was stored and removed properly.
	cout << p2.x << " " << p2.y << endl;


	//Test isEmpty and makeEmpty with coords
	if (!q2.isEmpty())
		cout << "Queue is not empty" << endl;

	cout << "Emptying queue" << endl;
	//q2.makeEmpty();


	if (q2.isEmpty())
		cout << "Queue is empty" << endl;



	return 0;
};