namespace DefaultNamespace;

public interface IPrototype<T>
{
    T DeepCopy();
    T ShallowCopy();
}

public class ObjectToCopy : IPrototype<ObjectToCopy>
{
    public string Name { get; set; }
    public int[] Values { get; set; }

    public ObjectToCopy DeepCopy()
    {
        return new ObjectToCopy
        {
            Name = Name,
            Values = (int[])Values.Clone()
        };
    }

    public ObjectToCopy ShallowCopy()
    {
        return (ObjectToCopy)this.MemberwiseClone();
    }
}