#include<stdio.h>
void prime(int num,int i,int rem)
{
	int prime;
	for(i=2;i<=num;i++)
	{
		rem=num%i;
		if(rem==0)
		{
			printf("It Is Not A Prime Number");
			break;
		}
		i=i+1;
		if(num==i)
	{
	printf("It Is a Prime Number");
}
}
}
void main()
{
	int num,i,rem;
	printf("Enter Number:");
	scanf("%d",&num);
	prime(num,i,rem);
}
