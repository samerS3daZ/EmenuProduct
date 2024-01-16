namespace BCM.Infrastructure.Helpers
{
    public static class _Constants
    {
        public static readonly List<string> allowedExtensions = new() { ".jpg", ".jpeg", ".png" };
        public static readonly int MegaByte = 1048576;
        public static readonly int MaxLength = 1 * MegaByte;
        public static readonly int MaxUploadedImage = 3;
		public static readonly List<string> allowedDigitalExtensions = new() { ".rar", ".zip", ".pdf" };
		public static readonly int MaxDigitalLength = 10 * MegaByte;
        public static readonly TimeSpan TokenLifeSpan = TimeSpan.FromMinutes(30);
    }
}
