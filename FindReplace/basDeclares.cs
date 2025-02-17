// Decompiled with JetBrains decompiler
// Type: FindReplace.basDeclares
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace FindReplace
{
  [OptionText]
  [StandardModule]
  internal sealed class basDeclares
  {
    [DllImport("Comdlg32", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern IntPtr FindText(IntPtr lpfr);

    [DllImport("Comdlg32", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern IntPtr ReplaceText(IntPtr lpfr);

    [DllImport("User32", EntryPoint = "RegisterWindowMessageA", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern int RegisterWindowMessage([MarshalAs(UnmanagedType.LPStr)] string message);

    [DllImport("User32", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern int DestroyWindow(IntPtr hwnd);

    [DllImport("User32", CharSet = CharSet.Auto, SetLastError = true)]
    internal static extern bool IsDialogMessage(IntPtr hWnd, ref Message m);
  }
}
