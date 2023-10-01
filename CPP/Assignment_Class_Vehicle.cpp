#include<iostream>
using namespace std;
class Vehicle
{
	public:
			virtual void start()
			{
				cout<<"Engine is Start"<<endl;
			}
			virtual void stop()
			{
				cout<<"Engine is Stop"<<endl;
			}
};
class car:public Vehicle
{
	public:
		void start()
			{
				cout<<"Car Name= Benz"<<endl;
				cout<<"Car is start"<<endl;
			}
			void stop()
			{
				cout<<"Car is stop"<<endl;
			}
};
class motorcycle:public Vehicle
{
	public:
			void start()
			{
				cout<<"Motorcycle Name= BMW"<<endl;
				cout<<"motorcycle is start"<<endl;
			}
			void stop()
			{
				cout<<"motorcycle is stop"<<endl;
			}	
};
class truck:public Vehicle
{
	public:
			void start()
			{
				cout<<"Truck Name= TATA"<<endl;
				cout<<"Truck is start"<<endl;
			}
			void stop()
			{
				cout<<"Truck is stop"<<endl;
			}
};
int main()
{
	Vehicle *v;
	car c;
	motorcycle m;
	truck t;
	v=&c;
	v->start();
	v->stop();
	
	v=&m;
	v->start();
	v->stop();

	
	v=&t;
	v->start();
	v->stop();
	
	return 0;
}
