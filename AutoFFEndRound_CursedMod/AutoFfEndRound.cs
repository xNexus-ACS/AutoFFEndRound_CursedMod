using CursedMod.Events.Handlers;
using CursedMod.Features.Wrappers.Server;
using CursedMod.Loader;
using CursedMod.Loader.Modules;

namespace AutoFFEndRound_CursedMod;

public class AutoFfEndRound : CursedModule
{
    public override string ModuleAuthor => "xNexusACS";
    public override string ModuleName => "AutoFFEndRound";
    public override string ModuleVersion => "1.0.0";
    public override string CursedModVersion => CursedModInformation.Version;

    public override void OnLoaded()
    {
        CursedRoundEventsHandler.RoundEnded += OnRoundEnded;
        CursedRoundEventsHandler.RestartingRound += OnRestartingRound;
        base.OnLoaded();
    }

    public override void OnUnloaded()
    {
        CursedRoundEventsHandler.RoundEnded -= OnRoundEnded;
        CursedRoundEventsHandler.RestartingRound -= OnRestartingRound;
        base.OnUnloaded();
    }
    
    private void OnRoundEnded()
    {
        CursedServer.IsFriendlyFireEnabled = true;
    }
    
    private void OnRestartingRound()
    {
        CursedServer.IsFriendlyFireEnabled = false;
    }
}