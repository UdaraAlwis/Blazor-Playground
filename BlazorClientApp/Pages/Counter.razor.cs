using Microsoft.AspNetCore.Components;

namespace BlazorClientApp.Pages
{
    public class CounterBase : ComponentBase
    {
        [Parameter]
        public int CurrentCount { get; set; } = 0;

        public void IncrementCount()
        {
            CurrentCount++;
        }
    }
}
