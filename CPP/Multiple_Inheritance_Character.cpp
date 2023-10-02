#include<iostream>
using namespace std;
class Ability
{
	protected:
		string Ability_Name;
		public:
			void getAname(string an)
			{
				Ability_Name=an;
			}
};
class Equipment
{
	protected:
		string Equipment_Name;
		public:
			void getEname(string en)
			{
				Equipment_Name=en;
			}
};
class Character: public Equipment,public Ability
{
	protected:
		string Character_Name;
		public:
			void getCname(string cn)
			{
				Character_Name=cn;
			}
			void display()
			{
				cout<<"Character Name:"<<Character_Name<<endl;
				cout<<"Equipment Name:"<<Equipment_Name<<endl;
				cout<<"Ability Name:"<<Ability_Name<<endl;
			}
};
int main()
{
	Character c1;
	c1.getCname("Sarang");
	c1.getAname("Defence");
	c1.getEname("Sword");
	c1.display();
	return 0;
}
