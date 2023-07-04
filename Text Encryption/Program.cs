Console.WriteLine("Select an option from the following:");
Console.WriteLine("1) Encrypt Message");
Console.WriteLine("2) Decrypt Message");
Console.WriteLine("3) Exit the program");
int choice = Convert.ToInt32(Console.ReadLine());
char[,] encryption = { { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z' }, { 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','a','b','c'} };


if (choice == 1)
{
    Console.WriteLine("Please enter some text to encrypt.");
    string response = Console.ReadLine();
    response.ToLower();
    char[] responsearray = response.ToCharArray();
    Console.Clear();
    Console.WriteLine("Here is your encrypted text:");

    for (int i = 0; i < response.Length; i++)
    {
        char responseletter = responsearray[i];

        for (int x = 0; x < 26; x++)
        {
            if (encryption[0,x] == responseletter)
            {
                responsearray[i] = encryption[1, x];
            }
        }
        
        Console.WriteLine(responsearray[i]);
        
    }
    Console.ReadLine();
}