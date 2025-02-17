// Decompiled with JetBrains decompiler
// Type: bbEditor.Properties.box
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace bbEditor.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  internal sealed class box : ApplicationSettingsBase
  {
    private static box defaultInstance = (box) SettingsBase.Synchronized((SettingsBase) new box());

    public static box Default => box.defaultInstance;

    [DefaultSettingValue("")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public string tbox
    {
      get => (string) this[nameof (tbox)];
      set => this[nameof (tbox)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    public int tboxLength
    {
      get => (int) this[nameof (tboxLength)];
      set => this[nameof (tboxLength)] = (object) value;
    }

    [DefaultSettingValue("0")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public int tboxStart
    {
      get => (int) this[nameof (tboxStart)];
      set => this[nameof (tboxStart)] = (object) value;
    }

    private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
    {
    }

    private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
    {
    }
  }
}
