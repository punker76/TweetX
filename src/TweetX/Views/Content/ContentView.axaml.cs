﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TweetX.Views.Content
{
    public class ContentView : UserControl
    {
        public ContentView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}