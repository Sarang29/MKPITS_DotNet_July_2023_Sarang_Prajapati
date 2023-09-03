#include<stdio.h>
void factorial(int num,int i)
{
	int factorial=1;
	for(i=1;i<=num;i++)
	{
		factorial=factorial*i;
	}
	printf("\n Factorial of Given Number is :%d",factorial);
}
void main()
{
	int num,i;
	printf("Enter Number to Find Factorial:");
	scanf("%d",&num);
	factorial(num,i);
}
