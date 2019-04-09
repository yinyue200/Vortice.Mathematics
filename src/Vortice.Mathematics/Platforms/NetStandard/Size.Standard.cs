﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

namespace Vortice.Mathematics
{
    public partial struct Size
    {
        /// <summary>
        /// Performs an implicit conversion from <see cref="Size"/> to <see cref="System.Drawing.Size"/>.
        /// </summary>
        /// <param name="size">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator System.Drawing.Size(Size size) =>
            new System.Drawing.Size(size.Width, size.Height);


        /// <summary>
        /// Performs an implicit conversion from <see cref="System.Drawing.Size"/> to <see cref="Size"/>.
        /// </summary>
        /// <param name="size">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Size(System.Drawing.Size size) =>
            new Size(size.Width, size.Height);
    }
}
