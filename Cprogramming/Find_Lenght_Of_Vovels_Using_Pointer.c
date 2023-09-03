#include<stdio.h>
#include<string.h>
void main()
{
	int count=0;
	char name[10];
	char *ptr;
	printf("enter name:");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
			count=count+1;
		}
		ptr++;
	}
	printf("Lenght of Vovels=%d",count);
}
