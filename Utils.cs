namespace ABMTestLOC
{
    public static class Utils
    {
        public static void ClearNewLine(ref string message)
        {
            message = message.Replace("\r", "");
            message = message.Replace("\n", "");
        }
    }
}