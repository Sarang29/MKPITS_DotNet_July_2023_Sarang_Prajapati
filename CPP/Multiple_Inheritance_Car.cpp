#include<iostream>
using namespace std;
class Engine
{
	protected:
		string power;
		public:
		void getEngine(string p)
		{
			power=p;
		}
		void start()
		{
			cout<<"Engine is Start"<<endl;
		}
		void stop()
		{
			cout<<"Engine is Stop"<<endl;
		}
};
class Vehicle
{
	public:
		string brand;
		void Accelerate()
		{
			cout<<"Engine is Accelerate"<<endl;
		}
		void brek()
		{
			cout<<"Engine is Stopped"<<endl;
		}
		void display()
		{
			cout<<"Brand Name:"<<brand<<endl;
		}
};
class car:public Engine,public Vehicle
{
	public:
		void drive()
		{
			cout<<"Car is Driving"<<endl;
		}
		void park()
		{
			cout<<"Car is Parked"<<endl;
		}
};
int main()
{
	car c1,c2;
	cout<<"HondaCity"<<c1.brand<<endl;
	c1.start();
	c1.Accelerate();
	c1.drive();
	
	cout<<"Toyota"<<c2.brand<<endl;
	c2.stop();
	c2.brek();
	c2.park();
	return 0;
}
