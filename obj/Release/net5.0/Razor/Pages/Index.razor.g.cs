#pragma checksum "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c43598b8e958bee0ff4caae06816bd32b0606199"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea9.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Tarea9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Tarea9.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Tarea9.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using Tarea9.Data.Repositorio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddMarkupContent(3, "<thead><tr><th>Cedula</th>\r\n            <th>Nombre</th></tr></thead>\r\n    ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 15 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor"
         if(lsVacunados != null){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor"
             foreach (var item in lsVacunados)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 19 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor"
                         item.cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 20 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor"
                         item.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "D:\5 cuatrimestre\Programación III\unidad 9\tarea\Tarea9\Pages\Index.razor"
      
    List<Vacunados> lsVacunados = new List<Vacunados>();
    
    protected async override Task OnInitializedAsync()
    {
        lsVacunados = await RepoVacunados.Get();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepoVacunados RepoVacunados { get; set; }
    }
}
#pragma warning restore 1591