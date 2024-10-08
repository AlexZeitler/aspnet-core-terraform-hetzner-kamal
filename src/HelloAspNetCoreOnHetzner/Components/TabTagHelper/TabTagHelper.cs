using HelloAspNetCoreOnHetzner.Components.PartialTagHelperBase;
using HelloAspNetCoreOnHetzner.Components.NavigationItemTagHelper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HelloAspNetCoreOnHetzner.Components.TabTagHelper;

public class TabTagHelper : PartialTagHelperBase.PartialTagHelperBase
{
  public TabTagHelper(
    IHtmlHelper htmlHelper
  ) : base(htmlHelper)
  {
  }

  [HtmlAttributeName("item")] public NavigationItem? Item { get; set; }

  public override async Task ProcessAsync(
    TagHelperContext context,
    TagHelperOutput output
  )
  {
    if (Item == null)
      throw new ArgumentNullException(nameof(Item));

    var someContent = await RenderPartial("TabTagHelper", Item);

    output.PreContent.AppendHtml(someContent);
  }
}
