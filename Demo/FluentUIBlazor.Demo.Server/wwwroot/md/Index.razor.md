using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace FluentUI.Demo.Shared.Pages
{
    public partial class Index
    {
        Type[] types => Assembly.GetExecutingAssembly().GetTypes().Where(type => type.BaseType == typeof(ComponentBase)).ToArray();
        Type selectedType;
        RenderFragment RenderFragment;
        private string componentName;
        public string ComponentName
        {
            get { return componentName; }
            set
            {
                componentName = value;
                selectedType = types.Where(type => type.Name.ToUpper() == value.ToUpper())
                    .FirstOrDefault() ?? typeof(Label);
                RenderFragment = (builder) =>
                {
                    builder.OpenComponent(0, selectedType);
                    builder.CloseComponent();
                };
            }
        }
    }
}
