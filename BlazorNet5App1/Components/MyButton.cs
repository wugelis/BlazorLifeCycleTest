using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNet5App1.Components
{
    public class MyButton: ComponentBase
    {
        protected int current = 0;

        protected string _buttonText = "";

        [Parameter]
        public string ButtonText { get; set; }

        [Parameter]
        public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(5, "button");
            builder.AddAttribute(6, "class", "btn btn-primary");
            builder.AddAttribute(7, "onclick", OnClickCallback);
            builder.AddContent(8, ButtonText);
            builder.CloseElement();
        }

        protected void Button_Click()
        {
            current++;

            string buttonText = $"{_buttonText} {current}";

            ButtonText = "";

            ButtonText = buttonText;
        }

        protected override void OnParametersSet()
        {
            _buttonText = ButtonText;

            base.OnParametersSet();
        }

        protected override bool ShouldRender()
        {
            return true;
        }
    }
}
