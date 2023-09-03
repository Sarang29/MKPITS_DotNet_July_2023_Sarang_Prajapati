#include<stdio.h>
#include<string.h>
struct book
{
	char title[50];
	char author[50];
	int bookid;
};
void main()
{
	struct book b1;
	strcpy(b1.title,"dotnet");
	strcpy(b1.author,"Akash");
	b1.bookid=123;
	printf("\ntitle=%s",b1.title);
	printf("\nauthor=%s",b1.author);
	printf("\nbook id=%d",b1.bookid);
}
