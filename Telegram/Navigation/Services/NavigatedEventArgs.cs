//
// Copyright Fela Ameghino 2015-2024
//
// Distributed under the GNU General Public License v3.0. (See accompanying
// file LICENSE or copy at https://www.gnu.org/licenses/gpl-3.0.txt)
//
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Telegram.Navigation.Services
{
    // DOCS: https://github.com/Windows-XAML/Template10/wiki/Docs-%7C-NavigationService
    public partial class NavigatedEventArgs : EventArgs
    {
        public NavigatedEventArgs() { }
        public NavigatedEventArgs(NavigationEventArgs e, Page page)
        {
            Content = page;
            SourcePageType = e.SourcePageType;
            Parameter = e.Parameter;
            NavigationMode = e.NavigationMode;
        }

        public NavigationMode NavigationMode { get; set; }
        public Type SourcePageType { get; set; }
        public object Parameter { get; set; }
        public Page Content { get; set; }
    }
}
