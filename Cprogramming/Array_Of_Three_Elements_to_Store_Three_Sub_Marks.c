//Print Total Marks Using Array//
#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[3];
	marks[0]=99;
	marks[1]=88;
	marks[2]=77;
	for(i=0;i<3;i++)
	{
		printf("\n Marks =%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n Total marks is %d",sum);
}
