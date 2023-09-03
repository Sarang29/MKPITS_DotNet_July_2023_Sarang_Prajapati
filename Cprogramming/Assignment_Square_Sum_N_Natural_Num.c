#include<stdio.h>
int main()
{
	int num;
	int i;
	int sum=0;
	printf("enter number  : ");
	scanf("%d",&num);
	for (i=1;i<=num;i++)
	{
		printf(" %d ",i*i);
		sum=sum+(i*i);
	}
	printf("\n Square Sum of N Natural Number %d",sum);
}
