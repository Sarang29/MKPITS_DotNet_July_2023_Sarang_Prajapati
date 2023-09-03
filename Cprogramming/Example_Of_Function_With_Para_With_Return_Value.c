#include<stdio.h>
int addition(int n1,int n2)
{
	int result=n1+n2;
	return result;
}
void main()
{
char ch='y';
do
{
	int num1,num2,result;
	printf("enter 2 number");
	scanf("%d%d",&num1,&num2);
	result=addition(num1,num2);
	printf("result=%d",result);
	printf("\n do you want to contine,press y");
	fflush(stdin);
	scanf("%c",&ch);
}
while (ch=='y');
}
