// Decompiled with JetBrains decompiler
// Type: FindReplace.FindReplaceDialog
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#nullable disable
namespace FindReplace
{
  [OptionText]
  public class FindReplaceDialog : Component, IMessageFilter, IFindReplaceDialog
  {
    private const int bufferSize = 256;
    internal static int FindReplaceFlags;
    internal static int findMessage;
    internal static int helpMessage;
    private IntPtr findReplacePointer;
    private FindReplaceDialogType dialogType;
    private IntPtr windowHandle;
    private OwnerWindow Owner;
    private string findWhatString;
    private string replaceWithString;
    private IntPtr findWhatPointer;
    private IntPtr replaceWithPointer;
    private ArrayList wordTerminators;
    private ArrayList wordPrefixes;

    public FindReplaceDialog()
    {
      this.findWhatPointer = IntPtr.Zero;
      this.replaceWithPointer = IntPtr.Zero;
      try
      {
        this.Owner = new OwnerWindow(this);
        this.wordPrefixes = new ArrayList();
        this.wordTerminators = new ArrayList();
        this.SetOption(FindReplaceEnum.DisableMatchCase, false);
        this.SetOption(FindReplaceEnum.DisableUpDown, false);
        this.SetOption(FindReplaceEnum.DisableWholeWord, false);
        this.SetOption(FindReplaceEnum.Down, true);
        this.SetOption(FindReplaceEnum.HideMatchCase, false);
        this.SetOption(FindReplaceEnum.HideUpDown, false);
        this.SetOption(FindReplaceEnum.HideWholeWord, false);
        this.SetOption(FindReplaceEnum.MatchCase, false);
        this.SetOption(FindReplaceEnum.MatchWholeWord, false);
        this.SetOption(FindReplaceEnum.ShowHelp, true);
        ArrayList wordPrefixes = this.wordPrefixes;
        wordPrefixes.Add((object) " ");
        wordPrefixes.Add((object) ".");
        wordPrefixes.Add((object) "!");
        wordPrefixes.Add((object) "?");
        wordPrefixes.Add((object) ",");
        wordPrefixes.Add((object) ";");
        wordPrefixes.Add((object) ":");
        wordPrefixes.Add((object) "\"");
        wordPrefixes.Add((object) "'");
        wordPrefixes.Add((object) "");
        ArrayList wordTerminators = this.wordTerminators;
        wordTerminators.Add((object) " ");
        wordTerminators.Add((object) ".");
        wordTerminators.Add((object) "!");
        wordTerminators.Add((object) "?");
        wordTerminators.Add((object) ",");
        wordTerminators.Add((object) ";");
        wordTerminators.Add((object) ":");
        wordTerminators.Add((object) "\"");
        wordTerminators.Add((object) "'");
        wordTerminators.Add((object) "");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    bool IMessageFilter.PreFilterMessage(ref Message m)
    {
      try
      {
        return basDeclares.IsDialogMessage(this.windowHandle, ref m);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    public event IFindReplaceDialog.FindNextClickEventHandler FindNextClick;

    public event IFindReplaceDialog.DialogTerminateEventHandler DialogTerminate;

    public event IFindReplaceDialog.ReplaceClickEventHandler ReplaceClick;

    public event IFindReplaceDialog.ReplaceAllClickEventHandler ReplaceAllClick;

    public event IFindReplaceDialog.HelpEventHandler Help;

    public event IFindReplaceDialog.TextFoundEventHandler TextFound;

    public event IFindReplaceDialog.SearchFailedEventHandler SearchFailed;

    protected virtual void OnReplaceClick()
    {
      IFindReplaceDialog.ReplaceClickEventHandler replaceClickEvent = this.ReplaceClickEvent;
      if (replaceClickEvent == null)
        return;
      replaceClickEvent();
    }

    protected virtual void OnHelp()
    {
      IFindReplaceDialog.HelpEventHandler helpEvent = this.HelpEvent;
      if (helpEvent == null)
        return;
      helpEvent();
    }

    protected virtual void OnReplaceAllClick()
    {
      IFindReplaceDialog.ReplaceAllClickEventHandler replaceAllClickEvent = this.ReplaceAllClickEvent;
      if (replaceAllClickEvent == null)
        return;
      replaceAllClickEvent();
    }

    protected virtual void OnFindNextClick()
    {
      IFindReplaceDialog.FindNextClickEventHandler findNextClickEvent = this.FindNextClickEvent;
      if (findNextClickEvent == null)
        return;
      findNextClickEvent();
    }

    protected virtual void OnDialogTerminate()
    {
      try
      {
        this.windowHandle = IntPtr.Zero;
        this.Owner.ReleaseHandle();
        Application.RemoveMessageFilter((IMessageFilter) this);
        IFindReplaceDialog.DialogTerminateEventHandler dialogTerminateEvent = this.DialogTerminateEvent;
        if (dialogTerminateEvent == null)
          return;
        dialogTerminateEvent();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    protected virtual void OnTextFound(Control sourceControl, string findWhat, int Position)
    {
      FindReplaceEventArgs eventArguments = new FindReplaceEventArgs(sourceControl, findWhat, Position);
      IFindReplaceDialog.TextFoundEventHandler textFoundEvent = this.TextFoundEvent;
      if (textFoundEvent == null)
        return;
      textFoundEvent(eventArguments);
    }

    protected virtual void OnSearchFailed(Control sourceControl, string findWhat)
    {
      FindReplaceEventArgs eventArguments = new FindReplaceEventArgs(sourceControl, findWhat, -1);
      IFindReplaceDialog.SearchFailedEventHandler searchFailedEvent = this.SearchFailedEvent;
      if (searchFailedEvent == null)
        return;
      searchFailedEvent(eventArguments);
    }

    [Description("Specifies whether to search up or down.")]
    [DefaultValue(1)]
    public FindDirection Direction
    {
      get
      {
        try
        {
          return this.GetOption(FindReplaceEnum.Down) ? FindDirection.Down : FindDirection.Up;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          if (value == FindDirection.Down)
            this.SetOption(FindReplaceEnum.Down, true);
          else
            this.SetOption(FindReplaceEnum.Down, false);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [DefaultValue(true)]
    [Description("Specifies whether the Directional options are enabled or disabled. Only available for a Find dialog box.")]
    public bool DirectionEnabled
    {
      get
      {
        try
        {
          return this.Type == FindReplaceDialogType.Find && !this.GetOption(FindReplaceEnum.DisableUpDown);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          if (this.Type == FindReplaceDialogType.Find)
            this.SetOption(FindReplaceEnum.DisableUpDown, !value);
          else
            this.SetOption(FindReplaceEnum.DisableUpDown, false);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [Description("Specifies whether the Directional options are visible or hidden. Only available for a Find dialog box.")]
    [DefaultValue(true)]
    public bool DirectionVisible
    {
      get
      {
        try
        {
          return this.Type == FindReplaceDialogType.Find && !this.GetOption(FindReplaceEnum.HideUpDown);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          if (this.Type == FindReplaceDialogType.Find)
            this.SetOption(FindReplaceEnum.HideUpDown, !value);
          else
            this.SetOption(FindReplaceEnum.HideUpDown, false);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [Description("Specifies whether to do a case sensitive search or not.")]
    [DefaultValue(false)]
    public bool MatchCase
    {
      get
      {
        try
        {
          return this.GetOption(FindReplaceEnum.MatchCase);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.SetOption(FindReplaceEnum.MatchCase, value);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [DefaultValue(true)]
    [Description("Specifies whether the MatchCase options should be enabled or disabled.")]
    public bool MatchCaseEnabled
    {
      get
      {
        try
        {
          return !this.GetOption(FindReplaceEnum.DisableMatchCase);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.SetOption(FindReplaceEnum.DisableMatchCase, !value);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [DefaultValue(true)]
    [Description("Specifies whether the MatchCase options should be visible or hidden.")]
    public bool MatchCaseVisible
    {
      get
      {
        try
        {
          return !this.GetOption(FindReplaceEnum.HideMatchCase);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.SetOption(FindReplaceEnum.HideMatchCase, !value);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [DefaultValue(false)]
    [Description("Specifies whether to match the whole word or not.")]
    public bool MatchWholeWord
    {
      get
      {
        try
        {
          return this.GetOption(FindReplaceEnum.MatchWholeWord);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.SetOption(FindReplaceEnum.MatchWholeWord, value);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [DefaultValue(true)]
    [Description("Specifies whether the MatchCase options should be enabled or disabled.")]
    public bool MatchWholeWordEnabled
    {
      get
      {
        try
        {
          return !this.GetOption(FindReplaceEnum.DisableWholeWord);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.SetOption(FindReplaceEnum.DisableWholeWord, !value);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [DefaultValue(true)]
    [Description("Specifies whether the Directional options should be visible or hidden.")]
    public bool MatchWholeWordVisible
    {
      get
      {
        try
        {
          return !this.GetOption(FindReplaceEnum.HideWholeWord);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.SetOption(FindReplaceEnum.HideWholeWord, !value);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [DefaultValue(true)]
    [Description("Specifies whether the Help button should be visible or not.")]
    public bool HelpVisible
    {
      get
      {
        try
        {
          return this.GetOption(FindReplaceEnum.ShowHelp);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.SetOption(FindReplaceEnum.ShowHelp, value);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [Description("Specifies the string to search for.")]
    public string FindWhat
    {
      get
      {
        try
        {
          if (Information.IsNothing((object) this.findWhatString))
            this.findWhatString = "";
          return this.findWhatString;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.findWhatString = value;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [Description("Specifies the string to replace with.")]
    public string ReplaceWith
    {
      get
      {
        try
        {
          if (Information.IsNothing((object) this.replaceWithString))
            this.replaceWithString = "";
          return this.replaceWithString;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.replaceWithString = value;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    [Description("Specifies which type of dialog should be displayed.")]
    [DefaultValue(0)]
    public FindReplaceDialogType Type
    {
      get
      {
        try
        {
          return this.dialogType;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
      set
      {
        try
        {
          this.dialogType = value;
          if (value != FindReplaceDialogType.Replace)
            return;
          this.DirectionVisible = false;
          this.DirectionEnabled = false;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          throw ex;
        }
      }
    }

    public void Show(IWin32Window windowOwner)
    {
      try
      {
        if (FindReplaceDialog.findMessage == 0)
        {
          FindReplaceDialog.findMessage = basDeclares.RegisterWindowMessage("commdlg_FindReplace");
          FindReplaceDialog.helpMessage = basDeclares.RegisterWindowMessage("commdlg_help");
        }
        this.Owner.AssignHandle(windowOwner.Handle);
        this.CleanUp();
        structFindReplace structure;
        structure.hwndOwner = windowOwner.Handle;
        structure.cbSize = Marshal.SizeOf(typeof (structFindReplace));
        this.findWhatPointer = this.StringToPointer(this.FindWhat, ref structure.findWhatLen);
        structure.findWhat = this.findWhatPointer;
        this.replaceWithPointer = this.StringToPointer(this.ReplaceWith, ref structure.replaceWithLen);
        structure.replaceWith = this.replaceWithPointer;
        structure.findReplaceFlags = FindReplaceDialog.FindReplaceFlags;
        structure.hInstance = IntPtr.Zero;
        this.findReplacePointer = Marshal.AllocHGlobal(Marshal.SizeOf((object) structure));
        Marshal.StructureToPtr((object) structure, this.findReplacePointer, true);
        Application.AddMessageFilter((IMessageFilter) this);
        this.windowHandle = this.dialogType != FindReplaceDialogType.Find ? basDeclares.ReplaceText(this.findReplacePointer) : basDeclares.FindText(this.findReplacePointer);
        if (!this.windowHandle.Equals((object) IntPtr.Zero))
          return;
        Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    void IFindReplaceDialog.Dispose(bool disposing)
    {
      try
      {
        base.Dispose(disposing);
        this.CleanUp();
        if (this.windowHandle.Equals((object) IntPtr.Zero))
          return;
        basDeclares.DestroyWindow(this.windowHandle);
        Application.RemoveMessageFilter((IMessageFilter) this);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    public void FindString(TextBox sourceControl)
    {
      this.FindReplaceString(sourceControl, FindReplaceDialog.FindReplaceOperation.FindOnly);
    }

    public void ReplaceString(TextBox sourceControl, bool ReplaceAll)
    {
      if (ReplaceAll)
        this.FindReplaceString(sourceControl, FindReplaceDialog.FindReplaceOperation.ReplaceAll);
      else
        this.FindReplaceString(sourceControl, FindReplaceDialog.FindReplaceOperation.Replace);
    }

    private int Search(
      TextBox sourceControl,
      string searchText,
      string findWhat,
      CompareMethod compareMode,
      FindDirection direction,
      int startIndex)
    {
      if (direction == FindDirection.Down)
      {
        int startIndex1 = Strings.InStr(startIndex, searchText, findWhat, compareMode);
        if (startIndex1 <= 0)
          return -1;
        if (this.MatchWholeWord)
        {
          while (!this.IsWholeWord(startIndex1, searchText, findWhat))
          {
            checked { ++startIndex; }
            startIndex1 = Strings.InStr(startIndex, searchText, findWhat, compareMode);
            if (startIndex1 == 0)
              break;
          }
        }
        return startIndex1;
      }
      if (startIndex <= 0)
        return -1;
      int startIndex2 = Strings.InStrRev(searchText, findWhat, startIndex, compareMode);
      if (this.MatchWholeWord)
      {
        while (!this.IsWholeWord(startIndex2, searchText, findWhat))
        {
          checked { --startIndex; }
          startIndex2 = Strings.InStrRev(searchText, findWhat, startIndex, compareMode);
          if (startIndex2 == 0)
            break;
        }
      }
      return startIndex2;
    }

    private void FindReplaceString(
      TextBox sourceControl,
      FindReplaceDialog.FindReplaceOperation operation)
    {
      string findWhat = this.FindWhat;
      string str1 = sourceControl.Text;
      FindDirection direction = this.Direction;
      CompareMethod compareMethod = !this.MatchCase ? CompareMethod.Text : CompareMethod.Binary;
      int startIndex1 = direction != FindDirection.Down ? sourceControl.SelectionStart : checked (sourceControl.SelectionStart + sourceControl.SelectionLength + 1);
      switch (operation)
      {
        case FindReplaceDialog.FindReplaceOperation.FindOnly:
          int num1 = this.Search(sourceControl, str1, findWhat, compareMethod, direction, startIndex1);
          if (num1 > 0)
          {
            sourceControl.Select(checked (num1 - 1), Strings.Len(findWhat));
            this.OnTextFound((Control) sourceControl, findWhat, checked (num1 - 1));
            break;
          }
          this.OnSearchFailed((Control) sourceControl, findWhat);
          break;
        case FindReplaceDialog.FindReplaceOperation.Replace:
          if (Strings.StrComp(sourceControl.SelectedText, findWhat, compareMethod) == 0)
          {
            int selectionStart = sourceControl.SelectionStart;
            string str2 = Strings.Left(str1, selectionStart) + Strings.Replace(str1, findWhat, this.ReplaceWith, checked (selectionStart + 1), 1, compareMethod);
            sourceControl.Text = str2;
            sourceControl.Select(selectionStart, Strings.Len(this.ReplaceWith));
            break;
          }
          int num2 = this.Search(sourceControl, str1, findWhat, compareMethod, direction, startIndex1);
          if (num2 == 0)
          {
            sourceControl.Select(checked (num2 - 1), Strings.Len(findWhat));
            break;
          }
          this.OnSearchFailed((Control) sourceControl, findWhat);
          break;
        default:
          int Start = this.Search(sourceControl, str1, findWhat, compareMethod, direction, startIndex1);
          if (Start > 0)
          {
            while (Start >= 1)
            {
              str1 = Strings.Left(str1, checked (Start - 1)) + Strings.Replace(str1, findWhat, this.ReplaceWith, Start, 1, compareMethod);
              checked { ++startIndex1; }
              int startIndex2 = checked (Start + this.ReplaceWith.Length);
              Start = this.Search(sourceControl, str1, findWhat, compareMethod, direction, startIndex2);
              int num3;
              checked { ++num3; }
            }
            sourceControl.Text = str1;
            sourceControl.Select(0, 0);
            break;
          }
          this.OnSearchFailed((Control) sourceControl, findWhat);
          break;
      }
    }

    private bool IsWholeWord(int startIndex, string searchText, string findWhat)
    {
      try
      {
        string str1 = startIndex <= 1 ? "" : Strings.Mid(searchText, checked (startIndex - 1), 1);
        string str2 = Strings.Mid(searchText, checked (startIndex + Strings.Len(findWhat)), 1);
        return this.wordPrefixes.IndexOf((object) str1) >= 0 & this.wordTerminators.IndexOf((object) str2) >= 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    private IntPtr StringToPointer(string stringIn, ref short length)
    {
      try
      {
        IntPtr pv = Marshal.StringToHGlobalAuto(stringIn);
        length = checked ((short) stringIn.Length);
        if (stringIn == null | stringIn.Length < 256)
        {
          pv = Marshal.ReAllocHGlobal(pv, new IntPtr(checked (256 * Marshal.SystemDefaultCharSize)));
          length = (short) 256;
        }
        return pv;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    private void SetOption(FindReplaceEnum findReplaceOption, bool enableOption)
    {
      try
      {
        if (enableOption)
          FindReplaceDialog.FindReplaceFlags = (int) ((FindReplaceEnum) FindReplaceDialog.FindReplaceFlags | findReplaceOption);
        else
          FindReplaceDialog.FindReplaceFlags = (int) ((FindReplaceEnum) FindReplaceDialog.FindReplaceFlags & ~findReplaceOption);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    private bool GetOption(FindReplaceEnum findReplaceOption)
    {
      try
      {
        return ((FindReplaceEnum) FindReplaceDialog.FindReplaceFlags & findReplaceOption) != (FindReplaceEnum) 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    private void CleanUp()
    {
      try
      {
        if (!this.findWhatPointer.Equals((object) IntPtr.Zero))
          Marshal.FreeHGlobal(this.findWhatPointer);
        if (!this.replaceWithPointer.Equals((object) IntPtr.Zero))
          Marshal.FreeHGlobal(this.replaceWithPointer);
        if (!this.findReplacePointer.Equals((object) IntPtr.Zero))
        {
          object structure = Marshal.PtrToStructure(this.findReplacePointer, typeof (structFindReplace));
          structFindReplace structFindReplace1;
          structFindReplace structFindReplace2 = structure != null ? (structFindReplace) structure : structFindReplace1;
          Marshal.FreeHGlobal(this.findReplacePointer);
        }
        this.findReplacePointer = IntPtr.Zero;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    internal void HandleHlpMsg(Message forwardedMessage) => this.OnHelp();

    internal void HandleFindMsgString(Message forwardedMessage)
    {
      try
      {
        object structure = Marshal.PtrToStructure(forwardedMessage.LParam, typeof (structFindReplace));
        structFindReplace structFindReplace1;
        structFindReplace structFindReplace2 = structure != null ? (structFindReplace) structure : structFindReplace1;
        FindReplaceDialog.FindReplaceFlags = structFindReplace2.findReplaceFlags;
        this.findWhatString = Marshal.PtrToStringAuto(structFindReplace2.findWhat);
        this.replaceWithString = Marshal.PtrToStringAuto(structFindReplace2.replaceWith);
        if (this.GetOption(FindReplaceEnum.DialogTerm))
        {
          this.SetOption(FindReplaceEnum.DialogTerm, false);
          this.OnDialogTerminate();
        }
        else if (this.GetOption(FindReplaceEnum.FindNext))
        {
          this.SetOption(FindReplaceEnum.FindNext, false);
          this.OnFindNextClick();
        }
        else if (this.GetOption(FindReplaceEnum.Replace))
        {
          this.SetOption(FindReplaceEnum.Replace, false);
          this.OnReplaceClick();
        }
        else
        {
          if (!this.GetOption(FindReplaceEnum.ReplaceAll))
            return;
          this.SetOption(FindReplaceEnum.ReplaceAll, false);
          this.OnReplaceAllClick();
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw ex;
      }
    }

    [OptionText]
    public enum FindReplaceOperation
    {
      FindOnly = 1,
      Replace = 2,
      ReplaceAll = 3,
    }
  }
}
