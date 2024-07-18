namespace WinFormsApp6;

public class Car
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int  Year{ get; set; }
    public string stNum { get; set; }

    public override string ToString()
    {
        return $"{Id}:\t{Marka}--{Model}--{Year}--{stNum}";
    }
}
