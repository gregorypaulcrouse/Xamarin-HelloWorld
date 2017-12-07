using Xamarin.Forms;

namespace HelloWorld
{
    public partial class HelloWorldPage : ContentPage
    {
        string worldLabelInitialText = " ";

        public HelloWorldPage()
        {
            InitializeComponent();
            worldLabel.Text = worldLabelInitialText;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (worldLabel.Text == worldLabelInitialText){
                worldLabel.Text = "World";
            }else{
                worldLabel.Text = worldLabelInitialText;
            }
        }
    }
}
