#include<stdio.h>
int main()
{
	int counter=20;
	while(counter<=30)
	{
		if(counter%2!=0)
		{
			printf("%d\n",counter);
		}
		counter=counter+1;
	}
}
