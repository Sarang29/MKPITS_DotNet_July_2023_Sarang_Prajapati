// Copy Number From One Array To Another//
#include<stdio.h>
int main()
{
	int i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		printf("enter number:");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("\n Elements of Array1");
	for(i=0;i<5;i++)
	{
		printf("\n %d",arr1[i]);
	}
	printf("\n Elements of Array2");
	for(i=0;i<5;i++)
	{
		printf("\n %d",arr2[i]);
	}	
}
