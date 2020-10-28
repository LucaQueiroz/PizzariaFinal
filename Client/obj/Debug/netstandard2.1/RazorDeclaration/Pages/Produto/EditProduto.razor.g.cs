#pragma checksum "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1633a76d7f46b0561aa55ba92b0d6bf1f295cba1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Segundatentativa.Client.Pages.Produto
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
#line 3 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/EditProduto")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Produto/EditProduto/{Item}")]
    public partial class EditProduto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
       

    private Produto produto = new Produto();
    private EditContext editContext { get; set; }

    [Parameter]
    public string Item { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var itemId = Item;
        produto = await Http.GetFromJsonAsync<Produto>($"/produto/GetById?id={itemId}");
        editContext = new EditContext(produto);
    }

    private async Task HandleValidSubmit()
    {
        //Enviar dados para o Controller no Backend
        var teste = await Http.PutAsJsonAsync("/Produto/Update", produto);
        NavigationManager.NavigateTo("Produto/ListarProduto");
    }

    private void HandleReset()
    {
        produto = new Produto();
        editContext = new EditContext(produto);
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
