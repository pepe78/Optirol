// Decompiled with JetBrains decompiler
// Type: Optirol.Properties.Resources
// Assembly: Optirol, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00BF1D7A-FB0A-4D90-A8E1-A8B009A65C83
// Assembly location: C:\Users\tarab\OneDrive\Desktop\Optirol1.1\Optirol.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Optirol.Properties
{
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) Optirol.Properties.Resources.resourceMan, (object) null))
          Optirol.Properties.Resources.resourceMan = new ResourceManager("Optirol.Properties.Resources", typeof (Optirol.Properties.Resources).Assembly);
        return Optirol.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Optirol.Properties.Resources.resourceCulture;
      }
      set
      {
        Optirol.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
