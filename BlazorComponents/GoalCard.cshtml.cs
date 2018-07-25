using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorComponents
{
    public class GoalCardModel : BlazorComponent
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }

        [Parameter]
        public string Header { get; set; }
    }
}
