//Addition of 2 number using pointer//
#include<stdio.h>
int main()
{
	int num1,num2,*ptr1,*ptr2,temp;
	printf("enter 2 number");
	scanf("%d%d",&num1,&num2);
	ptr1=&num1;
	ptr2=&num2;
	temp=*ptr1+*ptr2;
	printf("\n Addition of two number is:%d",temp);
}
