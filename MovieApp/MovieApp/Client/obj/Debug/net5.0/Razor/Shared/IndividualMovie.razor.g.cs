#pragma checksum "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3080a7004136cd2ed1babccb15e2cde5cf29242"
// <auto-generated/>
#pragma warning disable 1591
namespace MovieApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\_Imports.razor"
using MovieApp.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class IndividualMovie : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "individual-movie-container");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "href", 
#nullable restore
#line 2 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
              movieURL

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 3 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                   Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "alt", "Poster");
            __builder.AddAttribute(7, "class", "movie-poster");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "href", 
#nullable restore
#line 5 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                 movieURL

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
__builder.AddContent(12, Movie.TitleBrief);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.OpenElement(15, "a");
            __builder.AddAttribute(16, "class", "btn btn-info");
            __builder.AddAttribute(17, "href", "/movies/edit/" + (
#nullable restore
#line 7 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                                                    Movie.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-danger");
            __builder.AddAttribute(23, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
                            () => DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n            Delete\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Patryk\source\repos\cwiczenia12_mp-PatrykNosal66\MovieApp\MovieApp\Client\Shared\IndividualMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
    private string movieURL = string.Empty;

    protected override void OnInitialized()
    {
        movieURL = $"movie/{Movie.Id}/{Movie.Title.Replace(" ", "-")}";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
