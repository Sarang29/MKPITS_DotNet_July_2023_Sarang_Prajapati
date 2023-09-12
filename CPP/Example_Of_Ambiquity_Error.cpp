#include<iostream>
using namespace std;
class classA
{
	public:
		void display()
		{
			cout<<"Display from Class A"<<endl;
		}
};
class classB
{
	public:
		void display()
		{
			cout<<"Display from Class B";
		}
};
class classc: public classA,classB
{
	public:
	void displayC()
	{
		classA::display();
		classB::display();
	}
};
int main()
{
	classc c1;
	c1.displayC();
}
