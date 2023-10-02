#include<iostream>
using namespace std;
int main()
{
	int rem,num,sum=0,i;
	cout<<"Enter Number";
	cin>>num;
	for(i=num;num!=0;num=num/10)
	{
		rem=num%10;
		sum=sum+(rem*rem*rem);
	}
	if(sum==i)
	{
		cout<<"Armstrong Number"<<i;
	}
	else
	{
		cout<<"Not A Armstrong Number"<<i;
	}
}
