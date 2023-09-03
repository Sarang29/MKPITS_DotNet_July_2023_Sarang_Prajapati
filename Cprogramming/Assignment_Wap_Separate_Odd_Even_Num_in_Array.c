// Separate Odd Even Number into Separate Array//
#include<stdio.h>
int main()
{
	int i,arr[5];
	for(i=0;i<5;i++)
	{
		printf("Enter Number:");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		if(arr[i]%2==0)
		{
			printf("\n Number is Even :%d",arr[i]);
		}
		else
		{
			printf("\n Number is Odd  :%d",arr[i]);
		}
	}
}
