// Decompiled with JetBrains decompiler
// Type: FindReplace.FindReplaceEventArgs
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using System;
using System.Windows.Forms;

#nullable disable
namespace FindReplace
{
  public class FindReplaceEventArgs : EventArgs
  {
    private int intPosition;
    private string strFindWhat;
    private Control ctrlSource;

    public int Position => this.intPosition;

    public string FindWhat => this.strFindWhat;

    public Control Control => this.ctrlSource;

    internal FindReplaceEventArgs(Control ControlIn, string findWhatIn, int PositionIn)
    {
      this.ctrlSource = ControlIn;
      this.strFindWhat = findWhatIn;
      this.intPosition = PositionIn;
    }
  }
}
