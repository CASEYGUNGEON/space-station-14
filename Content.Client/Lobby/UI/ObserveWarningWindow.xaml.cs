using JetBrains.Annotations;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Lobby.UI;

[GenerateTypedNameReferences]
[UsedImplicitly]
public sealed partial class ObserveWarningWindow : DefaultWindow
{
    public ObserveWarningWindow()
    {
        Title = Loc.GetString("observe-warning-window-title");
        RobustXamlLoader.Load(this);
        IoCManager.InjectDependencies(this);

        ObserveButton.OnPressed += _ => { this.Close(); };
        NevermindButton.OnPressed += _ => { this.Close(); };
    }
}