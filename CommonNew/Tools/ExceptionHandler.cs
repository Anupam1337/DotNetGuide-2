namespace CommonNew.Tools
{
    public static class ExceptionHandler
    {
        public static void Handle(Exception ex)
        {
            LoggingHelper.Log($"Error: {ex.Message}");
        }
    }
}
