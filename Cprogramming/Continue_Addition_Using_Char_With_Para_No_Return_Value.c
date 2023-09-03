#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("\n addition of 2no=%d",result);
}
void main()
{
char ch='y';
do
{
	int num1,num2;
	printf("enter 2 number");
	scanf("%d%d",&num1,&num2);
	addition(num1,num2);
	printf("\ndo you want to contine,press y");
	fflush(stdin);
	scanf("%c",&ch);
}
while(ch=='y');
}
