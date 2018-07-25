using BlazorEvalService.Models;
using Microsoft.AspNetCore.Blazor.Components;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;

namespace BlazorEvalApp.Pages
{
    public class GoalsModel : BlazorComponent
    {
        public IEnumerable<Goal> Goals { get; set; }

        public void LoadGoals()
        {
        }
    }
}
