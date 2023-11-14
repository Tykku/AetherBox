using AetherBox.UI;
using AetherBox.Configurations;
using Dalamud.Game.ClientState.Conditions;
using Dalamud.Game.Text.SeStringHandling.Payloads;
using Dalamud.Game.Command;
using Dalamud.IoC;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using ECommons;
using ECommons.DalamudServices;
using ECommons.GameHelpers;
using ECommons.ImGuiMethods;
using Dalamud.Interface.Internal;

namespace AetherBox;

public sealed class AetherBoxPlugin : IDalamudPlugin, IDisposable
{
    static readonly List<IDisposable> _dis = new();

    public string Name => "AetherBox";
    private const string CommandName = "/aetherbox";

    private DalamudPluginInterface PluginInterface { get; init; }
    private ICommandManager CommandManager { get; init; }
    public Configuration Configuration { get; init; }
    public WindowSystem WindowSystem = new("AetherBox");

    private ConfigWindow ConfigWindow { get; init; }
    private MainWindow MainWindow { get; init; }

    public AetherBoxPlugin(
        [RequiredVersion("1.0")] DalamudPluginInterface pluginInterface,
        [RequiredVersion("1.0")] ICommandManager commandManager)
    {
        this.PluginInterface = pluginInterface;
        this.CommandManager = commandManager;

        this.Configuration = this.PluginInterface.GetPluginConfig() as Configuration ?? new Configuration();
        this.Configuration.Initialize(this.PluginInterface);

        // Assuming the images are in an 'Images' subfolder in the same directory as the assembly
        var imagePath = Path.Combine(PluginInterface.AssemblyLocation.Directory?.FullName!, "Images", "logo.png");
        var logoImage = this.PluginInterface.UiBuilder.LoadImage(imagePath);


        ConfigWindow = new ConfigWindow(this);
        MainWindow = new MainWindow(this, logoImage);
        
        WindowSystem.AddWindow(ConfigWindow);
        WindowSystem.AddWindow(MainWindow);

        this.CommandManager.AddHandler(CommandName, new CommandInfo(OnCommand)
        {
            HelpMessage = "Opens Main Menu"
        });

        this.PluginInterface.UiBuilder.Draw += DrawUI;
        this.PluginInterface.UiBuilder.OpenMainUi += ToggleMainWindow;
        this.PluginInterface.UiBuilder.OpenConfigUi += ToggleMainWindow;
    }

    public void Dispose()
    {
        this.WindowSystem.RemoveAllWindows();
        
        ConfigWindow.Dispose();
        MainWindow.Dispose();
        
        this.CommandManager.RemoveHandler(CommandName);
    }

    // in response to the slash command, just display our main ui
    private void OnCommand(string command, string args)
    {        
        MainWindow.IsOpen = true;
    }

    private void DrawUI()
    {
        this.WindowSystem.Draw();
    }

    public void DrawConfigUI()
    {
        ConfigWindow.IsOpen = true;
    }

    //
    // Summary:
    //     Toggle MainWindow is open state.
    private void ToggleMainWindow()
    {
        MainWindow.IsOpen = !MainWindow.IsOpen;
    }

    // Public method to load images from the 'Images' folder within the assembly directory
    public IDalamudTextureWrap? LoadImage(string imageName)
    {
        // Assuming the 'Images' folder is in the same directory as the assembly
        var imagesDirectory = Path.Combine(this.PluginInterface.AssemblyLocation.Directory?.FullName!, "Images");
        var imagePath = Path.Combine(imagesDirectory, imageName);

        // Check if the file exists before trying to load it
        if (File.Exists(imagePath))
        {
            return this.PluginInterface.UiBuilder.LoadImage(imagePath);
        }
        else
        {
            // Handle the case where the image does not exist
            // You could log an error or throw an exception, depending on your error handling strategy
            Svc.Log.Error($"Image not found: {imagePath}");
            return null; // Or however you wish to handle this case
        }
    }
}