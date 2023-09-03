#include<stdio.h>
int main()
{
	int i;
	for(i=1;i<=10;i++)
	{
		printf("num=%d",i);
		if(i%2==0)
		{
			break;
		}
		printf("\n bye");
	}
}
