#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("\n addition of 2nos=%d",result);
}
void main()
{
	int num1,num2;
	printf("enter number");
	scanf("%d,%d",&num1,&num2);
	addition(num1,num2);
	printf("bye");
}
