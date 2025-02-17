// Decompiled with JetBrains decompiler
// Type: bbEditor.CustomCodesDialog
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using bbEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace bbEditor
{
  public class CustomCodesDialog : Form
  {
    private Stack<string> undoStack = new Stack<string>();
    private Stack<string> redoStack = new Stack<string>();
    private string _resultText;
    private IContainer components;
    private Label Action1ShCutKey;
    private Label Action2ShCutKey;
    private Label Action3ShCutKey;
    private Label Action4ShCutKey;
    private Label Action5ShCutKey;
    private Button Reset1Button;
    private Button Reset2Button;
    private Button Reset3Button;
    private Button Reset4Button;
    private Button Reset5Button;
    private Button SaveCustomCodesButton;
    private Button ExitCustomCodesDialogButton;
    private Label ShortcutKeysLabel;
    private Label YourCustomCodeLabel;
    public TextBox Action1TextBox;
    public TextBox Action2TextBox;
    public TextBox Action3TextBox;
    public TextBox Action4TextBox;
    public TextBox Action5TextBox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    public Button Action1Button;
    public Button Action2Button;
    public Button Action3Button;
    public Button Action4Button;
    public Button Action5Button;
    private ContextMenuStrip Action1contextMenu;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ContextMenuStrip Action5contextMenu;
    private ToolStripMenuItem toolStripMenuItem13;
    private ToolStripMenuItem toolStripMenuItem14;
    private ToolStripMenuItem toolStripMenuItem15;
    private ToolStripMenuItem toolStripMenuItem16;
    private ContextMenuStrip Action4contextMenu;
    private ToolStripMenuItem toolStripMenuItem9;
    private ToolStripMenuItem toolStripMenuItem10;
    private ToolStripMenuItem toolStripMenuItem11;
    private ToolStripMenuItem toolStripMenuItem12;
    private ContextMenuStrip Action3contextMenu;
    private ToolStripMenuItem toolStripMenuItem5;
    private ToolStripMenuItem toolStripMenuItem6;
    private ToolStripMenuItem toolStripMenuItem7;
    private ToolStripMenuItem toolStripMenuItem8;
    private ContextMenuStrip Action2contextMenu;
    private ToolStripMenuItem toolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem toolStripMenuItem4;

    public CustomCodesDialog() => this.InitializeComponent();

    public string ResultText
    {
      get => this._resultText;
      private set => this._resultText = value;
    }

    private string ctext1
    {
      get => this.Action1TextBox.Text;
      set => this.Action1TextBox.Text = value;
    }

    private string ctext2
    {
      get => this.Action2TextBox.Text;
      set => this.Action2TextBox.Text = value;
    }

    private string ctext3
    {
      get => this.Action3TextBox.Text;
      set => this.Action3TextBox.Text = value;
    }

    private string ctext4
    {
      get => this.Action4TextBox.Text;
      set => this.Action4TextBox.Text = value;
    }

    private string ctext5
    {
      get => this.Action5TextBox.Text;
      set => this.Action5TextBox.Text = value;
    }

    private int cpos1
    {
      get => this.Action1TextBox.SelectionStart;
      set => this.Action1TextBox.SelectionStart = value;
    }

    private int cpos2
    {
      get => this.Action2TextBox.SelectionStart;
      set => this.Action2TextBox.SelectionStart = value;
    }

    private int cpos3
    {
      get => this.Action3TextBox.SelectionStart;
      set => this.Action3TextBox.SelectionStart = value;
    }

    private int cpos4
    {
      get => this.Action4TextBox.SelectionStart;
      set => this.Action4TextBox.SelectionStart = value;
    }

    private int cpos5
    {
      get => this.Action5TextBox.SelectionStart;
      set => this.Action5TextBox.SelectionStart = value;
    }

    private void SaveCustomCodesButton_Click(object sender, EventArgs e)
    {
      if (!this.Action1TextBox.ReadOnly)
      {
        if (this.Action1TextBox.TextLength > 0)
        {
          CustomCodes.Default.Action1Code = this.ctext1;
          CustomCodes.Default.Action1Caret = this.cpos1;
          CustomCodes.Default.Action1Textbox = true;
          CustomCodes.Default.Action1TextBoxColor = Color.IndianRed;
          CustomCodes.Default.Save();
          this.Action1TextBox.ReadOnly = true;
          this.Action1TextBox.BackColor = Color.IndianRed;
        }
        else
        {
          CustomCodes.Default.Action1Code = "";
          CustomCodes.Default.Action1Caret = 0;
          CustomCodes.Default.Action1Textbox = false;
          CustomCodes.Default.Action1TextBoxColor = Color.Empty;
          CustomCodes.Default.Save();
        }
      }
      if (!this.Action2TextBox.ReadOnly)
      {
        if (this.Action2TextBox.TextLength > 0)
        {
          CustomCodes.Default.Action2Code = this.ctext2;
          CustomCodes.Default.Action2Caret = this.cpos2;
          CustomCodes.Default.Action2Textbox = true;
          CustomCodes.Default.Action2TextBoxColor = Color.IndianRed;
          CustomCodes.Default.Save();
          this.Action2TextBox.ReadOnly = true;
          this.Action2TextBox.BackColor = Color.IndianRed;
        }
        else
        {
          CustomCodes.Default.Action2Code = "";
          CustomCodes.Default.Action2Caret = 0;
          CustomCodes.Default.Action2Textbox = false;
          CustomCodes.Default.Action2TextBoxColor = Color.Empty;
          CustomCodes.Default.Save();
        }
      }
      if (!this.Action3TextBox.ReadOnly)
      {
        if (this.Action3TextBox.TextLength > 0)
        {
          CustomCodes.Default.Action3Code = this.ctext3;
          CustomCodes.Default.Action3Caret = this.cpos3;
          CustomCodes.Default.Action3Textbox = true;
          CustomCodes.Default.Action3TextBoxColor = Color.IndianRed;
          CustomCodes.Default.Save();
          this.Action3TextBox.ReadOnly = true;
          this.Action3TextBox.BackColor = Color.IndianRed;
        }
        else
        {
          CustomCodes.Default.Action3Code = "";
          CustomCodes.Default.Action3Caret = 0;
          CustomCodes.Default.Action3Textbox = false;
          CustomCodes.Default.Action3TextBoxColor = Color.Empty;
          CustomCodes.Default.Save();
        }
      }
      if (!this.Action4TextBox.ReadOnly)
      {
        if (this.Action4TextBox.TextLength > 0)
        {
          CustomCodes.Default.Action4Code = this.ctext4;
          CustomCodes.Default.Action4Caret = this.cpos4;
          CustomCodes.Default.Action4Textbox = true;
          CustomCodes.Default.Action4TextBoxColor = Color.IndianRed;
          CustomCodes.Default.Save();
          this.Action4TextBox.ReadOnly = true;
          this.Action4TextBox.BackColor = Color.IndianRed;
        }
      }
      else
      {
        CustomCodes.Default.Action4Code = "";
        CustomCodes.Default.Action4Caret = 0;
        CustomCodes.Default.Action4Textbox = false;
        CustomCodes.Default.Action4TextBoxColor = Color.Empty;
        CustomCodes.Default.Save();
      }
      if (!this.Action5TextBox.ReadOnly)
      {
        if (this.Action5TextBox.TextLength > 0)
        {
          CustomCodes.Default.Action5Code = this.ctext5;
          CustomCodes.Default.Action5Caret = this.cpos5;
          CustomCodes.Default.Action5Textbox = true;
          CustomCodes.Default.Action5TextBoxColor = Color.IndianRed;
          CustomCodes.Default.Save();
          this.Action5TextBox.ReadOnly = true;
          this.Action5TextBox.BackColor = Color.IndianRed;
        }
        else
        {
          CustomCodes.Default.Action5Code = "";
          CustomCodes.Default.Action5Caret = 0;
          CustomCodes.Default.Action5Textbox = false;
          CustomCodes.Default.Action5TextBoxColor = Color.Empty;
          CustomCodes.Default.Save();
        }
      }
      Form.ActiveForm.Focus();
    }

    private void ExitCustomCodesDialogButton_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    private void Reset1Button_Click(object sender, EventArgs e)
    {
      if (!this.Action1TextBox.ReadOnly)
        return;
      this.Action1TextBox.ReadOnly = false;
      this.Action1TextBox.BackColor = Color.Empty;
      this.Action1TextBox.Focus();
    }

    private void Reset2Button_Click(object sender, EventArgs e)
    {
      if (!this.Action2TextBox.ReadOnly)
        return;
      this.Action2TextBox.ReadOnly = false;
      this.Action2TextBox.BackColor = Color.Empty;
      this.Action2TextBox.Focus();
    }

    private void Reset3Button_Click(object sender, EventArgs e)
    {
      if (!this.Action3TextBox.ReadOnly)
        return;
      this.Action3TextBox.ReadOnly = false;
      this.Action3TextBox.BackColor = Color.Empty;
      this.Action3TextBox.Focus();
    }

    private void Reset4Button_Click(object sender, EventArgs e)
    {
      if (!this.Action4TextBox.ReadOnly)
        return;
      this.Action4TextBox.ReadOnly = false;
      this.Action4TextBox.BackColor = Color.Empty;
      this.Action4TextBox.Focus();
    }

    private void Reset5Button_Click(object sender, EventArgs e)
    {
      if (!this.Action5TextBox.ReadOnly)
        return;
      this.Action5TextBox.ReadOnly = false;
      this.Action5TextBox.BackColor = Color.Empty;
      this.Action5TextBox.Focus();
    }

    private void Action1Button_Click(object sender, EventArgs e)
    {
      if (!this.Action1TextBox.ReadOnly)
      {
        if (this.ctext1.Length > 0)
        {
          string str1 = this.ctext1.Substring(0, this.cpos1);
          string str2 = this.ctext1.Substring(this.cpos1, this.ctext1.Length - str1.Length);
          if (box.Default.tboxLength > 0)
          {
            int num = box.Default.tboxStart + box.Default.tboxLength + this.ctext1.Length;
            this.ResultText = str1 + box.Default.tbox + str2;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
          else
          {
            int num = box.Default.tboxStart + str1.Length;
            this.ResultText = this.ctext1;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
        }
        else
        {
          MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
          int num = (int) MessageBox.Show("You have not defined a custom code for Action 1.", "ACTION 1 NOT POSSIBLE", MessageBoxButtons.OK);
        }
      }
      else
      {
        int action1Caret = CustomCodes.Default.Action1Caret;
        string str3 = CustomCodes.Default.Action1Code.ToString();
        string str4 = str3.Substring(0, action1Caret);
        string str5 = str3.Substring(action1Caret, str3.Length - action1Caret);
        if (box.Default.tboxLength > 0)
        {
          int num = box.Default.tboxStart + box.Default.tboxLength + str3.Length;
          this.ResultText = str4 + box.Default.tbox + str5;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
        else
        {
          int num = box.Default.tboxStart + str4.Length;
          this.ResultText = str3;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
      }
    }

    private void Action2Button_Click(object sender, EventArgs e)
    {
      if (!this.Action2TextBox.ReadOnly)
      {
        if (this.ctext2.Length > 0)
        {
          string str1 = this.ctext2.Substring(0, this.cpos2);
          string str2 = this.ctext2.Substring(this.cpos2, this.ctext2.Length - str1.Length);
          if (box.Default.tboxLength > 0)
          {
            int num = box.Default.tboxStart + box.Default.tboxLength + this.ctext2.Length;
            this.ResultText = str1 + box.Default.tbox + str2;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
          else
          {
            int num = box.Default.tboxStart + str1.Length;
            this.ResultText = this.ctext2;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
        }
        else
        {
          MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
          int num = (int) MessageBox.Show("You have not defined a custom code for Action 2.", "ACTION 2 NOT POSSIBLE", MessageBoxButtons.OK);
        }
      }
      else
      {
        int action2Caret = CustomCodes.Default.Action2Caret;
        string str3 = CustomCodes.Default.Action2Code.ToString();
        string str4 = str3.Substring(0, action2Caret);
        string str5 = str3.Substring(action2Caret, str3.Length - action2Caret);
        if (box.Default.tboxLength > 0)
        {
          int num = box.Default.tboxStart + box.Default.tboxLength + str3.Length;
          this.ResultText = str4 + box.Default.tbox + str5;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
        else
        {
          int num = box.Default.tboxStart + str4.Length;
          this.ResultText = str3;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
      }
    }

    private void Action3Button_Click(object sender, EventArgs e)
    {
      if (!this.Action3TextBox.ReadOnly)
      {
        if (this.ctext3.Length > 0)
        {
          string str1 = this.ctext3.Substring(0, this.cpos3);
          string str2 = this.ctext3.Substring(this.cpos3, this.ctext3.Length - str1.Length);
          if (box.Default.tboxLength > 0)
          {
            int num = box.Default.tboxStart + box.Default.tboxLength + this.ctext3.Length;
            this.ResultText = str1 + box.Default.tbox + str2;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
          else
          {
            int num = box.Default.tboxStart + str1.Length;
            this.ResultText = this.ctext3;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
        }
        else
        {
          MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
          int num = (int) MessageBox.Show("You have not defined a custom code for Action 3.", "ACTION 3 NOT POSSIBLE", MessageBoxButtons.OK);
        }
      }
      else
      {
        int action3Caret = CustomCodes.Default.Action3Caret;
        string str3 = CustomCodes.Default.Action3Code.ToString();
        string str4 = str3.Substring(0, action3Caret);
        string str5 = str3.Substring(action3Caret, str3.Length - action3Caret);
        if (box.Default.tboxLength > 0)
        {
          int num = box.Default.tboxStart + box.Default.tboxLength + str3.Length;
          this.ResultText = str4 + box.Default.tbox + str5;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
        else
        {
          int num = box.Default.tboxStart + str4.Length;
          this.ResultText = str3;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
      }
    }

    private void Action4Button_Click(object sender, EventArgs e)
    {
      if (!this.Action4TextBox.ReadOnly)
      {
        if (this.ctext4.Length > 0)
        {
          string str1 = this.ctext4.Substring(0, this.cpos4);
          string str2 = this.ctext4.Substring(this.cpos4, this.ctext4.Length - str1.Length);
          if (box.Default.tboxLength > 0)
          {
            int num = box.Default.tboxStart + box.Default.tboxLength + this.ctext4.Length;
            this.ResultText = str1 + box.Default.tbox + str2;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
          else
          {
            int num = box.Default.tboxStart + str1.Length;
            this.ResultText = this.ctext4;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
        }
        else
        {
          MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
          int num = (int) MessageBox.Show("You have not defined a custom code for Action 4.", "ACTION 4 NOT POSSIBLE", MessageBoxButtons.OK);
        }
      }
      else
      {
        int action4Caret = CustomCodes.Default.Action4Caret;
        string str3 = CustomCodes.Default.Action4Code.ToString();
        string str4 = str3.Substring(0, action4Caret);
        string str5 = str3.Substring(action4Caret, str3.Length - action4Caret);
        if (box.Default.tboxLength > 0)
        {
          int num = box.Default.tboxStart + box.Default.tboxLength + str3.Length;
          this.ResultText = str4 + box.Default.tbox + str5;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
        else
        {
          int num = box.Default.tboxStart + str4.Length;
          this.ResultText = str3;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
      }
    }

    private void Action5Button_Click(object sender, EventArgs e)
    {
      if (!this.Action5TextBox.ReadOnly)
      {
        if (this.ctext5.Length > 0)
        {
          string str1 = this.ctext5.Substring(0, this.cpos5);
          string str2 = this.ctext5.Substring(this.cpos5, this.ctext5.Length - str1.Length);
          if (box.Default.tboxLength > 0)
          {
            int num = box.Default.tboxStart + box.Default.tboxLength + this.ctext5.Length;
            this.ResultText = str1 + box.Default.tbox + str2;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
          else
          {
            int num = box.Default.tboxStart + str1.Length;
            this.ResultText = this.ctext5;
            box.Default.tboxStart = num;
            this.DialogResult = DialogResult.OK;
          }
        }
        else
        {
          MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
          int num = (int) MessageBox.Show("You have not defined a custom code for Action 5.", "ACTION 5 NOT POSSIBLE", MessageBoxButtons.OK);
        }
      }
      else
      {
        int action5Caret = CustomCodes.Default.Action5Caret;
        string str3 = CustomCodes.Default.Action5Code.ToString();
        string str4 = str3.Substring(0, action5Caret);
        string str5 = str3.Substring(action5Caret, str3.Length - action5Caret);
        if (box.Default.tboxLength > 0)
        {
          int num = box.Default.tboxStart + box.Default.tboxLength + str3.Length;
          this.ResultText = str4 + box.Default.tbox + str5;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
        else
        {
          int num = box.Default.tboxStart + str4.Length;
          this.ResultText = str3;
          box.Default.tboxStart = num;
          this.DialogResult = DialogResult.OK;
        }
      }
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.Action1TextBox.SelectionLength <= 0)
        return;
      this.Action1TextBox.Cut();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.Action1TextBox.SelectionLength <= 0)
        return;
      this.Action1TextBox.Copy();
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Action1TextBox.Paste();
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Action1TextBox.SelectAll();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      if (this.Action2TextBox.SelectionLength <= 0)
        return;
      this.Action2TextBox.Cut();
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      if (this.Action2TextBox.SelectionLength <= 0)
        return;
      this.Action2TextBox.Copy();
    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {
      this.Action2TextBox.Paste();
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e)
    {
      this.Action2TextBox.SelectAll();
    }

    private void toolStripMenuItem5_Click(object sender, EventArgs e)
    {
      if (this.Action3TextBox.SelectionLength <= 0)
        return;
      this.Action3TextBox.Cut();
    }

    private void toolStripMenuItem6_Click(object sender, EventArgs e)
    {
      if (this.Action3TextBox.SelectionLength <= 0)
        return;
      this.Action3TextBox.Copy();
    }

    private void toolStripMenuItem7_Click(object sender, EventArgs e)
    {
      this.Action3TextBox.Paste();
    }

    private void toolStripMenuItem8_Click(object sender, EventArgs e)
    {
      this.Action3TextBox.SelectAll();
    }

    private void toolStripMenuItem9_Click(object sender, EventArgs e)
    {
      if (this.Action4TextBox.SelectionLength <= 0)
        return;
      this.Action4TextBox.Cut();
    }

    private void toolStripMenuItem10_Click(object sender, EventArgs e)
    {
      if (this.Action4TextBox.SelectionLength <= 0)
        return;
      this.Action4TextBox.Copy();
    }

    private void toolStripMenuItem11_Click(object sender, EventArgs e)
    {
      this.Action4TextBox.Paste();
    }

    private void toolStripMenuItem12_Click(object sender, EventArgs e)
    {
      this.Action4TextBox.SelectAll();
    }

    private void toolStripMenuItem13_Click(object sender, EventArgs e)
    {
      if (this.Action5TextBox.SelectionLength <= 0)
        return;
      this.Action5TextBox.Cut();
    }

    private void toolStripMenuItem14_Click(object sender, EventArgs e)
    {
      if (this.Action5TextBox.SelectionLength <= 0)
        return;
      this.Action5TextBox.Copy();
    }

    private void toolStripMenuItem15_Click(object sender, EventArgs e)
    {
      this.Action5TextBox.Paste();
    }

    private void toolStripMenuItem16_Click(object sender, EventArgs e)
    {
      this.Action5TextBox.SelectAll();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (CustomCodesDialog));
      this.Action1Button = new Button();
      this.Action2Button = new Button();
      this.Action3Button = new Button();
      this.Action4Button = new Button();
      this.Action5Button = new Button();
      this.Action1ShCutKey = new Label();
      this.Action2ShCutKey = new Label();
      this.Action3ShCutKey = new Label();
      this.Action4ShCutKey = new Label();
      this.Action5ShCutKey = new Label();
      this.Reset1Button = new Button();
      this.Reset2Button = new Button();
      this.Reset3Button = new Button();
      this.Reset4Button = new Button();
      this.Reset5Button = new Button();
      this.SaveCustomCodesButton = new Button();
      this.ExitCustomCodesDialogButton = new Button();
      this.ShortcutKeysLabel = new Label();
      this.YourCustomCodeLabel = new Label();
      this.Action5contextMenu = new ContextMenuStrip(this.components);
      this.toolStripMenuItem13 = new ToolStripMenuItem();
      this.toolStripMenuItem14 = new ToolStripMenuItem();
      this.toolStripMenuItem15 = new ToolStripMenuItem();
      this.toolStripMenuItem16 = new ToolStripMenuItem();
      this.Action1contextMenu = new ContextMenuStrip(this.components);
      this.cutToolStripMenuItem = new ToolStripMenuItem();
      this.copyToolStripMenuItem = new ToolStripMenuItem();
      this.pasteToolStripMenuItem = new ToolStripMenuItem();
      this.selectAllToolStripMenuItem = new ToolStripMenuItem();
      this.Action4contextMenu = new ContextMenuStrip(this.components);
      this.toolStripMenuItem9 = new ToolStripMenuItem();
      this.toolStripMenuItem10 = new ToolStripMenuItem();
      this.toolStripMenuItem11 = new ToolStripMenuItem();
      this.toolStripMenuItem12 = new ToolStripMenuItem();
      this.Action3contextMenu = new ContextMenuStrip(this.components);
      this.toolStripMenuItem5 = new ToolStripMenuItem();
      this.toolStripMenuItem6 = new ToolStripMenuItem();
      this.toolStripMenuItem7 = new ToolStripMenuItem();
      this.toolStripMenuItem8 = new ToolStripMenuItem();
      this.Action2contextMenu = new ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new ToolStripMenuItem();
      this.toolStripMenuItem2 = new ToolStripMenuItem();
      this.toolStripMenuItem3 = new ToolStripMenuItem();
      this.toolStripMenuItem4 = new ToolStripMenuItem();
      this.label1 = new Label();
      this.label2 = new Label();
      this.label3 = new Label();
      this.label4 = new Label();
      this.Action5TextBox = new TextBox();
      this.Action4TextBox = new TextBox();
      this.Action3TextBox = new TextBox();
      this.Action2TextBox = new TextBox();
      this.Action1TextBox = new TextBox();
      this.Action5contextMenu.SuspendLayout();
      this.Action1contextMenu.SuspendLayout();
      this.Action4contextMenu.SuspendLayout();
      this.Action3contextMenu.SuspendLayout();
      this.Action2contextMenu.SuspendLayout();
      this.SuspendLayout();
      this.Action1Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action1Button.Location = new Point(11, 52);
      this.Action1Button.Name = "Action1Button";
      this.Action1Button.Size = new Size(67, 20);
      this.Action1Button.TabIndex = 8;
      this.Action1Button.TabStop = false;
      this.Action1Button.Text = "Action 1";
      this.Action1Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Action1Button.UseVisualStyleBackColor = true;
      this.Action1Button.Click += new EventHandler(this.Action1Button_Click);
      this.Action2Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action2Button.Location = new Point(11, 81);
      this.Action2Button.Name = "Action2Button";
      this.Action2Button.Size = new Size(67, 20);
      this.Action2Button.TabIndex = 9;
      this.Action2Button.TabStop = false;
      this.Action2Button.Text = "Action 2";
      this.Action2Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Action2Button.UseVisualStyleBackColor = true;
      this.Action2Button.Click += new EventHandler(this.Action2Button_Click);
      this.Action3Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action3Button.Location = new Point(11, 110);
      this.Action3Button.Name = "Action3Button";
      this.Action3Button.Size = new Size(67, 20);
      this.Action3Button.TabIndex = 10;
      this.Action3Button.TabStop = false;
      this.Action3Button.Text = "Action 3";
      this.Action3Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Action3Button.UseVisualStyleBackColor = true;
      this.Action3Button.Click += new EventHandler(this.Action3Button_Click);
      this.Action4Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action4Button.Location = new Point(11, 139);
      this.Action4Button.Name = "Action4Button";
      this.Action4Button.Size = new Size(67, 20);
      this.Action4Button.TabIndex = 11;
      this.Action4Button.TabStop = false;
      this.Action4Button.Text = "Action 4";
      this.Action4Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Action4Button.UseVisualStyleBackColor = true;
      this.Action4Button.Click += new EventHandler(this.Action4Button_Click);
      this.Action5Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action5Button.Location = new Point(11, 169);
      this.Action5Button.Name = "Action5Button";
      this.Action5Button.Size = new Size(67, 20);
      this.Action5Button.TabIndex = 12;
      this.Action5Button.TabStop = false;
      this.Action5Button.Text = "Action 5";
      this.Action5Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Action5Button.UseVisualStyleBackColor = true;
      this.Action5Button.Click += new EventHandler(this.Action5Button_Click);
      this.Action1ShCutKey.AutoSize = true;
      this.Action1ShCutKey.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Action1ShCutKey.Location = new Point(85, 55);
      this.Action1ShCutKey.Name = "Action1ShCutKey";
      this.Action1ShCutKey.Size = new Size(44, 13);
      this.Action1ShCutKey.TabIndex = 13;
      this.Action1ShCutKey.Text = "Ctrl + 1";
      this.Action2ShCutKey.AutoSize = true;
      this.Action2ShCutKey.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Action2ShCutKey.Location = new Point(85, 86);
      this.Action2ShCutKey.Name = "Action2ShCutKey";
      this.Action2ShCutKey.Size = new Size(44, 13);
      this.Action2ShCutKey.TabIndex = 14;
      this.Action2ShCutKey.Text = "Ctrl + 2";
      this.Action3ShCutKey.AutoSize = true;
      this.Action3ShCutKey.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Action3ShCutKey.Location = new Point(85, 115);
      this.Action3ShCutKey.Name = "Action3ShCutKey";
      this.Action3ShCutKey.Size = new Size(44, 13);
      this.Action3ShCutKey.TabIndex = 15;
      this.Action3ShCutKey.Text = "Ctrl + 3";
      this.Action4ShCutKey.AutoSize = true;
      this.Action4ShCutKey.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Action4ShCutKey.Location = new Point(85, 144);
      this.Action4ShCutKey.Name = "Action4ShCutKey";
      this.Action4ShCutKey.Size = new Size(44, 13);
      this.Action4ShCutKey.TabIndex = 16;
      this.Action4ShCutKey.Text = "Ctrl + 4";
      this.Action5ShCutKey.AutoSize = true;
      this.Action5ShCutKey.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Action5ShCutKey.Location = new Point(85, 173);
      this.Action5ShCutKey.Name = "Action5ShCutKey";
      this.Action5ShCutKey.Size = new Size(44, 13);
      this.Action5ShCutKey.TabIndex = 17;
      this.Action5ShCutKey.Text = "Ctrl + 5";
      this.Reset1Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Reset1Button.Location = new Point(578, 54);
      this.Reset1Button.Name = "Reset1Button";
      this.Reset1Button.Size = new Size(67, 20);
      this.Reset1Button.TabIndex = 20;
      this.Reset1Button.TabStop = false;
      this.Reset1Button.Text = "Reset";
      this.Reset1Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Reset1Button.UseVisualStyleBackColor = true;
      this.Reset1Button.Click += new EventHandler(this.Reset1Button_Click);
      this.Reset2Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Reset2Button.Location = new Point(578, 82);
      this.Reset2Button.Name = "Reset2Button";
      this.Reset2Button.Size = new Size(67, 20);
      this.Reset2Button.TabIndex = 21;
      this.Reset2Button.TabStop = false;
      this.Reset2Button.Text = "Reset";
      this.Reset2Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Reset2Button.UseVisualStyleBackColor = true;
      this.Reset2Button.Click += new EventHandler(this.Reset2Button_Click);
      this.Reset3Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Reset3Button.Location = new Point(578, 111);
      this.Reset3Button.Name = "Reset3Button";
      this.Reset3Button.Size = new Size(67, 20);
      this.Reset3Button.TabIndex = 22;
      this.Reset3Button.TabStop = false;
      this.Reset3Button.Text = "Reset";
      this.Reset3Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Reset3Button.UseVisualStyleBackColor = true;
      this.Reset3Button.Click += new EventHandler(this.Reset3Button_Click);
      this.Reset4Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Reset4Button.Location = new Point(578, 139);
      this.Reset4Button.Name = "Reset4Button";
      this.Reset4Button.Size = new Size(67, 20);
      this.Reset4Button.TabIndex = 23;
      this.Reset4Button.TabStop = false;
      this.Reset4Button.Text = "Reset";
      this.Reset4Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Reset4Button.UseVisualStyleBackColor = true;
      this.Reset4Button.Click += new EventHandler(this.Reset4Button_Click);
      this.Reset5Button.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Reset5Button.Location = new Point(578, 169);
      this.Reset5Button.Name = "Reset5Button";
      this.Reset5Button.Size = new Size(67, 20);
      this.Reset5Button.TabIndex = 24;
      this.Reset5Button.TabStop = false;
      this.Reset5Button.Text = "Reset";
      this.Reset5Button.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.Reset5Button.UseVisualStyleBackColor = true;
      this.Reset5Button.Click += new EventHandler(this.Reset5Button_Click);
      this.SaveCustomCodesButton.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SaveCustomCodesButton.Location = new Point(219, 202);
      this.SaveCustomCodesButton.Name = "SaveCustomCodesButton";
      this.SaveCustomCodesButton.Size = new Size(67, 20);
      this.SaveCustomCodesButton.TabIndex = 1;
      this.SaveCustomCodesButton.Text = "Save";
      this.SaveCustomCodesButton.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.SaveCustomCodesButton.UseVisualStyleBackColor = true;
      this.SaveCustomCodesButton.Click += new EventHandler(this.SaveCustomCodesButton_Click);
      this.ExitCustomCodesDialogButton.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ExitCustomCodesDialogButton.Location = new Point(392, 202);
      this.ExitCustomCodesDialogButton.Name = "ExitCustomCodesDialogButton";
      this.ExitCustomCodesDialogButton.Size = new Size(67, 20);
      this.ExitCustomCodesDialogButton.TabIndex = 2;
      this.ExitCustomCodesDialogButton.Text = "Exit";
      this.ExitCustomCodesDialogButton.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.ExitCustomCodesDialogButton.UseVisualStyleBackColor = true;
      this.ExitCustomCodesDialogButton.Click += new EventHandler(this.ExitCustomCodesDialogButton_Click);
      this.ShortcutKeysLabel.AutoSize = true;
      this.ShortcutKeysLabel.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ShortcutKeysLabel.Location = new Point(79, 202);
      this.ShortcutKeysLabel.Name = "ShortcutKeysLabel";
      this.ShortcutKeysLabel.Size = new Size(53, 13);
      this.ShortcutKeysLabel.TabIndex = 18;
      this.ShortcutKeysLabel.Text = " HotKeys";
      this.YourCustomCodeLabel.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.YourCustomCodeLabel.Location = new Point(11, 0);
      this.YourCustomCodeLabel.Name = "YourCustomCodeLabel";
      this.YourCustomCodeLabel.Size = new Size(633, 49);
      this.YourCustomCodeLabel.TabIndex = 19;
      this.YourCustomCodeLabel.Tag = (object) "    ";
      this.YourCustomCodeLabel.Text = componentResourceManager.GetString("YourCustomCodeLabel.Text");
      this.Action5contextMenu.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem13,
        (ToolStripItem) this.toolStripMenuItem14,
        (ToolStripItem) this.toolStripMenuItem15,
        (ToolStripItem) this.toolStripMenuItem16
      });
      this.Action5contextMenu.Name = "contextMenuStrip1";
      this.Action5contextMenu.Size = new Size(165, 92);
      this.toolStripMenuItem13.Name = "toolStripMenuItem13";
      this.toolStripMenuItem13.ShortcutKeys = Keys.X | Keys.Control;
      this.toolStripMenuItem13.Size = new Size(164, 22);
      this.toolStripMenuItem13.Text = "Cut";
      this.toolStripMenuItem13.Click += new EventHandler(this.toolStripMenuItem13_Click);
      this.toolStripMenuItem14.Name = "toolStripMenuItem14";
      this.toolStripMenuItem14.ShortcutKeys = Keys.C | Keys.Control;
      this.toolStripMenuItem14.Size = new Size(164, 22);
      this.toolStripMenuItem14.Text = "Copy";
      this.toolStripMenuItem14.Click += new EventHandler(this.toolStripMenuItem14_Click);
      this.toolStripMenuItem15.Name = "toolStripMenuItem15";
      this.toolStripMenuItem15.ShortcutKeys = Keys.V | Keys.Control;
      this.toolStripMenuItem15.Size = new Size(164, 22);
      this.toolStripMenuItem15.Text = "Paste";
      this.toolStripMenuItem15.Click += new EventHandler(this.toolStripMenuItem15_Click);
      this.toolStripMenuItem16.Name = "toolStripMenuItem16";
      this.toolStripMenuItem16.ShortcutKeys = Keys.A | Keys.Control;
      this.toolStripMenuItem16.Size = new Size(164, 22);
      this.toolStripMenuItem16.Text = "Select All";
      this.toolStripMenuItem16.Click += new EventHandler(this.toolStripMenuItem16_Click);
      this.Action1contextMenu.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.cutToolStripMenuItem,
        (ToolStripItem) this.copyToolStripMenuItem,
        (ToolStripItem) this.pasteToolStripMenuItem,
        (ToolStripItem) this.selectAllToolStripMenuItem
      });
      this.Action1contextMenu.Name = "contextMenuStrip1";
      this.Action1contextMenu.Size = new Size(165, 92);
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = Keys.X | Keys.Control;
      this.cutToolStripMenuItem.Size = new Size(164, 22);
      this.cutToolStripMenuItem.Text = "Cut";
      this.cutToolStripMenuItem.Click += new EventHandler(this.cutToolStripMenuItem_Click);
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = Keys.C | Keys.Control;
      this.copyToolStripMenuItem.Size = new Size(164, 22);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.Click += new EventHandler(this.copyToolStripMenuItem_Click);
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = Keys.V | Keys.Control;
      this.pasteToolStripMenuItem.Size = new Size(164, 22);
      this.pasteToolStripMenuItem.Text = "Paste";
      this.pasteToolStripMenuItem.Click += new EventHandler(this.pasteToolStripMenuItem_Click);
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.ShortcutKeys = Keys.A | Keys.Control;
      this.selectAllToolStripMenuItem.Size = new Size(164, 22);
      this.selectAllToolStripMenuItem.Text = "Select All";
      this.selectAllToolStripMenuItem.Click += new EventHandler(this.selectAllToolStripMenuItem_Click);
      this.Action4contextMenu.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem9,
        (ToolStripItem) this.toolStripMenuItem10,
        (ToolStripItem) this.toolStripMenuItem11,
        (ToolStripItem) this.toolStripMenuItem12
      });
      this.Action4contextMenu.Name = "contextMenuStrip1";
      this.Action4contextMenu.Size = new Size(165, 92);
      this.toolStripMenuItem9.Name = "toolStripMenuItem9";
      this.toolStripMenuItem9.ShortcutKeys = Keys.X | Keys.Control;
      this.toolStripMenuItem9.Size = new Size(164, 22);
      this.toolStripMenuItem9.Text = "Cut";
      this.toolStripMenuItem9.Click += new EventHandler(this.toolStripMenuItem9_Click);
      this.toolStripMenuItem10.Name = "toolStripMenuItem10";
      this.toolStripMenuItem10.ShortcutKeys = Keys.C | Keys.Control;
      this.toolStripMenuItem10.Size = new Size(164, 22);
      this.toolStripMenuItem10.Text = "Copy";
      this.toolStripMenuItem10.Click += new EventHandler(this.toolStripMenuItem10_Click);
      this.toolStripMenuItem11.Name = "toolStripMenuItem11";
      this.toolStripMenuItem11.ShortcutKeys = Keys.V | Keys.Control;
      this.toolStripMenuItem11.Size = new Size(164, 22);
      this.toolStripMenuItem11.Text = "Paste";
      this.toolStripMenuItem11.Click += new EventHandler(this.toolStripMenuItem11_Click);
      this.toolStripMenuItem12.Name = "toolStripMenuItem12";
      this.toolStripMenuItem12.ShortcutKeys = Keys.A | Keys.Control;
      this.toolStripMenuItem12.Size = new Size(164, 22);
      this.toolStripMenuItem12.Text = "Select All";
      this.toolStripMenuItem12.Click += new EventHandler(this.toolStripMenuItem12_Click);
      this.Action3contextMenu.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem5,
        (ToolStripItem) this.toolStripMenuItem6,
        (ToolStripItem) this.toolStripMenuItem7,
        (ToolStripItem) this.toolStripMenuItem8
      });
      this.Action3contextMenu.Name = "contextMenuStrip1";
      this.Action3contextMenu.Size = new Size(165, 92);
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.ShortcutKeys = Keys.X | Keys.Control;
      this.toolStripMenuItem5.Size = new Size(164, 22);
      this.toolStripMenuItem5.Text = "Cut";
      this.toolStripMenuItem5.Click += new EventHandler(this.toolStripMenuItem5_Click);
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.ShortcutKeys = Keys.C | Keys.Control;
      this.toolStripMenuItem6.Size = new Size(164, 22);
      this.toolStripMenuItem6.Text = "Copy";
      this.toolStripMenuItem6.Click += new EventHandler(this.toolStripMenuItem6_Click);
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.ShortcutKeys = Keys.V | Keys.Control;
      this.toolStripMenuItem7.Size = new Size(164, 22);
      this.toolStripMenuItem7.Text = "Paste";
      this.toolStripMenuItem7.Click += new EventHandler(this.toolStripMenuItem7_Click);
      this.toolStripMenuItem8.Name = "toolStripMenuItem8";
      this.toolStripMenuItem8.ShortcutKeys = Keys.A | Keys.Control;
      this.toolStripMenuItem8.Size = new Size(164, 22);
      this.toolStripMenuItem8.Text = "Select All";
      this.toolStripMenuItem8.Click += new EventHandler(this.toolStripMenuItem8_Click);
      this.Action2contextMenu.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.toolStripMenuItem1,
        (ToolStripItem) this.toolStripMenuItem2,
        (ToolStripItem) this.toolStripMenuItem3,
        (ToolStripItem) this.toolStripMenuItem4
      });
      this.Action2contextMenu.Name = "contextMenuStrip1";
      this.Action2contextMenu.Size = new Size(165, 92);
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.ShortcutKeys = Keys.X | Keys.Control;
      this.toolStripMenuItem1.Size = new Size(164, 22);
      this.toolStripMenuItem1.Text = "Cut";
      this.toolStripMenuItem1.Click += new EventHandler(this.toolStripMenuItem1_Click);
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.ShortcutKeys = Keys.C | Keys.Control;
      this.toolStripMenuItem2.Size = new Size(164, 22);
      this.toolStripMenuItem2.Text = "Copy";
      this.toolStripMenuItem2.Click += new EventHandler(this.toolStripMenuItem2_Click);
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.ShortcutKeys = Keys.V | Keys.Control;
      this.toolStripMenuItem3.Size = new Size(164, 22);
      this.toolStripMenuItem3.Text = "Paste";
      this.toolStripMenuItem3.Click += new EventHandler(this.toolStripMenuItem3_Click);
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.ShortcutKeys = Keys.A | Keys.Control;
      this.toolStripMenuItem4.Size = new Size(164, 22);
      this.toolStripMenuItem4.Text = "Select All";
      this.toolStripMenuItem4.Click += new EventHandler(this.toolStripMenuItem4_Click);
      this.label1.BackColor = Color.IndianRed;
      this.label1.Enabled = false;
      this.label1.Location = new Point(504, 201);
      this.label1.Name = "label1";
      this.label1.Size = new Size(25, 5);
      this.label1.TabIndex = 25;
      this.label2.BackColor = SystemColors.Window;
      this.label2.Location = new Point(504, 212);
      this.label2.Name = "label2";
      this.label2.Size = new Size(25, 5);
      this.label2.TabIndex = 26;
      this.label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(535, 194);
      this.label3.Name = "label3";
      this.label3.Size = new Size(109, 16);
      this.label3.TabIndex = 27;
      this.label3.Text = "saved (Read Only)";
      this.label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(535, 206);
      this.label4.Name = "label4";
      this.label4.Size = new Size(59, 13);
      this.label4.TabIndex = 28;
      this.label4.Text = "not saved";
      this.Action5TextBox.AcceptsReturn = true;
      this.Action5TextBox.BackColor = CustomCodes.Default.Action5TextBoxColor;
      this.Action5TextBox.ContextMenuStrip = this.Action5contextMenu;
      this.Action5TextBox.DataBindings.Add(new Binding("Text", (object) CustomCodes.Default, "Action5Code", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action5TextBox.DataBindings.Add(new Binding("ReadOnly", (object) CustomCodes.Default, "Action5Textbox", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action5TextBox.DataBindings.Add(new Binding("BackColor", (object) CustomCodes.Default, "Action5TextBoxColor", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action5TextBox.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action5TextBox.Location = new Point(135, 169);
      this.Action5TextBox.MaxLength = 100000;
      this.Action5TextBox.Multiline = true;
      this.Action5TextBox.Name = "Action5TextBox";
      this.Action5TextBox.ReadOnly = CustomCodes.Default.Action5Textbox;
      this.Action5TextBox.ScrollBars = ScrollBars.Vertical;
      this.Action5TextBox.Size = new Size(437, 20);
      this.Action5TextBox.TabIndex = 7;
      this.Action5TextBox.Text = CustomCodes.Default.Action5Code;
      this.Action4TextBox.AcceptsReturn = true;
      this.Action4TextBox.BackColor = CustomCodes.Default.Action4TextBoxColor;
      this.Action4TextBox.ContextMenuStrip = this.Action4contextMenu;
      this.Action4TextBox.DataBindings.Add(new Binding("Text", (object) CustomCodes.Default, "Action4Code", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action4TextBox.DataBindings.Add(new Binding("ReadOnly", (object) CustomCodes.Default, "Action4Textbox", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action4TextBox.DataBindings.Add(new Binding("BackColor", (object) CustomCodes.Default, "Action4TextBoxColor", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action4TextBox.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action4TextBox.Location = new Point(135, 138);
      this.Action4TextBox.MaxLength = 100000;
      this.Action4TextBox.Multiline = true;
      this.Action4TextBox.Name = "Action4TextBox";
      this.Action4TextBox.ReadOnly = CustomCodes.Default.Action4Textbox;
      this.Action4TextBox.ScrollBars = ScrollBars.Vertical;
      this.Action4TextBox.Size = new Size(437, 20);
      this.Action4TextBox.TabIndex = 6;
      this.Action4TextBox.Text = CustomCodes.Default.Action4Code;
      this.Action3TextBox.AcceptsReturn = true;
      this.Action3TextBox.BackColor = CustomCodes.Default.Action3TextBoxColor;
      this.Action3TextBox.ContextMenuStrip = this.Action3contextMenu;
      this.Action3TextBox.DataBindings.Add(new Binding("Text", (object) CustomCodes.Default, "Action3Code", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action3TextBox.DataBindings.Add(new Binding("ReadOnly", (object) CustomCodes.Default, "Action3Textbox", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action3TextBox.DataBindings.Add(new Binding("BackColor", (object) CustomCodes.Default, "Action3TextBoxColor", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action3TextBox.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action3TextBox.Location = new Point(135, 110);
      this.Action3TextBox.MaxLength = 100000;
      this.Action3TextBox.Multiline = true;
      this.Action3TextBox.Name = "Action3TextBox";
      this.Action3TextBox.ReadOnly = CustomCodes.Default.Action3Textbox;
      this.Action3TextBox.ScrollBars = ScrollBars.Vertical;
      this.Action3TextBox.Size = new Size(437, 20);
      this.Action3TextBox.TabIndex = 5;
      this.Action3TextBox.Text = CustomCodes.Default.Action3Code;
      this.Action2TextBox.AcceptsReturn = true;
      this.Action2TextBox.BackColor = CustomCodes.Default.Action2TextBoxColor;
      this.Action2TextBox.ContextMenuStrip = this.Action2contextMenu;
      this.Action2TextBox.DataBindings.Add(new Binding("Text", (object) CustomCodes.Default, "Action2Code", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action2TextBox.DataBindings.Add(new Binding("ReadOnly", (object) CustomCodes.Default, "Action2Textbox", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action2TextBox.DataBindings.Add(new Binding("BackColor", (object) CustomCodes.Default, "Action2TextBoxColor", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action2TextBox.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action2TextBox.Location = new Point(135, 80);
      this.Action2TextBox.MaxLength = 100000;
      this.Action2TextBox.Multiline = true;
      this.Action2TextBox.Name = "Action2TextBox";
      this.Action2TextBox.ReadOnly = CustomCodes.Default.Action2Textbox;
      this.Action2TextBox.ScrollBars = ScrollBars.Vertical;
      this.Action2TextBox.Size = new Size(437, 20);
      this.Action2TextBox.TabIndex = 4;
      this.Action2TextBox.Text = CustomCodes.Default.Action2Code;
      this.Action1TextBox.AcceptsReturn = true;
      this.Action1TextBox.BackColor = CustomCodes.Default.Action1TextBoxColor;
      this.Action1TextBox.ContextMenuStrip = this.Action1contextMenu;
      this.Action1TextBox.DataBindings.Add(new Binding("Text", (object) CustomCodes.Default, "Action1Code", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action1TextBox.DataBindings.Add(new Binding("ReadOnly", (object) CustomCodes.Default, "Action1Textbox", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action1TextBox.DataBindings.Add(new Binding("BackColor", (object) CustomCodes.Default, "Action1TextBoxColor", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Action1TextBox.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Action1TextBox.Location = new Point(135, 52);
      this.Action1TextBox.MaxLength = 100000;
      this.Action1TextBox.Multiline = true;
      this.Action1TextBox.Name = "Action1TextBox";
      this.Action1TextBox.ReadOnly = CustomCodes.Default.Action1Textbox;
      this.Action1TextBox.ScrollBars = ScrollBars.Vertical;
      this.Action1TextBox.Size = new Size(437, 20);
      this.Action1TextBox.TabIndex = 3;
      this.Action1TextBox.Text = CustomCodes.Default.Action1Code;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Wheat;
      this.ClientSize = new Size(657, 226);
      this.ControlBox = false;
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.YourCustomCodeLabel);
      this.Controls.Add((Control) this.ShortcutKeysLabel);
      this.Controls.Add((Control) this.ExitCustomCodesDialogButton);
      this.Controls.Add((Control) this.SaveCustomCodesButton);
      this.Controls.Add((Control) this.Reset5Button);
      this.Controls.Add((Control) this.Reset4Button);
      this.Controls.Add((Control) this.Reset3Button);
      this.Controls.Add((Control) this.Reset2Button);
      this.Controls.Add((Control) this.Reset1Button);
      this.Controls.Add((Control) this.Action5TextBox);
      this.Controls.Add((Control) this.Action4TextBox);
      this.Controls.Add((Control) this.Action3TextBox);
      this.Controls.Add((Control) this.Action2TextBox);
      this.Controls.Add((Control) this.Action1TextBox);
      this.Controls.Add((Control) this.Action5ShCutKey);
      this.Controls.Add((Control) this.Action4ShCutKey);
      this.Controls.Add((Control) this.Action3ShCutKey);
      this.Controls.Add((Control) this.Action2ShCutKey);
      this.Controls.Add((Control) this.Action1ShCutKey);
      this.Controls.Add((Control) this.Action5Button);
      this.Controls.Add((Control) this.Action4Button);
      this.Controls.Add((Control) this.Action3Button);
      this.Controls.Add((Control) this.Action2Button);
      this.Controls.Add((Control) this.Action1Button);
      this.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (CustomCodesDialog);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Custom Codes";
      this.Action5contextMenu.ResumeLayout(false);
      this.Action1contextMenu.ResumeLayout(false);
      this.Action4contextMenu.ResumeLayout(false);
      this.Action3contextMenu.ResumeLayout(false);
      this.Action2contextMenu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
