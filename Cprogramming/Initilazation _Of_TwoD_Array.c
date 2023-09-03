#include<stdio.h>
int main()
{
	int arr[2][2]={{0,1},{2,3}};
	int row,col;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("\n arr[%d][%d]=%d",row,col,arr[row][col]);
		}
	}	
}
