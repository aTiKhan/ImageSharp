﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing.Processors.Filters;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the alteration of the opacity component to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class OpacityExtensions
    {
        /// <summary>
        /// Multiplies the alpha component of the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="amount">The proportion of the conversion. Must be between 0 and 1.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext Opacity(this IImageProcessingContext source, float amount)
            => source.ApplyProcessor(new OpacityProcessor(amount));

        /// <summary>
        /// Multiplies the alpha component of the image.
        /// </summary>
        /// <param name="source">The image this method extends.</param>
        /// <param name="amount">The proportion of the conversion. Must be between 0 and 1.</param>
        /// <param name="rectangle">
        /// The <see cref="Rectangle"/> structure that specifies the portion of the image object to alter.
        /// </param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext Opacity(this IImageProcessingContext source, float amount, Rectangle rectangle)
            => source.ApplyProcessor(new OpacityProcessor(amount), rectangle);
    }
}