// Decompiled with JetBrains decompiler
// Type: FindReplace.OwnerWindow
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Windows.Forms;

#nullable disable
namespace FindReplace
{
  [OptionText]
  internal class OwnerWindow : NativeWindow
  {
    private FindReplaceDialog parent;

    internal OwnerWindow(FindReplaceDialog FindReplaceDialogIn)
    {
      try
      {
        this.parent = FindReplaceDialogIn;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    protected override void WndProc(ref Message interceptedMessage)
    {
      try
      {
        if (interceptedMessage.HWnd.Equals((object) this.Handle))
        {
          if (interceptedMessage.Msg == FindReplaceDialog.findMessage)
            this.parent.HandleFindMsgString(interceptedMessage);
          else if (interceptedMessage.Msg == FindReplaceDialog.helpMessage)
            this.parent.HandleHlpMsg(interceptedMessage);
          else
            this.DefWndProc(ref interceptedMessage);
        }
        else
          this.DefWndProc(ref interceptedMessage);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }
  }
}
