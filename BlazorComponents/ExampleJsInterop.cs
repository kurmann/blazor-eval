using System;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorComponents
{
    public class ExampleJsInterop
    {
        public static string Prompt(string message)
        {
            return RegisteredFunction.Invoke<string>(
                "BlazorComponents.ExampleJsInterop.Prompt",
                message);
        }
    }
}
