Console.Write("enter the user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Yahoo, it's Masha!");
}
else
{
    Console.Write("Hi,");
    Console.WriteLine(username);
}