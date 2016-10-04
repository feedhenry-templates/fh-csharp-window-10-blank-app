using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using FHSDK;
using FHSDK.FHHttpClient;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace fh_csharp_window_10_blank_app
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                await FHClient.Init();
            }
            catch (FHException)
            {

            }
        }
    }
}
