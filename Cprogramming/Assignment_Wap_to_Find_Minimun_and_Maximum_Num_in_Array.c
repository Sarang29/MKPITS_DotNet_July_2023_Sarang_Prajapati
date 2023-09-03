//Wap to Find Minimun & Maximum Number in an Array/
#include<stdio.h>
int main()
{
	int i,num,arr[100],min,max;
	printf("Enter number:");
	scanf("%d",&num);
	for(i=0;i<num;i++)
	{
		printf("Enter Array");
		scanf("%d",&arr[i]);
	}
	min=max=arr[0];
	for(i=1;i<num;i++)
	{
		if (min>arr[i])
			min=arr[i];
		if(max<arr[i])
			max=arr[i];
	}
	printf("\n Minimun Number is :%d",min);
	printf("\nMaximum Number is :%d",max);
	}
