// Decompiled with JetBrains decompiler
// Type: FindReplace.FindReplaceEnum
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using Microsoft.VisualBasic.CompilerServices;

#nullable disable
namespace FindReplace
{
  [OptionText]
  internal enum FindReplaceEnum
  {
    Down = 1,
    MatchWholeWord = 2,
    MatchCase = 4,
    FindNext = 8,
    Replace = 16, // 0x00000010
    ReplaceAll = 32, // 0x00000020
    DialogTerm = 64, // 0x00000040
    ShowHelp = 128, // 0x00000080
    EnableHook = 256, // 0x00000100
    EnableTemplate = 512, // 0x00000200
    DisableUpDown = 1024, // 0x00000400
    DisableMatchCase = 2048, // 0x00000800
    DisableWholeWord = 4096, // 0x00001000
    EnableTemplateHandle = 8192, // 0x00002000
    HideUpDown = 16384, // 0x00004000
    HideMatchCase = 32768, // 0x00008000
    HideWholeWord = 65536, // 0x00010000
  }
}
