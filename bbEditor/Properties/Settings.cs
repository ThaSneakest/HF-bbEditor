// Decompiled with JetBrains decompiler
// Type: bbEditor.Properties.Settings
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace bbEditor.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
    {
    }

    private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
    {
    }

    public static Settings Default => Settings.defaultInstance;

    [DefaultSettingValue("Tahoma, 11.25pt")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Font Fstyle
    {
      get => (Font) this[nameof (Fstyle)];
      set => this[nameof (Fstyle)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("Black")]
    [DebuggerNonUserCode]
    public Color Fcolor
    {
      get => (Color) this[nameof (Fcolor)];
      set => this[nameof (Fcolor)] = (object) value;
    }

    [DefaultSettingValue("0, 0")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Point FormLocation
    {
      get => (Point) this[nameof (FormLocation)];
      set => this[nameof (FormLocation)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("")]
    public string ApplicationVersion
    {
      get => (string) this[nameof (ApplicationVersion)];
      set => this[nameof (ApplicationVersion)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("True")]
    public bool Split1panel2collapsed
    {
      get => (bool) this[nameof (Split1panel2collapsed)];
      set => this[nameof (Split1panel2collapsed)] = (object) value;
    }

    [DefaultSettingValue("275")]
    [DebuggerNonUserCode]
    [UserScopedSetting]
    public int splitterposition
    {
      get => (int) this[nameof (splitterposition)];
      set => this[nameof (splitterposition)] = (object) value;
    }

    [UserScopedSetting]
    [DefaultSettingValue("True")]
    [DebuggerNonUserCode]
    public bool codeon
    {
      get => (bool) this[nameof (codeon)];
      set => this[nameof (codeon)] = (object) value;
    }

    [DefaultSettingValue("628, 447")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Size FormSize
    {
      get => (Size) this[nameof (FormSize)];
      set => this[nameof (FormSize)] = (object) value;
    }

    [DebuggerNonUserCode]
    [DefaultSettingValue("0")]
    [UserScopedSetting]
    public int eCaret
    {
      get => (int) this[nameof (eCaret)];
      set => this[nameof (eCaret)] = (object) value;
    }

    [DefaultSettingValue("False")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public bool KSCFrmEnabled
    {
      get => (bool) this[nameof (KSCFrmEnabled)];
      set => this[nameof (KSCFrmEnabled)] = (object) value;
    }

    [DefaultSettingValue("0, 0")]
    [UserScopedSetting]
    [DebuggerNonUserCode]
    public Point KSCFrmLocation
    {
      get => (Point) this[nameof (KSCFrmLocation)];
      set => this[nameof (KSCFrmLocation)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("False")]
    public bool KSCFrmShow
    {
      get => (bool) this[nameof (KSCFrmShow)];
      set => this[nameof (KSCFrmShow)] = (object) value;
    }

    [DebuggerNonUserCode]
    [UserScopedSetting]
    [DefaultSettingValue("260, 636")]
    public Size KSCFrmSize
    {
      get => (Size) this[nameof (KSCFrmSize)];
      set => this[nameof (KSCFrmSize)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Tahoma, 8.25pt")]
    public Font KSCFrmFont
    {
      get => (Font) this[nameof (KSCFrmFont)];
      set => this[nameof (KSCFrmFont)] = (object) value;
    }

    [UserScopedSetting]
    [DebuggerNonUserCode]
    [DefaultSettingValue("Black")]
    public Color KSCFrmFontColor
    {
      get => (Color) this[nameof (KSCFrmFontColor)];
      set => this[nameof (KSCFrmFontColor)] = (object) value;
    }
  }
}
