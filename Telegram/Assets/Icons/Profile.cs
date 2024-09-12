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
//           7.1.0+ge1fa92580f
//       
//       Command:
//           LottieGen -Language CSharp -Public -TargetUapVersion 8 -WinUIVersion 2.7 -InputFile u_profile.json
//       
//       Input file:
//           u_profile.json (4445 bytes created 9:05+01:00 Mar 17 2022)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |    36 |
// |--------------------------+-------|
// | Expression animators     |     2 |
// | KeyFrame animators       |     2 |
// | Reference parameters     |     2 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     - |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     1 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |     2 |
// |--------------------------+-------|
// | Brushes                  |     2 |
// | Gradient stops           |     2 |
// | CompositionVisualSurface |     - |
// ------------------------------------
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
    // Name:        u_profile
    // Frame rate:  60 fps
    // Frame count: 30
    // Duration:    500.0 mS
    sealed partial class Profile
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
        , Microsoft.UI.Xaml.Controls.IAnimatedVisualSource2
    {
        // Animation duration: 0.500 seconds.
        internal const long c_durationTicks = 5000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Profile_AnimatedVisual.IsRuntimeCompatible())
            {
                return
                    new Profile_AnimatedVisual(
                        compositor
                        );
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 30d;

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
            return frameNumber / 30d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
                { "NormalToPointerOver_Start", 0.0 },
                { "NormalToPointerOver_End", 1 },
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed partial class Profile_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionColorGradientStop _gradientStop_0_AlmostMediumAquamarine_FF61C8B8;
            CompositionColorGradientStop _gradientStop_1_AlmostCadetBlue_FF479D8E;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;

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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<100, 145>
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(0F, 3.5F));
                    builder.AddCubicBezier(new Vector2(4.5F, 3.5F), new Vector2(6.5F, 1F), new Vector2(6.5F, -0.5F));
                    builder.AddCubicBezier(new Vector2(6.5F, -1.43200004F), new Vector2(6.5F, -1.89699996F), new Vector2(6.34800005F, -2.2650001F));
                    builder.AddCubicBezier(new Vector2(6.14499998F, -2.75500011F), new Vector2(5.75500011F, -3.14499998F), new Vector2(5.26499987F, -3.34800005F));
                    builder.AddCubicBezier(new Vector2(4.89699984F, -3.5F), new Vector2(4.43200016F, -3.5F), new Vector2(3.5F, -3.5F));
                    builder.AddLine(new Vector2(-3.5F, -3.5F));
                    builder.AddCubicBezier(new Vector2(-4.43200016F, -3.5F), new Vector2(-4.89699984F, -3.5F), new Vector2(-5.26499987F, -3.34800005F));
                    builder.AddCubicBezier(new Vector2(-5.75500011F, -3.14499998F), new Vector2(-6.14499998F, -2.75500011F), new Vector2(-6.34800005F, -2.2650001F));
                    builder.AddCubicBezier(new Vector2(-6.5F, -1.89699996F), new Vector2(-6.5F, -1.43200004F), new Vector2(-6.5F, -0.5F));
                    builder.AddCubicBezier(new Vector2(-6.5F, 1F), new Vector2(-4.5F, 3.5F), new Vector2(0F, 3.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - -  Offset:<100, 60>
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(0F, 4F));
                    builder.AddCubicBezier(new Vector2(2.20900011F, 4F), new Vector2(4F, 2.20900011F), new Vector2(4F, 0F));
                    builder.AddCubicBezier(new Vector2(4F, -2.20900011F), new Vector2(2.20900011F, -4F), new Vector2(0F, -4F));
                    builder.AddCubicBezier(new Vector2(-2.20900011F, -4F), new Vector2(-4F, -2.20900011F), new Vector2(-4F, 0F));
                    builder.AddCubicBezier(new Vector2(-4F, 2.20900011F), new Vector2(-2.20900011F, 4F), new Vector2(0F, 4F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostMediumAquamarine_FF61C8B8()
            {
                return _gradientStop_0_AlmostMediumAquamarine_FF61C8B8 = _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0x61, 0xC8, 0xB8));
            }

            // Stop 1
            CompositionColorGradientStop GradientStop_1_AlmostCadetBlue_FF479D8E()
            {
                return _gradientStop_1_AlmostCadetBlue_FF479D8E = _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x47, 0x9D, 0x8E));
            }

            // - Layer aggregator
            // Offset:<100, 145>
            CompositionLinearGradientBrush LinearGradientBrush_0()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostMediumAquamarine_FF61C8B8());
                colorStops.Add(GradientStop_1_AlmostCadetBlue_FF479D8E());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(0F, -3.5F);
                result.EndPoint = new Vector2(0F, 3.5F);
                return result;
            }

            // - Layer aggregator
            // Offset:<100, 60>
            CompositionLinearGradientBrush LinearGradientBrush_1()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(_gradientStop_0_AlmostMediumAquamarine_FF61C8B8);
                colorStops.Add(_gradientStop_1_AlmostCadetBlue_FF479D8E);
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(0F, -4F);
                result.EndPoint = new Vector2(0F, 4F);
                return result;
            }

            // - Layer aggregator
            // Offset:<100, 145>
            CompositionPathGeometry PathGeometry_0()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Layer aggregator
            // Offset:<100, 60>
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_1()));
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<100, 145>, Scale:<10, 10>
                var geometry = PathGeometry_0();
                var result = CreateSpriteShape(geometry, new Matrix3x2(10F, 0F, 0F, 10F, 100F, 145F), LinearGradientBrush_0());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_0(), RootProgress());
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<100, 60>, Scale:<10, 10>
                var geometry = PathGeometry_1();
                var result = CreateSpriteShape(geometry, new Matrix3x2(10F, 0F, 0F, 10F, 100F, 60F), LinearGradientBrush_1());
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_1(), _rootProgress);
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                var shapes = result.Shapes;
                // Offset:<100, 145>
                shapes.Add(SpriteShape_0());
                // Offset:<100, 60>
                shapes.Add(SpriteShape_1());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // - - Layer aggregator
            // -  Offset:<100, 145>
            // Offset
            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - Layer aggregator
            // Offset:<100, 145>
            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), StepThenHoldEasingFunction());
                // Frame 2.
                result.InsertKeyFrame(0.0666666701F, new Vector2(0F, 0F), HoldThenStepEasingFunction());
                // Frame 11.
                result.InsertKeyFrame(0.366666675F, new Vector2(0F, -1.66700006F), CubicBezierEasingFunction_0());
                // Frame 20.
                result.InsertKeyFrame(0.666666687F, new Vector2(0F, 1F), _cubicBezierEasingFunction_0);
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new Vector2(0F, 0F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Layer aggregator
            // Offset:<100, 60>
            // Path animation as a translation.
            Vector2KeyFrameAnimation OffsetVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 9.
                result.InsertKeyFrame(0.300000012F, new Vector2(0F, -1.33299994F), _cubicBezierEasingFunction_0);
                // Frame 18.
                result.InsertKeyFrame(0.600000024F, new Vector2(0F, 1F), _cubicBezierEasingFunction_0);
                // Frame 27.
                result.InsertKeyFrame(0.899999976F, new Vector2(0F, 0F), _cubicBezierEasingFunction_0);
                return result;
            }

            internal Profile_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(200F, 200F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
