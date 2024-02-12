using System;
using AetherBox.Features;
using AetherBox.FeaturesSetup;
using ClickLib;
using Dalamud.Game.Addon.Lifecycle;
using Dalamud.Game.Addon.Lifecycle.AddonArgTypes;
using Dalamud.Game.ClientState.Keys;
using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Interface.Internal.Notifications;
using Dalamud.Plugin.Services;
using ECommons;
using ECommons.Automation;
using ECommons.DalamudServices;
using FFXIVClientStructs.FFXIV.Client.Game.Control;
using FFXIVClientStructs.FFXIV.Client.Game.Object;
using FFXIVClientStructs.FFXIV.Client.UI;
using FFXIVClientStructs.FFXIV.Component.GUI;
namespace AetherBox.Features.Experiments;
public class AutoCrystalTowerStriker : Feature
{
	public override string Name => "Auto Crystal Tower Striker";

	public override string Description => "Auto play the Crystal Tower Striker minigame in the Gold Saucer";

	public override FeatureType FeatureType => FeatureType.Disabled;

	public bool Initialized { get; set; }

	private VirtualKey ConflictKey { get; set; } = VirtualKey.SHIFT;


	public override void Enable()
	{
		base.Enable();
		Svc.Framework.Update += OnUpdate;
		Svc.AddonLifeCycle.RegisterListener(AddonEvent.PostSetup, "Hummer", OnAddonSetup);
		Initialized = true;
	}

	public override void Disable()
	{
		base.Disable();
		Svc.Framework.Update -= OnUpdate;
		Svc.AddonLifeCycle.UnregisterListener(OnAddonSetup);
		TaskManager?.Abort();
		Initialized = false;
	}

	private void OnUpdate(IFramework framework)
	{
		if (TaskManager.IsBusy && Svc.KeyState[ConflictKey])
		{
			TaskManager.Abort();
			Svc.PluginInterface.UiBuilder.AddNotification("ConflictKey used on AutoCrystalTowerStriker", "AetherBox", NotificationType.Success);
		}
	}

	private void OnAddonSetup(AddonEvent type, AddonArgs args)
	{
		TaskManager.Enqueue((Func<bool?>)WaitSelectStringAddon, (string)null);
		TaskManager.Enqueue((Func<bool?>)ClickGameButton, (string)null);
	}

	private unsafe static bool? WaitSelectStringAddon()
	{
		if (GenericHelpers.TryGetAddonByName<AddonSelectString>("SelectString", out var addon) && GenericHelpers.IsAddonReady(&addon->AtkUnitBase))
		{
			return Click.TrySendClick("select_string1");
		}
		return false;
	}

	private unsafe bool? ClickGameButton()
	{
		if (GenericHelpers.TryGetAddonByName<AtkUnitBase>("Hummer", out var addon) && GenericHelpers.IsAddonReady(addon))
		{
			AtkComponentButton* button;
			button = addon->GetButtonNodeById(29u);
			if (button == null || !button->IsEnabled)
			{
				return false;
			}
			addon->IsVisible = false;
			Callback.Fire(addon, true, 11, 3, 0);
			TaskManager.DelayNext(5000);
			TaskManager.Enqueue((Func<bool?>)StartAnotherRound, (string)null);
			return true;
		}
		return false;
	}

	private unsafe static bool? StartAnotherRound()
	{
		if (GenericHelpers.IsOccupied())
		{
			return false;
		}
		Dalamud.Game.ClientState.Objects.Types.GameObject machineTarget;
		machineTarget = Svc.Targets.PreviousTarget;
		FFXIVClientStructs.FFXIV.Client.Game.Object.GameObject* machine;
		machine = ((machineTarget.DataId == 2005035) ? ((FFXIVClientStructs.FFXIV.Client.Game.Object.GameObject*)machineTarget.Address) : ((FFXIVClientStructs.FFXIV.Client.Game.Object.GameObject*)null));
		if (machine != null)
		{
			TargetSystem.Instance()->InteractWithObject(machine);
			return true;
		}
		return false;
	}
}
