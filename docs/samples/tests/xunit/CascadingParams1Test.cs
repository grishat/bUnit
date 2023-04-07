using Xunit;
using Bunit;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Bunit.Rendering;

namespace Bunit.Docs.Samples;

public class CascadingParams1Test : TestContext
{
  [Fact]
  public void Test()
  {
    var isDarkTheme = true;

    var cut = RenderComponent<CascadingParams>(parameters => parameters
      .Add(p => p.IsDarkTheme, isDarkTheme)
    );
  }
}