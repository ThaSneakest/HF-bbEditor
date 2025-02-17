// Decompiled with JetBrains decompiler
// Type: FindReplace.structFindReplace
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;

#nullable disable
namespace FindReplace
{
  [OptionText]
  internal struct structFindReplace
  {
    internal int cbSize;
    internal IntPtr hwndOwner;
    internal IntPtr hInstance;
    internal int findReplaceFlags;
    internal IntPtr findWhat;
    internal IntPtr replaceWith;
    internal short findWhatLen;
    internal short replaceWithLen;
    internal IntPtr custData;
    internal IntPtr hookProc;
    internal IntPtr templateName;
  }
}
