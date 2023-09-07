using System.Drawing;

namespace overridertruefalse.Classes;

public class Player
{
    public string Name { get; set; }
    public string? Password { get; set; }
    public string Fullname { get; set; }
    public int Age { get; set; }
    public ulong Id { get; }
    public DateTime CreationDate { get;}
    
    public Player()
    {
        
    }
    public Player(string Name, DateTime CreationDate, string Fullname)
    {
        this.Name = Name;
        this.CreationDate = CreationDate;
        this.Fullname = Fullname;
    }
    public Player(string Name, string? Password,DateTime CreationDate, string Fullname)
    {
        this.Name = Name;
        this.CreationDate = CreationDate;
        this.Password = Password;
        this.Fullname = Fullname;
    }
    public Player(string Name, string? Password,DateTime CreationDate, string Fullname,ulong Id)
    {
        this.Name = Name;
        this.CreationDate = CreationDate;
        this.Password = Password;
        this.Fullname = Fullname;
        this.Id = Id;
    }

    public void ShowInfo()
    {
        Console.WriteLine(this.Name,this.CreationDate,this.Fullname);
    }
    public void ShowInfo(string password)
    {
        try
        {
            Console.WriteLine($"Имя: {this.Name},{this.CreationDate} ");
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: " + e + "Вывод не доступен");
        }
        
    }
}
