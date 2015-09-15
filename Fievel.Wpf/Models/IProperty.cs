﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Fievel.Wpf.Models
{
    public interface IProperty : INotifyPropertyChanged
    {
        ObservableCollection<string> Errors { get; }

        event EventHandler ValueChanged;

        bool IsEnabled { get; set; }

        bool IsValid { get; }

        bool IsDirty { get; }

        void Revert();

        void MarkAsClean();
    }
}