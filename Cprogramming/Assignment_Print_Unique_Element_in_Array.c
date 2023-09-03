// Program To Print Unique Elements In An Array//
#include<stdio.h>
int main()
{
	int i,j,arr[5],count=0;
	for(i=0;i<5;i++)
	{
	printf("Enter Number:");
	scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{	count=0;
		for(j=0;j<5;j++)
		{
			if(i!=j)
			{
				if(arr[i]==arr[j])
				{
				count++;
				break;
				}
			}
		}
		if(count==0)
		{
		printf("\n Unique Number =%d",arr[i]);
		}	
	}
}
