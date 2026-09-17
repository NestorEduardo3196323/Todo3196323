namespace Todo3196323
{
    public partial class AppShell : Shell
    {

        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TodoItemPage), typeof(TodoItemPage));
        }
    }

}