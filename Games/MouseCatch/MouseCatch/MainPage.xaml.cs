using MouseCatch.Game.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MouseCatch
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Timer Timer { get; set; }
        public GameController controller;

        public MainPage()
        {
            this.InitializeComponent();
            controller = new GameController();
        }

        private async void GameLoop(object state)
        {
            controller.Step();
            await this.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
                  {
                      MouseUpdate();
                  });
        }

        private void mouseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            controller.Start();
            this.Timer = new Timer(GameLoop, null, TimeSpan.Zero, new TimeSpan(0, 0, 0, 0, 1));
        }

        private void stepButton_Click(object sender, RoutedEventArgs e)
        {
            controller.Step();
            MouseUpdate();

        }

        private void MouseUpdate()
        {
            foreach (var mouse in controller.World.GetMice())
            {
                MouseTransform.TranslateX = mouse.Position.TransformX;
                MouseTransform.TranslateY = mouse.Position.TransformY;
                MouseTransform.Rotation = mouse.Rotation;
            }
        }
    }




}
