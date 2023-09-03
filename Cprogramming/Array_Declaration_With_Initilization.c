#include<stdio.h>
int main()
{
	int i,sum=0,marks[3]={80,90,100};
	for(i=0;i<3;i++)
	{
		printf("\n Marks =%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\n Total marks is %d",sum);
}
