#include<stdio.h>
void sayhello()
{
	printf("Hello\n");
}
void main()
{
	printf("calling function\n");
	sayhello();
	printf("Back to main function\n");
	sayhello();
	printf("bye");
}
