using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNet5App1.Shared
{
    public enum PageLoadingState { Loading, Loaded, Error, None };

    public partial class LoadingContainer
    {
        [Parameter]
        public PageLoadingState State { get; set; }

        [Parameter]
        public RenderFragment None { get; set; }

        [Parameter]
        public RenderFragment Loading { get; set; }

        [Parameter]
        public RenderFragment Loaded { get; set; }

        [Parameter]
        public RenderFragment Error { get; set; }
    }
}
