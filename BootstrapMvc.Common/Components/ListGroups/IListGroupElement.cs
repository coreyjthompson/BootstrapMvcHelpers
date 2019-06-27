namespace Mvc.ListGroups
{
    public interface IListGroupElement : IActivable, IDisableable
    {
        ListGroupItemType Type { get; set; }
    }
}
