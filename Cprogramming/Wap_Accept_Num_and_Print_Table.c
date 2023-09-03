// wap to accept a number and print table of that number//
#include<stdio.h>
int main()
{
	int num;
	int counter;
	printf("enter number:");
	scanf("%d",&num);
	for(counter=1;counter<=10;counter++)
	{
		printf("\n%d*%d=%d",num,counter,num*counter);
	}
}
