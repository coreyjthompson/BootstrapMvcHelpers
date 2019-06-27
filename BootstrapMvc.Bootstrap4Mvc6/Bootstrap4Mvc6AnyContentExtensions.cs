namespace Mvc
{
	#region

	using System.Collections.Generic;
	using System.Linq;

	using Mvc.Controls;
	using Mvc.Core;

	using Microsoft.AspNetCore.Mvc.Rendering;

	#endregion

	public static class Bootstrap4Mvc6AnyContentExtensions
	{
		public static IItemWriter<Select, SelectContent> Select(this IAnyContentMarker contentHelper, IEnumerable<SelectListItem> items)
		{
			var select = contentHelper.Select();
			select.Item.Items = items.Select(x => SelectListItemToSelectOption(contentHelper.Context, x));
			return select;
		}

		private static SelectOption SelectListItemToSelectOption(IBootstrapContext context, SelectListItem item)
		{
			return context.Helper.CreateWriter<SelectOption, AnyContent>(null).Value(item.Value).Disabled(item.Disabled).Content(item.Text).Item;
		}
	}
}