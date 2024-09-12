//
// Copyright Fela Ameghino 2015-2024
//
// Distributed under the GNU General Public License v3.0. (See accompanying
// file LICENSE or copy at https://www.gnu.org/licenses/gpl-3.0.txt)
//
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.2-build.15+g2b49bb9edc
//       
//       Command:
//           LottieGen -GenerateColorBindings -Language CSharp -MinimumUapVersion 8 -Namespace Telegram.Assets.Icons -Public -WinUIVersion 2.7 -InputFile EmojiToSticker.json
//       
//       Input file:
//           EmojiToSticker.json (8097 bytes created 15:57+02:00 Jul 25 2022)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ___________________________________________________________
// |       Object stats       | UAP v11 count | UAP v8 count |
// |__________________________|_______________|______________|
// | All CompositionObjects   |            91 |           83 |
// |--------------------------+---------------+--------------|
// | Expression animators     |             8 |            6 |
// | KeyFrame animators       |             7 |            5 |
// | Reference parameters     |             8 |            6 |
// | Expression operations    |             4 |            4 |
// |--------------------------+---------------+--------------|
// | Animated brushes         |             1 |            1 |
// | Animated gradient stops  |             - |            - |
// | ExpressionAnimations     |             2 |            2 |
// | PathKeyFrameAnimations   |             2 |            - |
// |--------------------------+---------------+--------------|
// | ContainerVisuals         |             3 |            3 |
// | ShapeVisuals             |             4 |            4 |
// |--------------------------+---------------+--------------|
// | ContainerShapes          |             - |            - |
// | CompositionSpriteShapes  |             6 |            6 |
// |--------------------------+---------------+--------------|
// | Brushes                  |             5 |            5 |
// | Gradient stops           |             - |            - |
// | CompositionVisualSurface |             2 |            2 |
// -----------------------------------------------------------
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.Effects;
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Microsoft.UI;
using Microsoft.UI.Composition;

namespace Telegram.Assets.Icons
{
    // Name:        emoji_to_sticker
    // Frame rate:  60 fps
    // Frame count: 20
    // Duration:    333.3 mS
    // ___________________________________________________________
    // | Theme property |   Accessor   | Type  |  Default value  |
    // |________________|______________|_______|_________________|
    // | #000000        | Color_000000 | Color | #FF000000 Black |
    // -----------------------------------------------------------
    public sealed partial class EmojiToSticker
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 0.333 seconds.
        internal const long c_durationTicks = 3333333;

