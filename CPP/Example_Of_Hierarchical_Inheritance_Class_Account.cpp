#include<iostream>
using namespace std;
class account
{
	public:
		int acc_no;
		int bal;
		int interest;
		void getdata(int a,int b,int c)
		{
			acc_no=a;
			bal=b;
			interest=c;
		}
};
class saving:public account
{
	public:
		int deposit(int amt)
		{
			bal=bal+interest+amt;
			return bal;
		}
};
class current:public account
{
	public:
		int deposit(int amt)
		{
			bal=bal+amt;
			return bal;
		}
};
int main()
{
	saving s1;
	current c1;
	
	int result;
	int acnt_no,balc,inst,amount;
	
	cout<<"Enter Account No, Balance, Interest and Amount"<<endl;
	cin>>acnt_no>>balc>>inst>>amount;
	s1.getdata(acnt_no,balc,inst);
	result=s1.deposit(amount);
	cout<<"Balance With Interest:"<<result<<endl;
	
	c1.getdata(acnt_no,balc,inst);
	result=c1.deposit(amount);
	cout<<"Balance Without Interest:"<<result<<endl;
	return 0;
}
