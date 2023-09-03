// Find Duplicate Number of Elements Using Array//
#include<stdio.h>
int main()
{
	int arr[5];
	int i,count=0;
	int j;
	for(i=0;i<5;i++)
	{
		printf("\nenter number:");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				count++;
				break;
			}
		}
	}
	printf("\n Number of Duplicate Elements =%d",count);
}
