#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void stop()=0;
};
class Tick_Tack_Toe:public Game
{
	public:
		void start()
		{
			cout<<"Tick_Tack_Toe is Started"<<endl;
		}
		void play()
		{
			cout<<"Tick_Tack_Toe is Playing"<<endl;
		}
		void stop()
		{
			cout<<"Tick_Tack_Toe is Ended"<<endl;
		}
};
class Chess:public Game
{
	public:
		void start()
		{
			cout<<"Chess is Started"<<endl;
		}
		void play()
		{
			cout<<"Chess is Playing"<<endl;
		}
		void stop()
		{
			cout<<"Chess is Ended"<<endl;
		}
};
int main()
{
	Tick_Tack_Toe t;
	t.start();
	t.play();
	t.stop();
	
	Chess c;
	c.start();
	c.play();
	c.stop();
	
	return 0;
}
