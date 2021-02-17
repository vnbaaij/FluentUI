@page "/stackPage"

<header class="root">
    <h1 class="title">Stack</h1>
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
            <Stack>
                <Stack>
                    <StackItem Tokens=@(new StackItemTokens { Padding = 10 }) Align=@Alignment.End>
                        <span>Here's one</span>
                    </StackItem>
                    <StackItem>
                        <span>Here's two</span>
                    </StackItem>
                    <StackItem>
                        <span>Here's three</span>
                    </StackItem>
                    <StackItem>
                        <span>Here's four</span>
                    </StackItem>
                </Stack>

                <Stack Tokens=@(new StackTokens { ChildrenGap = new[] { 10.0 }, Padding="5px 2px" })>
                    <span>Here's one</span>
                    <span>Here's two</span>
                    <span>Here's three</span>
                    <span>Here's four</span>
                </Stack>

                <Stack Wrap="true" Tokens=@(new StackTokens { ChildrenGap = new[] { 10.0 }, Padding="5px 2px" })>
                    <span>Here's one</span>
                    <span>Here's two</span>
                    <span>Here's three</span>
                    <span>Here's four</span>
                </Stack>

                <Stack Horizontal="true" Tokens=@(new StackTokens { ChildrenGap = new[] { 10.0 }, Padding="5px 2px" })>
                    <span>Here's one</span>
                    <span>Here's two</span>
                    <span>Here's three</span>
                    <span>Here's four</span>
                </Stack>

                <Stack Horizontal="true" Style=@mainStyle Tokens=@tokens>
                    <StackItem Grow="1" Style=@itemStyle>
                        <span>Here's one</span>
                    </StackItem>
                    <StackItem Grow="3" Style=@itemStyle>
                        <span>Here's two</span>
                    </StackItem>
                    <StackItem Grow="3" Style=@itemStyle>
                        <span>Here's three</span>
                    </StackItem>
                    <StackItem Grow="1" Style=@itemStyle>
                        <span>Here's four</span>
                    </StackItem>
                </Stack>

            </Stack>
        </div>
    </div>
</div>
@code {
    //ToDo: Add Demo sections
    string mainStyle = "background:var(--palette-ThemeTertiary);";
    string itemStyle = "background:var(--palette-ThemePrimary);";
    StackTokens tokens = new StackTokens { ChildrenGap = new double[] { 4.0 }, Padding = 8.0 };
}
