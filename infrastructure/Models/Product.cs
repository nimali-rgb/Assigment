

using System.Security.Cryptography.X509Certificates;

namespace infrastructure.Models;

public class Product
{
    //ska innehålla namn pris och id för Godkänt
    // pulic string elr GUID

    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!; 
    public decimal Price { get; set; }

}
