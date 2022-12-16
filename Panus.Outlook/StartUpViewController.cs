namespace Panus.Outlook
{
    public class StartUpViewController
    {
        public StartUpViewController(StartUpView startUpView)
        {
            this.View = startUpView;
        }
        public StartUpView View { get; set; }
    }
}
