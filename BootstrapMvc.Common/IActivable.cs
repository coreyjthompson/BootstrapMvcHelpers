namespace Mvc
{
    public interface IActivable
    {
        void SetActive(bool active = true);

        bool Active();
    }
}
