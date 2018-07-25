using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorComponents
{
    public class GoalModel : BlazorComponent
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public string Description { get; set; }
    }
}
