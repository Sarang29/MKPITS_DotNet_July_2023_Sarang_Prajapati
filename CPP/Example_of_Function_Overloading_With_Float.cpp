#include<iostream>
using namespace std;
class calculation
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		float add(float n1,float n2)
		{
			return n1+n2;
		}
};
int main()
{
	calculation c1;
	cout<<"Addtion of Integer:"<<c1.add(2,3)<<endl;
	cout<<"Addition of Float:"<<c1.add(3.3f,4.4f);
	return 0;
}
