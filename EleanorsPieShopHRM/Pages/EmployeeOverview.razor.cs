﻿using EleanorsPieShopHRM.Models;
using EleanorsPieShopHRM.Shared.Domain;

namespace EleanorsPieShopHRM.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default!;
        private Employee? _selectedEmployee;

        protected override void OnInitialized()
        {
            base.OnInitialized();

            Employees= MockDataService.Employees;
        }
        public void ShowQuickViewPopup(Employee selectedEmployee)
        {
            _selectedEmployee= selectedEmployee;
        }
    }
}
