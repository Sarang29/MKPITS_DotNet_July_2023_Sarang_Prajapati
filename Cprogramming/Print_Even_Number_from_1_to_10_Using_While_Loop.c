#include<stdio.h>
int main()
{
	int counter=2;
	while(counter<=10)
	{
		if(counter%2==0)
		{
			printf("%d\n",counter);
		}
		counter=counter+1;
	}
}
