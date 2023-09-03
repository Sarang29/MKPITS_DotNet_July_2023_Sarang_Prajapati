//wap to accept a number and arrange them in ascending order//
#include<stdio.h>
int main()
{
	int num,i,j,arr[10],temp;
	printf("enter number:");
	scanf("%d",&num);
	for(i=0;i<num;i++)
	{
		printf("enter Array");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<num;i++)
	{
		for(j=i+1;j<num;j++)
		{
			if (arr[i]>arr[j])
			{
				temp=arr[i];
				arr[i]=arr[j];
				arr[j]=temp;
			}
		}
	}
	for(i=0;i<num;i++)
	printf("\n Number in Ascending Order :%d",arr[i]);
}
