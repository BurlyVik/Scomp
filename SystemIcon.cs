namespace scomp
{
    // Helper class to get system icons for file extensions
    public static class SystemIcon
    {
        public static Icon GetIconForExtension(FileInfo file)
        {
            // Get the default icon for a file extension
            Icon icon = Icon.ExtractAssociatedIcon($"{file.FullName}");
            return icon;
        }
    }
}
