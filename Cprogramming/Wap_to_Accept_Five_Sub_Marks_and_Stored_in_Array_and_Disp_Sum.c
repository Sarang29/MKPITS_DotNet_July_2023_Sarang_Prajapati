// Find Total Marks Of 5 Students Using Array//
#include<stdio.h>
int main()
{
	int i,sum=0,marks[5];
	for(i=0;i<5;i++)
	{
		printf("enter 5 number");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("\n marks =%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n Total marks =%d",sum);
	}
