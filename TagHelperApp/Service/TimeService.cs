namespace TagHelperApp.Service
{
    interface ITimeService
    {
        string GetTimeService();
    }
    public class TimeService : ITimeService
    {
        public string GetTimeService()
        {
            return DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }
    }
}
