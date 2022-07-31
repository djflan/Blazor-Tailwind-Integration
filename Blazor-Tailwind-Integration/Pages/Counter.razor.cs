using Microsoft.AspNetCore.Components;

namespace Blazor_Tailwind_Integration.Pages
{
    public partial class Counter : ComponentBase
    {
        private int _currentCount = 0;

        [Parameter]
        public int IncrementAmount { get; set; } = 1;

        private void IncrementCount()
        {
            _currentCount+= IncrementAmount;
        }
    }
}
