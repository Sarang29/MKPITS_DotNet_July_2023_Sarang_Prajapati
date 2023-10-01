//Display N Terms of odd natural number & their sum//
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
		cout<<2*i-1<<endl;
		sum=sum+(2*i-1);
	}
	cout<<"______________"<<endl;
	cout<<sum<<endl;
}
