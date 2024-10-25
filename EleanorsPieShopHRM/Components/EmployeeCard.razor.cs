using EleanorsPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EleanorsPieShopHRM.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee Employee { get; set; } = default!;
        [Parameter]
        public EventCallback<Employee> EmployeeQuickViewClicked { get; set; }
    }
}
