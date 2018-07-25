using Microsoft.AspNetCore.Blazor.Components;
using System.Collections.Generic;

namespace BlazorComponents
{
    public class GoalListModel : BlazorComponent
    {
        [Parameter]
        public IEnumerable<Goal> Goals { get; set; }
    }
}
