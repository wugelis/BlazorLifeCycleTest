using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNet5App1.Components
{
    public class MyButton2: ComponentBase
    {
        [Parameter]
        public string ButtonText { get; set; }
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            builder.AddMarkupContent(0, $"<button class=\"btn btn-primary\">{ButtonText}</button>");
        }

        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
