//Copy one string to another string using pointer//
#include<stdio.h>
void main()
{
	char name1[20],name2[20],*ptr1,*ptr2;
	printf("enter name");
	gets(name1);
	ptr1=name1;
	ptr2=name2;
	while(*ptr1!='0')
	{
		*ptr2=*ptr1;
		*ptr1++;
		*ptr2++;
	}
	*ptr2!='0';
	printf("\n copy name :%s",name2);
}
