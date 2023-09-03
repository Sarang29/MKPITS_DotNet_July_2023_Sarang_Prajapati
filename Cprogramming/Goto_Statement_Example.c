#include<stdio.h>
int main()
{
	int num,i=1;
	{
		printf("Enter Number");
		scanf("%d",&num);
		table:
			printf("\n %d*%d=%d",num,i,num*i);
			i++;
			if(i<=10)
			{
				goto table;
			}
	}
}
