//perfect number or not//
#include<stdio.h>
int main()
{
	int num;
	int i;
	int rem;
	int sum=0;
	printf("Enter number:");
	scanf("%d",&num);
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
		printf("It is a perfece number");
	}
	else
	{
		printf("Not a perfect number");
	}
}
