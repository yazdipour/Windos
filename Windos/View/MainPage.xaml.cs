﻿using System;
using System.Collections.Generic;
using Windos.Model;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Windos.View
{
    public sealed partial class MainPage : Page
    {
        string col = "";
        List<NavButton> navButtons = new List<NavButton>()
        {
            new NavButton()
            {
                Title="FileExplorer",
                PageType=typeof(FileExplorerPage),
                Bg="#fff"
            },
            new NavButton()
            {
                Title="Calculator",
                PageType=typeof(CacheMode),
            },
            new NavButton()
            {
                Title="Spotify",
                PageType=typeof(GroovePage),
            },
            new NavButton()
            {
                Title="People",
                PageType=typeof(PeoplePage),
            },
            new NavButton()
            {
                Title="Skype",
                PageType=typeof(SkypePage),
            },
            new NavButton()
            {
                Title="ToDo",
                PageType=typeof(ToDoPage),
            }
        };
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Orbit_ItemClick(object sender, Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewItemClickedEventArgs e)
        {
            var btn = e.Item as Microsoft.Toolkit.Uwp.UI.Controls.OrbitViewDataItem;
            var res = navButtons.Find(obj => obj.Title == btn.Label);
            if (res != null) Frame.Navigate(res.PageType);
        }
    }
}
