public interface IBaseView<TController, TProperties>
{
    public TController Controller { get; }
    public TProperties Properties { get; }
}