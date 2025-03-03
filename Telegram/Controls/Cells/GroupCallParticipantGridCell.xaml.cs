//
// Copyright Fela Ameghino 2015-2024
//
// Distributed under the GNU General Public License v3.0. (See accompanying
// file LICENSE or copy at https://www.gnu.org/licenses/gpl-3.0.txt)
//
using Microsoft.Graphics.Canvas.Effects;
using System;
using System.Numerics;
using Telegram.Controls.Media;
using Telegram.Native.Calls;
using Telegram.Navigation;
using Telegram.Services;
using Telegram.Services.Calls;
using Telegram.Td.Api;
using Telegram.Views.Calls;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Hosting;
using Windows.UI.Xaml.Media;

namespace Telegram.Controls.Cells
{
    public sealed partial class GroupCallParticipantGridCell : HyperlinkButton
    {
        private GroupCallParticipant _participant;
        private GroupCallParticipantVideoInfo _videoInfo;

        private SpriteVisual _pausedVisual;
        private CompositionEffectBrush _pausedBrush;

        private readonly VoipVideoOutputSink _sink;
        private readonly bool _screenSharing;

        public GroupCallParticipantGridCell(IClientService clientService, GroupCallParticipant participant, GroupCallParticipantVideoInfo videoInfo, bool screenSharing)
        {
            InitializeComponent();
            UpdateGroupCallParticipant(clientService, participant, videoInfo);

            _sink = VoipVideoOutput.CreateSink(CanvasRoot, false);
            _screenSharing = screenSharing;

            if (screenSharing)
            {
                ScreenSharing.Text = Icons.SmallScreencastFilled;
            }

            var header = ElementComposition.GetElementVisual(Header);
            header.Opacity = 0;
        }

        public bool Matches(GroupCallParticipant participant, GroupCallParticipantVideoInfo videoInfo)
        {
            return participant != null && participant.ParticipantId.AreTheSame(ParticipantId) && _videoInfo.EndpointId == _videoInfo.EndpointId;
        }

        public VoipVideoOutputSink Sink => _sink;

        public VoipVideoChannelQuality Quality => ActualHeight switch
        {
            double h when h >= 720 || (h >= 360 && IsScreenSharing) => VoipVideoChannelQuality.Full,
            double h when h >= 360 && !IsScreenSharing => VoipVideoChannelQuality.Medium,
            _ => VoipVideoChannelQuality.Thumbnail
        };

        // TODO: this is currently not supported
        public Stretch GetStretch(ParticipantsGridMode mode, bool list)
        {
            if (_screenSharing || IsSelected || IsPinned)
            {
                return Stretch.Uniform;
            }

            return mode == ParticipantsGridMode.Compact || list ? Stretch.Fill : Stretch.UniformToFill;
        }

        public GroupCallParticipant Participant => _participant;
        public MessageSender ParticipantId => _participant.ParticipantId;

        public GroupCallParticipantVideoInfo VideoInfo => _videoInfo;
        public string EndpointId => _videoInfo.EndpointId;

        public bool IsScreenSharing => _screenSharing;

        public bool IsSelected { get; set; }

        public bool IsPinned
        {
            get => Pin.IsChecked == true;
            set => Pin.IsChecked = value;
        }

        public bool IsList
        {
            set => LayoutRoot.Constraint = value ? new Size(16, 9) : null;
        }

        public event EventHandler TogglePinned;

        public event EventHandler ToggleDocked;

        public void UpdateGroupCallParticipant(IClientService clientService, GroupCallParticipant participant, GroupCallParticipantVideoInfo videoInfo)
        {
            _participant = participant;
            _videoInfo = videoInfo;

            Tag = participant;

            ShowHidePaused(videoInfo.IsPaused);

            if (clientService.TryGetUser(participant.ParticipantId, out User user))
            {
                Title.Text = user.FullName();
            }
            else if (clientService.TryGetChat(participant.ParticipantId, out Chat chat))
            {
                Title.Text = clientService.GetTitle(chat);
            }

            if (participant.IsSpeaking)
            {
                Speaking.BorderBrush = new SolidColorBrush { Color = Color.FromArgb(0xFF, 0x33, 0xc6, 0x59) };
                Glyph.Text = Icons.MicOn;
            }
            else
            {
                Speaking.BorderBrush = null;
                Glyph.Text = participant.IsMutedForAllUsers || participant.IsMutedForCurrentUser ? Icons.MicOff : Icons.MicOn;
            }
        }

