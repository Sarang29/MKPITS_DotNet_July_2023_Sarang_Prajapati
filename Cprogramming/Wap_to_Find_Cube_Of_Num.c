// Wap to find cube of a number//
#include<stdio.h>
int main()
{
	int num;
	int cube;
	int i;
	printf("Enter number:");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
	}
	printf("Cube is = %d",cube);
}
