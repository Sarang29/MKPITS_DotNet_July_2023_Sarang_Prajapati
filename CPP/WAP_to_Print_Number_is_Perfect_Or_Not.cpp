//perfect number or not//
#include<iostream>
using namespace std;
int main()
{
	int num;
	int i;
	int rem;
	int sum=0;
	cout<<"Enter number:";
	cin>>num;
	for(i=1;i<num;i++)
	{
		if(rem==0)
		{
			rem=num%1;
			sum=sum+1;
		}
	}
	if(sum==num)
	{
		cout<<"It is a perfece number";
	}
	else
	{
		cout<<"Not a perfect number";
	}
}
