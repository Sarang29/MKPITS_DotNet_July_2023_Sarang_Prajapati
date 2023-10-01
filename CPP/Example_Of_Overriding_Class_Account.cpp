#include<iostream>
using namespace std;
class Account
{
	public:
		int acc_no;
		int bal;
		virtual void deposit(int amt)
		{
			cout<<"Hello from Account class"<<endl;
		}
};
class saving:public Account
{
	public:
		void deposit(int amt)
		{
		int interest=500;
		bal=bal+amt+interest;
		cout<<"Account Number="<<acc_no<<endl;
		cout<<"Balance With interest="<<bal<<endl;
		cout<<"---------------------------------------"<<endl;
		}
};
class current:public Account
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<"Account Number="<<acc_no<<endl;
			cout<<"Balance Without Interest="<<bal<<endl;
		}
};
int main()
{
	Account *a;
	saving s1;
	current c1;
	a=&s1;
	a->acc_no=123;
	a->bal=1000;
	a->deposit(1000);
	a=&c1;
	a->acc_no=212;
	a->bal=4000;
	a->deposit(500);
	return 0;
}
