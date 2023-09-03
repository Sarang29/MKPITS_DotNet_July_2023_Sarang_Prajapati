// Substraction of two matrices//
#include<stdio.h>
void main()
{
	int arr1[2][2]={{3,4},{6,8}};
	int arr2[2][2]={{1,2},{4,7}};
	int arr3[2][2];
	int row,col;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr3[row][col]=arr2[row][col]-arr1[row][col];
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d\t",arr3[row][col]);
		}
		printf("\n");
	}
}
