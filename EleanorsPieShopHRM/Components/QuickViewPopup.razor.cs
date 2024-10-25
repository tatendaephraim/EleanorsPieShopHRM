using EleanorsPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace EleanorsPieShopHRM.Components
{
    public partial class QuickViewPopup
    {
        [Parameter]
        public Employee? Employee { get; set; }

        private Employee? _employee;

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            _employee = Employee;
        }

        public void Close()
        {
            _employee = null;
        }

    }
}