        private bool _infoCollapsed;

        public void ShowHideInfo(bool show, bool? docked)
        {
            if (_infoCollapsed == !show)
            {
                return;
            }

            _infoCollapsed = !show;

            var anim = BootStrapper.Current.Compositor.CreateScalarKeyFrameAnimation();
            //anim.InsertKeyFrame(0, show ? 0 : 1);
            anim.InsertKeyFrame(1, show ? 1 : 0);

            var info = ElementComposition.GetElementVisual(Info);
            info.StartAnimation("Opacity", anim);

            if (IsSelected || !show)
            {
                ShowHideHeader(show, docked);
            }
        }

        private bool _headerCollapsed;

        public void ShowHideHeader(bool show, bool? docked)
        {
            if (show && docked == null)
            {
                ModeRoot.Visibility = Visibility.Collapsed;
            }
            else if (show)
            {
                Mode.IsChecked = docked;
                Mode.Visibility = Visibility.Visible;
            }

            if (_headerCollapsed == !show)
            {
                return;
            }

            _headerCollapsed = !show;

            Back.IsEnabled = Mode.IsEnabled = Pin.IsEnabled = show;

            var anim = BootStrapper.Current.Compositor.CreateScalarKeyFrameAnimation();
            anim.InsertKeyFrame(1, show ? 1 : 0);

            var header = ElementComposition.GetElementVisual(Header);
            header.StartAnimation("Opacity", anim);
        }

        private bool _pausedCollapsed;

        private void ShowHidePaused(bool show)
        {
            if (_pausedCollapsed == !show)
            {
                return;
            }

            _pausedCollapsed = !show;

            if (show)
            {
                var paused = ElementComposition.GetElementVisual(PausedRoot);

                var graphicsEffect = new GaussianBlurEffect
                {
                    Name = "Blur",
                    BlurAmount = 10,
                    BorderMode = EffectBorderMode.Hard,
                    Source = new CompositionEffectSourceParameter("backdrop")
                };

                var effectFactory = BootStrapper.Current.Compositor.CreateEffectFactory(graphicsEffect, new[] { "Blur.BlurAmount" });
                var effectBrush = effectFactory.CreateBrush();
                var backdrop = BootStrapper.Current.Compositor.CreateBackdropBrush();
                effectBrush.SetSourceParameter("backdrop", backdrop);

                _pausedBrush = effectBrush;
                _pausedVisual = BootStrapper.Current.Compositor.CreateSpriteVisual();
                _pausedVisual.Size = ActualSize;
                _pausedVisual.Brush = effectBrush;

                ElementCompositionPreview.SetElementChildVisual(CanvasRoot, _pausedVisual);
                PausedRoot.Visibility = Visibility.Visible;
                Scrim.Visibility = Visibility.Collapsed;

                //var blur = BootStrapper.Current.Compositor.CreateScalarKeyFrameAnimation();
                //blur.Duration = TimeSpan.FromMilliseconds(300);
                //blur.InsertKeyFrame(1, 10);

                //var anim = BootStrapper.Current.Compositor.CreateScalarKeyFrameAnimation();
                //anim.InsertKeyFrame(0, show ? 0 : 1);
                //anim.InsertKeyFrame(1, show ? 1 : 0);

                //paused.StartAnimation("Opacity", anim);
                //effectBrush.Properties.StartAnimation("Blur.BlurAmount", blur);
            }
            else
            {
                ElementCompositionPreview.SetElementChildVisual(CanvasRoot, null);
                PausedRoot.Visibility = Visibility.Collapsed;
                Scrim.Visibility = Visibility.Visible;

                _pausedBrush = null;
                _pausedVisual = null;
            }
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            if (_pausedVisual != null)
            {
                _pausedVisual.Size = finalSize.ToVector2();
            }

            return base.ArrangeOverride(finalSize);
        }


        private void Pin_Click(object sender, RoutedEventArgs e)
        {
            TogglePinned?.Invoke(this, EventArgs.Empty);
        }

        private void Mode_Click(object sender, RoutedEventArgs e)
        {
            ToggleDocked?.Invoke(this, EventArgs.Empty);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var peer = new HyperlinkButtonAutomationPeer(this);
            var pattern = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;

            pattern.Invoke();
        }
    }
}
