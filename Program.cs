// See https://aka.ms/new-console-template for more information
using SingletonExample;

Console.WriteLine("Hello, World!");

Singleton Servers1 = Singleton.GetSingleton();
Singleton Servers2 = Singleton.GetSingleton();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(Server1());
    Console.WriteLine(Server2());
}

string Server1()
{
    return "Next server1 is: " + Servers1.GetNextServer();
}
string Server2()
{
    return "Next server2 is: " + Servers2.GetNextServer();
}