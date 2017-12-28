using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace TaskManager
{
    public class TaskValidationRule2 : ValidationRule
    {
        public override ValidationResult Validate(object value,
            System.Globalization.CultureInfo cultureInfo)
        {
            Task task = (value as BindingGroup).Items[0] as Task;
            if (task.dueDate < DateTime.Now)
            {
                return new ValidationResult(false,
                    "Due Date must be later than now.");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }
}
