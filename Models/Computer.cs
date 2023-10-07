namespace HelloWorld.Models
{
  public class Computer           // This is the model.
  {
    public int ComputerId {get; set;}
    public string Motherboard { get; set; } = "";
    public int? Cpucores { get; set; } = 0;
    public bool HasWiFi { get; set; }
    public bool HasLTE { get; set; }
    public DateTime Releasedate { get; set; }
    public decimal? Price { get; set; } = 0m;
    public string Videocard { get; set; } = ""; // Declare the property as nullable, use "?" at the end of the data type.

    // public Computer ()                         // To solve the "non-nullable string" property warning.
    // {
    //     if (Motherboard == null)
    //     {
    //         Motherboard = "";
    //     }
    //     if (Videocard == null)
    //     {
    //         Videocard = "";
    //     }
    //     if (Cpucores == null)
    //     {
    //         Cpucores = 0;
    //     }
    // }

    // private int _memory; // This is how to define a field in a class.
    // private int Memory {get{return _memory;} set{_memory = value;}} // This is how to define a property on that field in a class. 
  }
}