#pragma checksum "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\Pages\PaymentReceipt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59987b7d9c104ca9096577654175470253a9ccd6"
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
#line 1 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using TvLicenceProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "J:\Documents\Code\TVLicenceProject\BlazorApp\TvLicenceProject\_Imports.razor"
using TvLicenceProject.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/paymentreceipt")]
    public partial class PaymentReceipt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Payment complete</h1>\r\n<br>\r\n<br>\r\n<br>\r\nPayment Reference number:\r\n<br> \r\nAmount paid:\r\n<br>\r\nDate: \r\n<br>\r\n<br>\r\n<br>\r\nYour payment was successful.\r\nA confirmation email was sent to your email address\r\n");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591