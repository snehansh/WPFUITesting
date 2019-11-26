using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using WPFUITesting;

namespace TestProject
{
    [Apartment(ApartmentState.STA)]
    [TestFixture]
    public class Window1Tests
    {
        private ButtonAutomationPeer buttonPeer;
        private TextBoxAutomationPeer textBoxPeer;
        private MainWindow window;
        private WindowAutomationPeer windowPeer;

        [SetUp]
        public void SetUp()
        {
            window = new MainWindow();
            window.Show();
            windowPeer = new WindowAutomationPeer(window);
            List<AutomationPeer> children = windowPeer.GetChildren();
            buttonPeer = (ButtonAutomationPeer)children[0];
            textBoxPeer = (TextBoxAutomationPeer)children[1];
        }

        [Test]
        public void ClickingIncrementIncrementsTheNumberInTheTextBox()
        {
            Assert.AreEqual("0", ((IValueProvider)textBoxPeer).Value);
            Button button = (Button)buttonPeer.Owner;
            RoutedEventArgs args = new RoutedEventArgs(Button.ClickEvent, button);
            button.RaiseEvent(args);
            Assert.AreEqual("1", ((IValueProvider)textBoxPeer).Value);
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}
