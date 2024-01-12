using ECommons.DalamudServices;

namespace AetherBox.FeaturesSetup
{
    internal static class Events
    {
        private static uint? jobID;

        public static void Init()
        {
            Svc.Framework.Update += UpdateEvents;
        }

        public static void Disable()
        {
            Svc.Framework.Update -= UpdateEvents;
            Svc.Log.Debug("Disabled UpdateEvents.");
        }

        private static void UpdateEvents(Dalamud.Plugin.Services.IFramework framework)
        {
            if (Svc.ClientState.LocalPlayer is null) return;
            JobID = Svc.ClientState.LocalPlayer.ClassJob.Id;
        }

        public static uint? JobID
        {
            get => jobID;
            set
            {
                if (value != null && jobID != value)
                {
                    jobID = value;
                    Svc.Log.Debug($"Job changed to {value}");
                    OnJobChanged?.Invoke(value);
                }
            }
        }

        public delegate void OnJobChangeDelegate(uint? jobId);
        public static event OnJobChangeDelegate? OnJobChanged;

    }
}
