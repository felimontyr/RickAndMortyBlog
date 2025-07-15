namespace RickAndMortyVisor.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Status { get; set; }
    public string Species { get; set; }
    public string Gender { get; set; }
    public string Image { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
}
