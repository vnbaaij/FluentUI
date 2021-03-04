@page "/test"
@using System.Reflection
@using System.Linq
<h3>test</h3>
<div class="section" style="transition-delay: 0.05s;">
    <div class="sectionHeader">
        <h2 class="subHeading" id="basic-inputs">Search for Fluent UI Components</h2>
    </div>
    <div class="content">
        <input class="form form-control" @bind="ComponentName" @bind:event="oninput" />

        @{
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (AssemblyName an in a.GetReferencedAssemblies().Where(x => x.Name.StartsWith("FluentUI")))
            {
                string s = $"Name={an.Name}, Version={an.Version}, Culture={an.CultureInfo.Name}, PublicKey token={BitConverter.ToString(an.GetPublicKeyToken())}";
                @s
                <br />
            }
        }
        @RenderFragment
    </div>
</div>


@code {
    private IEnumerable<Type> types;
    //= from a in AppDomain.CurrentDomain.GetAssemblies().Where(a=>a.FullName.StartsWith("FluentUI") )
    //                         from t in a.GetExportedTypes()
    //                          select t;

    //Assembly.GetExecutingAssembly().GetReferencedAssemblies().GetTypes().Where(type => type.BaseType == typeof(ComponentBase)).ToArray();
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

    protected override void OnInitialized()
    {
        types = FindTypes(x => x.FullName.StartsWith("FluentUI"));
        base.OnInitialized();
    }

    public static IEnumerable<Type> FindTypes(Func<Type, bool> predicate)
    {
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        {
            if (!assembly.IsDynamic)
            {
                Type[] exportedTypes = null;
                try
                {
                    exportedTypes = assembly.GetExportedTypes();
                }
                catch (ReflectionTypeLoadException e)
                {
                    exportedTypes = e.Types;
                }

                if (exportedTypes != null)
                {
                    foreach (var type in exportedTypes)
                    {
                        if (predicate(type))
                            yield return type;
                    }
                }
            }
        }
    }
}
