// <copyright file="TextInputControl.cs" company="Anton Hirov - Private entrepreneur">
// Copyright (c) Anton Hirov - Private entrepreneur. All rights reserved.
// </copyright>

namespace DarkgridToolkit.Desktop.Controls
{
    using System.Windows;
    using System.Windows.Controls;

    public class TextInputControl : Control
    {
        static TextInputControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(TextInputControl),
                new FrameworkPropertyMetadata(typeof(TextInputControl))
            );
        }
    }
}
