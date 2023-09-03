// fabonasis series//
#include<stdio.h>
int main()
{
	int num1;
	int num2,i;
	int add=num1+num2;
	printf("Enter 2 number:");
	scanf("%d%d",&num1,&num2);
	for(i=3;i<10;i++)
	{
		printf("%d",add);
		
		num1=num2;
		add=num2;
		
		add=num1+num2;
	}
}
