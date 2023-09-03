//find factorial using pointer//
#include<stdio.h>
int main()
{
	int num,factorial=1,*ptr,i;
	printf("enter number :");
	scanf("%d",&num);
	ptr=&factorial;
	for(i=1;i<=num;i++)
	{
		*ptr=(*ptr)*i;
	}
	printf("\n Factorial is %d",factorial);
}
