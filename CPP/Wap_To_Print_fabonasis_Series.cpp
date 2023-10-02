// fabonasis series//
#include<iostream>
using namespace std;
int main()
{
	int num1;
	int num2,i;
	int add=num1+num2;
	cout<<"Enter 2 number:";
	cin>>num1>>num2;
	for(i=3;i<10;i++)
	{
		cout<<add<<endl;
		
		num1=num2;
		add=num2;
		
		add=num1+num2;
	}
}
