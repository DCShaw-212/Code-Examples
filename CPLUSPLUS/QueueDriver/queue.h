#pragma once
#include <string>
#include <memory>
#include <iostream>

using namespace std;


//

template <class DataType>
struct Node{
	
public:
	//Node(){}
	//~Node(){}
	DataType info;
	shared_ptr<Node<DataType>>next;

	
};




template<class DataType>
class Queue
{

private:
	//The two Smart pointers needed
	
	shared_ptr<Node<DataType>>front = nullptr;
	
	
	shared_ptr<Node<DataType>>back = nullptr;
	
public:
	//VS put these here and they're not hurting anything
	
	Queue(){}
	~Queue() {}

	
	

	//isEmpty - no parameters. Returns true when the queue has 0 elements and false otherwise.

	bool isEmpty()
	{

		if ((*front) == nullptr)
			return true;
		else
			return false;

	};

	//peek - takes in one parameter by reference, of type DataType if no elements, return false. If elements to peek at, return true and set parameter to that element

	bool peek(DataType& element)
	{
		if (isEmpty())
			return false;
		else
		{
			front = &element;
			return true;
		}
	};

	//enqueue - takes in on paramter of type DataType and returns nothing. Don't change the parameter so either pass it by value or pass it by reference using the const keyword
	void enqueue(const DataType& element)
	{
		//check if there are no items in the queue
		if (isEmpty())
		{
			
			front = new Node<DataType>;
			
			front->info = element;
			front->next = nullptr;
			back -> info = element;
		}
		//check if there are items in the queue
		else
		{
			shared_ptr<Node<DataType>>temp;
			
			temp = new Node<DataType>;
			temp->info = element;
			temp->next = nullptr;
			back = temp;

		}
	};
	//dequeue - very simliar to peek, except that it also removes the element that gets passed back from a queue
	bool dequeue(DataType& element)
	{
		//check if there are no items in the queue
		if(isEmpty())
			return false;
		
		//check if there is one item in the queue
		else if (front->next = back)
		{
			front->info = element;
			front = nullptr;
			back = nullptr;
			return true;
		}
		//check if there are 2 or more items
		else 
		{
			front->info = element;
			front = front->next;
			return true;
		}
		
	};
	//makeEmpty - takes no parameters and returns nothing. This method will malke the queue empty again.
	//delete the first node -> cascade = overflow :( 
	//dequeue instead for as long as you have to :)
	void makeEmpty()
	{
		while (isEmpty != true) {
			dequeue();
		}
	};

	//printQueue

	void printQueue() {
		shared_ptr<Node<DataType>> ptr(front);
		while (ptr != nullptr)
		{
			cout << ptr->info << "-->";
			ptr = ptr->next;
		}
		cout << "nullptr" << endl;


	};
	

};


