// Decompiled with JetBrains decompiler
// Type: bbEditor.MessageBoxHelper
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace bbEditor
{
  internal static class MessageBoxHelper
  {
    internal static void PrepToCenterMessageBoxOnForm(Form form)
    {
      new MessageBoxHelper.MessageBoxCenterHelper().Prep(form);
    }

    private class MessageBoxCenterHelper
    {
      private int messageHook;
      private IntPtr parentFormHandle;

      public void Prep(Form form)
      {
        MessageBoxHelper.NativeMethods.CenterMessageCallBackDelegate callback = new MessageBoxHelper.NativeMethods.CenterMessageCallBackDelegate(this.CenterMessageCallBack);
        GCHandle.Alloc((object) callback);
        this.parentFormHandle = form.Handle;
        this.messageHook = MessageBoxHelper.NativeMethods.SetWindowsHookEx(5, callback, new IntPtr(MessageBoxHelper.NativeMethods.GetWindowLong(this.parentFormHandle, -6)), MessageBoxHelper.NativeMethods.GetCurrentThreadId()).ToInt32();
      }

      private int CenterMessageCallBack(int message, int wParam, int lParam)
      {
        if (message == 5)
        {
          MessageBoxHelper.NativeMethods.RECT lpRect1;
          MessageBoxHelper.NativeMethods.GetWindowRect(this.parentFormHandle, out lpRect1);
          MessageBoxHelper.NativeMethods.RECT lpRect2;
          MessageBoxHelper.NativeMethods.GetWindowRect(new IntPtr(wParam), out lpRect2);
          int X = lpRect1.Left + (lpRect1.Right - lpRect1.Left) / 2 - (lpRect2.Right - lpRect2.Left) / 2;
          int Y = lpRect1.Top + (lpRect1.Bottom - lpRect1.Top) / 2 - (lpRect2.Bottom - lpRect2.Top) / 2;
          MessageBoxHelper.NativeMethods.SetWindowPos(wParam, 0, X, Y, 0, 0, 21);
          MessageBoxHelper.NativeMethods.UnhookWindowsHookEx(this.messageHook);
        }
        return 0;
      }
    }

    private static class NativeMethods
    {
      [DllImport("user32.dll")]
      [return: MarshalAs(UnmanagedType.Bool)]
      internal static extern bool UnhookWindowsHookEx(int hhk);

      [DllImport("user32.dll", SetLastError = true)]
      internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

      [DllImport("kernel32.dll")]
      internal static extern int GetCurrentThreadId();

      [DllImport("user32.dll", SetLastError = true)]
      internal static extern IntPtr SetWindowsHookEx(
        int hook,
        MessageBoxHelper.NativeMethods.CenterMessageCallBackDelegate callback,
        IntPtr hMod,
        int dwThreadId);

      [DllImport("user32.dll")]
      [return: MarshalAs(UnmanagedType.Bool)]
      internal static extern bool SetWindowPos(
        int hWnd,
        int hWndInsertAfter,
        int X,
        int Y,
        int cx,
        int cy,
        int uFlags);

      [DllImport("user32.dll")]
      [return: MarshalAs(UnmanagedType.Bool)]
      internal static extern bool GetWindowRect(
        IntPtr hWnd,
        out MessageBoxHelper.NativeMethods.RECT lpRect);

      internal struct RECT
      {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
      }

      internal delegate int CenterMessageCallBackDelegate(int message, int wParam, int lParam);
    }
  }
}
