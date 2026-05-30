using Supabase;
namespace textSim.database
{
    public static class SupabaseService
    {
        public static Client? SupabaseClient;

        public static async Task Initialize()
        {
            var url = "add a supabase url";
            var key = "ADD a supabase";

            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };
            SupabaseClient = new Client(url, key, options);
            await SupabaseClient.InitializeAsync();
        }
    }
}
