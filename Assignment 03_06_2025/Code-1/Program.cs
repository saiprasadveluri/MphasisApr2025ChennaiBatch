// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using TaskmanagerEFConsole;
DataAccess dataAccess = new DataAccess();
UserInfo loggedinUser = null;
//AddNewUser();
LoginUser();
bool isAdmin = dataAccess.IsInRole(loggedinUser.Email, 1);
if (isAdmin)
{
    //Add Project
}
else
{
    Console.WriteLine("Not authorized to create Project");
}
/**************************************************************/

    void LoginUser()
    {
        Console.Write("Email:");
        string Email = Console.ReadLine();
        Console.Write("Password:");
        string Password = Console.ReadLine();

        (UserInfo uinf, bool Status) = dataAccess.ValidateUser(Email, Password);
        if (!Status)
        {
            Console.Write("Login failed");
        }
        else
        {
            loggedinUser = uinf;
            Console.WriteLine("Welcome! " + uinf.Name);
        }
    }

void AddNewUser()
{
Console.Write("Name:");
string Name = Console.ReadLine();
Console.Write("Email:");
string Email = Console.ReadLine();
Console.Write("Password:");
string Password = Console.ReadLine();
Console.Write("Phone:");
string Phone = Console.ReadLine();
    if (dataAccess.IsEmailExists(Email))
    {
        Console.WriteLine("Email Exists.");
        return;
    }

    bool Result = dataAccess.AddNewUser(Name, Password, Email, Phone, 3);
    if (Result)
    {
        Console.WriteLine("Success");
    }
    else
    {
        Console.WriteLine("Error");
    }
}