#include<iostream>
using namespace std;
class Shape
{
	public:
		virtual void draw()=0;
};
class Rectangle: public Shape
{
	public:
		void draw()
		{
			cout<<"Draw from Rectangle class"<<endl;
		}
};
int main()
{
	Rectangle r;
	r.draw();
	return 0;
}
