#pragma checksum "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\PaymentConfirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d12e399413c4a0bfdab4d22256302f7a0e7a2137"
// <auto-generated/>
#pragma warning disable 1591
namespace TvLicenceProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using TvLicenceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\_Imports.razor"
using TvLicenceProject.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/paymentconfirmation")]
    public partial class PaymentConfirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Please check you input the right details:</h1>\r\n<br>\r\n<br>\r\n<br>\r\netc, etc.\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\PaymentConfirmation.razor"
                                          Navigate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Pay");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\PaymentConfirmation.razor"
       
void Navigate()
{
    UriHelper.NavigateTo("paymentreceipt");
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
