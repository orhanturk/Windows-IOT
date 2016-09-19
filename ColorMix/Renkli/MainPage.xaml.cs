using IoTHelpers.Gpio.Modules;
using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Renkli
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MulticolorLed led;

    //    private PushButton button;
       
        public MainPage()
        {
           this.InitializeComponent();

            led = new MulticolorLed(redPinNumber: 5, greenPinNumber: 17, bluePinNumber: 22);

            ///Red Blink
            Task.Delay(2000).Wait();
            led.TurnRed();

            //Yellow Blink
            Task.Delay(2000).Wait();
            led.TurnBlue();

            //Green Blink
            Task.Delay(2000).Wait();
            led.TurnGreen();

            Task.Delay(2000).Wait();

            led.TurnOff();

        }

        // button.Click += (s, e) => led.Red = !led.Red;


    }
}
