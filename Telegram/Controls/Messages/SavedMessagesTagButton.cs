//
// Copyright Fela Ameghino 2015-2024
//
// Distributed under the GNU General Public License v3.0. (See accompanying
// file LICENSE or copy at https://www.gnu.org/licenses/gpl-3.0.txt)
//
using System.Text;
using Telegram.Common;
using Telegram.Streams;
using Telegram.Td.Api;
using Telegram.ViewModels.Chats;
using Windows.Foundation;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Point = Windows.Foundation.Point;

namespace Telegram.Controls.Messages
{
    // Simplified version of ReactionButton
    public partial class SavedMessagesTagButton : RadioButton
    {
        private Grid LayoutRoot;
        private CustomEmojiIcon Icon;
        private AnimatedTextBlock Count;

        public SavedMessagesTagButton()
        {
            DefaultStyleKey = typeof(SavedMessagesTagButton);
            GroupName = nameof(SavedMessagesTagButton);

            Click += OnClick;
        }

        protected override AutomationPeer OnCreateAutomationPeer()
        {
            return new SavedMessagesTagButtonAutomationPeer(this);
        }

        public string GetAutomationName()
        {
            if (_reaction is SavedMessagesTag interaction)
            {
                if (interaction.Tag is ReactionTypeEmoji emoji)
                {
                    return Locale.Declension(Strings.R.AccDescrNumberOfPeopleReactions, 1, emoji.Emoji);
                }
                else
                {
                    return Locale.Declension(Strings.R.AccDescrNumberOfPeopleReactions, 1, Strings.AccDescrCustomEmoji2);
                }
            }

            return null;
        }

        private ChatSearchViewModel _viewModel;
        private SavedMessagesTag _reaction;
        private ReactionType _reactionType;

        public SavedMessagesTag Reaction => _reaction;

        public void SetReaction(ChatSearchViewModel viewModel, SavedMessagesTag reaction)
        {
            if (Icon == null)
            {
                _viewModel = viewModel;
                _reaction = reaction;
                return;
            }

            var recycled = reaction.Tag.AreTheSame(_reaction?.Tag);

            _viewModel = viewModel;
            _reaction = reaction;

            UpdateInteraction(viewModel, reaction, recycled);

            if (_reactionType.AreTheSame(reaction.Tag))
            {
                return;
            }

            _reactionType = reaction.Tag;

            using (Icon.BeginBatchUpdate())
            {
                var custom = reaction.Tag is ReactionTypeCustomEmoji;
                var size = custom ? 20 : 32;

                Icon.Width = Icon.Height = size;
                Icon.FrameSize = new Size(size, size);
                Icon.LoopCount = custom ? 3 : 1;

                Icon.IsViewportAware = custom;

                Icon.Source = new ReactionFileSource(viewModel.ClientService, reaction.Tag)
                {
                    UseCenterAnimation = true,
                    IsUnique = true
                };
            }
        }

        private void UpdateInteraction(ChatSearchViewModel viewModel, SavedMessagesTag tag, bool recycled)
        {
            //IsChecked = interaction.IsChosen;

            //if (isTag)
            //{
            //    if (RecentChoosers != null)
            //    {
            //        RecentChoosers.Visibility = Visibility.Collapsed;
            //    }

            //    if (Count != null)
            //    {
            //        Count.Visibility = Visibility.Collapsed;
            //    }
            //}
            //else if (interaction.TotalCount > interaction.RecentSenderIds.Count)
            //{
            Count ??= GetTemplateChild(nameof(Count)) as AnimatedTextBlock;
            Count.Visibility = Visibility.Visible;

            var builder = new StringBuilder(tag.Label);
            if (builder.Length > 0)
            {
                builder.Append(" ");
            }

            builder.Append(tag.Count.ToString());

            Count.Text = builder.ToString();

            //    Count.Text = Formatter.ShortNumber(interaction.TotalCount);

            //    if (RecentChoosers != null)
            //    {
            //        RecentChoosers.Visibility = Visibility.Collapsed;
            //    }
            //}
            //else
            //{
            //    RecentChoosers ??= GetRecentChoosers();
            //    RecentChoosers.Visibility = Visibility.Visible;

            //    var destination = RecentChoosers.Items;
            //    var origin = interaction.RecentSenderIds;

            //    if (destination.Count > 0 && recycled)
            //    {
            //        destination.ReplaceDiff(origin);
            //    }
            //    else
            //    {
            //        destination.Clear();
            //        destination.AddRange(origin);
            //    }

            //    if (Count != null)
            //    {
            //        Count.Visibility = Visibility.Collapsed;
            //    }
            //}
        }

        protected override void OnApplyTemplate()
        {
            LayoutRoot = GetTemplateChild(nameof(LayoutRoot)) as Grid;
            Icon = GetTemplateChild(nameof(Icon)) as CustomEmojiIcon;

            if (_reaction != null)
            {
                SetReaction(_viewModel, _reaction);
            }

            base.OnApplyTemplate();
        }

