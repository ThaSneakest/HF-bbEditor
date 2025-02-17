// Decompiled with JetBrains decompiler
// Type: bbEditor.Properties.Resources
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace bbEditor.Properties
{
  [CompilerGenerated]
  [DebuggerNonUserCode]
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
        if (object.ReferenceEquals((object) bbEditor.Properties.Resources.resourceMan, (object) null))
          bbEditor.Properties.Resources.resourceMan = new ResourceManager("bbEditor.Properties.Resources", typeof (bbEditor.Properties.Resources).Assembly);
        return bbEditor.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => bbEditor.Properties.Resources.resourceCulture;
      set => bbEditor.Properties.Resources.resourceCulture = value;
    }
  }
}
