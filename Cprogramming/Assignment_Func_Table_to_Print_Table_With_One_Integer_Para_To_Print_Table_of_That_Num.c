#include<stdio.h>
void table(int num,int i)
{
	int table;
	for(i=1;i<=10;i++)
	{
		table=num*i;
		printf("\n%d*%d=%d",num,i,table);
	}
}
void main()
{
	int num,i;
	printf("Enter Number:");
	scanf("%d",&num);
	table(num,i);
}
