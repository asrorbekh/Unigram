﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.2-build.24+g767465b091
//       
//       Command:
//           LottieGen -DisableTranslationOptimizer -Language CSharp -Namespace Telegram.Assets.Icons -Public -WinUIVersion 2.8 -InputFile PremiumGifting.json
//       
//       Input file:
//           PremiumGifting.json (3229 bytes created 14:43+04:00 Dec 22 2023)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ___________________________________________________________
// |       Object stats       | UAP v15 count | UAP v7 count |
// |__________________________|_______________|______________|
// | All CompositionObjects   |            38 |           38 |
// |--------------------------+---------------+--------------|
// | Expression animators     |             1 |            1 |
// | KeyFrame animators       |             1 |            1 |
// | Reference parameters     |             1 |            1 |
// | Expression operations    |             0 |            0 |
// |--------------------------+---------------+--------------|
// | Animated brushes         |             - |            - |
// | Animated gradient stops  |             - |            - |
// | ExpressionAnimations     |             1 |            1 |
// | PathKeyFrameAnimations   |             - |            - |
// |--------------------------+---------------+--------------|
// | ContainerVisuals         |             2 |            2 |
// | ShapeVisuals             |             1 |            1 |
// |--------------------------+---------------+--------------|
// | ContainerShapes          |             4 |            4 |
// | CompositionSpriteShapes  |             1 |            1 |
// |--------------------------+---------------+--------------|
// | Brushes                  |             1 |            1 |
// | Gradient stops           |             2 |            2 |
// | CompositionVisualSurface |             - |            - |
// -----------------------------------------------------------
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
    // Name:        u_settings
    // Frame rate:  60 fps
    // Frame count: 30
    // Duration:    500.0 mS
    public sealed partial class PremiumGifting
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

            if (PremiumGifting_AnimatedVisual_UAPv15.IsRuntimeCompatible())
            {
                var res = 
                    new PremiumGifting_AnimatedVisual_UAPv15(
                        compositor
                        );
                    res.CreateAnimations();
                    return res;
            }

            if (PremiumGifting_AnimatedVisual_UAPv7.IsRuntimeCompatible())
            {
                var res = 
                    new PremiumGifting_AnimatedVisual_UAPv7(
                        compositor
                        );
                    res.CreateAnimations();
                    return res;
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
        public TimeSpan Duration => TimeSpan.FromTicks(5000000);

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

        sealed partial class PremiumGifting_AnimatedVisual_UAPv15 : Microsoft.UI.Xaml.Controls.IAnimatedVisual2
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            AnimationController _animationController_0;
            CompositionContainerShape _containerShape_0;
            ContainerVisual _root;

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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            // - Shape tree root for layer: Shape
            AnimationController AnimationController_0()
            {
                if (_animationController_0 != null) { return _animationController_0; }
                var result = _animationController_0 = _c.CreateAnimationController();
                result.Pause();
                BindProperty(_animationController_0, "Progress", "_.Progress", "_", _root);
                return result;
            }

            // - - - - - - - Shape tree root for layer: Shape
            // - - - - ShapeGroup: Shape
            CanvasGeometry Geometry()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-3.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(-3.5F, -6.32800007F), new Vector2(-2.82800007F, -7F), new Vector2(-2F, -7F));
                    builder.AddCubicBezier(new Vector2(-1.22000003F, -7F), new Vector2(-0.579999983F, -6.40500021F), new Vector2(-0.507000029F, -5.64400005F));
                    builder.AddLine(new Vector2(-0.5F, -5.5F));
                    builder.AddLine(new Vector2(-0.5F, -4F));
                    builder.AddLine(new Vector2(-2F, -4F));
                    builder.AddLine(new Vector2(-2.14400005F, -4.00699997F));
                    builder.AddCubicBezier(new Vector2(-2.90499997F, -4.07999992F), new Vector2(-3.5F, -4.71999979F), new Vector2(-3.5F, -5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(0.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(0.5F, -6.32800007F), new Vector2(1.17200005F, -7F), new Vector2(2F, -7F));
                    builder.AddCubicBezier(new Vector2(2.82800007F, -7F), new Vector2(3.5F, -6.32800007F), new Vector2(3.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(3.5F, -4.67199993F), new Vector2(2.82800007F, -4F), new Vector2(2F, -4F));
                    builder.AddLine(new Vector2(0.5F, -4F));
                    builder.AddLine(new Vector2(0.5F, -5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(4.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(4.5F, -6.88100004F), new Vector2(3.38100004F, -8F), new Vector2(2F, -8F));
                    builder.AddCubicBezier(new Vector2(1.18200004F, -8F), new Vector2(0.455000013F, -7.60699987F), new Vector2(0.00100000005F, -6.99900007F));
                    builder.AddCubicBezier(new Vector2(-0.455000013F, -7.60699987F), new Vector2(-1.18200004F, -8F), new Vector2(-2F, -8F));
                    builder.AddCubicBezier(new Vector2(-3.38100004F, -8F), new Vector2(-4.5F, -6.88100004F), new Vector2(-4.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(-4.5F, -4.9369998F), new Vector2(-4.3130002F, -4.41699982F), new Vector2(-3.99900007F, -3.99900007F));
                    builder.AddLine(new Vector2(-6F, -4F));
                    builder.AddCubicBezier(new Vector2(-6.55200005F, -4F), new Vector2(-7F, -3.55200005F), new Vector2(-7F, -3F));
                    builder.AddLine(new Vector2(-7F, -1F));
                    builder.AddCubicBezier(new Vector2(-7F, -0.448000014F), new Vector2(-6.55200005F, 0F), new Vector2(-6F, 0F));
                    builder.AddLine(new Vector2(-0.5F, 0F));
                    builder.AddLine(new Vector2(-0.5F, -4F));
                    builder.AddLine(new Vector2(0.5F, -4F));
                    builder.AddLine(new Vector2(0.5F, 0F));
                    builder.AddLine(new Vector2(6F, 0F));
                    builder.AddCubicBezier(new Vector2(6.55200005F, 0F), new Vector2(7F, -0.448000014F), new Vector2(7F, -1F));
                    builder.AddLine(new Vector2(7F, -3F));
                    builder.AddCubicBezier(new Vector2(7F, -3.55200005F), new Vector2(6.55200005F, -4F), new Vector2(6F, -4F));
                    builder.AddLine(new Vector2(3.99900007F, -3.99900007F));
                    builder.AddCubicBezier(new Vector2(4.3130002F, -4.41699982F), new Vector2(4.5F, -4.9369998F), new Vector2(4.5F, -5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(6F, 5.5F));
                    builder.AddLine(new Vector2(6F, 1F));
                    builder.AddLine(new Vector2(0.5F, 1F));
                    builder.AddLine(new Vector2(0.5F, 8F));
                    builder.AddLine(new Vector2(3.5F, 8F));
                    builder.AddLine(new Vector2(3.66400003F, 7.99499989F));
                    builder.AddCubicBezier(new Vector2(4.96799994F, 7.90999985F), new Vector2(6F, 6.82499981F), new Vector2(6F, 5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-0.5F, 8F));
                    builder.AddLine(new Vector2(-0.5F, 1F));
                    builder.AddLine(new Vector2(-6F, 1F));
                    builder.AddLine(new Vector2(-6F, 5.5F));
                    builder.AddLine(new Vector2(-5.99499989F, 5.66400003F));
                    builder.AddCubicBezier(new Vector2(-5.90999985F, 6.96799994F), new Vector2(-4.82499981F, 8F), new Vector2(-3.5F, 8F));
                    builder.AddLine(new Vector2(-0.5F, 8F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - - Shape tree root for layer: Shape
            // - - - ShapeGroup: Shape
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostLightGreen_FF73D865()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0x73, 0xD8, 0x65));
            }

            // - - - - - - Shape tree root for layer: Shape
            // - - - ShapeGroup: Shape
            // Stop 1
            CompositionColorGradientStop GradientStop_1_AlmostForestGreen_FF439E36()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x43, 0x9E, 0x36));
            }

            // Shape tree root for layer: Shape
            CompositionContainerShape ContainerShape_0()
            {
                if (_containerShape_0 != null) { return _containerShape_0; }
                var result = _containerShape_0 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(0F, 0F);
                result.Offset = new Vector2(100F, 100F);
                result.RotationAngleInDegrees = 0F;
                result.Shapes.Add(ContainerShape_1());
                return result;
            }

            // - Shape tree root for layer: Shape
            CompositionContainerShape ContainerShape_1()
            {
                var result = _c.CreateContainerShape();
                // ShapeGroup: Shape
                result.Shapes.Add(ContainerShape_2());
                return result;
            }

            // - - Shape tree root for layer: Shape
            // ShapeGroup: Shape
            CompositionContainerShape ContainerShape_2()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(0F, 0F);
                result.Offset = new Vector2(0F, 0F);
                result.RotationAngleInDegrees = 0F;
                result.Scale = new Vector2(10F, 10F);
                result.Shapes.Add(ContainerShape_3());
                return result;
            }

            // - - - Shape tree root for layer: Shape
            // ShapeGroup: Shape
            CompositionContainerShape ContainerShape_3()
            {
                var result = _c.CreateContainerShape();
                result.Shapes.Add(SpriteShape());
                return result;
            }

            // - - - - - Shape tree root for layer: Shape
            // - - ShapeGroup: Shape
            CompositionLinearGradientBrush LinearGradientBrush()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostLightGreen_FF73D865());
                colorStops.Add(GradientStop_1_AlmostForestGreen_FF439E36());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(0F, -8F);
                result.EndPoint = new Vector2(0F, 8F);
                return result;
            }

            // - - - - - Shape tree root for layer: Shape
            // - - ShapeGroup: Shape
            CompositionPathGeometry PathGeometry()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry()));
            }

            // - - - - Shape tree root for layer: Shape
            // - ShapeGroup: Shape
            CompositionSpriteShape SpriteShape()
            {
                var result = _c.CreateSpriteShape(PathGeometry());
                result.FillBrush = LinearGradientBrush();
                return result;
            }

            ContainerVisual ContainerVisual_0()
            {
                var result = _c.CreateContainerVisual();
                // Shape tree root for layer: Shape
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                if (_root != null) { return _root; }
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                result.Children.InsertAtTop(ContainerVisual_0());
                return result;
            }

            // Shape tree root for layer: Shape
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                result.Shapes.Add(ContainerShape_0());
                return result;
            }

            // - - Shape tree root for layer: Shape
            // Scale
            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.FinalStep = 1;
                result.IsFinalStepSingleFrame = true;
                result.StepCount = 1;
                return result;
            }

            // - Shape tree root for layer: Shape
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 10.
                result.InsertKeyFrame(0.333333343F, new Vector2(1.12F, 1.12F), _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F)));
                // Frame 20.
                result.InsertKeyFrame(0.666666687F, new Vector2(0.949999988F, 0.949999988F), _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F)));
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new Vector2(1F, 1F), _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F)));
                return result;
            }

            internal PremiumGifting_AnimatedVisual_UAPv15(
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

            public void CreateAnimations()
            {
                _containerShape_0.StartAnimation("Scale", ScaleVector2Animation(), AnimationController_0());
            }

            public void DestroyAnimations()
            {
                _containerShape_0.StopAnimation("Scale");
            }

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 15);
            }
        }

        sealed partial class PremiumGifting_AnimatedVisual_UAPv7 : Microsoft.UI.Xaml.Controls.IAnimatedVisual2
        {
            const long c_durationTicks = 5000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionContainerShape _containerShape_0;
            ContainerVisual _root;

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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            // - - - - - - - Shape tree root for layer: Shape
            // - - - - ShapeGroup: Shape
            CanvasGeometry Geometry()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(-3.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(-3.5F, -6.32800007F), new Vector2(-2.82800007F, -7F), new Vector2(-2F, -7F));
                    builder.AddCubicBezier(new Vector2(-1.22000003F, -7F), new Vector2(-0.579999983F, -6.40500021F), new Vector2(-0.507000029F, -5.64400005F));
                    builder.AddLine(new Vector2(-0.5F, -5.5F));
                    builder.AddLine(new Vector2(-0.5F, -4F));
                    builder.AddLine(new Vector2(-2F, -4F));
                    builder.AddLine(new Vector2(-2.14400005F, -4.00699997F));
                    builder.AddCubicBezier(new Vector2(-2.90499997F, -4.07999992F), new Vector2(-3.5F, -4.71999979F), new Vector2(-3.5F, -5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(0.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(0.5F, -6.32800007F), new Vector2(1.17200005F, -7F), new Vector2(2F, -7F));
                    builder.AddCubicBezier(new Vector2(2.82800007F, -7F), new Vector2(3.5F, -6.32800007F), new Vector2(3.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(3.5F, -4.67199993F), new Vector2(2.82800007F, -4F), new Vector2(2F, -4F));
                    builder.AddLine(new Vector2(0.5F, -4F));
                    builder.AddLine(new Vector2(0.5F, -5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(4.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(4.5F, -6.88100004F), new Vector2(3.38100004F, -8F), new Vector2(2F, -8F));
                    builder.AddCubicBezier(new Vector2(1.18200004F, -8F), new Vector2(0.455000013F, -7.60699987F), new Vector2(0.00100000005F, -6.99900007F));
                    builder.AddCubicBezier(new Vector2(-0.455000013F, -7.60699987F), new Vector2(-1.18200004F, -8F), new Vector2(-2F, -8F));
                    builder.AddCubicBezier(new Vector2(-3.38100004F, -8F), new Vector2(-4.5F, -6.88100004F), new Vector2(-4.5F, -5.5F));
                    builder.AddCubicBezier(new Vector2(-4.5F, -4.9369998F), new Vector2(-4.3130002F, -4.41699982F), new Vector2(-3.99900007F, -3.99900007F));
                    builder.AddLine(new Vector2(-6F, -4F));
                    builder.AddCubicBezier(new Vector2(-6.55200005F, -4F), new Vector2(-7F, -3.55200005F), new Vector2(-7F, -3F));
                    builder.AddLine(new Vector2(-7F, -1F));
                    builder.AddCubicBezier(new Vector2(-7F, -0.448000014F), new Vector2(-6.55200005F, 0F), new Vector2(-6F, 0F));
                    builder.AddLine(new Vector2(-0.5F, 0F));
                    builder.AddLine(new Vector2(-0.5F, -4F));
                    builder.AddLine(new Vector2(0.5F, -4F));
                    builder.AddLine(new Vector2(0.5F, 0F));
                    builder.AddLine(new Vector2(6F, 0F));
                    builder.AddCubicBezier(new Vector2(6.55200005F, 0F), new Vector2(7F, -0.448000014F), new Vector2(7F, -1F));
                    builder.AddLine(new Vector2(7F, -3F));
                    builder.AddCubicBezier(new Vector2(7F, -3.55200005F), new Vector2(6.55200005F, -4F), new Vector2(6F, -4F));
                    builder.AddLine(new Vector2(3.99900007F, -3.99900007F));
                    builder.AddCubicBezier(new Vector2(4.3130002F, -4.41699982F), new Vector2(4.5F, -4.9369998F), new Vector2(4.5F, -5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(6F, 5.5F));
                    builder.AddLine(new Vector2(6F, 1F));
                    builder.AddLine(new Vector2(0.5F, 1F));
                    builder.AddLine(new Vector2(0.5F, 8F));
                    builder.AddLine(new Vector2(3.5F, 8F));
                    builder.AddLine(new Vector2(3.66400003F, 7.99499989F));
                    builder.AddCubicBezier(new Vector2(4.96799994F, 7.90999985F), new Vector2(6F, 6.82499981F), new Vector2(6F, 5.5F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    builder.BeginFigure(new Vector2(-0.5F, 8F));
                    builder.AddLine(new Vector2(-0.5F, 1F));
                    builder.AddLine(new Vector2(-6F, 1F));
                    builder.AddLine(new Vector2(-6F, 5.5F));
                    builder.AddLine(new Vector2(-5.99499989F, 5.66400003F));
                    builder.AddCubicBezier(new Vector2(-5.90999985F, 6.96799994F), new Vector2(-4.82499981F, 8F), new Vector2(-3.5F, 8F));
                    builder.AddLine(new Vector2(-0.5F, 8F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - - - - Shape tree root for layer: Shape
            // - - - ShapeGroup: Shape
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostLightGreen_FF73D865()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0x73, 0xD8, 0x65));
            }

            // - - - - - - Shape tree root for layer: Shape
            // - - - ShapeGroup: Shape
            // Stop 1
            CompositionColorGradientStop GradientStop_1_AlmostForestGreen_FF439E36()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x43, 0x9E, 0x36));
            }

            // Shape tree root for layer: Shape
            CompositionContainerShape ContainerShape_0()
            {
                if (_containerShape_0 != null) { return _containerShape_0; }
                var result = _containerShape_0 = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(0F, 0F);
                result.Offset = new Vector2(100F, 100F);
                result.RotationAngleInDegrees = 0F;
                result.Shapes.Add(ContainerShape_1());
                return result;
            }

            // - Shape tree root for layer: Shape
            CompositionContainerShape ContainerShape_1()
            {
                var result = _c.CreateContainerShape();
                // ShapeGroup: Shape
                result.Shapes.Add(ContainerShape_2());
                return result;
            }

            // - - Shape tree root for layer: Shape
            // ShapeGroup: Shape
            CompositionContainerShape ContainerShape_2()
            {
                var result = _c.CreateContainerShape();
                result.CenterPoint = new Vector2(0F, 0F);
                result.Offset = new Vector2(0F, 0F);
                result.RotationAngleInDegrees = 0F;
                result.Scale = new Vector2(10F, 10F);
                result.Shapes.Add(ContainerShape_3());
                return result;
            }

            // - - - Shape tree root for layer: Shape
            // ShapeGroup: Shape
            CompositionContainerShape ContainerShape_3()
            {
                var result = _c.CreateContainerShape();
                result.Shapes.Add(SpriteShape());
                return result;
            }

            // - - - - - Shape tree root for layer: Shape
            // - - ShapeGroup: Shape
            CompositionLinearGradientBrush LinearGradientBrush()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostLightGreen_FF73D865());
                colorStops.Add(GradientStop_1_AlmostForestGreen_FF439E36());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(0F, -8F);
                result.EndPoint = new Vector2(0F, 8F);
                return result;
            }

            // - - - - - Shape tree root for layer: Shape
            // - - ShapeGroup: Shape
            CompositionPathGeometry PathGeometry()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry()));
            }

            // - - - - Shape tree root for layer: Shape
            // - ShapeGroup: Shape
            CompositionSpriteShape SpriteShape()
            {
                var result = _c.CreateSpriteShape(PathGeometry());
                result.FillBrush = LinearGradientBrush();
                return result;
            }

            ContainerVisual ContainerVisual_0()
            {
                var result = _c.CreateContainerVisual();
                // Shape tree root for layer: Shape
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                if (_root != null) { return _root; }
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                result.Children.InsertAtTop(ContainerVisual_0());
                return result;
            }

            // Shape tree root for layer: Shape
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(200F, 200F);
                result.Shapes.Add(ContainerShape_0());
                return result;
            }

            // - - Shape tree root for layer: Shape
            // Scale
            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _c.CreateStepEasingFunction();
                result.FinalStep = 1;
                result.IsFinalStepSingleFrame = true;
                result.StepCount = 1;
                return result;
            }

            // - Shape tree root for layer: Shape
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(1F, 1F), HoldThenStepEasingFunction());
                // Frame 10.
                result.InsertKeyFrame(0.333333343F, new Vector2(1.12F, 1.12F), _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F)));
                // Frame 20.
                result.InsertKeyFrame(0.666666687F, new Vector2(0.949999988F, 0.949999988F), _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F)));
                // Frame 29.
                result.InsertKeyFrame(0.966666639F, new Vector2(1F, 1F), _c.CreateCubicBezierEasingFunction(new Vector2(0.600000024F, 0F), new Vector2(0.400000006F, 1F)));
                return result;
            }

            internal PremiumGifting_AnimatedVisual_UAPv7(
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

            public void CreateAnimations()
            {
                _containerShape_0.StartAnimation("Scale", ScaleVector2Animation());
                var controller = _containerShape_0.TryGetAnimationController("Scale");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress", "_", _root);
            }

            public void DestroyAnimations()
            {
                _containerShape_0.StopAnimation("Scale");
            }

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