        protected override void OnToggle()
        {
            //base.OnToggle();
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            var chosen = _reaction;
            if (chosen == null || Icon == null)
            {
                return;
            }

            if (IsChecked is true)
            {
                _viewModel.SavedMessagesTag = null;
                ClearValue(IsCheckedProperty);
            }
            else
            {
                _viewModel.SavedMessagesTag = _reaction.Tag;
                SetValue(IsCheckedProperty, true);
            }
        }

        protected override void OnKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key is VirtualKey.Left or VirtualKey.Right && Parent is Panel panel)
            {
                e.Handled = true;

                var index = panel.Children.IndexOf(this);

                Control control = null;
                if (e.Key == VirtualKey.Left && index > 0)
                {
                    control = panel.Children[index - 1] as Control;
                }
                else if (e.Key == VirtualKey.Right && index < panel.Children.Count - 1)
                {
                    control = panel.Children[index + 1] as Control;
                }

                control?.Focus(FocusState.Keyboard);
            }
            if (e.Key is >= VirtualKey.Left and <= VirtualKey.Down && false)
            {
                e.Handled = true;

                var direction = e.Key switch
                {
                    VirtualKey.Left => FocusNavigationDirection.Left,
                    VirtualKey.Up => FocusNavigationDirection.Up,
                    VirtualKey.Right => FocusNavigationDirection.Right,
                    VirtualKey.Down => FocusNavigationDirection.Down,
                    _ => FocusNavigationDirection.Next
                };

                FocusManager.TryMoveFocus(direction, new FindNextElementOptions { SearchRoot = Parent });
            }

            base.OnKeyDown(e);
        }
    }

    public partial class ReactionAsTagPath : SavedMessagesTagPath
    {
        public ReactionAsTagPath()
            : base(true)
        {

        }
    }

    public partial class SavedMessagesTagPath : Path
    {
        private readonly PathFigure _figure;
        private readonly EllipseGeometry _ellipse;

        public SavedMessagesTagPath()
            : this(false)
        {

        }

        protected SavedMessagesTagPath(bool hasHole)
        {
            var geometry = new PathGeometry();
            geometry.Figures.Add(_figure = new PathFigure
            {
                StartPoint = new Point(5.53846f, 0),
                IsClosed = true,
                IsFilled = true
            });

            if (hasHole)
            {
                var group = new GeometryGroup();
                group.Children.Add(geometry);
                group.Children.Add(_ellipse = new EllipseGeometry
                {
                    RadiusX = 3,
                    RadiusY = 3,
                });

                Data = group;
                Stretch = Stretch.None;
            }
            else
            {
                Data = geometry;
                Stretch = Stretch.None;
            }
        }

        private double _finalWidth;

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(0, 0);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            // This should not happen if the same PathGeometry is reused over and over
            if (_finalWidth == finalSize.Width)
            {
                return finalSize;
            }


            var width = finalSize.Width;
            var far = 28f;

            var blp = width - (far - 14.4508f);
            var brp = width - (far - 20.1773f);
            var trp = width - (far - 14.4108f);

            var brp1trp2 = width - (far - 16.6541f);
            var brp2trp1 = width - (far - 18.7758f);

            var tipep = width - (far - 27.1917f);
            var tipp12 = width - (far - 28.2705f);

            _figure.Segments.Clear();
            _figure.AddCubicBezier(new Point(2.47964, 0), new Point(0, 2.47964), new Point(0, 5.53846));
            _figure.AddLine(0, 18.4638);
            _figure.AddCubicBezier(new Point(0, 21.5225), new Point(2.47964, 24), new Point(5.53846, 24));
            _figure.AddLine(blp, 24);
            _figure.AddCubicBezier(new Point(brp1trp2, 24.0022), new Point(brp2trp1, 22.9825), new Point(brp, 21.2308));
            _figure.AddLine(tipep, 14.3088);
            _figure.AddCubicBezier(new Point(tipp12, 12.9603), new Point(tipp12, 11.0442), new Point(tipep, 9.69554));
            _figure.AddLine(brp, 2.77148);
            _figure.AddCubicBezier(new Point(brp2trp1, 1.01976), new Point(brp1trp2, 0), new Point(trp, 0));
            _figure.AddLine(5.53846, 0);

            if (_ellipse != null)
            {
                _ellipse.Center = new Point(width - (far - 17), 9 + 3);
            }

            _finalWidth = finalSize.Width;
            return finalSize;
        }
    }

    public partial class SavedMessagesTagButtonAutomationPeer : RadioButtonAutomationPeer
    {
        private readonly SavedMessagesTagButton _owner;

        public SavedMessagesTagButtonAutomationPeer(SavedMessagesTagButton owner)
            : base(owner)
        {
            _owner = owner;
        }

        protected override string GetNameCore()
        {
            return _owner.GetAutomationName() ?? base.GetNameCore();
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.ListItem;
        }
    }
}
