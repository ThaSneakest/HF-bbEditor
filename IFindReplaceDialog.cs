// Decompiled with JetBrains decompiler
// Type: IFindReplaceDialog
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using FindReplace;
using Microsoft.VisualBasic.CompilerServices;
using System.Windows.Forms;

#nullable disable
public interface IFindReplaceDialog
{
  event IFindReplaceDialog.ReplaceClickEventHandler ReplaceClick;

  event IFindReplaceDialog.ReplaceAllClickEventHandler ReplaceAllClick;

  event IFindReplaceDialog.FindNextClickEventHandler FindNextClick;

  event IFindReplaceDialog.DialogTerminateEventHandler DialogTerminate;

  event IFindReplaceDialog.HelpEventHandler Help;

  event IFindReplaceDialog.SearchFailedEventHandler SearchFailed;

  event IFindReplaceDialog.TextFoundEventHandler TextFound;

  void Dispose(bool disposing);

  void FindString(TextBox sourceControl);

  void ReplaceString(TextBox sourceControl, bool ReplaceAll);

  void Show(IWin32Window windowOwner);

  FindDirection Direction { get; set; }

  bool DirectionEnabled { get; set; }

  bool DirectionVisible { get; set; }

  string FindWhat { get; set; }

  bool HelpVisible { get; set; }

  bool MatchCase { get; set; }

  bool MatchCaseEnabled { get; set; }

  bool MatchCaseVisible { get; set; }

  bool MatchWholeWord { get; set; }

  string ReplaceWith { get; set; }

  FindReplaceDialogType Type { get; set; }

  bool MatchWholeWordEnabled { get; set; }

  bool MatchWholeWordVisible { get; set; }

  [OptionText]
  delegate void ReplaceClickEventHandler();

  [OptionText]
  delegate void ReplaceAllClickEventHandler();

  [OptionText]
  delegate void FindNextClickEventHandler();

  [OptionText]
  delegate void DialogTerminateEventHandler();

  [OptionText]
  delegate void HelpEventHandler();

  [OptionText]
  delegate void SearchFailedEventHandler(FindReplaceEventArgs eventArguments);

  [OptionText]
  delegate void TextFoundEventHandler(FindReplaceEventArgs eventArguments);
}
