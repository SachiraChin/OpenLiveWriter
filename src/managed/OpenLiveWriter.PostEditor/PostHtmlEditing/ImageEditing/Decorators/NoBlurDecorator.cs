﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System;
using System.Collections.Generic;
using System.Text;
using OpenLiveWriter.ApplicationFramework;
using OpenLiveWriter.Extensibility.ImageEditing;

namespace OpenLiveWriter.PostEditor.PostHtmlEditing.ImageEditing.Decorators
{
    public class NoBlurDecorator : IImageDecorator
    {
        public NoBlurDecorator()
        {
        }

        public readonly static string Id = "NoBlur";

        public void Decorate(ImageDecoratorContext context)
        {
        }

        public ImageDecoratorEditor CreateEditor(CommandManager commandManager)
        {
            return null;
        }
    }
}
