#pragma checksum "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Usuario\ListarUsuario.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fffa07d9c0a04e58e8cf96076c1468b5d7bdc898"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Segundatentativa.Client.Pages.Usuario
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Segundatentativa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Segundatentativa.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\luca-\Desktop\Segundatentativa\Client\_Imports.razor"
using Segundatentativa.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Usuario\ListarUsuario.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Usuario/ListarUsuario")]
    public partial class ListarUsuario : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Usuario\ListarUsuario.razor"
       

    private List<Usuario> ListaUsuario = new List<Usuario>();

    protected override async Task OnInitializedAsync()
    {

        var usuarios = await Http.GetFromJsonAsync<List<Usuario>>("/Usuario/List");
        foreach (var item in usuarios)
        {
            ListaUsuario.Add(item);
        }
    }

    private async Task DeleteUsuario(int itemId)
    {
        //call controller
        await Http.DeleteAsync("/Usuario/Delete/"+itemId);
        NavigationManager.NavigateTo("Usuario/ListarUsuario", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
