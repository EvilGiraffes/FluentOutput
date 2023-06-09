﻿using FluentOutput.Sdk.Abstractions;

using NUnit.Framework;

namespace FluentOutput.NUnit;
public class FluentNUnit : IFluentOutput
{
    public void WriteLine(IMessageRenderer renderer)
        => TestContext.WriteLine(renderer.Render());
}