        // Theme property: Color_000000.
        internal static readonly Color c_themeColor_000000 = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);

        CompositionPropertySet _themeProperties;
        Color _themeColor_000000 = c_themeColor_000000;

        // Theme properties.
        public Color Color_000000
        {
            get => _themeColor_000000;
            set
            {
                _themeColor_000000 = value;
                if (_themeProperties != null)
                {
                    _themeProperties.InsertVector4("Color_000000", ColorAsVector4((Color)_themeColor_000000));
                }
            }
        }

        static Vector4 ColorAsVector4(Color color) => new Vector4(color.R, color.G, color.B, color.A);

        CompositionPropertySet EnsureThemeProperties(Compositor compositor)
        {
            if (_themeProperties == null)
            {
                _themeProperties = compositor.CreatePropertySet();
                _themeProperties.InsertVector4("Color_000000", ColorAsVector4((Color)Color_000000));
            }
            return _themeProperties;
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;
            EnsureThemeProperties(compositor);

            if (EmojiToSticker_AnimatedVisual_UAPv11.IsRuntimeCompatible())
            {
                var res =
                    new EmojiToSticker_AnimatedVisual_UAPv11(
                        compositor,
                        _themeProperties
                        );
                res.CreateAnimations();
                return res;
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 20d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 20d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
            if (propertyName == "Color_000000")
            {
                _themeColor_000000 = value;
            }
            else
            {
                return;
            }

            if (_themeProperties != null)
            {
                _themeProperties.InsertVector4(propertyName, ColorAsVector4(value));
            }
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed partial class EmojiToSticker_AnimatedVisual_UAPv11 : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 3333333;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            readonly CompositionPropertySet _themeProperties;
            CompositionColorBrush _themeColor_Color_000000;
            CompositionPathGeometry _pathGeometry_0;
            CompositionPathGeometry _pathGeometry_2;
            CompositionPathGeometry _pathGeometry_3;
            CompositionPathGeometry _pathGeometry_4;
            CompositionSpriteShape _spriteShape_1;
            CompositionSpriteShape _spriteShape_3;
            CompositionSpriteShape _spriteShape_4;
            CompositionSpriteShape _spriteShape_5;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;
            Vector2KeyFrameAnimation _offsetVector2Animation_1;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            PathKeyFrameAnimation CreatePathKeyFrameAnimation(float initialProgress, CompositionPath initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreatePathKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            // - - - - Shape tree root for layer: 1
            // - - -  Offset:<120, 120>
            // - Path
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(0F, -9.25F));
                    builder.AddCubicBezier(new Vector2(-5.11000013F, -9.25F), new Vector2(-9.25F, -5.11000013F), new Vector2(-9.25F, 0F));
                    builder.AddCubicBezier(new Vector2(-9.25F, 0F), new Vector2(-9.25F, 0.00999999978F), new Vector2(-9.25F, 0.00999999978F));
                    builder.AddCubicBezier(new Vector2(-9.25F, 5.11000013F), new Vector2(-5.11000013F, 9.25F), new Vector2(0F, 9.25F));
                    builder.AddCubicBezier(new Vector2(0F, 9.25F), new Vector2(0.00999999978F, 9.25F), new Vector2(0.00999999978F, 9.25F));
                    builder.AddCubicBezier(new Vector2(5.11000013F, 9.25F), new Vector2(9.25F, 5.11000013F), new Vector2(9.25F, 0.00999999978F));
                    builder.AddCubicBezier(new Vector2(9.25F, 0.00999999978F), new Vector2(9.25F, 0F), new Vector2(9.25F, 0F));
                    builder.AddCubicBezier(new Vector2(9.25F, -5.11000013F), new Vector2(5.11000013F, -9.25F), new Vector2(0.00999999978F, -9.25F));
                    builder.AddCubicBezier(new Vector2(0.00999999978F, -9.25F), new Vector2(0F, -9.25F), new Vector2(0F, -9.25F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Shape tree root for layer: 1
            // - - -  Offset:<120, 120>
            // - Path
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-4.37900019F, -8.5F));
                    builder.AddCubicBezier(new Vector2(-6.65500021F, -8.5F), new Vector2(-8.5F, -6.65500021F), new Vector2(-8.5F, -4.37900019F));
                    builder.AddCubicBezier(new Vector2(-8.5F, -4.37900019F), new Vector2(-8.5F, 4.37900019F), new Vector2(-8.5F, 4.37900019F));
                    builder.AddCubicBezier(new Vector2(-8.5F, 6.65500021F), new Vector2(-6.65500021F, 8.5F), new Vector2(-4.37900019F, 8.5F));
                    builder.AddCubicBezier(new Vector2(-4.37900019F, 8.5F), new Vector2(1.5F, 8.5F), new Vector2(1.5F, 8.5F));
                    builder.AddCubicBezier(new Vector2(1.5F, 8.5F), new Vector2(8.5F, 1.5F), new Vector2(8.5F, 1.5F));
                    builder.AddCubicBezier(new Vector2(8.5F, 1.5F), new Vector2(8.5F, -4.37900019F), new Vector2(8.5F, -4.37900019F));
                    builder.AddCubicBezier(new Vector2(8.5F, -6.65500021F), new Vector2(6.65500021F, -8.5F), new Vector2(4.37900019F, -8.5F));
                    builder.AddCubicBezier(new Vector2(4.37900019F, -8.5F), new Vector2(-4.37900019F, -8.5F), new Vector2(-4.37900019F, -8.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Shape tree root for layer: 2
            // - -  Offset:<167.5, 167.5>
            CanvasGeometry Geometry_2()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(2.0999999F, 8F));
                    builder.AddLine(new Vector2(2.0999999F, 4.5F));
                    builder.AddCubicBezier(new Vector2(2.0999999F, 3.11899996F), new Vector2(3.2190001F, 2F), new Vector2(4.5999999F, 2F));
                    builder.AddLine(new Vector2(8.10000038F, 2F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Masks
            // - - -  Offset:<167.5, 167.5>
            // - Path
            CanvasGeometry Geometry_3()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-46.75F, -141F));
                    builder.AddCubicBezier(new Vector2(-98.2639999F, -141F), new Vector2(-140F, -99.2639999F), new Vector2(-140F, -47.75F));
                    builder.AddCubicBezier(new Vector2(-140F, -47.75F), new Vector2(-140F, -47.6489983F), new Vector2(-140F, -47.6489983F));
                    builder.AddCubicBezier(new Vector2(-140F, 3.7650001F), new Vector2(-98.2639999F, 45.5F), new Vector2(-46.75F, 45.5F));
                    builder.AddCubicBezier(new Vector2(-46.75F, 45.5F), new Vector2(-46.6489983F, 45.5F), new Vector2(-46.6489983F, 45.5F));
                    builder.AddCubicBezier(new Vector2(4.76499987F, 45.5F), new Vector2(46.5F, 3.7650001F), new Vector2(46.5F, -47.6489983F));
                    builder.AddCubicBezier(new Vector2(46.5F, -47.6489983F), new Vector2(46.5F, -47.75F), new Vector2(46.5F, -47.75F));
                    builder.AddCubicBezier(new Vector2(46.5F, -99.2639999F), new Vector2(4.76499987F, -141F), new Vector2(-46.6489983F, -141F));
                    builder.AddCubicBezier(new Vector2(-46.6489983F, -141F), new Vector2(-46.75F, -141F), new Vector2(-46.75F, -141F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - Masks
            // - - -  Offset:<167.5, 167.5>
            // - Path
            CanvasGeometry Geometry_4()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-91.5449982F, -130.5F));
                    builder.AddCubicBezier(new Vector2(-114.440002F, -130.5F), new Vector2(-133F, -112.374001F), new Vector2(-133F, -90.0149994F));
                    builder.AddCubicBezier(new Vector2(-133F, -90.0149994F), new Vector2(-133F, -3.9849999F), new Vector2(-133F, -3.9849999F));
                    builder.AddCubicBezier(new Vector2(-133F, 18.3740005F), new Vector2(-114.440002F, 36.5F), new Vector2(-91.5449982F, 36.5F));
                    builder.AddCubicBezier(new Vector2(-91.5449982F, 36.5F), new Vector2(-32.4119987F, 36.5F), new Vector2(-32.4119987F, 36.5F));
                    builder.AddCubicBezier(new Vector2(-32.4119987F, 36.5F), new Vector2(38F, -32.2649994F), new Vector2(38F, -32.2649994F));
                    builder.AddCubicBezier(new Vector2(38F, -32.2649994F), new Vector2(38F, -90.0149994F), new Vector2(38F, -90.0149994F));
                    builder.AddCubicBezier(new Vector2(38F, -112.374001F), new Vector2(19.4400005F, -130.5F), new Vector2(-3.45499992F, -130.5F));
                    builder.AddCubicBezier(new Vector2(-3.45499992F, -130.5F), new Vector2(-91.5449982F, -130.5F), new Vector2(-91.5449982F, -130.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            CanvasGeometry Geometry_5()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(0F, -0.25F));
                    builder.AddCubicBezier(new Vector2(0.702000022F, -0.25F), new Vector2(1.25F, 0.298000008F), new Vector2(1.25F, 1F));
                    builder.AddCubicBezier(new Vector2(1.25F, 1.70200002F), new Vector2(0.702000022F, 2.25F), new Vector2(0F, 2.25F));
                    builder.AddCubicBezier(new Vector2(-0.702000022F, 2.25F), new Vector2(-1.25F, 1.70200002F), new Vector2(-1.25F, 1F));
                    builder.AddCubicBezier(new Vector2(-1.25F, 0.298000008F), new Vector2(-0.702000022F, -0.25F), new Vector2(0F, -0.25F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<120, 152.5>
            CanvasGeometry Geometry_6()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(3.25F, 0F));
                    builder.AddCubicBezier(new Vector2(2.34500003F, 0.628000021F), new Vector2(1.21899998F, 1F), new Vector2(0F, 1F));
                    builder.AddCubicBezier(new Vector2(-1.21899998F, 1F), new Vector2(-2.34500003F, 0.628000021F), new Vector2(-3.25F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Masks
            // Offset:<167.5, 167.5>
            CompositionColorBrush ColorBrush_Black()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0x00));
            }

            // Color bound to theme property value: Color_000000
            CompositionColorBrush ThemeColor_Color_000000()
            {
                if (_themeColor_Color_000000 != null) { return _themeColor_Color_000000; }
                var result = _themeColor_Color_000000 = _c.CreateColorBrush();
                BindProperty(_themeColor_Color_000000, "Color", "ColorRGB(_theme.Color_000000.W,_theme.Color_000000.X,_theme.Color_000000.Y,_theme.Color_000000.Z)", "_theme", _themeProperties);
                return result;
            }

            CompositionEffectBrush EffectBrush()
            {
                var effectFactory = EffectFactory();
                var result = effectFactory.CreateBrush();
                result.SetSourceParameter("destination", SurfaceBrush_0());
                result.SetSourceParameter("source", SurfaceBrush_1());
                return result;
            }

            CompositionEffectFactory EffectFactory()
            {
                var compositeEffect = new CompositeEffect();
                compositeEffect.Mode = CanvasComposite.DestinationIn;
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("destination"));
                compositeEffect.Sources.Add(new CompositionEffectSourceParameter("source"));
                var result = _c.CreateEffectFactory(compositeEffect);
                return result;
            }

            // - Shape tree root for layer: 1
            // Offset:<120, 120>
            CompositionPathGeometry PathGeometry_0()
            {
                if (_pathGeometry_0 != null) { return _pathGeometry_0; }
                var result = _pathGeometry_0 = _c.CreatePathGeometry();
                return result;
            }

            // - Shape tree root for layer: 2
            // Offset:<167.5, 167.5>
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_2()));
            }

            // - Masks
            // Offset:<167.5, 167.5>
            CompositionPathGeometry PathGeometry_2()
            {
                if (_pathGeometry_2 != null) { return _pathGeometry_2; }
                var result = _pathGeometry_2 = _c.CreatePathGeometry();
                return result;
            }

            CompositionPathGeometry PathGeometry_3()
            {
                return (_pathGeometry_3 == null)
                    ? _pathGeometry_3 = _c.CreatePathGeometry(new CompositionPath(Geometry_5()))
                    : _pathGeometry_3;
            }

            // - Layer aggregator
            // Offset:<120, 152.5>
            CompositionPathGeometry PathGeometry_4()
            {
                if (_pathGeometry_4 != null) { return _pathGeometry_4; }
                var result = _pathGeometry_4 = _c.CreatePathGeometry(new CompositionPath(Geometry_6()));
                return result;
            }

            // Shape tree root for layer: 1
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<120, 120>, Scale:<10, 10>
                var result = CreateSpriteShape(PathGeometry_0(), new Matrix3x2(10F, 0F, 0F, 10F, 120F, 120F)); ;
                result.StrokeBrush = ThemeColor_Color_000000();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeLineJoin = CompositionStrokeLineJoin.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 1.5F;
                return result;
            }

            // Shape tree root for layer: 2
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<167.5, 167.5>, Scale:<10, 10>
                if (_spriteShape_1 != null) { return _spriteShape_1; }
                var result = _spriteShape_1 = CreateSpriteShape(PathGeometry_1(), new Matrix3x2(10F, 0F, 0F, 10F, 167.5F, 167.5F)); ;
                result.StrokeBrush = ThemeColor_Color_000000();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 1.5F;
                return result;
            }

            // Masks
            // Offset:<167.5, 167.5>
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<167.5, 167.5>
                var geometry = PathGeometry_2();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, 167.5F, 167.5F), ColorBrush_Black()); ;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_3()
            {
                // Offset:<90, 90>, Scale:<10, 10>
                var geometry = PathGeometry_3();
                if (_spriteShape_3 != null) { return _spriteShape_3; }
                var result = _spriteShape_3 = CreateSpriteShape(geometry, new Matrix3x2(10F, 0F, 0F, 10F, 90F, 90F), ThemeColor_Color_000000()); ;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_4()
            {
                // Offset:<150, 90>, Scale:<10, 10>
                var geometry = PathGeometry_3();
                if (_spriteShape_4 != null) { return _spriteShape_4; }
                var result = _spriteShape_4 = CreateSpriteShape(geometry, new Matrix3x2(10F, 0F, 0F, 10F, 150F, 90F), ThemeColor_Color_000000()); ;
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_5()
            {
                // Offset:<120, 152.5>, Scale:<10, 10>
                if (_spriteShape_5 != null) { return _spriteShape_5; }
                var result = _spriteShape_5 = CreateSpriteShape(PathGeometry_4(), new Matrix3x2(10F, 0F, 0F, 10F, 120F, 152.5F)); ;
                result.StrokeBrush = ThemeColor_Color_000000();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 2F;
                result.StrokeThickness = 1.5F;
                return result;
            }

            CompositionSurfaceBrush SurfaceBrush_0()
            {
                return _c.CreateSurfaceBrush(VisualSurface_0());
            }

            CompositionSurfaceBrush SurfaceBrush_1()
            {
                return _c.CreateSurfaceBrush(VisualSurface_1());
            }

            CompositionVisualSurface VisualSurface_0()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_0();
                result.SourceSize = new Vector2(240F, 240F);
                return result;
            }

            CompositionVisualSurface VisualSurface_1()
            {
                var result = _c.CreateVisualSurface();
                result.SourceVisual = ContainerVisual_1();
                result.SourceSize = new Vector2(240F, 240F);
                return result;
            }

            ContainerVisual ContainerVisual_0()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Shape tree root for layer: 2
                result.Children.InsertAtTop(ShapeVisual_1());
                return result;
            }

            ContainerVisual ContainerVisual_1()
            {
                var result = _c.CreateContainerVisual();
                result.BorderMode = CompositionBorderMode.Soft;
                // Masks
                result.Children.InsertAtTop(ShapeVisual_2());
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                if (_root != null) { return _root; }
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                var children = result.Children;
                // Shape tree root for layer: 1
                children.InsertAtTop(ShapeVisual_0());
                children.InsertAtTop(SpriteVisual_0());
                // Layer aggregator
                children.InsertAtTop(ShapeVisual_3());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return (_cubicBezierEasingFunction_0 == null)
                    ? _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F))
                    : _cubicBezierEasingFunction_0;
            }

            ExpressionAnimation RootProgress()
            {
                if (_rootProgress != null) { return _rootProgress; }
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // - - Shape tree root for layer: 1
            // -  Offset:<120, 120>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_0()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, new CompositionPath(Geometry_0()), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new CompositionPath(Geometry_1()), CubicBezierEasingFunction_0());
                return result;
            }

            // - - Masks
            // -  Offset:<167.5, 167.5>
            // Path
            PathKeyFrameAnimation PathKeyFrameAnimation_1()
            {
                // Frame 0.
                var result = CreatePathKeyFrameAnimation(0F, new CompositionPath(Geometry_3()), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new CompositionPath(Geometry_4()), CubicBezierEasingFunction_0());
                return result;
            }

            // - - Layer aggregator
            // -  Offset:<120, 152.5>
            // TrimStart
            ScalarKeyFrameAnimation TrimStartScalarAnimation_0_to_0p3()
            {
                // Frame 0.
                var result = CreateScalarKeyFrameAnimation(0F, 0F, StepThenHoldEasingFunction());
                // Frame 7.
                result.InsertKeyFrame(0.349999994F, 0F, HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, 0.300000012F, CubicBezierEasingFunction_0());
                return result;
            }

            // Shape tree root for layer: 1
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(240F, 240F);
                // Offset:<120, 120>
                result.Shapes.Add(SpriteShape_0());
                return result;
            }

            // Shape tree root for layer: 2
            ShapeVisual ShapeVisual_1()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(240F, 240F);
                // Offset:<167.5, 167.5>
                result.Shapes.Add(SpriteShape_1());
                return result;
            }

            // Masks
            ShapeVisual ShapeVisual_2()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(240F, 240F);
                // Offset:<167.5, 167.5>
                result.Shapes.Add(SpriteShape_2());
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_3()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(240F, 240F);
                var shapes = result.Shapes;
                // Offset:<90, 90>
                shapes.Add(SpriteShape_3());
                // Offset:<150, 90>
                shapes.Add(SpriteShape_4());
                // Offset:<120, 152.5>
                shapes.Add(SpriteShape_5());
                return result;
            }

            SpriteVisual SpriteVisual_0()
            {
                var result = _c.CreateSpriteVisual();
                result.Size = new Vector2(240F, 240F);
                result.Brush = EffectBrush();
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                if (_holdThenStepEasingFunction != null) { return _holdThenStepEasingFunction; }
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<120, 152.5>
            // TrimStart
            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - Shape tree root for layer: 2
            // Offset:<167.5, 167.5>
            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new Vector2(-5.0999999F, -5F), CubicBezierEasingFunction_0());
                return result;
            }

            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_1()
            {
                // Frame 0.
                if (_offsetVector2Animation_1 != null) { return _offsetVector2Animation_1; }
                var result = _offsetVector2Animation_1 = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new Vector2(0F, -1F), CubicBezierEasingFunction_0());
                return result;
            }

            // - Layer aggregator
            // Offset:<120, 152.5>
            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_2()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 12.
                result.InsertKeyFrame(0.600000024F, new Vector2(0F, -0.5F), CubicBezierEasingFunction_0());
                return result;
            }

            internal EmojiToSticker_AnimatedVisual_UAPv11(
                Compositor compositor,
                CompositionPropertySet themeProperties
                )
            {
                _c = compositor;
                _themeProperties = themeProperties;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(240F, 240F);
            void IDisposable.Dispose() => _root?.Dispose();

            public void CreateAnimations()
            {
                StartProgressBoundAnimation(_pathGeometry_0, "Path", PathKeyFrameAnimation_0(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_2, "Path", PathKeyFrameAnimation_1(), RootProgress());
                StartProgressBoundAnimation(_pathGeometry_4, "TrimStart", TrimStartScalarAnimation_0_to_0p3(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_1, "Offset", OffsetVector2Animation_0(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_3, "Offset", OffsetVector2Animation_1(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_4, "Offset", OffsetVector2Animation_1(), RootProgress());
                StartProgressBoundAnimation(_spriteShape_5, "Offset", OffsetVector2Animation_2(), RootProgress());
            }

            public void DestroyAnimations()
            {
                _pathGeometry_0.StopAnimation("Path");
                _pathGeometry_2.StopAnimation("Path");
                _pathGeometry_4.StopAnimation("TrimStart");
                _spriteShape_1.StopAnimation("Offset");
                _spriteShape_3.StopAnimation("Offset");
                _spriteShape_4.StopAnimation("Offset");
                _spriteShape_5.StopAnimation("Offset");
            }

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 11);
            }
        }
    }
}
