namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            string myText = entry.Text;
      
        }
        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            Ivan.Text = text;
        }
        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;
            
            if (count %2  == 0)
            {
                Ivan.TextColor = new Color(0, 255, 255);
                CounterBtn.Text = $"Clicked {count} time";
            }
            else 
            {

                Ivan.TextColor = new Color(10, 0, 255);
                Ivan.Text = "aaaa";
                CounterBtn.Text = $"Clicked {count} times";

                SemanticScreenReader.Announce(CounterBtn.Text);
            }
        }
    }
}
