@page  "/focusTrapZonePage"

<header class="root">
    <h1 class="title">FocusTrapZonePage</h1>
</header>
<div class="section" style="transition-delay: 0s;">
    <div id="overview" tabindex="-1">
        <h2 class="subHeading hiddenContent">Overview</h2>
    </div>
    <div class="content">
        <div class="ms-Markdown">
            <p>

            </p>
        </div>
    </div>
</div>
<div class="section" style="transition-delay: 0s;">
    <div id="overview" tabindex="-1">
        <h2 class="subHeading">Usage</h2>
    </div>
    <div>
        <div class="subSection">
            <Checkbox @bind-Checked=@isFocusTrapped @bind-Checked:event="CheckedChanged" Label="Enable FocusTrapZone" />
            <div style="padding: 50px; background-color:yellow;">
                <FocusTrapZone Disabled=@(!isFocusTrapped)>
                    <DefaultButton Text="First Button" OnClick=@OnInnerClick />
                    <DefaultButton Text="Second Button" OnClick=@OnInnerClick />
                    <DefaultButton Text="Third Button" OnClick=@OnInnerClick />
                </FocusTrapZone>
            </div>

            <DefaultButton Text="Outside Button" OnClick=@OnOuterClick />

            <em>@debugText</em>
            @isFocusTrapped
        </div>
    </div>
</div>

@code {
// ToDo: Add Demo sections
    bool isFocusTrapped = false;
    string debugText = "";

    Task OnInnerClick(MouseEventArgs args)
    {
        debugText = "Inner button clicked";
        return Task.CompletedTask;
    }
    Task OnOuterClick(MouseEventArgs args)
    {
        debugText = "Outer button clicked";
        return Task.CompletedTask;
    }
}
