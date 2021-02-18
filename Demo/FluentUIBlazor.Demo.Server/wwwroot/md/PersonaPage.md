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

            <Persona Text="Random Person"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Online
                     Size=@PersonaSize.Size48
                     ShowInitialsUntilImageLoads="true" />

            <Persona Text="Someone Else"
                     Presence=@PersonaPresenceStatus.Online
                     Size=@PersonaSize.Size48
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size8, no presence</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Size=@PersonaSize.Size8
                     ShowInitialsUntilImageLoads="true" />
            <h3>Size8, with presence</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Offline
                     Size=@PersonaSize.Size8
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size24</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Online
                     Size=@PersonaSize.Size24
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size32</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Online
                     Size=@PersonaSize.Size32
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size40</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Away
                     Size=@PersonaSize.Size40
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size48</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Busy
                     Size=@PersonaSize.Size48
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size56</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Online
                     Size=@PersonaSize.Size56
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size72</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.DND
                     Size=@PersonaSize.Size72
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size100</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Blocked
                     Size=@PersonaSize.Size100
                     ShowInitialsUntilImageLoads="true" />

            <h3>Size120</h3>
            <Persona Text="Annie Lindqvist"
                     SecondaryText="Got no job"
                     TertiaryText="Found on the internet"
                     OptionalText="Don't worry about this guy"
                     ImageUrl="personFace.jpg"
                     Presence=@PersonaPresenceStatus.Away
                     Size=@PersonaSize.Size120
                     ShowInitialsUntilImageLoads="true" />

        </div>
    </div>
</div>

@code {
    //ToDo: Add Demo sections
}
