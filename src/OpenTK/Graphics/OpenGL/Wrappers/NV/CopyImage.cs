//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "CopyImage" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_copy_image]
            /// Perform a raw data copy between two images
            /// </summary>
            /// <param name="srcName">
            /// The name of a texture or renderbuffer object from which to copy.
            /// </param>
            /// <param name="srcTarget">
            /// The target representing the namespace of the source name srcName.
            /// </param>
            /// <param name="srcLevel">
            /// The mipmap level to read from the source.
            /// </param>
            /// <param name="srcX">
            /// The X coordinate of the left edge of the souce region to copy.
            /// </param>
            /// <param name="srcY">
            /// The Y coordinate of the top edge of the souce region to copy.
            /// </param>
            /// <param name="srcZ">
            /// The Z coordinate of the near edge of the souce region to copy.
            /// </param>
            /// <param name="dstName">
            /// The name of a texture or renderbuffer object to which to copy.
            /// </param>
            /// <param name="dstTarget">
            /// The target representing the namespace of the destination name dstName.
            /// </param>
            /// <param name="dstLevel">
            /// The X coordinate of the left edge of the destination region.
            /// </param>
            /// <param name="dstX">
            /// The X coordinate of the left edge of the destination region.
            /// </param>
            /// <param name="dstY">
            /// The Y coordinate of the top edge of the destination region.
            /// </param>
            /// <param name="dstZ">
            /// The Z coordinate of the near edge of the destination region.
            /// </param>
            /// <param name="width">
            /// The height of the region to be copied.
            /// </param>
            /// <param name="height">
            /// The depth of the region to be copied.
            /// </param>
            /// <param name="depth"></param>
            [AutoGenerated(Category = "NV_copy_image", Version = "", EntryPoint = "glCopyImageSubDataNV")]
            public static void CopyImageSubData(uint srcName, OpenTK.Graphics.OpenGL.CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, OpenTK.Graphics.OpenGL.CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(331)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glCopyImageSubDataNV(uint srcName, OpenTK.Graphics.OpenGL.CopyBufferSubDataTarget srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, OpenTK.Graphics.OpenGL.CopyBufferSubDataTarget dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);
        }
    }
}