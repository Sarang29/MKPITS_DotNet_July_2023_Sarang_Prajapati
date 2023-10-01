//Display N Terms of even natural number & their sum//
#include<iostream>
using namespace std;
int main()
{
	int num;
	int i;
	int sum=0;
	cout<<"Enter number:";
	cin>>num;
	for(i=1;i<num;i++)
	{
		cout<<2*i<<endl;
		sum=sum+(2*i);
	}
	cout<<"______________"<<endl;
	cout<<sum<<endl;
}
