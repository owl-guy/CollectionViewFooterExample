using System.Collections.ObjectModel;

namespace CollectionViewFooterExample
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> _items;
        public ObservableCollection<string> Items
        {
            get => _items;
            set {
                _items = value;
                OnPropertyChanged();
            }
        }

        private Random _random;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            _random = new Random();
            Items = new ObservableCollection<string>();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Items.Add(_random.Next().ToString());
        }
    }

}
