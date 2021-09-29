#pragma checksum "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9043517ac4234f5d196c855f356c2e7803108734"
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
#nullable restore
#line 3 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
using TvLicenceProject.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/financedetails")]
    public partial class FinanceDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "govuk-width-container");
            __builder.AddMarkupContent(2, "<br>\r\n  ");
            __builder.AddMarkupContent(3, "<h1>Enter card details</h1>\r\n  <br>\r\n  ");
            __builder.OpenElement(4, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                     User

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "<h5>Card number</h5>\r\n   \r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "id", "CardNumber");
                __builder2.AddAttribute(11, "class", "payment-form fulllength");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                             User.CardNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.CardNumber = __value, User.CardNumber))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.CardNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    \r\n\r\n      <br>\r\n\r\n      ");
                __builder2.AddMarkupContent(16, "<h5>Expiry date</h5>\r\n   \r\n      ");
                __builder2.AddMarkupContent(17, "<p>For example. 10/20</p>\r\n    \r\n    \r\n      ");
                __builder2.AddMarkupContent(18, "<label for=\"ExpiryMonth\">Month</label>\r\n      <span id=\"span\"></span>\r\n      ");
                __builder2.AddMarkupContent(19, "<label for=\"ExpiryYear\">Year</label>\r\n      <br>\r\n   \r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "ExpiryMonth");
                __builder2.AddAttribute(22, "class", "payment-form dateComp");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                            User.ExpiryMonth

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.ExpiryMonth = __value, User.ExpiryMonth))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.ExpiryMonth));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n      /\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "id", "ExpiryYear");
                __builder2.AddAttribute(29, "class", "payment-form dateComp");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                           User.ExpiryYear

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.ExpiryYear = __value, User.ExpiryYear))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.ExpiryYear));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n      \r\n      <br>\r\n      <br>\r\n\r\n      ");
                __builder2.AddMarkupContent(34, "<h5>Name on card</h5>\r\n     \r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "CardName");
                __builder2.AddAttribute(37, "class", "payment-form fulllength");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                           User.CardName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.CardName = __value, User.CardName))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.CardName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n      <br>\r\n    \r\n      ");
                __builder2.AddMarkupContent(42, "<h5>Card security code</h5>\r\n\r\n      ");
                __builder2.AddMarkupContent(43, "<p> The last 3 digits on the back of the card</p>\r\n    \r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "CardSecurity");
                __builder2.AddAttribute(46, "class", "payment-form cscnumber");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                              User.CardSecurity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.CardSecurity = __value, User.CardSecurity))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.CardSecurity));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n      \r\n      <br>\r\n      <br>\r\n\r\n\r\n      ");
                __builder2.AddMarkupContent(51, "<h3>Billing Address</h3> \r\n      ");
                __builder2.AddMarkupContent(52, "<p> This is the address associated with the card</p>\r\n  \r\n      ");
                __builder2.AddMarkupContent(53, "<h5>Building address or name and street</h5>\r\n   \r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "id", "BillingStreet");
                __builder2.AddAttribute(56, "class", "payment-form pad-down fulllength");
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                                         User.BillingStreet

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.BillingStreet = __value, User.BillingStreet))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.BillingStreet));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "BillingStreet");
                __builder2.AddAttribute(63, "class", "payment-form fulllength");
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                                User.BillingStreet

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.BillingStreet = __value, User.BillingStreet))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.BillingStreet));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n\r\n      <br>\r\n\r\n      ");
                __builder2.AddMarkupContent(68, "<h5>City</h5>\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(69);
                __builder2.AddAttribute(70, "id", "BillingCity");
                __builder2.AddAttribute(71, "class", "payment-form pad-down halflength");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                                       User.BillingCity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.BillingCity = __value, User.BillingCity))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.BillingCity));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n      <br>\r\n      ");
                __builder2.AddMarkupContent(76, "<h5>Postcode</h5>\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(77);
                __builder2.AddAttribute(78, "id", "BillingPostCode");
                __builder2.AddAttribute(79, "class", "payment-form cscnumber");
                __builder2.AddAttribute(80, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                                 User.BillingPostcode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(81, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.BillingPostcode = __value, User.BillingPostcode))));
                __builder2.AddAttribute(82, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.BillingPostcode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(83, "\r\n\r\n      <br>\r\n      ");
                __builder2.AddMarkupContent(84, "<h5>Email</h5>\r\n\r\n      ");
                __builder2.AddMarkupContent(85, "<p>We\'ll send your billing confirmation here</p>\r\n    \r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(86);
                __builder2.AddAttribute(87, "id", "BillingEmail");
                __builder2.AddAttribute(88, "class", "payment-form fulllength");
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 74 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                               User.BillingEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => User.BillingEmail = __value, User.BillingEmail))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => User.BillingEmail));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n\r\n      <br>  \r\n\r\n      ");
                __builder2.AddMarkupContent(93, "<blockquote class=\"fulllength\">\r\n        An email will be sent to:\r\n        <br>\r\n        <b>\'Add Update when typed: Email Address\'</b></blockquote>\r\n\r\n      <br>\r\n\r\n      ");
                __builder2.OpenElement(94, "button");
                __builder2.AddAttribute(95, "class", "govuk-button");
                __builder2.AddAttribute(96, "type", "submit");
                __builder2.AddAttribute(97, "value", "submit");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
                                                                          Navigate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(99, "Continue");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "J:\Documents\Code\TVLicenceProject\TvLicenceProject\Pages\FinanceDetails.razor"
 
  
  
  void Navigate()
{
    UriHelper.NavigateTo("paymentconfirmation");
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserInfo User { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
    }
}
#pragma warning restore 1591
