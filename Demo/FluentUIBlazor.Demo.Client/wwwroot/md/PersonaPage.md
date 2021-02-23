@page "/personaPage"

<header class="root">
    <h1 class="title">Persona</h1>
</header>
<div class="section" style="transition-delay: 0s;">
    <div id="overview" tabindex="-1">
        <h2 class="subHeading hiddenContent">Overview</h2>
    </div>
    <div class="content">
        <div class="ms-Markdown">
            <p>A persona is a visual representation of a person across products, typically showcasing the image that person has&nbsp;chosen to&nbsp;upload themselves.&nbsp;The control&nbsp;can also&nbsp;be&nbsp;used to show that person's online status.</p>
            <p>The persona control is used in the&nbsp;<code>PeoplePicker</code>&nbsp;and&nbsp;<code>Facepile</code>&nbsp;controls.</p>
            <p>The complete control inclues an individual's avatar (an uploaded image or a composition of the person’s initials on a background&nbsp;color), their name or identification, and online status.</p>
        </div>
    </div>
</div>
<div class="section" style="transition-delay: 0s;">
    <div id="overview" tabindex="-1">
        <h2 class="subHeading">Usage</h2>
    </div>
    <div>
        <div class="subSection">
            <Demo Header="Persona in various sizes" Key="0" MetadataPath="PersonaPage">
                <Stack Horizontal="false" Tokens="@(new StackTokens() { ChildrenGap = new [] {10d}})">
                    <Checkbox DefaultChecked="true" Label="Include persona details" @bind-Checked=ShowDetails />

                    <Label>Size 8 Persona, with no presence</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Size=@PersonaSize.Size8
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />
                    <Label>Size 8 Persona, with presence</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Offline
                             Size=@PersonaSize.Size8
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 24 Persona</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Online
                             Size=@PersonaSize.Size24
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 32 Persona</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Online
                             Size=@PersonaSize.Size32
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 40 Persona</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Away
                             Size=@PersonaSize.Size40
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 48 Persona (default)</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Busy
                             Size=@PersonaSize.Size48
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 56 Persona (default)</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Online
                             Size=@PersonaSize.Size56
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 72 Persona</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.DND
                             Size=@PersonaSize.Size72
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 100 Persona</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Blocked
                             Size=@PersonaSize.Size100
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />

                    <Label>Size 120 Persona</Label>
                    <Persona Text="Annie Lindqvist"
                             SecondaryText="Got no job"
                             TertiaryText="Found on the internet"
                             OptionalText="Don't worry about this guy"
                             ImageUrl="personFace.jpg"
                             Presence=@PersonaPresenceStatus.Away
                             Size=@PersonaSize.Size120
                             ShowInitialsUntilImageLoads="true"
                             HidePersonaDetails="!ShowDetails" />
                </Stack>
            </Demo>
        </div>
        <div class="subSection">
            <Demo Header="Persona with initials" Key="1" MetadataPath="PersonaPage">
                <Stack Horizontal="false" Tokens="@(new StackTokens() { ChildrenGap = new [] {10d}})">
                    <Persona Text="Kat Larrson" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size24 />
                    <Persona Text="Annie" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size24 />
                    <Persona Text="Annie Lind" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size32 />
                    <Persona Text="Annie Boyl Lind" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size32 />
                    <Persona Text="David (The man) Goff" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size32 />
                    <Persona Text="David Goff [The man]" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size32 />
                    <Persona Text="Annie Boyl Carrie Lindqvist" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size40 />
                    <Persona Text="+1 (111) 123-4567 X4567" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size40 />
                    <Persona Text="+1 (555) 123-4567 X4567" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size48 AllowPhoneInitials=true />
                    <Persona Text="宋智洋" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size48 />
                    <Persona Text="남궁 성종" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size56 />
                    <Persona Text="خسرو رحیمی" SecondaryText="Designer" TertiaryText="In a meeting" OptionalText="Available at 4:00pm" Size=@PersonaSize.Size56 />
                    <Persona Text="Maor Sharett" ImageInitials="MS" SecondaryText="Designer" TertiaryText="In a meeting" InitialsColor=@PersonaInitialsColor.LightBlue Size=@PersonaSize.Size72 />
                    <Persona Text="Maor Sharett" ImageInitials="MS" SecondaryText="Designer" TertiaryText="In a meeting" InitialsColor=@PersonaInitialsColor.Magenta Size=@PersonaSize.Size100 />
                    <Persona Text="Maor Sharett" ImageInitials="MS" SecondaryText="Designer" TertiaryText="In a meeting" InitialsColor=@PersonaInitialsColor.Teal CoinSize=150 />
                </Stack>
            </Demo>
        </div>
        <div class="subSection">
            <Demo Header="Persona Presence" Key="2" MetadataPath="PersonaPage">
                <Stack Horizontal="true">
                    <Stack>
                        <Label>Online</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     ImageAlt="Annie Lindqvist, status is online." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     ImageAlt="Annie Lindqvist, status is online." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     ImageAlt="Annie Lindqvist, status is online." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     ImageAlt="Annie Lindqvist, status is online." />
                        </Stack>
                    </Stack>

                    <Stack>
                        <Label>Online + Out of Office</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is online and out of office." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is online and out of office." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is online and out of office." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Online
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is online and out of office." />
                        </Stack>
                    </Stack>
                </Stack>

                <Stack Horizontal="true">
                    <Stack>
                        <Label>Away</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     ImageAlt="Annie Lindqvist, status is away." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     ImageAlt="Annie Lindqvist, status is away." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     ImageAlt="Annie Lindqvist, status is away." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     ImageAlt="Annie Lindqvist, status is away." />
                        </Stack>
                    </Stack>

                    <Stack>
                        <Label>Away + Out of Office</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is away and out of office." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is away and out of office." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is away and out of office." />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Away
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is away and out of office." />
                        </Stack>
                    </Stack>
                </Stack>

                <Stack Horizontal="true">
                    <Stack>
                        <Label>Busy</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     ImageAlt="Annie Lindqvist, status is busy" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     ImageAlt="Annie Lindqvist, status is busy" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     ImageAlt="Annie Lindqvist, status is busy" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     ImageAlt="Annie Lindqvist, status is busy" />
                        </Stack>
                    </Stack>

                    <Stack>
                        <Label>Busy + Out of Office</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is busy and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is busy and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is busy and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Busy
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is busy and out of office" />
                        </Stack>
                    </Stack>
                </Stack>

                <Stack Horizontal="true">
                    <Stack>
                        <Label>Do not Disturb</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     ImageAlt="Annie Lindqvist, status is do not disturb" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     ImageAlt="Annie Lindqvist, status is do not disturb" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     ImageAlt="Annie Lindqvist, status is do not disturb" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     ImageAlt="Annie Lindqvist, status is do not disturb" />
                        </Stack>
                    </Stack>

                    <Stack>
                        <Label>Do not Disturb + Out of Office</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is do not disturb and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is do not disturb and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is do not disturb and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.DND
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is do not disturb and out of office" />
                        </Stack>
                    </Stack>
                </Stack>

                <Label>Blocked</Label>
                <Stack Horizontal="true">
                    <Persona Text=""
                             Size=@PersonaSize.Size8
                             HidePersonaDetails="true"
                             Presence=@PersonaPresenceStatus.Blocked
                             ImageAlt="Annie Lindqvist, status is blocked" />
                    <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                             ImageInitials="AL"
                             Text="Annie Lindqvist"
                             SecondaryText="Software Engineer"
                             TertiaryText="In a meeting"
                             OptionalText="Available at 4:00pm"
                             Size=@PersonaSize.Size24
                             HidePersonaDetails="true"
                             Presence=@PersonaPresenceStatus.Blocked
                             ImageAlt="Annie Lindqvist, status is blocked" />
                    <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                             ImageInitials="AL"
                             Text="Annie Lindqvist"
                             SecondaryText="Software Engineer"
                             TertiaryText="In a meeting"
                             OptionalText="Available at 4:00pm"
                             HidePersonaDetails="true"
                             Presence=@PersonaPresenceStatus.Blocked
                             ImageAlt="Annie Lindqvist, status is blocked" />
                    <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                             ImageInitials="AL"
                             Text="Annie Lindqvist"
                             SecondaryText="Software Engineer"
                             TertiaryText="In a meeting"
                             OptionalText="Available at 4:00pm"
                             Size=@PersonaSize.Size72
                             HidePersonaDetails="true"
                             Presence=@PersonaPresenceStatus.Blocked
                             ImageAlt="Annie Lindqvist, status is blocked" />
                </Stack>

                <Stack Horizontal="true">
                    <Stack>
                        <Label>Offline</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     ImageAlt="Annie Lindqvist, status is offline" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     ImageAlt="Annie Lindqvist, status is offline" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     ImageAlt="Annie Lindqvist, status is offline" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     ImageAlt="Annie Lindqvist, status is offline" />
                        </Stack>
                    </Stack>

                    <Stack>
                        <Label>Offline + Out of Office</Label>
                        <Stack Horizontal="true">
                            <Persona Text=""
                                     Size=@PersonaSize.Size8
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is offline and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size24
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is offline and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is offline and out of office" />
                            <Persona ImageUrl="https://static2.sharepointonline.com/files/fabric/office-ui-fabric-react-assets/persona-female.png"
                                     ImageInitials="AL"
                                     Text="Annie Lindqvist"
                                     SecondaryText="Software Engineer"
                                     TertiaryText="In a meeting"
                                     OptionalText="Available at 4:00pm"
                                     Size=@PersonaSize.Size72
                                     HidePersonaDetails="true"
                                     Presence=@PersonaPresenceStatus.Offline
                                     IsOutOfOffice="true"
                                     ImageAlt="Annie Lindqvist, status is offline and out of office" />
                        </Stack>
                    </Stack>
                </Stack>
            </Demo>
        </div>
    </div>
</div>

@code {
    //ToDo: Add Demo sections
    bool ShowDetails = true;
}
