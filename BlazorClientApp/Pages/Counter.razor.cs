using Microsoft.AspNetCore.Components;

namespace BlazorClientApp.Pages
{
    public class CounterBase : ComponentBase
    {
        public int CurrentCount = 0;

        public void IncrementCount()
        {
            CurrentCount++;
        }
    }
}
