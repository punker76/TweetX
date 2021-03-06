﻿using Avalonia;

namespace TweetX.Interfaces
{
    public interface IWindow
    {
        string Title { get; set; }
        PixelPoint Position { get; set; }
        double Width { get; set; }
        double Height { get; set; }
    }
}