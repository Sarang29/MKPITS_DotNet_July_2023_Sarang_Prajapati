//Function Without Parameter With no Return Value//
#include<stdio.h>
void check()
{
	int num,rem=0;
	printf("enter number");
	scanf("%d",&num);
	if(num%2==0)
	{
		printf("This is even no");
	}
	else
	{
		printf("This is odd no");
	}
}
void main()
{
	int num,rem=0;
	check(num,rem);
}
