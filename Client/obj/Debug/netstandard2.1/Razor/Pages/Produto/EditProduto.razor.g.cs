#pragma checksum "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1633a76d7f46b0561aa55ba92b0d6bf1f295cba1"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Cadastro do Produto</h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                          produto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 10 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                                                               HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-row");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group col-5");
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.AddMarkupContent(21, "<label>Produto</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                            produto.Nome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Nome = __value, produto.Nome))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Nome));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __Blazor.Segundatentativa.Client.Pages.Produto.EditProduto.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 16 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                              () => produto.Nome

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group col-5");
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.AddMarkupContent(35, "<label>Descricao do produto</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                            produto.Descricao

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Descricao = __value, produto.Descricao))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => produto.Descricao));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __Blazor.Segundatentativa.Client.Pages.Produto.EditProduto.TypeInference.CreateValidationMessage_1(__builder2, 42, 43, 
#nullable restore
#line 21 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                              () => produto.Descricao

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group col");
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.AddMarkupContent(49, "<label>Valor do produto</label>\r\n                    ");
                __Blazor.Segundatentativa.Client.Pages.Produto.EditProduto.TypeInference.CreateInputNumber_2(__builder2, 50, 51, "form-control", 52, 
#nullable restore
#line 25 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                              produto.Preco

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => produto.Preco = __value, produto.Preco)), 54, () => produto.Preco);
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __Blazor.Segundatentativa.Client.Pages.Produto.EditProduto.TypeInference.CreateValidationMessage_3(__builder2, 56, 57, 
#nullable restore
#line 26 "C:\Users\luca-\Desktop\Segundatentativa\Client\Pages\Produto\EditProduto.razor"
                                              () => produto.Preco 

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.AddMarkupContent(61, "<div class=\"text-center\">\r\n                <button type=\"submit\" class=\"btn btn-primary mr-1\">Salvar</button>\r\n                <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
            __builder.CloseElement();
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
namespace __Blazor.Segundatentativa.Client.Pages.Produto.EditProduto
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
