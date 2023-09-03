#include<stdio.h>
int main()
{
	int n,i,num[100];
	printf("Enter Number:");
	scanf("%d",&n);
	for(i=0;i<n;i++)
	{
		printf("\n Enter Marks:");
		scanf("%d",&num[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\n Reverse is %d",num[i]);
	}
}
