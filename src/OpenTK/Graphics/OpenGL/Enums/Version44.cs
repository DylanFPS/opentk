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

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Version44
    {
        /// <summary>
        /// Original was GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT = 0x00004000
        /// </summary>
        ClientMappedBufferBarrierBit = ((int)0x00004000),

        /// <summary>
        /// Original was GL_QUERY_BUFFER_BARRIER_BIT = 0x00008000
        /// </summary>
        QueryBufferBarrierBit = ((int)0x00008000),

        /// <summary>
        /// Original was GL_MAP_READ_BIT = 0x0001
        /// </summary>
        MapReadBit = 0x0001,

        /// <summary>
        /// Original was GL_MAP_WRITE_BIT = 0x0002
        /// </summary>
        MapWriteBit = 0x0002,

        /// <summary>
        /// Original was GL_MAP_PERSISTENT_BIT = 0x0040
        /// </summary>
        MapPersistentBit = 0x0040,

        /// <summary>
        /// Original was GL_MAP_COHERENT_BIT = 0x0080
        /// </summary>
        MapCoherentBit = 0x0080,

        /// <summary>
        /// Original was GL_DYNAMIC_STORAGE_BIT = 0x0100
        /// </summary>
        DynamicStorageBit = 0x0100,

        /// <summary>
        /// Original was GL_CLIENT_STORAGE_BIT = 0x0200
        /// </summary>
        ClientStorageBit = 0x0200,

        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = 0x1901,

        /// <summary>
        /// Original was GL_BUFFER_IMMUTABLE_STORAGE = 0x821F
        /// </summary>
        BufferImmutableStorage = 0x821f,

        /// <summary>
        /// Original was GL_BUFFER_STORAGE_FLAGS = 0x8220
        /// </summary>
        BufferStorageFlags = 0x8220,

        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED = 0x8221
        /// </summary>
        PrimitiveRestartForPatchesSupported = 0x8221,

        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIB_STRIDE = 0x82E5
        /// </summary>
        MaxVertexAttribStride = 0x82e5,

        /// <summary>
        /// Original was GL_MIRROR_CLAMP_TO_EDGE = 0x8743
        /// </summary>
        MirrorClampToEdge = 0x8743,

        /// <summary>
        /// Original was GL_TEXTURE_BUFFER_BINDING = 0x8C2A
        /// </summary>
        TextureBufferBinding = 0x8c2a,

        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = 0x8c3b,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = 0x8c8e,

        /// <summary>
        /// Original was GL_STENCIL_INDEX8 = 0x8D48
        /// </summary>
        StencilIndex8 = 0x8d48,

        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = 0x9192,

        /// <summary>
        /// Original was GL_QUERY_BUFFER_BINDING = 0x9193
        /// </summary>
        QueryBufferBinding = 0x9193,

        /// <summary>
        /// Original was GL_QUERY_RESULT_NO_WAIT = 0x9194
        /// </summary>
        QueryResultNoWait = 0x9194,

        /// <summary>
        /// Original was GL_LOCATION_COMPONENT = 0x934A
        /// </summary>
        LocationComponent = 0x934a,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_INDEX = 0x934B
        /// </summary>
        TransformFeedbackBufferIndex = 0x934b,

        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE = 0x934C
        /// </summary>
        TransformFeedbackBufferStride = 0x934c,

        /// <summary>
        /// Original was GL_CLEAR_TEXTURE = 0x9365
        /// </summary>
        ClearTexture = 0x9365
    }
}