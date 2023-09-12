#include<iostream>
using namespace std;
class calculation
{
	public:
		int add(int n1,int n2)
		{
			return n1+n2;
		}
		int add(int n1,int n2,int n3)
		{
			return n1+n2+n3;
		}
};
int main()
{
	calculation c1;
	cout<<"Addition of 2 Numbers:"<<c1.add(2,3)<<endl;
	cout<<"Addition of 3 Numbers:"<<c1.add(2,3,4);
	return 0;
}
