Console.WriteLine("Write a user name");
string username = Console.ReadLine();

if(username.ToLower() == "tanya")
{
    Console.WriteLine("Yo Tanya!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}