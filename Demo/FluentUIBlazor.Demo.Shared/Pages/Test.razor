@page "/test"
@using System.Reflection
<h3>test</h3>
<div class="section" style="transition-delay: 0.05s;">
    <div class="sectionHeader">
        <h2 class="subHeading" id="basic-inputs">Search for Fluent UI Components</h2>
    </div>
    <div class="content">
        <input class="form form-control" @bind="componentName" @bind:event="oninput" />
        @RenderFragment
    </div>
</div>


@code {
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
