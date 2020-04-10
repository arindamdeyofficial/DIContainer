namespace DIContainer
{
    public interface IProduct<T> where T:new()
    {
        string Desc { get; set; }
        string Name { get; set; }
    }
}