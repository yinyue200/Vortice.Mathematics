﻿// Copyright (c) Amer Koleci and contributors.
// Distributed under the MIT license. See the LICENSE file in the project root for more information.

namespace Vortice.Mathematics
{
    public partial struct PointF
    {
        /// <summary>
        /// Performs an implicit conversion from <see cref="PointF"/> to <see cref="Android.Graphics.PointF"/>.
        /// </summary>
        /// <param name="point">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Android.Graphics.PointF(PointF point)
        {
            return new Android.Graphics.PointF(point.X, point.Y);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="Android.Graphics.PointF"/> to <see cref="PointF"/>.
        /// </summary>
        /// <param name="point">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator PointF(Android.Graphics.PointF point)
        {
            return new PointF(point.X, point.Y);
        }
    }
}