//contanicate two string using pointer//
#include<stdio.h>
void main()
{
	char name1[20],name2[20],*ptr1,*ptr2;
	printf("Enter first name");
	gets(name1);
	printf("Enter second name");
	gets(name2);
	ptr1=name1;
	while(*ptr1!='\0')
	{
		*ptr1++;
	}
	ptr2=name2;
	while (*ptr2!='\0')
	{
		*ptr1=*ptr2;
		*ptr1++;
		*ptr2++;
	}
	*ptr1='\0';
	printf("\n contanicated string :%s",name1);
}
