using Advanced.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advanced.Blazor.Forms
{
    public class DeptStateValidator : OwningComponentBase<DataContext>
    {
        public DataContext Context => Service;
        [Parameter]
        public long DepartmentId { get; set; }
        [Parameter]
        public string State { get; set; }
        [CascadingParameter]
        public EditContext CurrentEditContext { get; set; }
        private string DeptName { get; set; }
        private IDictionary<long, string> LocationStates { get; set; }
        protected override void OnInitialized()
        {
            ValidationMessageStore strore = new ValidationMessageStore(CurrentEditContext);
            CurrentEditContext.OnFieldChanged += (sender, args) =>
            {
                string name = args.FieldIdentifier.FieldName;
                if (name == "DepartmentID" || name == "LocationID")
                {
                    Validate(CurrentEditContext.Model as Person, strore);
                }
            };
        }
        protected override void OnParametersSet()
        {
            DeptName = Context.Departments.Find(DepartmentId).Name;
            LocationStates = Context.Locations.ToDictionary(l => l.LocationId, l => l.State);
        }
        private void Validate(Person model, ValidationMessageStore store)
        {
            if (model.DepartmentId == DepartmentId &&
                (!LocationStates.ContainsKey(model.LocationId) ||
                LocationStates[model.LocationId] != State))
            {
                store.Add(CurrentEditContext.Field("LocationId"), $"{DeptName} staff must be in: {State}");
            }
            else
            {
                store.Clear();
            }
            CurrentEditContext.NotifyValidationStateChanged();
        }
    }
    
}
