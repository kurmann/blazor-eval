using Microsoft.AspNetCore.Blazor.Components;
using System.Collections.Generic;

namespace BlazorComponents
{
    public class SimpleListModel : BlazorComponent
    {
        public List<string> listItems = new List<string>();
        public string newItem;

        public void AddItem()
        {
            if (string.IsNullOrEmpty(newItem))
                return;

            listItems.Add(newItem);
            newItem = "";
        }
    }
}
