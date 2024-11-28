namespace AdvancedC_;

public class Employe : IEquatable<Employe>
{
    public int id { get; set; }
    public string name { get; set; }   
    public int age { get; set; }


    public bool Equals(Employe? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return id == other.id && name == other.name && age == other.age;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Employe)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(id, name, age);
    }
}