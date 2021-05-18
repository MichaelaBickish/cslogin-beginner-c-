namespace cslogin.Models
{
  public class User
  {
    //#1
    public string Name { get; set; }
    public string Password { get; set; }

    public bool ValidatePassword(string input)
    {
      return input == Password;
    }



    public User(string name, string password)
    {
      Name = name;
      Password = password;

    }
  }


}