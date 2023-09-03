#include<stdio.h>
int main()
{
	int num;
	int counter;
	int result;
	printf("Enter Number:");
	scanf("%d",&num);
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		printf("\n%d*%d=%d",num,counter,num*counter);
	}
}
