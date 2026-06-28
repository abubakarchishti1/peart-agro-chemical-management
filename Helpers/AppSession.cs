namespace PeartAgroChemicalsManagementSystem.Helpers
{
    public static class AppSession
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string FullName { get; set; }
        public static string Role { get; set; }

        public static void Clear()
        {
            UserID = 0;
            Username = "";
            FullName = "";
            Role = "";
        }

        public static bool IsAdmin => Role == "Admin";
        public static bool IsManager => Role == "Manager";
    }
}