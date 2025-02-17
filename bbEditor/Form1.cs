// Decompiled with JetBrains decompiler
// Type: bbEditor.Form1
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using bbEditor.Properties;
using FindReplace;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace bbEditor
{
  public class Form1 : Form
  {
    private IContainer components;
    private ToolStripButton BoldButton;
    private ToolStripButton ItalicButton;
    private ToolStripButton UnderlineButton;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripButton OrderedListButton;
    private ToolStripButton UnorderedListButton;
    private ToolStripButton ListElementButton;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripButton HyperlinkButton;
    private ToolStripButton ImageButton;
    private ToolStripButton EmailButton;
    private ToolStripButton QuoteButton;
    private ToolStripButton CodeButton;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripButton AlignRightButton;
    private ToolStripButton AlignCenterButton;
    private ToolStripButton AlignLeftButton;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripButton FontColorButton;
    private ToolStripSeparator toolStripSeparator9;
    private ToolStripDropDownButton SizeButton;
    private ToolStripMenuItem Size1toolStripMenuItem;
    private ToolStripMenuItem Size2toolStripMenuItem;
    private ToolStripMenuItem Size3toolStripMenuItem;
    private ToolStripMenuItem Size4toolStripMenuItem;
    private ToolStripMenuItem Size5toolStripMenuItem;
    private ToolStripMenuItem Size6toolStripMenuItem;
    private ToolStripMenuItem Size7toolStripMenuItem;
    private ColorDialog colorDialog1;
    private OpenFileDialog openFileDialog1;
    private SaveFileDialog saveFileDialog1;
    private GroupBox OptionsControlBox;
    private Button UserFontButton;
    private CheckBox WordWrapCheckBox;
    private Label UserFontLabel;
    private Label WordWrapLabel;
    public ToolStrip toolStrip1;
    public MenuStrip menuStrip;
    private Label label1;
    private Panel colorpanel;
    private Button DarkOrangebutton;
    private Button DarkRedbutton;
    private Button DarkSlateGraybutton;
    private Button Indigobutton;
    private Button Navybutton;
    private Button DarkSlateBluebutton;
    private Button DarkGreenbutton;
    private Button DarkOliveGreenbutton;
    private Button Siennabutton;
    private Button Blackbutton;
    private Button SeaGreenbutton;
    private Button YellowGreenbutton;
    private Button SandyBrownbutton;
    private Button Redbutton;
    private Button DimGraybutton;
    private Button SlateGraybutton;
    private Button Bluebutton;
    private Button Tealbutton;
    private Button Greenbutton;
    private Button Olivebutton;
    private Button Wheatbutton;
    private Button Pinkbutton;
    private Button Silverbutton;
    private Button DarkOrchidbutton;
    private Button DeepSkyBluebutton;
    private Button Cyanbutton;
    private Button Limebutton;
    private Button Yellowbutton;
    private Button Orangebutton;
    private Button Fuchsiabutton;
    private Button Graybutton;
    private Button Purplebutton;
    private Button RoyalBluebutton;
    private Button MediumTurquoisebutton;
    private Button Whitebutton;
    private Button Plumbutton;
    private Button LightBluebutton;
    private Button PaleTurquoisebutton;
    private Button PaleGreenbutton;
    private Button LemonChiffonbutton;
    private ToolTip toolTip1;
    public TextBox textBox;
    private ToolStripMenuItem fileToolStripMenuItem1;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem undoToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ToolStripMenuItem toolsToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem findToolStripMenuItem;
    private ToolStripMenuItem replaceToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator11;
    private ToolStripMenuItem resetDefaultsToolStripMenuItem;
    private ToolStripMenuItem previewToolStripMenuItem;
    private ToolStripMenuItem saveSettingsToolStripMenuItem;
    private ToolStripMenuItem checkForUpdatesToolStripMenuItem;
    private ToolStripDropDownButton SpecialCode_toolStripDropDownButton1;
    private ToolStripMenuItem BackgroundcolorToolStripMenuItem;
    private ToolStripMenuItem HorizontalRuleToolStripMenuItem;
    private ToolStripMenuItem OverlineToolStripMenuItem;
    private ToolStripMenuItem phpToolStripMenuItem;
    private ToolStripMenuItem SpoilerToolStripMenuItem;
    private ToolStripMenuItem SQL_ToolStripMenuItem;
    private ToolStripMenuItem strikethroughToolStripMenuItem;
    private ToolStripMenuItem subscriptToolStripMenuItem;
    private ToolStripMenuItem superscriptToolStripMenuItem;
    private ToolStripDropDownButton IndentDropDownButton;
    private ToolStripMenuItem indent1ToolStripMenuItem;
    private ToolStripMenuItem indent2ToolStripMenuItem;
    private ToolStripMenuItem indent3ToolStripMenuItem;
    private ToolStripMenuItem indent4ToolStripMenuItem;
    private ToolStripMenuItem indent5ToolStripMenuItem1;
    private ToolStripMenuItem listElementCloseToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripButton RemoveCodeButton;
    private ToolStripSeparator toolStripSeparator12;
    private ToolStripSeparator toolStripSeparator13;
    private ToolStripMenuItem redoToolStripMenuItem;
    private ToolStripMenuItem newIPBEmailToolStripMenuItem;
    private ToolStripMenuItem listSquareBulletToolStripMenuItem;
    private ToolStripMenuItem useSplitScreenToolStripMenuItem;
    private SplitContainer splitContainer2;
    private WebBrowser webBrowser1;
    private ToolStripMenuItem BCSpecialsToolStripMenu;
    private ToolStripMenuItem cautionToolStripMenuItem;
    private ToolStripMenuItem infoToolStripMenuItem;
    private ToolStripMenuItem regToolStripMenuItem;
    private ToolStripMenuItem warnToolStripMenuItem;
    private FindReplaceDialog findReplaceDialog1;
    private ToolStripMenuItem customCodesToolStripMenuItem;
    private ToolStripMenuItem backupUserSettingsToolStripMenuItem;
    private ToolStripMenuItem restoreBackupToolStripMenuItem;
    private Button updateButton;
    private ToolStripMenuItem ToolsMenuStripSeparator;
    private ToolStripMenuItem codeOnOffToolStripMenuItem;
    private ToolStripMenuItem enhancedCaretToolStripMenuItem;
    public ToolStripButton PreviewButton;
    public SplitContainer splitContainer1;
    private ToolStripMenuItem keystrokeCombosToolStripMenuItem;
    private Stack<string> undoStack = new Stack<string>();
    private Stack<string> redoStack = new Stack<string>();
    private KeystrokeCombosDialog KSC;
    public bool preventUpdate;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.toolStrip1 = new ToolStrip();
      this.SpecialCode_toolStripDropDownButton1 = new ToolStripDropDownButton();
      this.BCSpecialsToolStripMenu = new ToolStripMenuItem();
      this.cautionToolStripMenuItem = new ToolStripMenuItem();
      this.infoToolStripMenuItem = new ToolStripMenuItem();
      this.regToolStripMenuItem = new ToolStripMenuItem();
      this.warnToolStripMenuItem = new ToolStripMenuItem();
      this.BackgroundcolorToolStripMenuItem = new ToolStripMenuItem();
      this.HorizontalRuleToolStripMenuItem = new ToolStripMenuItem();
      this.listElementCloseToolStripMenuItem = new ToolStripMenuItem();
      this.listSquareBulletToolStripMenuItem = new ToolStripMenuItem();
      this.newIPBEmailToolStripMenuItem = new ToolStripMenuItem();
      this.OverlineToolStripMenuItem = new ToolStripMenuItem();
      this.phpToolStripMenuItem = new ToolStripMenuItem();
      this.SpoilerToolStripMenuItem = new ToolStripMenuItem();
      this.SQL_ToolStripMenuItem = new ToolStripMenuItem();
      this.strikethroughToolStripMenuItem = new ToolStripMenuItem();
      this.subscriptToolStripMenuItem = new ToolStripMenuItem();
      this.superscriptToolStripMenuItem = new ToolStripMenuItem();
      this.BoldButton = new ToolStripButton();
      this.ItalicButton = new ToolStripButton();
      this.UnderlineButton = new ToolStripButton();
      this.toolStripSeparator5 = new ToolStripSeparator();
      this.OrderedListButton = new ToolStripButton();
      this.UnorderedListButton = new ToolStripButton();
      this.ListElementButton = new ToolStripButton();
      this.toolStripSeparator6 = new ToolStripSeparator();
      this.HyperlinkButton = new ToolStripButton();
      this.ImageButton = new ToolStripButton();
      this.EmailButton = new ToolStripButton();
      this.QuoteButton = new ToolStripButton();
      this.CodeButton = new ToolStripButton();
      this.toolStripSeparator7 = new ToolStripSeparator();
      this.SizeButton = new ToolStripDropDownButton();
      this.Size1toolStripMenuItem = new ToolStripMenuItem();
      this.Size2toolStripMenuItem = new ToolStripMenuItem();
      this.Size3toolStripMenuItem = new ToolStripMenuItem();
      this.Size4toolStripMenuItem = new ToolStripMenuItem();
      this.Size5toolStripMenuItem = new ToolStripMenuItem();
      this.Size6toolStripMenuItem = new ToolStripMenuItem();
      this.Size7toolStripMenuItem = new ToolStripMenuItem();
      this.FontColorButton = new ToolStripButton();
      this.toolStripSeparator9 = new ToolStripSeparator();
      this.toolStripSeparator12 = new ToolStripSeparator();
      this.PreviewButton = new ToolStripButton();
      this.toolStripSeparator13 = new ToolStripSeparator();
      this.toolStripSeparator8 = new ToolStripSeparator();
      this.IndentDropDownButton = new ToolStripDropDownButton();
      this.indent1ToolStripMenuItem = new ToolStripMenuItem();
      this.indent2ToolStripMenuItem = new ToolStripMenuItem();
      this.indent3ToolStripMenuItem = new ToolStripMenuItem();
      this.indent4ToolStripMenuItem = new ToolStripMenuItem();
      this.indent5ToolStripMenuItem1 = new ToolStripMenuItem();
      this.AlignLeftButton = new ToolStripButton();
      this.AlignCenterButton = new ToolStripButton();
      this.AlignRightButton = new ToolStripButton();
      this.toolStripSeparator10 = new ToolStripSeparator();
      this.RemoveCodeButton = new ToolStripButton();
      this.colorDialog1 = new ColorDialog();
      this.openFileDialog1 = new OpenFileDialog();
      this.saveFileDialog1 = new SaveFileDialog();
      this.OptionsControlBox = new GroupBox();
      this.WordWrapLabel = new Label();
      this.UserFontLabel = new Label();
      this.WordWrapCheckBox = new CheckBox();
      this.UserFontButton = new Button();
      this.menuStrip = new MenuStrip();
      this.fileToolStripMenuItem1 = new ToolStripMenuItem();
      this.newToolStripMenuItem = new ToolStripMenuItem();
      this.openToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator = new ToolStripSeparator();
      this.saveAsToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator1 = new ToolStripSeparator();
      this.previewToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator2 = new ToolStripSeparator();
      this.exitToolStripMenuItem = new ToolStripMenuItem();
      this.editToolStripMenuItem = new ToolStripMenuItem();
      this.undoToolStripMenuItem = new ToolStripMenuItem();
      this.redoToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator3 = new ToolStripSeparator();
      this.cutToolStripMenuItem = new ToolStripMenuItem();
      this.copyToolStripMenuItem = new ToolStripMenuItem();
      this.pasteToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator4 = new ToolStripSeparator();
      this.findToolStripMenuItem = new ToolStripMenuItem();
      this.replaceToolStripMenuItem = new ToolStripMenuItem();
      this.toolStripSeparator11 = new ToolStripSeparator();
      this.selectAllToolStripMenuItem = new ToolStripMenuItem();
      this.toolsToolStripMenuItem = new ToolStripMenuItem();
      this.codeOnOffToolStripMenuItem = new ToolStripMenuItem();
      this.customCodesToolStripMenuItem = new ToolStripMenuItem();
      this.enhancedCaretToolStripMenuItem = new ToolStripMenuItem();
      this.useSplitScreenToolStripMenuItem = new ToolStripMenuItem();
      this.optionsToolStripMenuItem = new ToolStripMenuItem();
      this.saveSettingsToolStripMenuItem = new ToolStripMenuItem();
      this.backupUserSettingsToolStripMenuItem = new ToolStripMenuItem();
      this.ToolsMenuStripSeparator = new ToolStripMenuItem();
      this.resetDefaultsToolStripMenuItem = new ToolStripMenuItem();
      this.restoreBackupToolStripMenuItem = new ToolStripMenuItem();
      this.helpToolStripMenuItem = new ToolStripMenuItem();
      this.aboutToolStripMenuItem = new ToolStripMenuItem();
      this.checkForUpdatesToolStripMenuItem = new ToolStripMenuItem();
      this.keystrokeCombosToolStripMenuItem = new ToolStripMenuItem();
      this.label1 = new Label();
      this.textBox = new TextBox();
      this.colorpanel = new Panel();
      this.Whitebutton = new Button();
      this.Plumbutton = new Button();
      this.LightBluebutton = new Button();
      this.PaleTurquoisebutton = new Button();
      this.PaleGreenbutton = new Button();
      this.LemonChiffonbutton = new Button();
      this.Wheatbutton = new Button();
      this.Pinkbutton = new Button();
      this.Silverbutton = new Button();
      this.DarkOrchidbutton = new Button();
      this.DeepSkyBluebutton = new Button();
      this.Cyanbutton = new Button();
      this.Limebutton = new Button();
      this.Yellowbutton = new Button();
      this.Orangebutton = new Button();
      this.Fuchsiabutton = new Button();
      this.Graybutton = new Button();
      this.Purplebutton = new Button();
      this.RoyalBluebutton = new Button();
      this.MediumTurquoisebutton = new Button();
      this.SeaGreenbutton = new Button();
      this.YellowGreenbutton = new Button();
      this.SandyBrownbutton = new Button();
      this.Redbutton = new Button();
      this.DimGraybutton = new Button();
      this.SlateGraybutton = new Button();
      this.Bluebutton = new Button();
      this.Tealbutton = new Button();
      this.Greenbutton = new Button();
      this.Olivebutton = new Button();
      this.DarkOrangebutton = new Button();
      this.DarkRedbutton = new Button();
      this.DarkSlateGraybutton = new Button();
      this.Indigobutton = new Button();
      this.Navybutton = new Button();
      this.DarkSlateBluebutton = new Button();
      this.DarkGreenbutton = new Button();
      this.DarkOliveGreenbutton = new Button();
      this.Siennabutton = new Button();
      this.Blackbutton = new Button();
      this.toolTip1 = new ToolTip(this.components);
      this.splitContainer1 = new SplitContainer();
      this.splitContainer2 = new SplitContainer();
      this.webBrowser1 = new WebBrowser();
      this.findReplaceDialog1 = new FindReplaceDialog();
      this.updateButton = new Button();
      this.toolStrip1.SuspendLayout();
      this.OptionsControlBox.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.colorpanel.SuspendLayout();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      this.SuspendLayout();
      this.toolStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.toolStrip1.AutoSize = false;
      this.toolStrip1.BackColor = Color.Wheat;
      this.toolStrip1.BackgroundImageLayout = ImageLayout.None;
      this.toolStrip1.Dock = DockStyle.None;
      this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
      this.toolStrip1.Items.AddRange(new ToolStripItem[28]
      {
        (ToolStripItem) this.SpecialCode_toolStripDropDownButton1,
        (ToolStripItem) this.BoldButton,
        (ToolStripItem) this.ItalicButton,
        (ToolStripItem) this.UnderlineButton,
        (ToolStripItem) this.toolStripSeparator5,
        (ToolStripItem) this.OrderedListButton,
        (ToolStripItem) this.UnorderedListButton,
        (ToolStripItem) this.ListElementButton,
        (ToolStripItem) this.toolStripSeparator6,
        (ToolStripItem) this.HyperlinkButton,
        (ToolStripItem) this.ImageButton,
        (ToolStripItem) this.EmailButton,
        (ToolStripItem) this.QuoteButton,
        (ToolStripItem) this.CodeButton,
        (ToolStripItem) this.toolStripSeparator7,
        (ToolStripItem) this.SizeButton,
        (ToolStripItem) this.FontColorButton,
        (ToolStripItem) this.toolStripSeparator9,
        (ToolStripItem) this.toolStripSeparator12,
        (ToolStripItem) this.PreviewButton,
        (ToolStripItem) this.toolStripSeparator13,
        (ToolStripItem) this.toolStripSeparator8,
        (ToolStripItem) this.IndentDropDownButton,
        (ToolStripItem) this.AlignLeftButton,
        (ToolStripItem) this.AlignCenterButton,
        (ToolStripItem) this.AlignRightButton,
        (ToolStripItem) this.toolStripSeparator10,
        (ToolStripItem) this.RemoveCodeButton
      });
      this.toolStrip1.Location = new Point(0, 29);
      this.toolStrip1.Margin = new Padding(0, 1, 0, 1);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Padding = new Padding(0, 0, 2, 0);
      this.toolStrip1.Size = new Size(612, 29);
      this.toolStrip1.TabIndex = 1;
      this.SpecialCode_toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.SpecialCode_toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[13]
      {
        (ToolStripItem) this.BCSpecialsToolStripMenu,
        (ToolStripItem) this.BackgroundcolorToolStripMenuItem,
        (ToolStripItem) this.HorizontalRuleToolStripMenuItem,
        (ToolStripItem) this.listElementCloseToolStripMenuItem,
        (ToolStripItem) this.listSquareBulletToolStripMenuItem,
        (ToolStripItem) this.newIPBEmailToolStripMenuItem,
        (ToolStripItem) this.OverlineToolStripMenuItem,
        (ToolStripItem) this.phpToolStripMenuItem,
        (ToolStripItem) this.SpoilerToolStripMenuItem,
        (ToolStripItem) this.SQL_ToolStripMenuItem,
        (ToolStripItem) this.strikethroughToolStripMenuItem,
        (ToolStripItem) this.subscriptToolStripMenuItem,
        (ToolStripItem) this.superscriptToolStripMenuItem
      });
      this.SpecialCode_toolStripDropDownButton1.Font = new Font("Script MT Bold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SpecialCode_toolStripDropDownButton1.Image = (Image) componentResourceManager.GetObject("SpecialCode_toolStripDropDownButton1.Image");
      this.SpecialCode_toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
      this.SpecialCode_toolStripDropDownButton1.Margin = new Padding(15, 1, 0, 2);
      this.SpecialCode_toolStripDropDownButton1.Name = "SpecialCode_toolStripDropDownButton1";
      this.SpecialCode_toolStripDropDownButton1.Size = new Size(34, 26);
      this.SpecialCode_toolStripDropDownButton1.Text = "S";
      this.SpecialCode_toolStripDropDownButton1.ToolTipText = "Special Codes";
      this.BCSpecialsToolStripMenu.DropDownItems.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.cautionToolStripMenuItem,
        (ToolStripItem) this.infoToolStripMenuItem,
        (ToolStripItem) this.regToolStripMenuItem,
        (ToolStripItem) this.warnToolStripMenuItem
      });
      this.BCSpecialsToolStripMenu.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BCSpecialsToolStripMenu.Name = "BCSpecialsToolStripMenu";
      this.BCSpecialsToolStripMenu.ShortcutKeys = Keys.LWin | Keys.Control;
      this.BCSpecialsToolStripMenu.ShowShortcutKeys = false;
      this.BCSpecialsToolStripMenu.Size = new Size(276, 26);
      this.BCSpecialsToolStripMenu.Text = "Bleeping Computer Specials";
      this.BCSpecialsToolStripMenu.Visible = false;
      this.cautionToolStripMenuItem.Name = "cautionToolStripMenuItem";
      this.cautionToolStripMenuItem.Size = new Size(136, 26);
      this.cautionToolStripMenuItem.Text = "Caution";
      this.cautionToolStripMenuItem.Click += new EventHandler(this.cautionToolStripMenuItem_Click);
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new Size(136, 26);
      this.infoToolStripMenuItem.Text = "Info";
      this.infoToolStripMenuItem.Click += new EventHandler(this.infoToolStripMenuItem_Click);
      this.regToolStripMenuItem.Name = "regToolStripMenuItem";
      this.regToolStripMenuItem.Size = new Size(136, 26);
      this.regToolStripMenuItem.Text = "Reg";
      this.regToolStripMenuItem.Click += new EventHandler(this.regToolStripMenuItem_Click);
      this.warnToolStripMenuItem.Name = "warnToolStripMenuItem";
      this.warnToolStripMenuItem.Size = new Size(136, 26);
      this.warnToolStripMenuItem.Text = "Warn";
      this.warnToolStripMenuItem.Click += new EventHandler(this.warnToolStripMenuItem_Click);
      this.BackgroundcolorToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BackgroundcolorToolStripMenuItem.Name = "BackgroundcolorToolStripMenuItem";
      this.BackgroundcolorToolStripMenuItem.Size = new Size(276, 26);
      this.BackgroundcolorToolStripMenuItem.Text = "Background-color";
      this.BackgroundcolorToolStripMenuItem.ToolTipText = "Formats color behind text";
      this.BackgroundcolorToolStripMenuItem.Click += new EventHandler(this.BackgroundcolorToolStripMenuItem_Click);
      this.HorizontalRuleToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.HorizontalRuleToolStripMenuItem.Name = "HorizontalRuleToolStripMenuItem";
      this.HorizontalRuleToolStripMenuItem.Size = new Size(276, 26);
      this.HorizontalRuleToolStripMenuItem.Text = "Horizontal Rule";
      this.HorizontalRuleToolStripMenuItem.ToolTipText = "Insert horizontal line across page";
      this.HorizontalRuleToolStripMenuItem.Click += new EventHandler(this.HorizontalRuleToolStripMenuItem_Click);
      this.listElementCloseToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.listElementCloseToolStripMenuItem.Name = "listElementCloseToolStripMenuItem";
      this.listElementCloseToolStripMenuItem.Size = new Size(276, 26);
      this.listElementCloseToolStripMenuItem.Text = "List Closing Element";
      this.listElementCloseToolStripMenuItem.ToolTipText = "Use only where supported!";
      this.listElementCloseToolStripMenuItem.Click += new EventHandler(this.listElementCloseToolStripMenuItem_Click);
      this.listSquareBulletToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.listSquareBulletToolStripMenuItem.Name = "listSquareBulletToolStripMenuItem";
      this.listSquareBulletToolStripMenuItem.Size = new Size(276, 26);
      this.listSquareBulletToolStripMenuItem.Text = "List Square Bullet";
      this.listSquareBulletToolStripMenuItem.Click += new EventHandler(this.listSquareBulletToolStripMenuItem_Click);
      this.newIPBEmailToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.newIPBEmailToolStripMenuItem.Name = "newIPBEmailToolStripMenuItem";
      this.newIPBEmailToolStripMenuItem.Size = new Size(276, 26);
      this.newIPBEmailToolStripMenuItem.Text = "New IPB Email";
      this.newIPBEmailToolStripMenuItem.ToolTipText = "Use only where supported!";
      this.newIPBEmailToolStripMenuItem.Click += new EventHandler(this.newIPBEmailToolStripMenuItem_Click);
      this.OverlineToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.OverlineToolStripMenuItem.Name = "OverlineToolStripMenuItem";
      this.OverlineToolStripMenuItem.Size = new Size(276, 26);
      this.OverlineToolStripMenuItem.Text = "Overline";
      this.OverlineToolStripMenuItem.ToolTipText = "Draws a line above selected text";
      this.OverlineToolStripMenuItem.Click += new EventHandler(this.OverlineToolStripMenuItem_Click);
      this.phpToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.phpToolStripMenuItem.Name = "phpToolStripMenuItem";
      this.phpToolStripMenuItem.Size = new Size(276, 26);
      this.phpToolStripMenuItem.Text = "PHP";
      this.phpToolStripMenuItem.ToolTipText = "Retains format of selected php code";
      this.phpToolStripMenuItem.Click += new EventHandler(this.phpToolStripMenuItem_Click);
      this.SpoilerToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SpoilerToolStripMenuItem.Name = "SpoilerToolStripMenuItem";
      this.SpoilerToolStripMenuItem.Size = new Size(276, 26);
      this.SpoilerToolStripMenuItem.Text = "Spoiler";
      this.SpoilerToolStripMenuItem.ToolTipText = "Hides text entered in an expandable box";
      this.SpoilerToolStripMenuItem.Click += new EventHandler(this.SpoilerToolStripMenuItem_Click);
      this.SQL_ToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SQL_ToolStripMenuItem.Name = "SQL_ToolStripMenuItem";
      this.SQL_ToolStripMenuItem.Size = new Size(276, 26);
      this.SQL_ToolStripMenuItem.Text = "SQL";
      this.SQL_ToolStripMenuItem.ToolTipText = "Retains format of selected SQL code ";
      this.SQL_ToolStripMenuItem.Click += new EventHandler(this.SQL_ToolStripMenuItem_Click);
      this.strikethroughToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
      this.strikethroughToolStripMenuItem.Size = new Size(276, 26);
      this.strikethroughToolStripMenuItem.Text = "Strikethrough";
      this.strikethroughToolStripMenuItem.ToolTipText = "Adds horizontal line through selected text";
      this.strikethroughToolStripMenuItem.Click += new EventHandler(this.strikethroughToolStripMenuItem_Click);
      this.subscriptToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.subscriptToolStripMenuItem.Name = "subscriptToolStripMenuItem";
      this.subscriptToolStripMenuItem.Size = new Size(276, 26);
      this.subscriptToolStripMenuItem.Text = "Subscript";
      this.subscriptToolStripMenuItem.ToolTipText = "Formats selected text as subscript";
      this.subscriptToolStripMenuItem.Click += new EventHandler(this.subscriptToolStripMenuItem_Click);
      this.superscriptToolStripMenuItem.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.superscriptToolStripMenuItem.Name = "superscriptToolStripMenuItem";
      this.superscriptToolStripMenuItem.Size = new Size(276, 26);
      this.superscriptToolStripMenuItem.Text = "Superscript";
      this.superscriptToolStripMenuItem.ToolTipText = "Formats selected text as superscript";
      this.superscriptToolStripMenuItem.Click += new EventHandler(this.superscriptToolStripMenuItem_Click);
      this.BoldButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.BoldButton.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.BoldButton.ForeColor = Color.Black;
      this.BoldButton.Image = (Image) componentResourceManager.GetObject("BoldButton.Image");
      this.BoldButton.ImageTransparentColor = Color.Magenta;
      this.BoldButton.Margin = new Padding(15, 1, 0, 2);
      this.BoldButton.Name = "BoldButton";
      this.BoldButton.Size = new Size(24, 26);
      this.BoldButton.Text = "B";
      this.BoldButton.ToolTipText = "Bold (Ctrl+B)";
      this.BoldButton.Click += new EventHandler(this.BoldButton_Click);
      this.ItalicButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ItalicButton.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.ItalicButton.ForeColor = Color.Black;
      this.ItalicButton.Image = (Image) componentResourceManager.GetObject("ItalicButton.Image");
      this.ItalicButton.ImageTransparentColor = Color.Magenta;
      this.ItalicButton.Name = "ItalicButton";
      this.ItalicButton.Size = new Size(23, 26);
      this.ItalicButton.Text = "I";
      this.ItalicButton.ToolTipText = "Italic (Ctrl+I)";
      this.ItalicButton.Click += new EventHandler(this.ItalicButton_Click);
      this.UnderlineButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.UnderlineButton.Font = new Font("Tahoma", 12f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.UnderlineButton.ForeColor = Color.Black;
      this.UnderlineButton.Image = (Image) componentResourceManager.GetObject("UnderlineButton.Image");
      this.UnderlineButton.ImageTransparentColor = Color.Magenta;
      this.UnderlineButton.Name = "UnderlineButton";
      this.UnderlineButton.Size = new Size(25, 26);
      this.UnderlineButton.Text = "U";
      this.UnderlineButton.ToolTipText = "Underline (Ctrl+U)";
      this.UnderlineButton.Click += new EventHandler(this.UnderlineButton_Click);
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new Size(6, 29);
      this.OrderedListButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.OrderedListButton.Image = (Image) componentResourceManager.GetObject("OrderedListButton.Image");
      this.OrderedListButton.ImageTransparentColor = Color.Magenta;
      this.OrderedListButton.Name = "OrderedListButton";
      this.OrderedListButton.Size = new Size(23, 26);
      this.OrderedListButton.Text = "toolStripButton4";
      this.OrderedListButton.ToolTipText = "Numbered List (Ctrl+O)";
      this.OrderedListButton.Click += new EventHandler(this.OrderedListButton_Click);
      this.UnorderedListButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.UnorderedListButton.Image = (Image) componentResourceManager.GetObject("UnorderedListButton.Image");
      this.UnorderedListButton.ImageTransparentColor = Color.Magenta;
      this.UnorderedListButton.Name = "UnorderedListButton";
      this.UnorderedListButton.Size = new Size(23, 26);
      this.UnorderedListButton.Text = "toolStripButton5";
      this.UnorderedListButton.ToolTipText = "Unordered List (Alt+U)";
      this.UnorderedListButton.Click += new EventHandler(this.UnorderedListButton_Click);
      this.ListElementButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.ListElementButton.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ListElementButton.Image = (Image) componentResourceManager.GetObject("ListElementButton.Image");
      this.ListElementButton.ImageTransparentColor = Color.Magenta;
      this.ListElementButton.Name = "ListElementButton";
      this.ListElementButton.Size = new Size(28, 26);
      this.ListElementButton.Text = "[*]";
      this.ListElementButton.ToolTipText = "List Element (Ctrl+L)";
      this.ListElementButton.Click += new EventHandler(this.ListElementButton_Click);
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new Size(6, 29);
      this.HyperlinkButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.HyperlinkButton.Image = (Image) componentResourceManager.GetObject("HyperlinkButton.Image");
      this.HyperlinkButton.ImageTransparentColor = Color.Magenta;
      this.HyperlinkButton.Name = "HyperlinkButton";
      this.HyperlinkButton.Size = new Size(23, 26);
      this.HyperlinkButton.Text = "toolStripButton7";
      this.HyperlinkButton.ToolTipText = "Insert Hyperlink (Alt+Space)";
      this.HyperlinkButton.Click += new EventHandler(this.HyperlinkButton_Click);
      this.ImageButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.ImageButton.Image = (Image) componentResourceManager.GetObject("ImageButton.Image");
      this.ImageButton.ImageTransparentColor = Color.Magenta;
      this.ImageButton.Name = "ImageButton";
      this.ImageButton.Size = new Size(23, 26);
      this.ImageButton.Text = "toolStripButton8";
      this.ImageButton.ToolTipText = "Insert Image Link (Alt+I)";
      this.ImageButton.Click += new EventHandler(this.ImageButton_Click);
      this.EmailButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.EmailButton.Image = (Image) componentResourceManager.GetObject("EmailButton.Image");
      this.EmailButton.ImageTransparentColor = Color.Magenta;
      this.EmailButton.Name = "EmailButton";
      this.EmailButton.Size = new Size(23, 26);
      this.EmailButton.Text = "toolStripButton9";
      this.EmailButton.ToolTipText = "Insert Email Address (Ctrl+E)";
      this.EmailButton.Click += new EventHandler(this.EmailButton_Click);
      this.QuoteButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.QuoteButton.Image = (Image) componentResourceManager.GetObject("QuoteButton.Image");
      this.QuoteButton.ImageTransparentColor = Color.Magenta;
      this.QuoteButton.Name = "QuoteButton";
      this.QuoteButton.Size = new Size(23, 26);
      this.QuoteButton.Text = "toolStripButton10";
      this.QuoteButton.ToolTipText = "Quote (Ctrl+Q)";
      this.QuoteButton.Click += new EventHandler(this.QuoteButton_Click);
      this.CodeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.CodeButton.Image = (Image) componentResourceManager.GetObject("CodeButton.Image");
      this.CodeButton.ImageTransparentColor = Color.Magenta;
      this.CodeButton.Name = "CodeButton";
      this.CodeButton.Size = new Size(23, 26);
      this.CodeButton.Text = "toolStripButton11";
      this.CodeButton.ToolTipText = "Code (Alt+C)";
      this.CodeButton.Click += new EventHandler(this.CodeButton_Click);
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new Size(6, 29);
      this.SizeButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.SizeButton.DropDownItems.AddRange(new ToolStripItem[7]
      {
        (ToolStripItem) this.Size1toolStripMenuItem,
        (ToolStripItem) this.Size2toolStripMenuItem,
        (ToolStripItem) this.Size3toolStripMenuItem,
        (ToolStripItem) this.Size4toolStripMenuItem,
        (ToolStripItem) this.Size5toolStripMenuItem,
        (ToolStripItem) this.Size6toolStripMenuItem,
        (ToolStripItem) this.Size7toolStripMenuItem
      });
      this.SizeButton.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.SizeButton.Image = (Image) componentResourceManager.GetObject("SizeButton.Image");
      this.SizeButton.ImageTransparentColor = Color.Magenta;
      this.SizeButton.Name = "SizeButton";
      this.SizeButton.Size = new Size(43, 26);
      this.SizeButton.Text = "Size";
      this.SizeButton.ToolTipText = "Font Size";
      this.Size1toolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.Size1toolStripMenuItem.Font = new Font("Tahoma", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Size1toolStripMenuItem.ForeColor = Color.Black;
      this.Size1toolStripMenuItem.Name = "Size1toolStripMenuItem";
      this.Size1toolStripMenuItem.Size = new Size(98, 40);
      this.Size1toolStripMenuItem.Text = "1";
      this.Size1toolStripMenuItem.Click += new EventHandler(this.Size1toolStripMenuItem_Click);
      this.Size2toolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.Size2toolStripMenuItem.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Size2toolStripMenuItem.ForeColor = Color.Black;
      this.Size2toolStripMenuItem.Name = "Size2toolStripMenuItem";
      this.Size2toolStripMenuItem.Size = new Size(98, 40);
      this.Size2toolStripMenuItem.Text = "2";
      this.Size2toolStripMenuItem.Click += new EventHandler(this.Size2toolStripMenuItem_Click);
      this.Size3toolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.Size3toolStripMenuItem.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Size3toolStripMenuItem.ForeColor = Color.Black;
      this.Size3toolStripMenuItem.Name = "Size3toolStripMenuItem";
      this.Size3toolStripMenuItem.Size = new Size(98, 40);
      this.Size3toolStripMenuItem.Text = "3";
      this.Size3toolStripMenuItem.Click += new EventHandler(this.Size3toolStripMenuItem_Click);
      this.Size4toolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.Size4toolStripMenuItem.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Size4toolStripMenuItem.ForeColor = Color.Black;
      this.Size4toolStripMenuItem.Name = "Size4toolStripMenuItem";
      this.Size4toolStripMenuItem.Size = new Size(98, 40);
      this.Size4toolStripMenuItem.Text = "4";
      this.Size4toolStripMenuItem.Click += new EventHandler(this.Size4toolStripMenuItem_Click);
      this.Size5toolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.Size5toolStripMenuItem.Font = new Font("Tahoma", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Size5toolStripMenuItem.ForeColor = Color.Black;
      this.Size5toolStripMenuItem.Name = "Size5toolStripMenuItem";
      this.Size5toolStripMenuItem.Size = new Size(98, 40);
      this.Size5toolStripMenuItem.Text = "5";
      this.Size5toolStripMenuItem.Click += new EventHandler(this.Size5toolStripMenuItem_Click);
      this.Size6toolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.Size6toolStripMenuItem.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Size6toolStripMenuItem.ForeColor = Color.Black;
      this.Size6toolStripMenuItem.Name = "Size6toolStripMenuItem";
      this.Size6toolStripMenuItem.Size = new Size(98, 40);
      this.Size6toolStripMenuItem.Text = "6";
      this.Size6toolStripMenuItem.Click += new EventHandler(this.Size6toolStripMenuItem_Click);
      this.Size7toolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
      this.Size7toolStripMenuItem.Font = new Font("Tahoma", 21.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Size7toolStripMenuItem.ForeColor = Color.Black;
      this.Size7toolStripMenuItem.Name = "Size7toolStripMenuItem";
      this.Size7toolStripMenuItem.Size = new Size(98, 40);
      this.Size7toolStripMenuItem.Text = "7";
      this.Size7toolStripMenuItem.Click += new EventHandler(this.Size7toolStripMenuItem_Click);
      this.FontColorButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.FontColorButton.Image = (Image) componentResourceManager.GetObject("FontColorButton.Image");
      this.FontColorButton.ImageTransparentColor = Color.Magenta;
      this.FontColorButton.Name = "FontColorButton";
      this.FontColorButton.Size = new Size(23, 26);
      this.FontColorButton.Text = "toolStripButton17";
      this.FontColorButton.ToolTipText = "Font Color";
      this.FontColorButton.Click += new EventHandler(this.FontColorButton_Click);
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new Size(6, 29);
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      this.toolStripSeparator12.Size = new Size(6, 29);
      this.PreviewButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.PreviewButton.Image = (Image) componentResourceManager.GetObject("PreviewButton.Image");
      this.PreviewButton.ImageTransparentColor = Color.Magenta;
      this.PreviewButton.Margin = new Padding(2, 1, 0, 2);
      this.PreviewButton.Name = "PreviewButton";
      this.PreviewButton.Size = new Size(23, 26);
      this.PreviewButton.ToolTipText = "Preview (Alt+P)";
      this.PreviewButton.Click += new EventHandler(this.previewToolStripMenuItem_Click);
      this.toolStripSeparator13.Name = "toolStripSeparator13";
      this.toolStripSeparator13.Size = new Size(6, 29);
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new Size(6, 29);
      this.IndentDropDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.IndentDropDownButton.DropDownItems.AddRange(new ToolStripItem[5]
      {
        (ToolStripItem) this.indent1ToolStripMenuItem,
        (ToolStripItem) this.indent2ToolStripMenuItem,
        (ToolStripItem) this.indent3ToolStripMenuItem,
        (ToolStripItem) this.indent4ToolStripMenuItem,
        (ToolStripItem) this.indent5ToolStripMenuItem1
      });
      this.IndentDropDownButton.Image = (Image) componentResourceManager.GetObject("IndentDropDownButton.Image");
      this.IndentDropDownButton.ImageTransparentColor = Color.Magenta;
      this.IndentDropDownButton.Margin = new Padding(2, 1, 0, 2);
      this.IndentDropDownButton.Name = "IndentDropDownButton";
      this.IndentDropDownButton.Size = new Size(29, 26);
      this.IndentDropDownButton.Text = "toolStripButton15";
      this.IndentDropDownButton.ToolTipText = "Indent";
      this.indent1ToolStripMenuItem.Name = "indent1ToolStripMenuItem";
      this.indent1ToolStripMenuItem.Size = new Size(117, 22);
      this.indent1ToolStripMenuItem.Text = "Indent 1";
      this.indent1ToolStripMenuItem.Click += new EventHandler(this.indent1ToolStripMenuItem_Click);
      this.indent2ToolStripMenuItem.Name = "indent2ToolStripMenuItem";
      this.indent2ToolStripMenuItem.Size = new Size(117, 22);
      this.indent2ToolStripMenuItem.Text = "Indent 2";
      this.indent2ToolStripMenuItem.Click += new EventHandler(this.indent2ToolStripMenuItem_Click);
      this.indent3ToolStripMenuItem.Name = "indent3ToolStripMenuItem";
      this.indent3ToolStripMenuItem.Size = new Size(117, 22);
      this.indent3ToolStripMenuItem.Text = "Indent 3";
      this.indent3ToolStripMenuItem.Click += new EventHandler(this.indent3ToolStripMenuItem_Click);
      this.indent4ToolStripMenuItem.Name = "indent4ToolStripMenuItem";
      this.indent4ToolStripMenuItem.Size = new Size(117, 22);
      this.indent4ToolStripMenuItem.Text = "Indent 4";
      this.indent4ToolStripMenuItem.Click += new EventHandler(this.indent4ToolStripMenuItem_Click);
      this.indent5ToolStripMenuItem1.Name = "indent5ToolStripMenuItem1";
      this.indent5ToolStripMenuItem1.Size = new Size(117, 22);
      this.indent5ToolStripMenuItem1.Text = "Indent 5";
      this.indent5ToolStripMenuItem1.Click += new EventHandler(this.indent5ToolStripMenuItem1_Click);
      this.AlignLeftButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.AlignLeftButton.Image = (Image) componentResourceManager.GetObject("AlignLeftButton.Image");
      this.AlignLeftButton.ImageTransparentColor = Color.Magenta;
      this.AlignLeftButton.Name = "AlignLeftButton";
      this.AlignLeftButton.Size = new Size(23, 26);
      this.AlignLeftButton.Text = "toolStripButton14";
      this.AlignLeftButton.ToolTipText = "Align Left";
      this.AlignLeftButton.Click += new EventHandler(this.AlignLeftButton_Click);
      this.AlignCenterButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.AlignCenterButton.Image = (Image) componentResourceManager.GetObject("AlignCenterButton.Image");
      this.AlignCenterButton.ImageTransparentColor = Color.Magenta;
      this.AlignCenterButton.Name = "AlignCenterButton";
      this.AlignCenterButton.Size = new Size(23, 26);
      this.AlignCenterButton.Text = "toolStripButton13";
      this.AlignCenterButton.ToolTipText = "Align Center";
      this.AlignCenterButton.Click += new EventHandler(this.AlignCenterButton_Click);
      this.AlignRightButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.AlignRightButton.Image = (Image) componentResourceManager.GetObject("AlignRightButton.Image");
      this.AlignRightButton.ImageTransparentColor = Color.Magenta;
      this.AlignRightButton.Margin = new Padding(2, 1, 0, 2);
      this.AlignRightButton.Name = "AlignRightButton";
      this.AlignRightButton.Size = new Size(23, 26);
      this.AlignRightButton.Text = "toolStripButton12";
      this.AlignRightButton.ToolTipText = "Align Right";
      this.AlignRightButton.Click += new EventHandler(this.AlignRightButton_Click);
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new Size(6, 29);
      this.RemoveCodeButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
      this.RemoveCodeButton.Image = (Image) componentResourceManager.GetObject("RemoveCodeButton.Image");
      this.RemoveCodeButton.ImageTransparentColor = Color.Magenta;
      this.RemoveCodeButton.Margin = new Padding(2, 1, 0, 2);
      this.RemoveCodeButton.Name = "RemoveCodeButton";
      this.RemoveCodeButton.Size = new Size(23, 26);
      this.RemoveCodeButton.ToolTipText = "Remove All BB Code";
      this.RemoveCodeButton.Click += new EventHandler(this.RemoveCodeButton_Click);
      this.openFileDialog1.DefaultExt = "txt";
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "All Files (*.*)|*.*|Text Documents (*.txt)|*.txt";
      this.saveFileDialog1.DefaultExt = "txt";
      this.saveFileDialog1.Filter = "All Files (*.*)|*.*|Text Documents (*.txt)|*.txt";
      this.OptionsControlBox.BackColor = Color.Wheat;
      this.OptionsControlBox.BackgroundImageLayout = ImageLayout.None;
      this.OptionsControlBox.Controls.Add((Control) this.WordWrapLabel);
      this.OptionsControlBox.Controls.Add((Control) this.UserFontLabel);
      this.OptionsControlBox.Controls.Add((Control) this.WordWrapCheckBox);
      this.OptionsControlBox.Controls.Add((Control) this.UserFontButton);
      this.OptionsControlBox.FlatStyle = FlatStyle.Flat;
      this.OptionsControlBox.ForeColor = Color.Wheat;
      this.OptionsControlBox.Location = new Point(44, 57);
      this.OptionsControlBox.Margin = new Padding(0);
      this.OptionsControlBox.Name = "OptionsControlBox";
      this.OptionsControlBox.Padding = new Padding(0);
      this.OptionsControlBox.Size = new Size(256, 76);
      this.OptionsControlBox.TabIndex = 4;
      this.OptionsControlBox.TabStop = false;
      this.OptionsControlBox.Visible = false;
      this.WordWrapLabel.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.WordWrapLabel.ForeColor = Color.Black;
      this.WordWrapLabel.Location = new Point(55, 43);
      this.WordWrapLabel.Name = "WordWrapLabel";
      this.WordWrapLabel.Size = new Size(188, 23);
      this.WordWrapLabel.TabIndex = 5;
      this.WordWrapLabel.Text = "Word Wrap On           Ctrl+W";
      this.WordWrapLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.UserFontLabel.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.UserFontLabel.ForeColor = Color.Black;
      this.UserFontLabel.Location = new Point(55, 10);
      this.UserFontLabel.Name = "UserFontLabel";
      this.UserFontLabel.Size = new Size(198, 23);
      this.UserFontLabel.TabIndex = 3;
      this.UserFontLabel.Text = "Change Font Style     Ctrl+Alt+F";
      this.UserFontLabel.TextAlign = ContentAlignment.MiddleLeft;
      this.WordWrapCheckBox.AutoSize = true;
      this.WordWrapCheckBox.Checked = true;
      this.WordWrapCheckBox.CheckState = CheckState.Checked;
      this.WordWrapCheckBox.Cursor = Cursors.Hand;
      this.WordWrapCheckBox.Location = new Point(25, 48);
      this.WordWrapCheckBox.Name = "WordWrapCheckBox";
      this.WordWrapCheckBox.Size = new Size(15, 14);
      this.WordWrapCheckBox.TabIndex = 2;
      this.WordWrapCheckBox.UseVisualStyleBackColor = true;
      this.WordWrapCheckBox.CheckedChanged += new EventHandler(this.WordWrapCheckBox_CheckedChanged);
      this.UserFontButton.BackgroundImage = (Image) componentResourceManager.GetObject("UserFontButton.BackgroundImage");
      this.UserFontButton.BackgroundImageLayout = ImageLayout.Stretch;
      this.UserFontButton.Cursor = Cursors.Hand;
      this.UserFontButton.Location = new Point(16, 10);
      this.UserFontButton.Name = "UserFontButton";
      this.UserFontButton.Size = new Size(24, 23);
      this.UserFontButton.TabIndex = 0;
      this.UserFontButton.Text = "button1";
      this.UserFontButton.UseVisualStyleBackColor = true;
      this.UserFontButton.Click += new EventHandler(this.UserFontButton_Click);
      this.menuStrip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.menuStrip.AutoSize = false;
      this.menuStrip.BackColor = Color.Wheat;
      this.menuStrip.Dock = DockStyle.None;
      this.menuStrip.Items.AddRange(new ToolStripItem[4]
      {
        (ToolStripItem) this.fileToolStripMenuItem1,
        (ToolStripItem) this.editToolStripMenuItem,
        (ToolStripItem) this.toolsToolStripMenuItem,
        (ToolStripItem) this.helpToolStripMenuItem
      });
      this.menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
      this.menuStrip.Location = new Point(0, 0);
      this.menuStrip.Margin = new Padding(0, 0, 0, 2);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Padding = new Padding(2, 0, 0, 0);
      this.menuStrip.Size = new Size(612, 29);
      this.menuStrip.TabIndex = 5;
      this.menuStrip.Text = "menuStrip1";
      this.fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[8]
      {
        (ToolStripItem) this.newToolStripMenuItem,
        (ToolStripItem) this.openToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator,
        (ToolStripItem) this.saveAsToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator1,
        (ToolStripItem) this.previewToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator2,
        (ToolStripItem) this.exitToolStripMenuItem
      });
      this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
      this.fileToolStripMenuItem1.Size = new Size(37, 29);
      this.fileToolStripMenuItem1.Text = "&File";
      this.newToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("newToolStripMenuItem.Image");
      this.newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = Keys.N | Keys.Control;
      this.newToolStripMenuItem.Size = new Size(154, 22);
      this.newToolStripMenuItem.Text = "&New";
      this.newToolStripMenuItem.Click += new EventHandler(this.newToolStripMenuItem_Click);
      this.openToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("openToolStripMenuItem.Image");
      this.openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = Keys.O | Keys.Alt;
      this.openToolStripMenuItem.Size = new Size(154, 22);
      this.openToolStripMenuItem.Text = "&Open";
      this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new Size(151, 6);
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.ShortcutKeys = Keys.S | Keys.Control;
      this.saveAsToolStripMenuItem.Size = new Size(154, 22);
      this.saveAsToolStripMenuItem.Text = "Save As";
      this.saveAsToolStripMenuItem.Click += new EventHandler(this.saveAsToolStripMenuItem_Click);
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new Size(151, 6);
      this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
      this.previewToolStripMenuItem.ShortcutKeys = Keys.P | Keys.Alt;
      this.previewToolStripMenuItem.Size = new Size(154, 22);
      this.previewToolStripMenuItem.Text = "Preview";
      this.previewToolStripMenuItem.Click += new EventHandler(this.previewToolStripMenuItem_Click);
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new Size(151, 6);
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new Size(154, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);
      this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[11]
      {
        (ToolStripItem) this.undoToolStripMenuItem,
        (ToolStripItem) this.redoToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator3,
        (ToolStripItem) this.cutToolStripMenuItem,
        (ToolStripItem) this.copyToolStripMenuItem,
        (ToolStripItem) this.pasteToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator4,
        (ToolStripItem) this.findToolStripMenuItem,
        (ToolStripItem) this.replaceToolStripMenuItem,
        (ToolStripItem) this.toolStripSeparator11,
        (ToolStripItem) this.selectAllToolStripMenuItem
      });
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new Size(39, 29);
      this.editToolStripMenuItem.Text = "&Edit";
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.ShortcutKeys = Keys.Z | Keys.Control;
      this.undoToolStripMenuItem.Size = new Size(164, 22);
      this.undoToolStripMenuItem.Text = "&Undo";
      this.undoToolStripMenuItem.Click += new EventHandler(this.undoToolStripMenuItem_Click);
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = Keys.Y | Keys.Control;
      this.redoToolStripMenuItem.Size = new Size(164, 22);
      this.redoToolStripMenuItem.Text = "&Redo";
      this.redoToolStripMenuItem.Click += new EventHandler(this.redoToolStripMenuItem_Click);
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new Size(161, 6);
      this.cutToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("cutToolStripMenuItem.Image");
      this.cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = Keys.X | Keys.Control;
      this.cutToolStripMenuItem.Size = new Size(164, 22);
      this.cutToolStripMenuItem.Text = "Cu&t";
      this.cutToolStripMenuItem.Click += new EventHandler(this.cutToolStripMenuItem_Click);
      this.copyToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("copyToolStripMenuItem.Image");
      this.copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = Keys.C | Keys.Control;
      this.copyToolStripMenuItem.Size = new Size(164, 22);
      this.copyToolStripMenuItem.Text = "&Copy";
      this.copyToolStripMenuItem.Click += new EventHandler(this.copyToolStripMenuItem_Click);
      this.pasteToolStripMenuItem.Image = (Image) componentResourceManager.GetObject("pasteToolStripMenuItem.Image");
      this.pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = Keys.V | Keys.Control;
      this.pasteToolStripMenuItem.Size = new Size(164, 22);
      this.pasteToolStripMenuItem.Text = "&Paste";
      this.pasteToolStripMenuItem.Click += new EventHandler(this.pasteToolStripMenuItem_Click);
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new Size(161, 6);
      this.findToolStripMenuItem.Name = "findToolStripMenuItem";
      this.findToolStripMenuItem.ShortcutKeys = Keys.F | Keys.Control;
      this.findToolStripMenuItem.Size = new Size(164, 22);
      this.findToolStripMenuItem.Text = "Find";
      this.findToolStripMenuItem.Click += new EventHandler(this.findToolStripMenuItem_Click);
      this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
      this.replaceToolStripMenuItem.ShortcutKeys = Keys.R | Keys.Control;
      this.replaceToolStripMenuItem.Size = new Size(164, 22);
      this.replaceToolStripMenuItem.Text = "Replace";
      this.replaceToolStripMenuItem.Click += new EventHandler(this.replaceToolStripMenuItem_Click);
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      this.toolStripSeparator11.Size = new Size(161, 6);
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.ShortcutKeys = Keys.A | Keys.Control;
      this.selectAllToolStripMenuItem.Size = new Size(164, 22);
      this.selectAllToolStripMenuItem.Text = "Select &All";
      this.selectAllToolStripMenuItem.Click += new EventHandler(this.selectAllToolStripMenuItem_Click);
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[10]
      {
        (ToolStripItem) this.codeOnOffToolStripMenuItem,
        (ToolStripItem) this.customCodesToolStripMenuItem,
        (ToolStripItem) this.enhancedCaretToolStripMenuItem,
        (ToolStripItem) this.useSplitScreenToolStripMenuItem,
        (ToolStripItem) this.optionsToolStripMenuItem,
        (ToolStripItem) this.saveSettingsToolStripMenuItem,
        (ToolStripItem) this.backupUserSettingsToolStripMenuItem,
        (ToolStripItem) this.ToolsMenuStripSeparator,
        (ToolStripItem) this.resetDefaultsToolStripMenuItem,
        (ToolStripItem) this.restoreBackupToolStripMenuItem
      });
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new Size(48, 29);
      this.toolsToolStripMenuItem.Text = "&Tools";
      this.codeOnOffToolStripMenuItem.Name = "codeOnOffToolStripMenuItem";
      this.codeOnOffToolStripMenuItem.Size = new Size(282, 22);
      this.codeOnOffToolStripMenuItem.Text = "Code Parsing On/Off";
      this.codeOnOffToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.codeOnOffToolStripMenuItem.ToolTipText = "Turn Preview codebox parsing off and on ( Ctrl+0 or Ctrl+NumPad0 )";
      this.codeOnOffToolStripMenuItem.Click += new EventHandler(this.codeOnOffToolStripMenuItem_Click);
      this.customCodesToolStripMenuItem.Name = "customCodesToolStripMenuItem";
      this.customCodesToolStripMenuItem.ShortcutKeys = Keys.C | Keys.Control | Keys.Alt;
      this.customCodesToolStripMenuItem.Size = new Size(282, 22);
      this.customCodesToolStripMenuItem.Text = "Custom Codes";
      this.customCodesToolStripMenuItem.Click += new EventHandler(this.customCodesToolStripMenuItem_Click);
      this.enhancedCaretToolStripMenuItem.Name = "enhancedCaretToolStripMenuItem";
      this.enhancedCaretToolStripMenuItem.ShortcutKeys = Keys.Space | Keys.Control | Keys.Alt;
      this.enhancedCaretToolStripMenuItem.Size = new Size(282, 22);
      this.enhancedCaretToolStripMenuItem.Text = "Enhanced Caret";
      this.enhancedCaretToolStripMenuItem.Click += new EventHandler(this.enhancedCaretToolStripMenuItem_Click);
      this.useSplitScreenToolStripMenuItem.Name = "useSplitScreenToolStripMenuItem";
      this.useSplitScreenToolStripMenuItem.ShortcutKeys = Keys.H | Keys.Control | Keys.Alt;
      this.useSplitScreenToolStripMenuItem.Size = new Size(282, 22);
      this.useSplitScreenToolStripMenuItem.Text = "Use Split Screen";
      this.useSplitScreenToolStripMenuItem.ToolTipText = "View Live Preview in Split Screen";
      this.useSplitScreenToolStripMenuItem.Click += new EventHandler(this.useSplitScreenToolStripMenuItem_Click);
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.ShortcutKeys = Keys.O | Keys.Control | Keys.Alt;
      this.optionsToolStripMenuItem.Size = new Size(282, 22);
      this.optionsToolStripMenuItem.Text = "&Options (Font/Word Wrap)";
      this.optionsToolStripMenuItem.Click += new EventHandler(this.optionsToolStripMenuItem_Click);
      this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
      this.saveSettingsToolStripMenuItem.ShortcutKeys = Keys.S | Keys.Shift | Keys.Control;
      this.saveSettingsToolStripMenuItem.Size = new Size(282, 22);
      this.saveSettingsToolStripMenuItem.Text = "Save Settings";
      this.saveSettingsToolStripMenuItem.Click += new EventHandler(this.saveSettingsToolStripMenuItem_Click);
      this.backupUserSettingsToolStripMenuItem.Name = "backupUserSettingsToolStripMenuItem";
      this.backupUserSettingsToolStripMenuItem.Size = new Size(282, 22);
      this.backupUserSettingsToolStripMenuItem.Text = "Backup User Settings";
      this.backupUserSettingsToolStripMenuItem.Click += new EventHandler(this.backupUserSettingsToolStripMenuItem_Click);
      this.ToolsMenuStripSeparator.Enabled = false;
      this.ToolsMenuStripSeparator.Name = "ToolsMenuStripSeparator";
      this.ToolsMenuStripSeparator.Size = new Size(282, 22);
      this.ToolsMenuStripSeparator.Text = "-----------------------";
      this.ToolsMenuStripSeparator.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.resetDefaultsToolStripMenuItem.Name = "resetDefaultsToolStripMenuItem";
      this.resetDefaultsToolStripMenuItem.ShowShortcutKeys = false;
      this.resetDefaultsToolStripMenuItem.Size = new Size(282, 22);
      this.resetDefaultsToolStripMenuItem.Text = "Reset Defaults";
      this.resetDefaultsToolStripMenuItem.Click += new EventHandler(this.resetDefaultsToolStripMenuItem_Click);
      this.restoreBackupToolStripMenuItem.Name = "restoreBackupToolStripMenuItem";
      this.restoreBackupToolStripMenuItem.Size = new Size(282, 22);
      this.restoreBackupToolStripMenuItem.Text = "Restore from Backup";
      this.restoreBackupToolStripMenuItem.TextImageRelation = TextImageRelation.TextAboveImage;
      this.restoreBackupToolStripMenuItem.ToolTipText = "If a backup does not exist, you will be prompted to browse for one";
      this.restoreBackupToolStripMenuItem.Click += new EventHandler(this.restoreBackupToolStripMenuItem_Click);
      this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
      {
        (ToolStripItem) this.aboutToolStripMenuItem,
        (ToolStripItem) this.checkForUpdatesToolStripMenuItem,
        (ToolStripItem) this.keystrokeCombosToolStripMenuItem
      });
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new Size(44, 29);
      this.helpToolStripMenuItem.Text = "&Help";
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new Size(214, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);
      this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
      this.checkForUpdatesToolStripMenuItem.Size = new Size(214, 22);
      this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
      this.checkForUpdatesToolStripMenuItem.Click += new EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
      this.keystrokeCombosToolStripMenuItem.Name = "keystrokeCombosToolStripMenuItem";
      this.keystrokeCombosToolStripMenuItem.ShortcutKeys = Keys.K | Keys.Control;
      this.keystrokeCombosToolStripMenuItem.Size = new Size(214, 22);
      this.keystrokeCombosToolStripMenuItem.Text = "Keystroke Combos";
      this.keystrokeCombosToolStripMenuItem.Click += new EventHandler(this.keystrokeCombosToolStripMenuItem_Click);
      this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
      this.label1.BackColor = Color.Black;
      this.label1.BorderStyle = BorderStyle.FixedSingle;
      this.label1.Enabled = false;
      this.label1.Location = new Point(0, 57);
      this.label1.Margin = new Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(612, 18);
      this.label1.TabIndex = 6;
      this.textBox.AllowDrop = true;
      this.textBox.DataBindings.Add(new Binding("Font", (object) Settings.Default, "Fstyle", true, DataSourceUpdateMode.OnPropertyChanged));
      this.textBox.DataBindings.Add(new Binding("ForeColor", (object) Settings.Default, "Fcolor", true, DataSourceUpdateMode.OnPropertyChanged));
      this.textBox.Dock = DockStyle.Fill;
      this.textBox.Font = Settings.Default.Fstyle;
      this.textBox.ForeColor = Settings.Default.Fcolor;
      this.textBox.HideSelection = false;
      this.textBox.Location = new Point(0, 0);
      this.textBox.Margin = new Padding(0, 1, 0, 0);
      this.textBox.MaxLength = 300000;
      this.textBox.Multiline = true;
      this.textBox.Name = "textBox";
      this.textBox.ScrollBars = ScrollBars.Both;
      this.textBox.Size = new Size(610, 333);
      this.textBox.TabIndex = 2;
      this.textBox.Click += new EventHandler(this.textBox_Click);
      this.textBox.DragDrop += new DragEventHandler(this.textBox_DragDrop);
      this.textBox.DragEnter += new DragEventHandler(this.textBox_DragEnter);
      this.textBox.KeyDown += new KeyEventHandler(this.textBox_KeyDown);
      this.colorpanel.BackColor = Color.Wheat;
      this.colorpanel.Controls.Add((Control) this.Whitebutton);
      this.colorpanel.Controls.Add((Control) this.Plumbutton);
      this.colorpanel.Controls.Add((Control) this.LightBluebutton);
      this.colorpanel.Controls.Add((Control) this.PaleTurquoisebutton);
      this.colorpanel.Controls.Add((Control) this.PaleGreenbutton);
      this.colorpanel.Controls.Add((Control) this.LemonChiffonbutton);
      this.colorpanel.Controls.Add((Control) this.Wheatbutton);
      this.colorpanel.Controls.Add((Control) this.Pinkbutton);
      this.colorpanel.Controls.Add((Control) this.Silverbutton);
      this.colorpanel.Controls.Add((Control) this.DarkOrchidbutton);
      this.colorpanel.Controls.Add((Control) this.DeepSkyBluebutton);
      this.colorpanel.Controls.Add((Control) this.Cyanbutton);
      this.colorpanel.Controls.Add((Control) this.Limebutton);
      this.colorpanel.Controls.Add((Control) this.Yellowbutton);
      this.colorpanel.Controls.Add((Control) this.Orangebutton);
      this.colorpanel.Controls.Add((Control) this.Fuchsiabutton);
      this.colorpanel.Controls.Add((Control) this.Graybutton);
      this.colorpanel.Controls.Add((Control) this.Purplebutton);
      this.colorpanel.Controls.Add((Control) this.RoyalBluebutton);
      this.colorpanel.Controls.Add((Control) this.MediumTurquoisebutton);
      this.colorpanel.Controls.Add((Control) this.SeaGreenbutton);
      this.colorpanel.Controls.Add((Control) this.YellowGreenbutton);
      this.colorpanel.Controls.Add((Control) this.SandyBrownbutton);
      this.colorpanel.Controls.Add((Control) this.Redbutton);
      this.colorpanel.Controls.Add((Control) this.DimGraybutton);
      this.colorpanel.Controls.Add((Control) this.SlateGraybutton);
      this.colorpanel.Controls.Add((Control) this.Bluebutton);
      this.colorpanel.Controls.Add((Control) this.Tealbutton);
      this.colorpanel.Controls.Add((Control) this.Greenbutton);
      this.colorpanel.Controls.Add((Control) this.Olivebutton);
      this.colorpanel.Controls.Add((Control) this.DarkOrangebutton);
      this.colorpanel.Controls.Add((Control) this.DarkRedbutton);
      this.colorpanel.Controls.Add((Control) this.DarkSlateGraybutton);
      this.colorpanel.Controls.Add((Control) this.Indigobutton);
      this.colorpanel.Controls.Add((Control) this.Navybutton);
      this.colorpanel.Controls.Add((Control) this.DarkSlateBluebutton);
      this.colorpanel.Controls.Add((Control) this.DarkGreenbutton);
      this.colorpanel.Controls.Add((Control) this.DarkOliveGreenbutton);
      this.colorpanel.Controls.Add((Control) this.Siennabutton);
      this.colorpanel.Controls.Add((Control) this.Blackbutton);
      this.colorpanel.Location = new Point(300, 56);
      this.colorpanel.Name = "colorpanel";
      this.colorpanel.Size = new Size(132, 154);
      this.colorpanel.TabIndex = 7;
      this.colorpanel.Visible = false;
      this.Whitebutton.BackColor = Color.White;
      this.Whitebutton.FlatAppearance.BorderColor = Color.Black;
      this.Whitebutton.FlatAppearance.BorderSize = 2;
      this.Whitebutton.FlatStyle = FlatStyle.Flat;
      this.Whitebutton.Location = new Point(114, 123);
      this.Whitebutton.Margin = new Padding(1);
      this.Whitebutton.Name = "Whitebutton";
      this.Whitebutton.Size = new Size(14, 28);
      this.Whitebutton.TabIndex = 39;
      this.toolTip1.SetToolTip((Control) this.Whitebutton, "White #FFFFFF");
      this.Whitebutton.UseVisualStyleBackColor = false;
      this.Whitebutton.Click += new EventHandler(this.Whitebutton_Click);
      this.Plumbutton.BackColor = Color.Plum;
      this.Plumbutton.FlatAppearance.BorderColor = Color.Black;
      this.Plumbutton.FlatAppearance.BorderSize = 2;
      this.Plumbutton.FlatStyle = FlatStyle.Flat;
      this.Plumbutton.Location = new Point(98, 123);
      this.Plumbutton.Margin = new Padding(1);
      this.Plumbutton.Name = "Plumbutton";
      this.Plumbutton.Size = new Size(14, 28);
      this.Plumbutton.TabIndex = 38;
      this.toolTip1.SetToolTip((Control) this.Plumbutton, "Plum\r\n#DDA0DD");
      this.Plumbutton.UseVisualStyleBackColor = false;
      this.Plumbutton.Click += new EventHandler(this.Plumbutton_Click);
      this.LightBluebutton.BackColor = Color.LightBlue;
      this.LightBluebutton.FlatAppearance.BorderColor = Color.Black;
      this.LightBluebutton.FlatAppearance.BorderSize = 2;
      this.LightBluebutton.FlatStyle = FlatStyle.Flat;
      this.LightBluebutton.Location = new Point(82, 123);
      this.LightBluebutton.Margin = new Padding(1);
      this.LightBluebutton.Name = "LightBluebutton";
      this.LightBluebutton.Size = new Size(14, 28);
      this.LightBluebutton.TabIndex = 37;
      this.toolTip1.SetToolTip((Control) this.LightBluebutton, "Light Blue\r\n#ADD8E6");
      this.LightBluebutton.UseVisualStyleBackColor = false;
      this.LightBluebutton.Click += new EventHandler(this.LightBluebutton_Click);
      this.PaleTurquoisebutton.BackColor = Color.PaleTurquoise;
      this.PaleTurquoisebutton.FlatAppearance.BorderColor = Color.Black;
      this.PaleTurquoisebutton.FlatAppearance.BorderSize = 2;
      this.PaleTurquoisebutton.FlatStyle = FlatStyle.Flat;
      this.PaleTurquoisebutton.Location = new Point(66, 123);
      this.PaleTurquoisebutton.Margin = new Padding(1);
      this.PaleTurquoisebutton.Name = "PaleTurquoisebutton";
      this.PaleTurquoisebutton.Size = new Size(14, 28);
      this.PaleTurquoisebutton.TabIndex = 36;
      this.toolTip1.SetToolTip((Control) this.PaleTurquoisebutton, "Pale Turquoise\r\n#AFEEEE");
      this.PaleTurquoisebutton.UseVisualStyleBackColor = false;
      this.PaleTurquoisebutton.Click += new EventHandler(this.PaleTurquoisebutton_Click);
      this.PaleGreenbutton.BackColor = Color.PaleGreen;
      this.PaleGreenbutton.FlatAppearance.BorderColor = Color.Black;
      this.PaleGreenbutton.FlatAppearance.BorderSize = 2;
      this.PaleGreenbutton.FlatStyle = FlatStyle.Flat;
      this.PaleGreenbutton.Location = new Point(50, 123);
      this.PaleGreenbutton.Margin = new Padding(1);
      this.PaleGreenbutton.Name = "PaleGreenbutton";
      this.PaleGreenbutton.Size = new Size(14, 28);
      this.PaleGreenbutton.TabIndex = 35;
      this.toolTip1.SetToolTip((Control) this.PaleGreenbutton, "Pale Green\r\n#98FB98");
      this.PaleGreenbutton.UseVisualStyleBackColor = false;
      this.PaleGreenbutton.Click += new EventHandler(this.PaleGreenbutton_Click);
      this.LemonChiffonbutton.BackColor = Color.LemonChiffon;
      this.LemonChiffonbutton.FlatAppearance.BorderColor = Color.Black;
      this.LemonChiffonbutton.FlatAppearance.BorderSize = 2;
      this.LemonChiffonbutton.FlatStyle = FlatStyle.Flat;
      this.LemonChiffonbutton.Location = new Point(34, 123);
      this.LemonChiffonbutton.Margin = new Padding(1);
      this.LemonChiffonbutton.Name = "LemonChiffonbutton";
      this.LemonChiffonbutton.Size = new Size(14, 28);
      this.LemonChiffonbutton.TabIndex = 34;
      this.toolTip1.SetToolTip((Control) this.LemonChiffonbutton, "Lemon Chiffon\r\n#FFFACD");
      this.LemonChiffonbutton.UseVisualStyleBackColor = false;
      this.LemonChiffonbutton.Click += new EventHandler(this.LemonChiffonbutton_Click);
      this.Wheatbutton.FlatAppearance.BorderColor = Color.Black;
      this.Wheatbutton.FlatAppearance.BorderSize = 2;
      this.Wheatbutton.FlatStyle = FlatStyle.Flat;
      this.Wheatbutton.Location = new Point(18, 123);
      this.Wheatbutton.Margin = new Padding(1);
      this.Wheatbutton.Name = "Wheatbutton";
      this.Wheatbutton.Size = new Size(14, 28);
      this.Wheatbutton.TabIndex = 33;
      this.toolTip1.SetToolTip((Control) this.Wheatbutton, "Wheat\r\n#F5DEB3");
      this.Wheatbutton.UseVisualStyleBackColor = true;
      this.Wheatbutton.Click += new EventHandler(this.Wheatbutton_Click);
      this.Pinkbutton.BackColor = Color.Pink;
      this.Pinkbutton.FlatAppearance.BorderColor = Color.Black;
      this.Pinkbutton.FlatAppearance.BorderSize = 2;
      this.Pinkbutton.FlatStyle = FlatStyle.Flat;
      this.Pinkbutton.Location = new Point(3, 123);
      this.Pinkbutton.Margin = new Padding(1);
      this.Pinkbutton.Name = "Pinkbutton";
      this.Pinkbutton.Size = new Size(14, 28);
      this.Pinkbutton.TabIndex = 32;
      this.toolTip1.SetToolTip((Control) this.Pinkbutton, "Pink\r\n#FFC0CB");
      this.Pinkbutton.UseVisualStyleBackColor = false;
      this.Pinkbutton.Click += new EventHandler(this.Pinkbutton_Click);
      this.Silverbutton.BackColor = Color.Silver;
      this.Silverbutton.FlatAppearance.BorderColor = Color.Black;
      this.Silverbutton.FlatAppearance.BorderSize = 2;
      this.Silverbutton.FlatStyle = FlatStyle.Flat;
      this.Silverbutton.Location = new Point(114, 93);
      this.Silverbutton.Margin = new Padding(1);
      this.Silverbutton.Name = "Silverbutton";
      this.Silverbutton.Size = new Size(14, 28);
      this.Silverbutton.TabIndex = 31;
      this.toolTip1.SetToolTip((Control) this.Silverbutton, "Silver\r\n#C0C0C0");
      this.Silverbutton.UseVisualStyleBackColor = false;
      this.Silverbutton.Click += new EventHandler(this.Silverbutton_Click);
      this.DarkOrchidbutton.BackColor = Color.DarkOrchid;
      this.DarkOrchidbutton.FlatAppearance.BorderColor = Color.Black;
      this.DarkOrchidbutton.FlatAppearance.BorderSize = 2;
      this.DarkOrchidbutton.FlatStyle = FlatStyle.Flat;
      this.DarkOrchidbutton.Location = new Point(98, 93);
      this.DarkOrchidbutton.Margin = new Padding(1);
      this.DarkOrchidbutton.Name = "DarkOrchidbutton";
      this.DarkOrchidbutton.Size = new Size(14, 28);
      this.DarkOrchidbutton.TabIndex = 30;
      this.toolTip1.SetToolTip((Control) this.DarkOrchidbutton, "Dark Orchid\r\n#9932CC");
      this.DarkOrchidbutton.UseVisualStyleBackColor = false;
      this.DarkOrchidbutton.Click += new EventHandler(this.DarkOrchidbutton_Click);
      this.DeepSkyBluebutton.BackColor = Color.DeepSkyBlue;
      this.DeepSkyBluebutton.FlatAppearance.BorderColor = Color.Black;
      this.DeepSkyBluebutton.FlatAppearance.BorderSize = 2;
      this.DeepSkyBluebutton.FlatStyle = FlatStyle.Flat;
      this.DeepSkyBluebutton.Location = new Point(82, 93);
      this.DeepSkyBluebutton.Margin = new Padding(1);
      this.DeepSkyBluebutton.Name = "DeepSkyBluebutton";
      this.DeepSkyBluebutton.Size = new Size(14, 28);
      this.DeepSkyBluebutton.TabIndex = 29;
      this.toolTip1.SetToolTip((Control) this.DeepSkyBluebutton, "Deep Sky Blue\r\n#00BFFF");
      this.DeepSkyBluebutton.UseVisualStyleBackColor = false;
      this.DeepSkyBluebutton.Click += new EventHandler(this.DeepSkyBluebutton_Click);
      this.Cyanbutton.BackColor = Color.Cyan;
      this.Cyanbutton.FlatAppearance.BorderColor = Color.Black;
      this.Cyanbutton.FlatAppearance.BorderSize = 2;
      this.Cyanbutton.FlatStyle = FlatStyle.Flat;
      this.Cyanbutton.Location = new Point(66, 93);
      this.Cyanbutton.Margin = new Padding(1);
      this.Cyanbutton.Name = "Cyanbutton";
      this.Cyanbutton.Size = new Size(14, 28);
      this.Cyanbutton.TabIndex = 28;
      this.toolTip1.SetToolTip((Control) this.Cyanbutton, "Cyan\r\n#00FFFF");
      this.Cyanbutton.UseVisualStyleBackColor = false;
      this.Cyanbutton.Click += new EventHandler(this.Cyanbutton_Click);
      this.Limebutton.BackColor = Color.Lime;
      this.Limebutton.FlatAppearance.BorderColor = Color.Black;
      this.Limebutton.FlatAppearance.BorderSize = 2;
      this.Limebutton.FlatStyle = FlatStyle.Flat;
      this.Limebutton.Location = new Point(50, 93);
      this.Limebutton.Margin = new Padding(1);
      this.Limebutton.Name = "Limebutton";
      this.Limebutton.Size = new Size(14, 28);
      this.Limebutton.TabIndex = 27;
      this.toolTip1.SetToolTip((Control) this.Limebutton, "Lime\r\n#00FF00");
      this.Limebutton.UseVisualStyleBackColor = false;
      this.Limebutton.Click += new EventHandler(this.Limebutton_Click);
      this.Yellowbutton.BackColor = Color.Yellow;
      this.Yellowbutton.FlatAppearance.BorderColor = Color.Black;
      this.Yellowbutton.FlatAppearance.BorderSize = 2;
      this.Yellowbutton.FlatStyle = FlatStyle.Flat;
      this.Yellowbutton.Location = new Point(34, 93);
      this.Yellowbutton.Margin = new Padding(1);
      this.Yellowbutton.Name = "Yellowbutton";
      this.Yellowbutton.Size = new Size(14, 28);
      this.Yellowbutton.TabIndex = 26;
      this.toolTip1.SetToolTip((Control) this.Yellowbutton, "Yellow\r\n#FFFF00");
      this.Yellowbutton.UseVisualStyleBackColor = false;
      this.Yellowbutton.Click += new EventHandler(this.Yellowbutton_Click);
      this.Orangebutton.BackColor = Color.Orange;
      this.Orangebutton.FlatAppearance.BorderColor = Color.Black;
      this.Orangebutton.FlatAppearance.BorderSize = 2;
      this.Orangebutton.FlatStyle = FlatStyle.Flat;
      this.Orangebutton.Location = new Point(18, 93);
      this.Orangebutton.Margin = new Padding(1);
      this.Orangebutton.Name = "Orangebutton";
      this.Orangebutton.Size = new Size(14, 28);
      this.Orangebutton.TabIndex = 25;
      this.toolTip1.SetToolTip((Control) this.Orangebutton, "Orange\r\n#FFA500");
      this.Orangebutton.UseVisualStyleBackColor = false;
      this.Orangebutton.Click += new EventHandler(this.Orangebutton_Click);
      this.Fuchsiabutton.BackColor = Color.Fuchsia;
      this.Fuchsiabutton.FlatAppearance.BorderColor = Color.Black;
      this.Fuchsiabutton.FlatAppearance.BorderSize = 2;
      this.Fuchsiabutton.FlatStyle = FlatStyle.Flat;
      this.Fuchsiabutton.Location = new Point(3, 93);
      this.Fuchsiabutton.Margin = new Padding(1);
      this.Fuchsiabutton.Name = "Fuchsiabutton";
      this.Fuchsiabutton.Size = new Size(14, 28);
      this.Fuchsiabutton.TabIndex = 24;
      this.toolTip1.SetToolTip((Control) this.Fuchsiabutton, "Fuchsia\r\n#FF00FF");
      this.Fuchsiabutton.UseVisualStyleBackColor = false;
      this.Fuchsiabutton.Click += new EventHandler(this.Fuchsiabutton_Click);
      this.Graybutton.BackColor = Color.Gray;
      this.Graybutton.FlatAppearance.BorderColor = Color.Black;
      this.Graybutton.FlatAppearance.BorderSize = 2;
      this.Graybutton.FlatStyle = FlatStyle.Flat;
      this.Graybutton.Location = new Point(114, 63);
      this.Graybutton.Margin = new Padding(1);
      this.Graybutton.Name = "Graybutton";
      this.Graybutton.Size = new Size(14, 28);
      this.Graybutton.TabIndex = 23;
      this.toolTip1.SetToolTip((Control) this.Graybutton, "Gray\r\n#808080");
      this.Graybutton.UseVisualStyleBackColor = false;
      this.Graybutton.Click += new EventHandler(this.Graybutton_Click);
      this.Purplebutton.BackColor = Color.Purple;
      this.Purplebutton.FlatAppearance.BorderColor = Color.Black;
      this.Purplebutton.FlatAppearance.BorderSize = 2;
      this.Purplebutton.FlatStyle = FlatStyle.Flat;
      this.Purplebutton.Location = new Point(98, 63);
      this.Purplebutton.Margin = new Padding(1);
      this.Purplebutton.Name = "Purplebutton";
      this.Purplebutton.Size = new Size(14, 28);
      this.Purplebutton.TabIndex = 22;
      this.toolTip1.SetToolTip((Control) this.Purplebutton, "Purple\r\n#800080");
      this.Purplebutton.UseVisualStyleBackColor = false;
      this.Purplebutton.Click += new EventHandler(this.Purplebutton_Click);
      this.RoyalBluebutton.BackColor = Color.RoyalBlue;
      this.RoyalBluebutton.FlatAppearance.BorderColor = Color.Black;
      this.RoyalBluebutton.FlatAppearance.BorderSize = 2;
      this.RoyalBluebutton.FlatStyle = FlatStyle.Flat;
      this.RoyalBluebutton.Location = new Point(82, 63);
      this.RoyalBluebutton.Margin = new Padding(1);
      this.RoyalBluebutton.Name = "RoyalBluebutton";
      this.RoyalBluebutton.Size = new Size(14, 28);
      this.RoyalBluebutton.TabIndex = 21;
      this.toolTip1.SetToolTip((Control) this.RoyalBluebutton, "Royal Blue\r\n#4169E1");
      this.RoyalBluebutton.UseVisualStyleBackColor = false;
      this.RoyalBluebutton.Click += new EventHandler(this.RoyalBluebutton_Click);
      this.MediumTurquoisebutton.BackColor = Color.MediumTurquoise;
      this.MediumTurquoisebutton.FlatAppearance.BorderColor = Color.Black;
      this.MediumTurquoisebutton.FlatAppearance.BorderSize = 2;
      this.MediumTurquoisebutton.FlatStyle = FlatStyle.Flat;
      this.MediumTurquoisebutton.Location = new Point(66, 63);
      this.MediumTurquoisebutton.Margin = new Padding(1);
      this.MediumTurquoisebutton.Name = "MediumTurquoisebutton";
      this.MediumTurquoisebutton.Size = new Size(14, 28);
      this.MediumTurquoisebutton.TabIndex = 20;
      this.toolTip1.SetToolTip((Control) this.MediumTurquoisebutton, "Medium Turquoise\r\n#48D1CC");
      this.MediumTurquoisebutton.UseVisualStyleBackColor = false;
      this.MediumTurquoisebutton.Click += new EventHandler(this.MediumTurquoisebutton_Click);
      this.SeaGreenbutton.BackColor = Color.SeaGreen;
      this.SeaGreenbutton.FlatAppearance.BorderColor = Color.Black;
      this.SeaGreenbutton.FlatAppearance.BorderSize = 2;
      this.SeaGreenbutton.FlatStyle = FlatStyle.Flat;
      this.SeaGreenbutton.Location = new Point(50, 63);
      this.SeaGreenbutton.Margin = new Padding(1);
      this.SeaGreenbutton.Name = "SeaGreenbutton";
      this.SeaGreenbutton.Size = new Size(14, 28);
      this.SeaGreenbutton.TabIndex = 19;
      this.toolTip1.SetToolTip((Control) this.SeaGreenbutton, "Sea Green\r\n#2E8B57");
      this.SeaGreenbutton.UseVisualStyleBackColor = false;
      this.SeaGreenbutton.Click += new EventHandler(this.SeaGreenbutton_Click);
      this.YellowGreenbutton.BackColor = Color.YellowGreen;
      this.YellowGreenbutton.FlatAppearance.BorderColor = Color.Black;
      this.YellowGreenbutton.FlatAppearance.BorderSize = 2;
      this.YellowGreenbutton.FlatStyle = FlatStyle.Flat;
      this.YellowGreenbutton.Location = new Point(34, 63);
      this.YellowGreenbutton.Margin = new Padding(1);
      this.YellowGreenbutton.Name = "YellowGreenbutton";
      this.YellowGreenbutton.Size = new Size(14, 28);
      this.YellowGreenbutton.TabIndex = 18;
      this.toolTip1.SetToolTip((Control) this.YellowGreenbutton, "Yellow Green\r\n#9ACD32");
      this.YellowGreenbutton.UseVisualStyleBackColor = false;
      this.YellowGreenbutton.Click += new EventHandler(this.YellowGreenbutton_Click);
      this.SandyBrownbutton.BackColor = Color.SandyBrown;
      this.SandyBrownbutton.FlatAppearance.BorderColor = Color.Black;
      this.SandyBrownbutton.FlatAppearance.BorderSize = 2;
      this.SandyBrownbutton.FlatStyle = FlatStyle.Flat;
      this.SandyBrownbutton.Location = new Point(18, 63);
      this.SandyBrownbutton.Margin = new Padding(1);
      this.SandyBrownbutton.Name = "SandyBrownbutton";
      this.SandyBrownbutton.Size = new Size(14, 28);
      this.SandyBrownbutton.TabIndex = 17;
      this.toolTip1.SetToolTip((Control) this.SandyBrownbutton, "Sandy Brown\r\n#F4A460");
      this.SandyBrownbutton.UseVisualStyleBackColor = false;
      this.SandyBrownbutton.Click += new EventHandler(this.SandyBrownbutton_Click);
      this.Redbutton.BackColor = Color.Red;
      this.Redbutton.FlatAppearance.BorderColor = Color.Black;
      this.Redbutton.FlatAppearance.BorderSize = 2;
      this.Redbutton.FlatStyle = FlatStyle.Flat;
      this.Redbutton.Location = new Point(3, 63);
      this.Redbutton.Margin = new Padding(1);
      this.Redbutton.Name = "Redbutton";
      this.Redbutton.Size = new Size(14, 28);
      this.Redbutton.TabIndex = 16;
      this.toolTip1.SetToolTip((Control) this.Redbutton, "Red\r\n#FF0000");
      this.Redbutton.UseVisualStyleBackColor = false;
      this.Redbutton.Click += new EventHandler(this.Redbutton_Click);
      this.DimGraybutton.BackColor = Color.DimGray;
      this.DimGraybutton.FlatAppearance.BorderColor = Color.Black;
      this.DimGraybutton.FlatAppearance.BorderSize = 2;
      this.DimGraybutton.FlatStyle = FlatStyle.Flat;
      this.DimGraybutton.Location = new Point(115, 33);
      this.DimGraybutton.Margin = new Padding(1);
      this.DimGraybutton.Name = "DimGraybutton";
      this.DimGraybutton.Size = new Size(14, 28);
      this.DimGraybutton.TabIndex = 15;
      this.toolTip1.SetToolTip((Control) this.DimGraybutton, "Dim Gray\r\n#696969");
      this.DimGraybutton.UseVisualStyleBackColor = false;
      this.DimGraybutton.Click += new EventHandler(this.DimGraybutton_Click);
      this.SlateGraybutton.BackColor = Color.SlateGray;
      this.SlateGraybutton.FlatAppearance.BorderColor = Color.Black;
      this.SlateGraybutton.FlatAppearance.BorderSize = 2;
      this.SlateGraybutton.FlatStyle = FlatStyle.Flat;
      this.SlateGraybutton.Location = new Point(99, 33);
      this.SlateGraybutton.Margin = new Padding(1);
      this.SlateGraybutton.Name = "SlateGraybutton";
      this.SlateGraybutton.Size = new Size(14, 28);
      this.SlateGraybutton.TabIndex = 14;
      this.toolTip1.SetToolTip((Control) this.SlateGraybutton, "Slate Gray\r\n#708090");
      this.SlateGraybutton.UseVisualStyleBackColor = false;
      this.SlateGraybutton.Click += new EventHandler(this.SlateGraybutton_Click);
      this.Bluebutton.BackColor = Color.Blue;
      this.Bluebutton.FlatAppearance.BorderColor = Color.Black;
      this.Bluebutton.FlatAppearance.BorderSize = 2;
      this.Bluebutton.FlatStyle = FlatStyle.Flat;
      this.Bluebutton.Location = new Point(83, 33);
      this.Bluebutton.Margin = new Padding(1);
      this.Bluebutton.Name = "Bluebutton";
      this.Bluebutton.Size = new Size(14, 28);
      this.Bluebutton.TabIndex = 13;
      this.toolTip1.SetToolTip((Control) this.Bluebutton, "Blue\r\n#0000FF");
      this.Bluebutton.UseVisualStyleBackColor = false;
      this.Bluebutton.Click += new EventHandler(this.Bluebutton_Click);
      this.Tealbutton.BackColor = Color.Teal;
      this.Tealbutton.FlatAppearance.BorderColor = Color.Black;
      this.Tealbutton.FlatAppearance.BorderSize = 2;
      this.Tealbutton.FlatStyle = FlatStyle.Flat;
      this.Tealbutton.Location = new Point(67, 33);
      this.Tealbutton.Margin = new Padding(1);
      this.Tealbutton.Name = "Tealbutton";
      this.Tealbutton.Size = new Size(14, 28);
      this.Tealbutton.TabIndex = 12;
      this.toolTip1.SetToolTip((Control) this.Tealbutton, "Teal\r\n#008080");
      this.Tealbutton.UseVisualStyleBackColor = false;
      this.Tealbutton.Click += new EventHandler(this.Tealbutton_Click);
      this.Greenbutton.BackColor = Color.Green;
      this.Greenbutton.FlatAppearance.BorderColor = Color.Black;
      this.Greenbutton.FlatAppearance.BorderSize = 2;
      this.Greenbutton.FlatStyle = FlatStyle.Flat;
      this.Greenbutton.Location = new Point(51, 33);
      this.Greenbutton.Margin = new Padding(1);
      this.Greenbutton.Name = "Greenbutton";
      this.Greenbutton.Size = new Size(14, 28);
      this.Greenbutton.TabIndex = 11;
      this.toolTip1.SetToolTip((Control) this.Greenbutton, "Green\r\n#008000");
      this.Greenbutton.UseVisualStyleBackColor = false;
      this.Greenbutton.Click += new EventHandler(this.Greenbutton_Click);
      this.Olivebutton.BackColor = Color.Olive;
      this.Olivebutton.FlatAppearance.BorderColor = Color.Black;
      this.Olivebutton.FlatAppearance.BorderSize = 2;
      this.Olivebutton.FlatStyle = FlatStyle.Flat;
      this.Olivebutton.Location = new Point(35, 33);
      this.Olivebutton.Margin = new Padding(1);
      this.Olivebutton.Name = "Olivebutton";
      this.Olivebutton.Size = new Size(14, 28);
      this.Olivebutton.TabIndex = 10;
      this.toolTip1.SetToolTip((Control) this.Olivebutton, "Olive\r\n#808000");
      this.Olivebutton.UseVisualStyleBackColor = false;
      this.Olivebutton.Click += new EventHandler(this.Olivebutton_Click);
      this.DarkOrangebutton.BackColor = Color.DarkOrange;
      this.DarkOrangebutton.FlatAppearance.BorderColor = Color.Black;
      this.DarkOrangebutton.FlatAppearance.BorderSize = 2;
      this.DarkOrangebutton.FlatStyle = FlatStyle.Flat;
      this.DarkOrangebutton.Location = new Point(19, 33);
      this.DarkOrangebutton.Margin = new Padding(1);
      this.DarkOrangebutton.Name = "DarkOrangebutton";
      this.DarkOrangebutton.Size = new Size(14, 28);
      this.DarkOrangebutton.TabIndex = 9;
      this.toolTip1.SetToolTip((Control) this.DarkOrangebutton, "Dark Orange\r\n#FF8C00");
      this.DarkOrangebutton.UseVisualStyleBackColor = false;
      this.DarkOrangebutton.Click += new EventHandler(this.DarkOrangebutton_Click);
      this.DarkRedbutton.BackColor = Color.DarkRed;
      this.DarkRedbutton.FlatAppearance.BorderColor = Color.Black;
      this.DarkRedbutton.FlatAppearance.BorderSize = 2;
      this.DarkRedbutton.FlatStyle = FlatStyle.Flat;
      this.DarkRedbutton.Location = new Point(3, 33);
      this.DarkRedbutton.Margin = new Padding(1);
      this.DarkRedbutton.Name = "DarkRedbutton";
      this.DarkRedbutton.Size = new Size(14, 28);
      this.DarkRedbutton.TabIndex = 8;
      this.toolTip1.SetToolTip((Control) this.DarkRedbutton, "Dark Red\r\n#8B0000");
      this.DarkRedbutton.UseVisualStyleBackColor = false;
      this.DarkRedbutton.Click += new EventHandler(this.DarkRedbutton_Click);
      this.DarkSlateGraybutton.BackColor = Color.DarkSlateGray;
      this.DarkSlateGraybutton.FlatAppearance.BorderColor = Color.Black;
      this.DarkSlateGraybutton.FlatAppearance.BorderSize = 2;
      this.DarkSlateGraybutton.FlatStyle = FlatStyle.Flat;
      this.DarkSlateGraybutton.Location = new Point(115, 3);
      this.DarkSlateGraybutton.Margin = new Padding(1);
      this.DarkSlateGraybutton.Name = "DarkSlateGraybutton";
      this.DarkSlateGraybutton.Size = new Size(14, 28);
      this.DarkSlateGraybutton.TabIndex = 7;
      this.toolTip1.SetToolTip((Control) this.DarkSlateGraybutton, "Dark Slate Gray\r\n#2F4F4F");
      this.DarkSlateGraybutton.UseVisualStyleBackColor = false;
      this.DarkSlateGraybutton.Click += new EventHandler(this.DarkSlateGraybutton_Click);
      this.Indigobutton.BackColor = Color.Indigo;
      this.Indigobutton.FlatAppearance.BorderColor = Color.Black;
      this.Indigobutton.FlatAppearance.BorderSize = 2;
      this.Indigobutton.FlatStyle = FlatStyle.Flat;
      this.Indigobutton.Location = new Point(99, 3);
      this.Indigobutton.Margin = new Padding(1);
      this.Indigobutton.Name = "Indigobutton";
      this.Indigobutton.Size = new Size(14, 28);
      this.Indigobutton.TabIndex = 6;
      this.toolTip1.SetToolTip((Control) this.Indigobutton, "Indigo\r\n#4B0082");
      this.Indigobutton.UseVisualStyleBackColor = false;
      this.Indigobutton.Click += new EventHandler(this.Indigobutton_Click);
      this.Navybutton.BackColor = Color.Navy;
      this.Navybutton.FlatAppearance.BorderColor = Color.Black;
      this.Navybutton.FlatAppearance.BorderSize = 2;
      this.Navybutton.FlatStyle = FlatStyle.Flat;
      this.Navybutton.Location = new Point(83, 3);
      this.Navybutton.Margin = new Padding(1);
      this.Navybutton.Name = "Navybutton";
      this.Navybutton.Size = new Size(14, 28);
      this.Navybutton.TabIndex = 5;
      this.toolTip1.SetToolTip((Control) this.Navybutton, "Navy\r\n#000080");
      this.Navybutton.UseVisualStyleBackColor = false;
      this.Navybutton.Click += new EventHandler(this.Navybutton_Click);
      this.DarkSlateBluebutton.BackColor = Color.DarkSlateBlue;
      this.DarkSlateBluebutton.FlatAppearance.BorderColor = Color.Black;
      this.DarkSlateBluebutton.FlatAppearance.BorderSize = 2;
      this.DarkSlateBluebutton.FlatStyle = FlatStyle.Flat;
      this.DarkSlateBluebutton.Location = new Point(67, 3);
      this.DarkSlateBluebutton.Margin = new Padding(1);
      this.DarkSlateBluebutton.Name = "DarkSlateBluebutton";
      this.DarkSlateBluebutton.Size = new Size(14, 28);
      this.DarkSlateBluebutton.TabIndex = 4;
      this.toolTip1.SetToolTip((Control) this.DarkSlateBluebutton, "Dark Slate Blue\r\n#483D8B");
      this.DarkSlateBluebutton.UseVisualStyleBackColor = false;
      this.DarkSlateBluebutton.Click += new EventHandler(this.DarkSlateBluebutton_Click);
      this.DarkGreenbutton.BackColor = Color.DarkGreen;
      this.DarkGreenbutton.FlatAppearance.BorderColor = Color.Black;
      this.DarkGreenbutton.FlatAppearance.BorderSize = 2;
      this.DarkGreenbutton.FlatStyle = FlatStyle.Flat;
      this.DarkGreenbutton.Location = new Point(51, 3);
      this.DarkGreenbutton.Margin = new Padding(1);
      this.DarkGreenbutton.Name = "DarkGreenbutton";
      this.DarkGreenbutton.Size = new Size(14, 28);
      this.DarkGreenbutton.TabIndex = 3;
      this.toolTip1.SetToolTip((Control) this.DarkGreenbutton, "Dark Green\r\n#006400");
      this.DarkGreenbutton.UseVisualStyleBackColor = false;
      this.DarkGreenbutton.Click += new EventHandler(this.DarkGreenbutton_Click);
      this.DarkOliveGreenbutton.BackColor = Color.DarkOliveGreen;
      this.DarkOliveGreenbutton.FlatAppearance.BorderColor = Color.Black;
      this.DarkOliveGreenbutton.FlatAppearance.BorderSize = 2;
      this.DarkOliveGreenbutton.FlatStyle = FlatStyle.Flat;
      this.DarkOliveGreenbutton.Location = new Point(35, 3);
      this.DarkOliveGreenbutton.Margin = new Padding(1);
      this.DarkOliveGreenbutton.Name = "DarkOliveGreenbutton";
      this.DarkOliveGreenbutton.Size = new Size(14, 28);
      this.DarkOliveGreenbutton.TabIndex = 2;
      this.toolTip1.SetToolTip((Control) this.DarkOliveGreenbutton, "Dark Olive Green\r\n#556B2F");
      this.DarkOliveGreenbutton.UseVisualStyleBackColor = false;
      this.DarkOliveGreenbutton.Click += new EventHandler(this.DarkOliveGreenbutton_Click);
      this.Siennabutton.BackColor = Color.Sienna;
      this.Siennabutton.FlatAppearance.BorderColor = Color.Black;
      this.Siennabutton.FlatAppearance.BorderSize = 2;
      this.Siennabutton.FlatStyle = FlatStyle.Flat;
      this.Siennabutton.Location = new Point(19, 3);
      this.Siennabutton.Margin = new Padding(1);
      this.Siennabutton.Name = "Siennabutton";
      this.Siennabutton.Size = new Size(14, 28);
      this.Siennabutton.TabIndex = 1;
      this.toolTip1.SetToolTip((Control) this.Siennabutton, "Sienna\r\n#A0522D");
      this.Siennabutton.UseVisualStyleBackColor = false;
      this.Siennabutton.Click += new EventHandler(this.Siennabutton_Click);
      this.Blackbutton.BackColor = Color.Black;
      this.Blackbutton.FlatAppearance.BorderColor = Color.Black;
      this.Blackbutton.FlatAppearance.BorderSize = 2;
      this.Blackbutton.FlatStyle = FlatStyle.Flat;
      this.Blackbutton.Location = new Point(3, 3);
      this.Blackbutton.Margin = new Padding(1);
      this.Blackbutton.Name = "Blackbutton";
      this.Blackbutton.Size = new Size(14, 28);
      this.Blackbutton.TabIndex = 0;
      this.toolTip1.SetToolTip((Control) this.Blackbutton, "Black \r\n#000000");
      this.Blackbutton.UseVisualStyleBackColor = false;
      this.Blackbutton.Click += new EventHandler(this.Blackbutton_Click);
      this.splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
      this.splitContainer1.BorderStyle = BorderStyle.FixedSingle;
      this.splitContainer1.DataBindings.Add(new Binding("Panel2Collapsed", (object) Settings.Default, "Split1panel2collapsed", true, DataSourceUpdateMode.OnPropertyChanged));
      this.splitContainer1.Location = new Point(0, 74);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = Orientation.Horizontal;
      this.splitContainer1.Panel1.Controls.Add((Control) this.textBox);
      this.splitContainer1.Panel2.Controls.Add((Control) this.splitContainer2);
      this.splitContainer1.Panel2Collapsed = Settings.Default.Split1panel2collapsed;
      this.splitContainer1.Size = new Size(612, 335);
      this.splitContainer1.SplitterDistance = Settings.Default.splitterposition;
      this.splitContainer1.SplitterWidth = 6;
      this.splitContainer1.TabIndex = 8;
      this.splitContainer2.Dock = DockStyle.Fill;
      this.splitContainer2.Location = new Point(0, 0);
      this.splitContainer2.Name = "splitContainer2";
      this.splitContainer2.Panel1.Controls.Add((Control) this.webBrowser1);
      this.splitContainer2.Panel2.Enabled = false;
      this.splitContainer2.Panel2Collapsed = true;
      this.splitContainer2.Size = new Size(148, 44);
      this.splitContainer2.SplitterDistance = 123;
      this.splitContainer2.TabIndex = 0;
      this.webBrowser1.AllowWebBrowserDrop = false;
      this.webBrowser1.Dock = DockStyle.Fill;
      this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
      this.webBrowser1.Location = new Point(0, 0);
      this.webBrowser1.MinimumSize = new Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.ScriptErrorsSuppressed = true;
      this.webBrowser1.Size = new Size(148, 44);
      this.webBrowser1.TabIndex = 0;
      this.webBrowser1.TabStop = false;
      this.webBrowser1.WebBrowserShortcutsEnabled = false;
      this.findReplaceDialog1.FindWhat = "";
      this.findReplaceDialog1.HelpVisible = false;
      this.findReplaceDialog1.ReplaceWith = "";
      this.findReplaceDialog1.FindNextClick += new IFindReplaceDialog.FindNextClickEventHandler(this.findReplaceDialog1_FindNextClick);
      this.findReplaceDialog1.ReplaceClick += new IFindReplaceDialog.ReplaceClickEventHandler(this.findReplaceDialog1_ReplaceClick);
      this.findReplaceDialog1.ReplaceAllClick += new IFindReplaceDialog.ReplaceAllClickEventHandler(this.findReplaceDialog1_ReplaceAllClick);
      this.findReplaceDialog1.TextFound += new IFindReplaceDialog.TextFoundEventHandler(this.findReplaceDialog1_TextFound);
      this.findReplaceDialog1.SearchFailed += new IFindReplaceDialog.SearchFailedEventHandler(this.findReplaceDialog1_SearchFailed);
      this.updateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.updateButton.BackColor = Color.Wheat;
      this.updateButton.Enabled = false;
      this.updateButton.Location = new Point(601, 0);
      this.updateButton.Name = "updateButton";
      this.updateButton.Size = new Size(10, 10);
      this.updateButton.TabIndex = 9;
      this.updateButton.UseVisualStyleBackColor = false;
      this.updateButton.Visible = false;
      this.updateButton.Click += new EventHandler(this.updateButton_Click);
      this.AllowDrop = true;
      this.AutoScaleDimensions = new SizeF(96f, 96f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.BackColor = SystemColors.Control;
      this.ClientSize = new Size(612, 409);
      this.Controls.Add((Control) this.OptionsControlBox);
      this.Controls.Add((Control) this.updateButton);
      this.Controls.Add((Control) this.splitContainer1);
      this.Controls.Add((Control) this.colorpanel);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.toolStrip1);
      this.Controls.Add((Control) this.menuStrip);
      this.DataBindings.Add(new Binding("Location", (object) Settings.Default, "FormLocation", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.KeyPreview = true;
      this.Location = Settings.Default.FormLocation;
      this.Margin = new Padding(4, 3, 4, 3);
      this.Name = nameof (Form1);
      this.Text = "bbEditor";
      this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
      this.Load += new EventHandler(this.Form1_Load);
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.OptionsControlBox.ResumeLayout(false);
      this.OptionsControlBox.PerformLayout();
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.colorpanel.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    [DllImport("user32.dll")]
    private static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

    [DllImport("user32.dll")]
    private static extern bool ShowCaret(IntPtr hWnd);

    public Form1()
    {
      this.InitializeComponent();
      this.textBox.TextChanged += new EventHandler(this.textBox_TextChanged);
      this.undoStack.Push(this.textBox.Text);
      Version version = Assembly.GetExecutingAssembly().GetName().Version;
      this.Text = this.Text + "  " + (object) version.Major + "." + (object) version.Minor + "." + (object) version.Build + "." + (object) version.Revision;
    }

    public string cname { get; set; }

    private void Form1_Load(object sender, EventArgs e)
    {
      File.WriteAllText(Path.GetTempPath() + "bbestyle.css", new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("bbEditor.bbestyle.css")).ReadToEnd());
      if (Settings.Default.KSCFrmShow)
      {
        this.KSC = new KeystrokeCombosDialog();
        this.KSC.Visible = true;
        this.KSC.Size = Settings.Default.KSCFrmSize;
        this.KSC.Location = Settings.Default.KSCFrmLocation;
        this.KSC.Enabled = Settings.Default.KSCFrmEnabled;
        this.KSC.Visible = Settings.Default.KSCFrmShow;
        this.KSC.Show();
      }
      this.Size = Settings.Default.FormSize;
      this.splitpos = Settings.Default.splitterposition;
      this.GotFocus += new EventHandler(this.Form1_gotFocus);
      this.Focus();
      this.textBox.GotFocus += new EventHandler(this.textBox_GotFocus);
    }

    private void Form1_gotFocus(object sender, EventArgs e)
    {
      this.updateButton.Enabled = true;
      this.updateButton.PerformClick();
      this.updateButton.Enabled = false;
      this.textBox.Focus();
    }

    private void textBox_GotFocus(object sender, EventArgs e)
    {
      if (Settings.Default.eCaret != 5)
        return;
      Form1.CreateCaret(this.textBox.Handle, IntPtr.Zero, 5, 20);
      Form1.ShowCaret(this.textBox.Handle);
    }

    private void BoldButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 7;
        this.textBox.SelectedText = "[b]" + this.textBox.SelectedText + "[/b]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 3;
        this.textBox.SelectedText = "[b][/b]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void ItalicButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 7;
        this.textBox.SelectedText = "[i]" + this.textBox.SelectedText + "[/i]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 3;
        this.textBox.SelectedText = "[i][/i]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void UnderlineButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 7;
        this.textBox.SelectedText = "[u]" + this.textBox.SelectedText + "[/u]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 3;
        this.textBox.SelectedText = "[u][/u]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void OrderedListButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      int selectionStart = this.textBox.SelectionStart;
      this.preventUpdate = true;
      this.textBox.SelectedText = new Regex("(\\[\\*\\])((\\[list.*?\\])+)", RegexOptions.IgnoreCase).Replace(new Regex("\\[\\*\\]\\[/").Replace(new Regex("\\[\\*\\]\r\n").Replace(new Regex("\\[\\*\\]\\s+\r\n").Replace("[list=1][*]" + new Regex("\r\n(.*?)").Replace(new Regex("\\[\\*\\](.*?)").Replace(this.textBox.SelectedText, "$1"), "\r\n[*]$1") + "[/list]", "[*]\r\n"), "\r\n"), "[/"), "$2$1");
      this.textBox.SelectionStart = selectionStart;
      this.preventUpdate = false;
    }

    private void UnorderedListButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      int selectionStart = this.textBox.SelectionStart;
      this.preventUpdate = true;
      this.textBox.SelectedText = new Regex("(\\[\\*\\])((\\[list.*?\\])+)", RegexOptions.IgnoreCase).Replace(new Regex("\\[\\*\\]\\[/").Replace(new Regex("\\[\\*\\]\r\n").Replace(new Regex("\\[\\*\\]\\s+\r\n").Replace("[list][*]" + new Regex("\r\n(.*?)").Replace(new Regex("\\[\\*\\](.*?)").Replace(this.textBox.SelectedText, "$1"), "\r\n[*]$1") + "[/list]", "[*]\r\n"), "\r\n"), "[/"), "$2$1");
      this.textBox.SelectionStart = selectionStart;
      this.preventUpdate = false;
    }

    private void ListElementButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + 3;
        this.textBox.SelectedText = "[*]" + this.textBox.SelectedText;
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 3;
        this.textBox.SelectedText = "[*]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void QuoteButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[quote]" + this.textBox.SelectedText + "[/quote]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 7;
        this.textBox.SelectedText = "[quote][/quote]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void CodeButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 13;
        this.textBox.SelectedText = "[code]" + this.textBox.SelectedText + "[/code]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 6;
        this.textBox.SelectedText = "[code][/code]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void Size1toolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[size=1]" + this.textBox.SelectedText + "[/size]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[size=1][/size]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void Size2toolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[size=2]" + this.textBox.SelectedText + "[/size]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[size=2][/size]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void Size3toolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[size=3]" + this.textBox.SelectedText + "[/size]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[size=3][/size]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void Size4toolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[size=4]" + this.textBox.SelectedText + "[/size]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[size=4][/size]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void Size5toolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[size=5]" + this.textBox.SelectedText + "[/size]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[size=5][/size]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void Size6toolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[size=6]" + this.textBox.SelectedText + "[/size]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[size=6][/size]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void Size7toolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[size=7]" + this.textBox.SelectedText + "[/size]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[size=7][/size]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void AlignLeftButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 13;
        this.textBox.SelectedText = "[left]" + this.textBox.SelectedText + "[/left]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 6;
        this.textBox.SelectedText = "[left][/left]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void AlignCenterButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 17;
        this.textBox.SelectedText = "[center]" + this.textBox.SelectedText + "[/center]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[center][/center]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void AlignRightButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 15;
        this.textBox.SelectedText = "[right]" + this.textBox.SelectedText + "[/right]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 7;
        this.textBox.SelectedText = "[right][/right]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void HyperlinkButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        string str = Interaction.InputBox("Enter URL", "Insert Hyperlink", "http://", 400, 100);
        if (!(str != ""))
          return;
        if (str == "http://" && str.Length == 7)
        {
          int num = this.textBox.SelectionStart + 12;
          this.textBox.SelectedText = "[url=" + str + "]" + this.textBox.SelectedText + "[/url]";
          this.textBox.SelectionStart = num;
        }
        else
        {
          int num = this.textBox.SelectionStart + str.Length + this.textBox.SelectedText.Length + 12;
          this.textBox.SelectedText = "[url=" + str + "]" + this.textBox.SelectedText + "[/url]";
          this.textBox.SelectionStart = num;
        }
      }
      else
      {
        int num = this.textBox.SelectionStart + 5;
        this.textBox.SelectedText = "[url=][/url]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void ImageButton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length == 0)
      {
        string str = Interaction.InputBox("Enter URL", "Insert Hyperlink", "http://", 400, 100);
        if (!(str != ""))
          return;
        if (str == "http://" && str.Length == 7)
        {
          int num = this.textBox.SelectionStart + str.Length + 5;
          this.textBox.SelectedText = "[img]" + str + "[/img]";
          this.textBox.SelectionStart = num;
        }
        else
        {
          int num = this.textBox.SelectionStart + str.Length + 11;
          this.textBox.SelectedText = "[img]" + str + "[/img]";
          this.textBox.SelectionStart = num;
        }
      }
      else
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num1 = (int) MessageBox.Show("You should not select text when inserting image tags." + Environment.NewLine + "The selected text will be placed after the image.", "IMPROPER USAGE", MessageBoxButtons.OK);
        string str = Interaction.InputBox("Enter URL", "Insert Hyperlink", "http://", 400, 100);
        if (!(str != ""))
          return;
        if (str == "http://" && str.Length == 7)
        {
          int num2 = this.textBox.SelectionStart + str.Length + 5;
          this.textBox.SelectedText = "[img]" + str + "[/img]" + Environment.NewLine + this.textBox.SelectedText;
          this.textBox.SelectionStart = num2;
        }
        else
        {
          int num3 = this.textBox.SelectionStart + str.Length + 11;
          this.textBox.SelectedText = "[img]" + str + "[/img]" + Environment.NewLine + this.textBox.SelectedText;
          this.textBox.SelectionStart = num3;
        }
      }
      this.preventUpdate = false;
    }

    private void EmailButton_Click(object sender, EventArgs e)
    {
      if (this.textBox.SelectedText.Length > 0)
      {
        this.textBox.ClearUndo();
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        string str = Interaction.InputBox("Enter Email Address", "Insert Email Address", XPos: 400, YPos: 100);
        if (!(str != ""))
          return;
        int num = this.textBox.SelectionStart + str.Length + this.textBox.SelectedText.Length + 18;
        this.textBox.SelectedText = "[email=\"" + str + "\"]" + this.textBox.SelectedText + "[/email]";
        this.textBox.SelectionStart = num;
        this.preventUpdate = false;
      }
      else
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num = (int) MessageBox.Show("You did not select any text." + Environment.NewLine + "Email tags are only used to mask" + Environment.NewLine + "an address behind a string of text.", "IMPROPER USAGE", MessageBoxButtons.OK);
      }
    }

    private void FontColorButton_Click(object sender, EventArgs e)
    {
      Form1.GlobalClass.GlobalVar = "color";
      this.colorpanel.Visible = true;
      this.colorpanel.BringToFront();
    }

    private void textBox_Click(object sender, EventArgs e)
    {
      if (this.OptionsControlBox.Visible)
      {
        this.OptionsControlBox.Visible = false;
        this.OptionsControlBox.SendToBack();
        this.textBox.Focus();
      }
      if (!this.colorpanel.Visible)
        return;
      this.colorpanel.Visible = false;
      this.colorpanel.SendToBack();
      this.textBox.Focus();
    }

    private void UserFontButton_Click(object sender, EventArgs e)
    {
      FontDialog fontDialog = new FontDialog();
      fontDialog.ShowColor = true;
      fontDialog.Font = this.textBox.Font;
      fontDialog.Color = this.textBox.ForeColor;
      if (fontDialog.ShowDialog() != DialogResult.Cancel)
      {
        this.textBox.Font = fontDialog.Font;
        this.textBox.ForeColor = fontDialog.Color;
      }
      if (!this.OptionsControlBox.Visible)
        return;
      this.OptionsControlBox.Visible = false;
      this.OptionsControlBox.SendToBack();
      this.textBox.Focus();
      this.textBox.SelectionLength = 0;
    }

    private void Blackbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#000000]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#000000][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Siennabutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#A0522D]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#A0522D][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DarkOliveGreenbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#556B2F]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#556B2F][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DarkGreenbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#006400]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#006400][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DarkSlateBluebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#483D8B]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#483D8B][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Navybutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#000080]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#000080][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Indigobutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#4B0082]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#4B0082][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DarkSlateGraybutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#2F4F4F]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#2F4F4F][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DarkRedbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#8B0000]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#8B0000][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DarkOrangebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FF8C00]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FF8C00][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Olivebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#808000]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#808000][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Greenbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#008000]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#008000][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Tealbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#008080]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#008080][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Bluebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#0000FF]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#0000FF][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void SlateGraybutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#708090]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#708090][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DimGraybutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#696969]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#696969][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Redbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FF0000]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FF0000][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void SandyBrownbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#F4A460]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#F4A460][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void YellowGreenbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#9ACD32]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#9ACD32][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void SeaGreenbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#2E8B57]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#2E8B57][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void MediumTurquoisebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#48D1CC]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#48D1CC][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void RoyalBluebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#4169E1]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#4169E1][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Purplebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#800080]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#800080][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Graybutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#808080]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#808080][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Fuchsiabutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FF00FF]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FF00FF][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Orangebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFA500]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFA500][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Yellowbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFFF00]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFFF00][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Limebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#00FF00]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#00FF00][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Cyanbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#00FFFF]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#00FFFF][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DeepSkyBluebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#00BFFF]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#00BFFF][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void DarkOrchidbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#9932CC]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#9932CC][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Silverbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#C0C0C0]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#C0C0C0][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Pinkbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFC0CB]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFC0CB][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Wheatbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#F5DEB3]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#F5DEB3][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void LemonChiffonbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFFACD]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFFACD][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void PaleGreenbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#98FB98]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#98FB98][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void PaleTurquoisebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#AFEEEE]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#AFEEEE][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void LightBluebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#ADD8E6]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#ADD8E6][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Plumbutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#DDA0DD]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#DDA0DD][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void Whitebutton_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + Form1.GlobalClass.GlobalVar.Length + 13 + Form1.GlobalClass.GlobalVar.Length;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFFFFF]" + this.textBox.SelectedText + "[/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + Form1.GlobalClass.GlobalVar.Length + 10;
        this.textBox.SelectedText = "[" + Form1.GlobalClass.GlobalVar + "=#FFFFFF][/" + Form1.GlobalClass.GlobalVar + "]";
        this.textBox.SelectionStart = num;
      }
      this.colorpanel.Visible = false;
      this.textBox.Focus();
      this.preventUpdate = false;
    }

    private void undoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.undoStack.Count > 0)
      {
        int selectionStart = this.textBox.SelectionStart;
        this.preventUpdate = true;
        this.redoStack.Push(this.textBox.Text);
        this.textBox.Text = this.undoStack.Pop();
        this.textBox.SelectionStart = selectionStart;
        this.preventUpdate = false;
        if (this.splitContainer1.Panel2Collapsed)
          return;
        this.previewToolStripMenuItem.PerformClick();
      }
      else
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num = (int) MessageBox.Show("Please accept my apologies. I can't undo that.", "UNDO NOT POSSIBLE", MessageBoxButtons.OK);
      }
    }

    private void redoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.redoStack.Count > 0)
      {
        int selectionStart = this.textBox.SelectionStart;
        this.preventUpdate = true;
        this.undoStack.Push(this.textBox.Text);
        this.textBox.Text = this.redoStack.Pop();
        this.textBox.SelectionStart = selectionStart;
        this.preventUpdate = false;
        if (this.splitContainer1.Panel2Collapsed)
          return;
        this.previewToolStripMenuItem.PerformClick();
      }
      else
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num = (int) MessageBox.Show("There's nothing left to redo.", "REDO NOT POSSIBLE", MessageBoxButtons.OK);
      }
    }

    private void textBox_TextChanged(object sender, EventArgs e)
    {
      if (this.textBox.SelectedText == this.textBox.Text && this.textBox.Text != "" || Control.ModifierKeys == Keys.Control)
        return;
      this.textBox.ClearUndo();
      if (!this.preventUpdate)
        this.undoStack.Push(this.textBox.Text);
      if (this.splitContainer1.Panel2Collapsed)
        return;
      this.previewToolStripMenuItem.PerformClick();
    }

    private void textBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control && e.KeyCode == Keys.W)
      {
        if (this.WordWrapCheckBox.Checked)
        {
          this.textBox.WordWrap = false;
          this.WordWrapCheckBox.Checked = false;
          this.textBox.SelectionLength = 0;
        }
        else
        {
          this.textBox.WordWrap = true;
          this.WordWrapCheckBox.Checked = true;
          this.textBox.SelectionLength = 0;
        }
      }
      if (e.Control && e.KeyCode == Keys.NumPad0)
      {
        Settings.Default.codeon = !Settings.Default.codeon;
        if (!this.splitContainer1.Panel2Collapsed)
          this.PreviewButton.PerformClick();
      }
      if (e.Control && e.KeyCode == Keys.D0)
      {
        Settings.Default.codeon = !Settings.Default.codeon;
        if (!this.splitContainer1.Panel2Collapsed)
          this.PreviewButton.PerformClick();
      }
      if (e.Control && e.KeyCode == Keys.NumPad1)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action1Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.textBox.SelectionLength = 0;
      }
      if (e.Control && e.KeyCode == Keys.NumPad2)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action2Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.NumPad3)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action3Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.NumPad4)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action4Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.NumPad5)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action5Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.D1)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action1Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.textBox.SelectionLength = 0;
      }
      if (e.Control && e.KeyCode == Keys.D2)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action2Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.D3)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action3Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.D4)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action4Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.D5)
      {
        string selectedText = this.textBox.SelectedText;
        int selectionLength = this.textBox.SelectionLength;
        int selectionStart = this.textBox.SelectionStart;
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        CustomCodesDialog customCodesDialog = new CustomCodesDialog();
        customCodesDialog.Show();
        customCodesDialog.StartPosition = FormStartPosition.CenterParent;
        customCodesDialog.Action5Button.PerformClick();
        if (customCodesDialog.DialogResult == DialogResult.OK)
        {
          this.textBox.ClearUndo();
          this.undoStack.Push(this.textBox.Text);
          this.preventUpdate = true;
          this.textBox.SelectedText = customCodesDialog.ResultText;
          this.textBox.SelectionStart = box.Default.tboxStart;
          this.preventUpdate = false;
          customCodesDialog.Close();
          if (!this.splitContainer1.Panel2Collapsed)
            this.previewToolStripMenuItem.PerformClick();
        }
        else
          customCodesDialog.Close();
        box.Default.tbox = selectedText;
        box.Default.tboxLength = selectionLength;
        box.Default.tboxStart = selectionStart;
      }
      if (e.Control && e.KeyCode == Keys.Y)
      {
        this.redoToolStripMenuItem.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.Z)
      {
        this.undoToolStripMenuItem.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.B)
      {
        this.BoldButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.I)
      {
        this.ItalicButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.U)
      {
        this.UnderlineButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.Q)
      {
        this.QuoteButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Alt && e.KeyCode == Keys.C)
      {
        this.CodeButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.L)
      {
        this.ListElementButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.O)
      {
        this.OrderedListButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Alt && e.KeyCode == Keys.U)
      {
        this.UnorderedListButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Alt && e.KeyCode == Keys.Space)
      {
        this.HyperlinkButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Alt && e.KeyCode == Keys.I)
      {
        this.ImageButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Control && e.KeyCode == Keys.E)
      {
        this.EmailButton.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.Alt && e.KeyCode == Keys.P)
      {
        this.previewToolStripMenuItem.PerformClick();
        e.SuppressKeyPress = true;
      }
      if (e.KeyCode == Keys.F && e.Modifiers == (Keys.Control | Keys.Alt))
      {
        FontDialog fontDialog = new FontDialog();
        fontDialog.ShowColor = true;
        fontDialog.Font = this.textBox.Font;
        fontDialog.Color = this.textBox.ForeColor;
        if (fontDialog.ShowDialog() != DialogResult.Cancel)
        {
          this.textBox.Font = fontDialog.Font;
          this.textBox.ForeColor = fontDialog.Color;
          this.textBox.SelectionLength = 0;
        }
      }
      if (e.KeyCode == Keys.LWin && e.Modifiers == Keys.Control)
      {
        this.SpecialCode_toolStripDropDownButton1.ShowDropDown();
        this.BCSpecialsToolStripMenu.Visible = true;
        this.BCSpecialsToolStripMenu.ShowDropDown();
        e.SuppressKeyPress = true;
      }
      if (!e.Control || e.KeyCode != Keys.K)
        return;
      this.keystrokeCombosToolStripMenuItem.PerformClick();
      e.SuppressKeyPress = true;
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this.textBox.TextLength <= 0)
        return;
      MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
      switch (MessageBox.Show((IWin32Window) this, "Save the current text?", "DATA PRESENT!", MessageBoxButtons.YesNoCancel))
      {
        case DialogResult.Cancel:
          e.Cancel = true;
          this.textBox.SelectionLength = 0;
          break;
        case DialogResult.Yes:
          SaveFileDialog saveFileDialog = new SaveFileDialog();
          saveFileDialog.DefaultExt = "*.txt";
          saveFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
          saveFileDialog.FilterIndex = 2;
          saveFileDialog.RestoreDirectory = true;
          if (saveFileDialog.ShowDialog() == DialogResult.OK)
          {
            Stream stream;
            if ((stream = saveFileDialog.OpenFile()) != null)
            {
              using (stream)
              {
                stream.Close();
                File.WriteAllText(saveFileDialog.FileName, this.textBox.Text);
              }
            }
          }
          else
            e.Cancel = true;
          this.textBox.SelectionLength = 0;
          break;
      }
    }

    private void findReplaceDialog1_FindNextClick()
    {
      Control textBox = (Control) this.textBox;
      if (!(textBox is TextBox))
        return;
      this.findReplaceDialog1.FindString((TextBox) textBox);
    }

    private void findReplaceDialog1_SearchFailed(FindReplaceEventArgs eventArguments)
    {
      MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
      int num = (int) MessageBox.Show("Could not find any occurrences of \"" + eventArguments.FindWhat + "\".");
    }

    private void findReplaceDialog1_TextFound(FindReplaceEventArgs eventArguments)
    {
      this.textBox.ScrollToCaret();
    }

    private void findReplaceDialog1_ReplaceClick()
    {
      Control textBox = (Control) this.textBox;
      if (!(textBox is TextBox))
        return;
      this.findReplaceDialog1.ReplaceString((TextBox) textBox, false);
    }

    private void findReplaceDialog1_ReplaceAllClick()
    {
      Control textBox = (Control) this.textBox;
      if (!(textBox is TextBox))
        return;
      this.findReplaceDialog1.ReplaceString((TextBox) textBox, true);
    }

    private void textBox_DragDrop(object sender, DragEventArgs e)
    {
      Path.GetFileNameWithoutExtension("");
      if (this.textBox.Text.Length > 0)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        this.Activate();
        if (MessageBox.Show((IWin32Window) this, "Data currently displayed will be lost. Continue?", "DATA PRESENT!", MessageBoxButtons.YesNo) == DialogResult.No)
          return;
      }
      this.textBox.Clear();
      this.undoStack.Clear();
      this.redoStack.Clear();
      if (!e.Data.GetDataPresent(DataFormats.FileDrop))
        return;
      foreach (string path in (string[]) e.Data.GetData(DataFormats.FileDrop))
      {
        if (File.Exists(path))
        {
          using (TextReader textReader = (TextReader) new StreamReader(path))
          {
            this.textBox.AppendText(textReader.ReadToEnd());
            this.Text = "bbEditor - Editing File: " + Path.GetFileNameWithoutExtension(path);
            this.Activate();
          }
        }
      }
    }

    private void textBox_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop))
        e.Effect = DragDropEffects.Copy;
      else
        e.Effect = DragDropEffects.None;
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.textBox.Text.Length > 0)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        if (MessageBox.Show((IWin32Window) this, "Data currently displayed will be lost. Continue?", "DATA PRESENT!", MessageBoxButtons.YesNo) == DialogResult.No)
        {
          this.textBox.SelectionLength = 0;
          return;
        }
      }
      this.undoStack.Clear();
      this.redoStack.Clear();
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.DefaultExt = "*.txt";
      openFileDialog.Filter = "All Files (*.*)|*.*|Text Documents (*.txt)|*.txt";
      openFileDialog.FilterIndex = 2;
      openFileDialog.RestoreDirectory = true;
      Stream stream;
      if (openFileDialog.ShowDialog() != DialogResult.OK || (stream = openFileDialog.OpenFile()) == null)
        return;
      using (stream)
      {
        string end = new StreamReader(openFileDialog.OpenFile()).ReadToEnd();
        TextBox textBox = new TextBox();
        this.textBox.Text = end;
        this.Text = "bbEditor - Editing File: " + Path.GetFileNameWithoutExtension(openFileDialog.FileName);
        stream.Close();
      }
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.textBox.Text.Length == 0)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        if (MessageBox.Show((IWin32Window) this, "There is nothing in the editor to save.", "NO DATA PRESENT!", MessageBoxButtons.OK) == DialogResult.OK)
        {
          this.textBox.SelectionLength = 0;
          return;
        }
      }
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.DefaultExt = "*.txt";
      saveFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
      saveFileDialog.FilterIndex = 2;
      saveFileDialog.RestoreDirectory = true;
      Stream stream;
      if (saveFileDialog.ShowDialog() != DialogResult.OK || (stream = saveFileDialog.OpenFile()) == null)
        return;
      using (stream)
      {
        stream.Close();
        File.WriteAllText(saveFileDialog.FileName, this.textBox.Text);
        this.Text = "bbEditor - Editing File: " + Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
        this.textBox.SelectionLength = 0;
      }
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

    private int splitpos
    {
      get => this.splitContainer1.SplitterDistance;
      set => this.splitContainer1.SplitterDistance = value;
    }

    private void saveSettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Settings.Default.FormSize = this.Size;
      if (this.KSC.Visible)
        Settings.Default.KSCFrmSize = this.KSC.Size;
      if (this.splitContainer1.Panel2Collapsed)
      {
        Settings.Default.Split1panel2collapsed = true;
        Settings.Default.splitterposition = 275;
      }
      else
      {
        Settings.Default.Split1panel2collapsed = false;
        Settings.Default.splitterposition = this.splitpos;
      }
      Settings.Default.Save();
    }

    private void resetDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DefaultsDialog defaultsDialog = new DefaultsDialog();
      int num = (int) defaultsDialog.ShowDialog();
      if (defaultsDialog.DialogResult == DialogResult.OK)
      {
        if (this.KSC != null)
        {
          this.KSC.Visible = false;
          this.KSC.Hide();
          this.KSC = (KeystrokeCombosDialog) null;
        }
        if (Settings.Default.KSCFrmShow)
        {
          this.KSC = new KeystrokeCombosDialog();
          this.KSC.Visible = true;
          this.KSC.Size = Settings.Default.KSCFrmSize;
          this.KSC.Location = Settings.Default.KSCFrmLocation;
          Settings.Default.KSCFrmEnabled = true;
          Settings.Default.KSCFrmShow = true;
          if (this.WindowState != FormWindowState.Maximized)
            this.textBox.Focus();
        }
        defaultsDialog.Close();
        Settings.Default.Save();
        Settings.Default.Reload();
      }
      else
        defaultsDialog.Close();
    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OptionsControlBox.Visible = true;
      this.OptionsControlBox.BringToFront();
      this.OptionsControlBox.Focus();
    }

    private void findToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.SelectionStart = 0;
      this.textBox.SelectionLength = 0;
      this.findReplaceDialog1.Type = FindReplaceDialogType.Find;
      this.findReplaceDialog1.Show((IWin32Window) this.textBox);
    }

    private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.SelectionStart = 0;
      this.textBox.SelectionLength = 0;
      this.findReplaceDialog1.Type = FindReplaceDialogType.Replace;
      this.findReplaceDialog1.Show((IWin32Window) this.textBox);
    }

    private void previewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.textBox.Text.Length <= 0)
        return;
      string input1 = new Regex(">").Replace(new Regex("<").Replace(this.textBox.Text, "&lt;"), "&gt;");
      string str1;
      if (Settings.Default.codeon)
      {
        for (string str2 = "[code]"; input1.Contains(str2); input1 = new Regex("(.*[\\s\\S]*?)(\\[code\\])(.*?[\\s\\S]*?)(\\[/code\\])(.*[\\s\\S]*)", RegexOptions.IgnoreCase | RegexOptions.Multiline).Replace(input1, "$1<div class=\"drawbox\"><b>Code:</b></div><div class=\"bbe_code\">" + str1 + "</div>$5"))
          str1 = new Regex("\\]").Replace(new Regex("\\[").Replace(new Regex("(.*[\\s\\S]*?\\[code\\])(.*?[\\s\\S]*?)(\\[/code\\].*[\\s\\S]*)", RegexOptions.IgnoreCase | RegexOptions.Multiline).Replace(input1, "$2"), ".bbecode1."), ".bbecode2.");
      }
      else
        input1 = new Regex("\\[/code\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[code\\]", RegexOptions.IgnoreCase).Replace(input1, "<div class=\"drawbox\"><b>Code:</b></div><div class=\"bbe_code\">"), "</div>");
      string str3;
      if (Settings.Default.codeon)
      {
        for (string str4 = "[code=auto:0]"; input1.Contains(str4); input1 = new Regex("(.*[\\s\\S]*?)(\\[code=auto:0\\])(.*?[\\s\\S]*?)(\\[/code\\])(.*[\\s\\S]*)", RegexOptions.IgnoreCase | RegexOptions.Multiline).Replace(input1, "$1<div class=\"drawbox\"><b>Code:</b></div><div class=\"bbe_code\">" + str3 + "</div>$5"))
          str3 = new Regex("\\]").Replace(new Regex("\\[").Replace(new Regex("(.*[\\s\\S]*?\\[code=auto:0\\])(.*?[\\s\\S]*?)(\\[/code\\].*[\\s\\S]*)", RegexOptions.IgnoreCase | RegexOptions.Multiline).Replace(input1, "$2"), ".bbecode1."), ".bbecode2.");
      }
      else
        input1 = new Regex("\\[/code\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[code=auto:0\\]", RegexOptions.IgnoreCase).Replace(input1, "<div class=\"drawbox\"><b>Code:</b></div><div class=\"bbe_code\">"), "</div>");
      string input2 = new Regex("\\[/email\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[email=\"(.+?)\"\\]", RegexOptions.IgnoreCase).Replace(new Regex("(\\[email=\".+?)(@)(.*?\"\\])", RegexOptions.IgnoreCase).Replace(new Regex("\\[/right\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[right\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/center\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[center\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/left\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[left\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/indent\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[indent=5\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[indent=4\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[indent=3\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[indent=2\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[indent=1\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[indent\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/background\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[background=(.+?)\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/overline\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[overline\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[hr\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/spoiler\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[spoiler\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/size\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[size\\=(.+?)\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/color\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[color\\=(.+?)\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[img=(.+?)\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[img\\](.+?)\\[/img\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\<a href=\"\"(.+?)\"\" target=\"_blank\">", RegexOptions.IgnoreCase).Replace(new Regex("\\[/url\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[url\\=(.+?)\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/url\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[url=mailto:(.+?)\\]", RegexOptions.IgnoreCase).Replace(new Regex("(\\[url=mailto:.+?)(@)(.*?\\])", RegexOptions.IgnoreCase).Replace(new Regex("\\[/sup\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[sup\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/sub\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[sub\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/s\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[s\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/u\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[u\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/i\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[i\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/b\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[b\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[\\*\\](.*)", RegexOptions.IgnoreCase).Replace(new Regex("\\[\\*\\](.*)</li>", RegexOptions.IgnoreCase).Replace(new Regex("(\\[\\*\\].*?)\\[/\\*\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/quote\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[quote\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/warn\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[warn\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/reg\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[reg\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/info\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[info\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/caution\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[caution\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/sql\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[sql\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/php\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[php\\]", RegexOptions.IgnoreCase).Replace(input1, "<pre class='prettyprint'>"), "</pre>"), "<pre class=\"prettyprint linenums:0 lang-sql\">"), "</pre>"), "<div class=\"message_box\"><div class=\"mb_title_box caut_title\">Caution! Please read for more information.</div><div class=\"mb_content caut_box\">"), "</div></div>"), "<div class=\"message_box\"><div class=\"mb_title_box info_title\">Useful information!</div><div class=\"mb_content info_box\">"), "</div></div>"), "<div class=\"message_box\"><div class=\"mb_title_box reg_title\">Registry File</div><div class=\"mb_content reg_box\">"), "</div></div>"), "<div class=\"message_box\"><div class=\"mb_title_box warn_title\">Warning! Please read this first.</div><div class=\"mb_content warn_box\">"), "</div></div>"), "<div class=\"drawbox\"><b>Quote:</b></div><div class=\"bbe_quote\">"), "</div>"), "$1</li>"), "<li>$1</li>"), "<li>$1</li>"), "<strong>"), "</strong>"), "<em>"), "</em>"), "<u>"), "</u>"), "<strike>"), "</strike>"), "<sub class='bbe'>"), "</sub>"), "<sup class='bbe'>"), "</sup>"), "$1.bbemail.$3"), "<a href='mailto:$1' title='E-mail Link' class='bbe_email'>"), "</a>"), "<a href=\"$1\" target=\"_blank\">"), "</a>"), "<a href=\"$1\" target=\"_blank\">"), "<img src=\"$1\" />"), "<img src=\"$1\" />"), "<font color=$1>"), "</font>"), "<font size=$1>"), "</font>"), "<span class='spoiler_title'>Spoiler</span> <input type='button' class='bbc_spoiler_show' value='Show' /><div class='bbc_spoiler_wrapper'><div class='bbc_spoiler_content' style=\"display:block;\">"), "</div></div>"), "<div class='bbe_hr'></div>"), "<div style=\"text-decoration: overline;\">"), "</div>"), "<span style='background-color: $1'>"), "</span>"), "<div class=\"bbe_indent\">"), "<div class=\"bbe_indent\">"), "<div class=\"bbe_indent_2\">"), "<div class=\"bbe_indent_3\">"), "<div class=\"bbe_indent_4\">"), "<div class=\"bbe_indent_5\">"), "</div>"), "<div class=\"bbe_left\">"), "</div>"), "<div class=\"bbe_center\">"), "</div>"), "<div class=\"bbe_right\">"), "</div>"), "$1.bbemail.$3"), "<a href='mailto:$1' title='E-mail Link' class='bbe_email'>"), "</a>");
      Regex regex = new Regex("(?(\")(\"[^\"]+?\"@)|(([0-9a-z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9]{2,17}))", RegexOptions.IgnoreCase);
      Match match = regex.Match(input2);
      if (match.Success)
        input2 = regex.Replace(input2, "<a href='mailto:" + (object) match + "' title='E-mail Link' class='bbe_email'>" + (object) match + "</a>");
      string contents1 = new Regex("(<a href=.*?)(\\.bbemail\\.)", RegexOptions.IgnoreCase).Replace(input2, "$1@");
      string tempPath = Path.GetTempPath();
      string str5 = tempPath + "preview.html";
      string path = tempPath + "bbe.tmp";
      File.WriteAllText(path, contents1);
      Stream stream = (Stream) File.OpenRead(path);
      string contents2 = new Regex("</li><br />").Replace(new Regex("\\.bbecode2\\.").Replace(new Regex("\\.bbecode1\\.").Replace(new Regex("\\[/list\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[list\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/list\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[list=1\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[/list\\]", RegexOptions.IgnoreCase).Replace(new Regex("\\[list=square\\]", RegexOptions.IgnoreCase).Replace(new StreamReader(stream).ReadToEnd(), "<ul class='bbe_list' type=square>"), "</ul>"), "<ul class='bbe_list' type=1>"), "</ul>"), "<ul class='bbe_list'>"), "</ul>"), "["), "]").Replace("\r", "").Replace("\n", "<br />"), "</li>");
      if (!this.splitContainer1.Panel2Collapsed)
      {
        using (StreamWriter text = File.CreateText(str5))
          text.WriteLine("<!doctype html><html><head><meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\"><title>bbEditor</title>");
        using (StreamWriter streamWriter = File.AppendText(str5))
        {
          streamWriter.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"./bbestyle.css\">");
          streamWriter.WriteLine("</head>");
          streamWriter.WriteLine("<body>");
          streamWriter.WriteLine("<div id=\"bbe_text\">");
        }
        File.AppendAllText(str5, contents2);
        stream.Close();
        using (StreamWriter streamWriter = File.AppendText(str5))
        {
          streamWriter.WriteLine("</div>");
          streamWriter.WriteLine("</div>");
          streamWriter.WriteLine("</body>");
          streamWriter.WriteLine("</html>");
        }
        this.webBrowser1.Url = new Uri(str5);
      }
      else
      {
        using (StreamWriter text = File.CreateText(str5))
          text.WriteLine("<!doctype html><html><head><meta http-equiv=\"content-type\" content=\"text/html; charset=UTF-8\"><title>bbEditor</title>");
        using (StreamWriter streamWriter = File.AppendText(str5))
        {
          streamWriter.WriteLine("<link rel=\"stylesheet\" type=\"text/css\" href=\"./bbestyle.css\">");
          streamWriter.WriteLine("</head>");
          streamWriter.WriteLine("<body>");
          streamWriter.WriteLine("<div id=\"head\">");
          streamWriter.WriteLine("<span id=\"title\">bbEditor by noahdfear</span>");
          streamWriter.WriteLine("</div>");
          streamWriter.WriteLine("<div id=\"bbe_body\">");
          streamWriter.WriteLine("<p id=\"bbe_header\">Your post preview</p>");
          streamWriter.WriteLine("<div id=\"bbe_text\">");
        }
        File.AppendAllText(str5, contents2);
        stream.Close();
        using (StreamWriter streamWriter = File.AppendText(str5))
        {
          streamWriter.WriteLine("</div>");
          streamWriter.WriteLine("</div>");
          streamWriter.WriteLine("</body>");
          streamWriter.WriteLine("</html>");
        }
        Process.Start(str5);
        this.textBox.Focus();
        this.textBox.SelectionLength = 0;
        this.SendToBack();
      }
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.textBox.TextLength > 0)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        if (MessageBox.Show((IWin32Window) this, "Save the current text?", "DATA PRESENT!", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
          SaveFileDialog saveFileDialog = new SaveFileDialog();
          saveFileDialog.DefaultExt = "*.txt";
          saveFileDialog.Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt";
          saveFileDialog.FilterIndex = 2;
          saveFileDialog.RestoreDirectory = true;
          if (saveFileDialog.ShowDialog() == DialogResult.OK)
          {
            Stream stream;
            if ((stream = saveFileDialog.OpenFile()) == null)
              return;
            using (stream)
            {
              stream.Close();
              File.WriteAllText(saveFileDialog.FileName, this.textBox.Text);
              this.textBox.Clear();
              this.Text = "bbEditor";
            }
          }
          else
            this.textBox.SelectionLength = 0;
        }
        else
        {
          this.textBox.Clear();
          this.Text = "bbEditor";
        }
      }
      else
      {
        this.textBox.Clear();
        this.Text = "bbEditor";
      }
    }

    private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.SelectAll();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.textBox.SelectionLength <= 0)
        return;
      this.textBox.Copy();
    }

    private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
        return;
      if (this.textBox.SelectionLength > 0)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        if (MessageBox.Show("Do you want to paste over current selection?", "Text Selected!", MessageBoxButtons.YesNo) == DialogResult.No)
          return;
      }
      this.textBox.SelectedText = "";
      this.textBox.Paste();
    }

    private void cutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!(this.textBox.SelectedText != ""))
        return;
      this.textBox.Cut();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int num = (int) new AboutBox().ShowDialog();
    }

    private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string fileName = "";
      Version version = (Version) null;
      string url = "http://noahdfear.net/bbEditor/update.xml";
      XmlTextReader xmlTextReader = (XmlTextReader) null;
      try
      {
        xmlTextReader = new XmlTextReader(url);
        int content = (int) xmlTextReader.MoveToContent();
        string str = "";
        if (xmlTextReader.NodeType == XmlNodeType.Element)
        {
          if (xmlTextReader.Name == "bbEditor")
          {
            while (xmlTextReader.Read())
            {
              if (xmlTextReader.NodeType == XmlNodeType.Element)
                str = xmlTextReader.Name;
              else if (xmlTextReader.NodeType == XmlNodeType.Text && xmlTextReader.HasValue)
              {
                switch (str)
                {
                  case "version":
                    version = new Version(xmlTextReader.Value);
                    continue;
                  case "url":
                    fileName = xmlTextReader.Value;
                    continue;
                  default:
                    continue;
                }
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num = (int) MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
        return;
      }
      finally
      {
        xmlTextReader?.Close();
      }
      if (Assembly.GetExecutingAssembly().GetName().Version.CompareTo(version) < 0)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        if (MessageBox.Show("Version " + (object) version.Major + "." + (object) version.Minor + "." + (object) version.Build + "." + (object) version.Revision + " of bbEditor is available. Would you like to download it?", "Update available", MessageBoxButtons.YesNo) != DialogResult.Yes)
          return;
        string filePath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
        string path = new Regex("(.*noahdfear_tools)(.*)(user.config)", RegexOptions.IgnoreCase).Replace(filePath, "$1\\$3.bbe");
        if (File.Exists(path))
        {
          if (MessageBox.Show("Your User Settings backup was created on " + Environment.NewLine + (object) File.GetLastWriteTime(path) + Environment.NewLine + "Would you like to create a new backup before updating?", "Backup Present", MessageBoxButtons.YesNo) != DialogResult.No)
          {
            using (FileStream fileStream = File.Create(path))
              fileStream.Close();
            if (!File.Exists(filePath))
            {
              Settings.Default.Save();
              if (!File.Exists(filePath))
              {
                int num = (int) MessageBox.Show("Unable to create user.config", "ERROR", MessageBoxButtons.OK);
                return;
              }
            }
            string end = new StreamReader((Stream) File.OpenRead(filePath)).ReadToEnd();
            File.WriteAllText(path, end);
            if (File.Exists(path))
            {
              int num1 = (int) MessageBox.Show("User settings backed up to:" + Environment.NewLine + path, "BACKUP SUCCESSFUL", MessageBoxButtons.OK);
            }
            else
            {
              int num2 = (int) MessageBox.Show("User settings backup unsuccessful.", "ERROR", MessageBoxButtons.OK);
            }
          }
        }
        else
          this.backupUserSettingsToolStripMenuItem.PerformClick();
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num3 = (int) MessageBox.Show("bbEditor needs to close to be overwritten." + Environment.NewLine + "Save the download to the same location it is now" + Environment.NewLine + "and allow it to overwrite. Restart it when download completes.", "Closing application", MessageBoxButtons.OK);
        Process.Start(fileName);
        Environment.Exit(1);
      }
      else
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num = (int) MessageBox.Show("Congratulations! You have the latest version.", "bbEditor is up to date", MessageBoxButtons.OK);
      }
    }

    private void BackgroundcolorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Form1.GlobalClass.GlobalVar = "background";
      this.colorpanel.Visible = true;
      this.colorpanel.BringToFront();
    }

    private void HorizontalRuleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + 4;
        this.textBox.SelectedText = "[hr]" + this.textBox.SelectedText;
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 4;
        this.textBox.SelectedText = "[hr]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void OverlineToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 21;
        this.textBox.SelectedText = "[overline]" + this.textBox.SelectedText + "[/overline]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 10;
        this.textBox.SelectedText = "[overline][/overline]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void phpToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 11;
        this.textBox.SelectedText = "[php]" + this.textBox.SelectedText + "[/php]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 5;
        this.textBox.SelectedText = "[php][/php]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void SQL_ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 11;
        this.textBox.SelectedText = "[sql]" + this.textBox.SelectedText + "[/sql]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 5;
        this.textBox.SelectedText = "[sql][/sql]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void SpoilerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 19;
        this.textBox.SelectedText = "[spoiler]" + this.textBox.SelectedText + "[/spoiler]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 9;
        this.textBox.SelectedText = "[spoiler][/spoiler]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 7;
        this.textBox.SelectedText = "[s]" + this.textBox.SelectedText + "[/s]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 3;
        this.textBox.SelectedText = "[s][/s]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void subscriptToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 11;
        this.textBox.SelectedText = "[sub]" + this.textBox.SelectedText + "[/sub]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 5;
        this.textBox.SelectedText = "[sub][/sub]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void superscriptToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 11;
        this.textBox.SelectedText = "[sup]" + this.textBox.SelectedText + "[/sup]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 5;
        this.textBox.SelectedText = "[sup][/sup]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void indent1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 17;
        this.textBox.SelectedText = "[indent]" + this.textBox.SelectedText + "[/indent]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 8;
        this.textBox.SelectedText = "[indent][/indent]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void indent2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 19;
        this.textBox.SelectedText = "[indent=2]" + this.textBox.SelectedText + "[/indent]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 10;
        this.textBox.SelectedText = "[indent=2][/indent]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void indent3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 19;
        this.textBox.SelectedText = "[indent=3]" + this.textBox.SelectedText + "[/indent]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 10;
        this.textBox.SelectedText = "[indent=3][/indent]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void indent4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 19;
        this.textBox.SelectedText = "[indent=4]" + this.textBox.SelectedText + "[/indent]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 10;
        this.textBox.SelectedText = "[indent=4][/indent]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void indent5ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 19;
        this.textBox.SelectedText = "[indent=5]" + this.textBox.SelectedText + "[/indent]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 10;
        this.textBox.SelectedText = "[indent=5][/indent]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void listElementCloseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.textBox.Text.Length <= 0)
        return;
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      this.textBox.SelectAll();
      this.textBox.SelectedText = new Regex("(\\[/list\\].*?)\\[/\\*\\]", RegexOptions.IgnoreCase | RegexOptions.Multiline).Replace(new Regex("(\\[\\*\\].*)\r*$", RegexOptions.IgnoreCase | RegexOptions.Multiline).Replace(new Regex("\\[/\\*\\]", RegexOptions.IgnoreCase | RegexOptions.Multiline).Replace(this.textBox.SelectedText, ""), "$1[/*]\r"), "[/*]$1");
      this.textBox.SelectionLength = 0;
      this.preventUpdate = false;
    }

    private void RemoveCodeButton_Click(object sender, EventArgs e)
    {
      int selectionStart = this.textBox.SelectionStart;
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      this.textBox.SelectAll();
      this.textBox.SelectedText = Regex.Replace(this.textBox.SelectedText, "\\[.*?\\]", string.Empty);
      this.textBox.SelectionStart = selectionStart;
      this.textBox.SelectionLength = 0;
      this.preventUpdate = false;
    }

    private void newIPBEmailToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.textBox.SelectedText.Length > 0)
      {
        this.textBox.ClearUndo();
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        string str = Interaction.InputBox("Enter Email Address", "Insert Email Address", XPos: 400, YPos: 100);
        if (!(str != ""))
          return;
        int num = this.textBox.SelectionStart + str.Length + this.textBox.SelectedText.Length + 19;
        this.textBox.SelectedText = "[url=mailto:" + str + "]" + this.textBox.SelectedText + "[/url]";
        this.textBox.SelectionStart = num;
        this.preventUpdate = false;
      }
      else
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num = (int) MessageBox.Show("You did not select any text." + Environment.NewLine + "Email tags are only used to mask" + Environment.NewLine + "an address behind a string of text.", "IMPROPER USAGE", MessageBoxButtons.OK);
      }
    }

    private void listSquareBulletToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      int selectionStart = this.textBox.SelectionStart;
      this.preventUpdate = true;
      this.textBox.SelectedText = new Regex("(\\[\\*\\])((\\[list.*?\\])+)", RegexOptions.IgnoreCase).Replace(new Regex("\\[\\*\\]\\[/").Replace(new Regex("\\[\\*\\]\r\n").Replace(new Regex("\\[\\*\\]\\s+\r\n").Replace("[list=square][*]" + new Regex("\r\n(.*?)").Replace(new Regex("\\[\\*\\](.*?)").Replace(this.textBox.SelectedText, "$1"), "\r\n[*]$1") + "[/list]", "[*]\r\n"), "\r\n"), "[/"), "$2$1");
      this.textBox.SelectionStart = selectionStart;
      this.preventUpdate = false;
    }

    private void useSplitScreenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.splitContainer1.Panel2Collapsed)
      {
        this.splitContainer1.Panel2Collapsed = false;
        this.webBrowser1.Navigate("about:blank");
        this.previewToolStripMenuItem.PerformClick();
      }
      else
        this.splitContainer1.Panel2Collapsed = true;
      Settings.Default.Split1panel2collapsed = this.splitContainer1.Panel2Collapsed;
    }

    private void cautionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 19;
        this.textBox.SelectedText = "[caution]" + this.textBox.SelectedText + "[/caution]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 9;
        this.textBox.SelectedText = "[caution][/caution]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void infoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 13;
        this.textBox.SelectedText = "[info]" + this.textBox.SelectedText + "[/info]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 6;
        this.textBox.SelectedText = "[info][/info]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void regToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 11;
        this.textBox.SelectedText = "[reg]" + this.textBox.SelectedText + "[/reg]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 5;
        this.textBox.SelectedText = "[reg][/reg]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void warnToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.textBox.ClearUndo();
      this.undoStack.Push(this.textBox.Text);
      this.preventUpdate = true;
      if (this.textBox.SelectedText.Length > 0)
      {
        int num = this.textBox.SelectionStart + this.textBox.SelectedText.Length + 13;
        this.textBox.SelectedText = "[warn]" + this.textBox.SelectedText + "[/warn]";
        this.textBox.SelectionStart = num;
      }
      else
      {
        int num = this.textBox.SelectionStart + 6;
        this.textBox.SelectedText = "[warn][/warn]";
        this.textBox.SelectionStart = num;
      }
      this.preventUpdate = false;
    }

    private void WordWrapCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      if (this.WordWrapCheckBox.Checked)
      {
        this.textBox.WordWrap = true;
        this.textBox.SelectionLength = 0;
      }
      else
      {
        this.textBox.WordWrap = false;
        this.textBox.SelectionLength = 0;
      }
    }

    private void customCodesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string selectedText = this.textBox.SelectedText;
      int selectionLength = this.textBox.SelectionLength;
      int selectionStart = this.textBox.SelectionStart;
      box.Default.tbox = selectedText;
      box.Default.tboxLength = selectionLength;
      box.Default.tboxStart = selectionStart;
      CustomCodesDialog customCodesDialog = new CustomCodesDialog();
      int num = (int) customCodesDialog.ShowDialog();
      if (customCodesDialog.DialogResult == DialogResult.OK)
      {
        this.textBox.ClearUndo();
        this.undoStack.Push(this.textBox.Text);
        this.preventUpdate = true;
        this.textBox.SelectedText = customCodesDialog.ResultText;
        this.textBox.SelectionStart = box.Default.tboxStart;
        this.preventUpdate = false;
        customCodesDialog.Close();
      }
      else
        customCodesDialog.Close();
      box.Default.tbox = selectedText;
      box.Default.tboxLength = selectionLength;
      box.Default.tboxStart = selectionStart;
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
      string str = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      if (!(Settings.Default.ApplicationVersion != str))
        return;
      Settings.Default.Upgrade();
      Settings.Default.Reload();
      Settings.Default.ApplicationVersion = str;
      Settings.Default.Save();
      CustomCodes.Default.Upgrade();
      CustomCodes.Default.Reload();
      CustomCodes.Default.Save();
      box.Default.Upgrade();
      box.Default.Reload();
      box.Default.Save();
    }

    private void backupUserSettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string filePath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
      if (!File.Exists(filePath))
        this.saveSettingsToolStripMenuItem.PerformClick();
      string path = new Regex("(.*noahdfear_tools)(.*)(user.config)", RegexOptions.IgnoreCase).Replace(filePath, "$1\\$3.bbe");
      if (File.Exists(path) && MessageBox.Show("A backup already exists! Overwrite?", "WARNING! BACKUP PRESENT", MessageBoxButtons.YesNo) == DialogResult.No)
        return;
      using (FileStream fileStream = File.Create(path))
        fileStream.Close();
      string end = new StreamReader((Stream) File.OpenRead(filePath)).ReadToEnd();
      File.WriteAllText(path, end);
      if (File.Exists(path))
      {
        int num1 = (int) MessageBox.Show("User settings backed up to:" + Environment.NewLine + path, "BACKUP SUCCESSFUL", MessageBoxButtons.OK);
      }
      else
      {
        int num2 = (int) MessageBox.Show("User settings backup unsuccessful.", "ERROR", MessageBoxButtons.OK);
      }
    }

    private void restoreBackupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string filePath = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
      string path = new Regex("(.*noahdfear_tools)(.*)(user.config)", RegexOptions.IgnoreCase).Replace(filePath, "$1\\$3.bbe");
      if (!File.Exists(path))
      {
        if (MessageBox.Show("A backup was not found." + Environment.NewLine + "Would you like to browse for one?", "ERROR", MessageBoxButtons.YesNo) == DialogResult.No)
          return;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
        openFileDialog.DefaultExt = ".config.bbe";
        openFileDialog.Filter = "config backup files (*.bbe)|*.bbe";
        openFileDialog.Multiselect = false;
        openFileDialog.RestoreDirectory = false;
        Stream stream;
        if (openFileDialog.ShowDialog() == DialogResult.OK && (stream = openFileDialog.OpenFile()) != null)
        {
          using (stream)
          {
            StreamReader streamReader = new StreamReader(openFileDialog.OpenFile());
            if (!File.Exists(path))
            {
              using (FileStream fileStream = File.Create(path))
                fileStream.Close();
            }
            string end = streamReader.ReadToEnd();
            if (!File.Exists(filePath))
            {
              Settings.Default.Save();
              if (!File.Exists(filePath))
              {
                int num = (int) MessageBox.Show("Unable to create user.config", "ERROR", MessageBoxButtons.OK);
                return;
              }
            }
            File.WriteAllText(filePath, end);
            stream.Close();
          }
        }
      }
      else
      {
        Stream stream = (Stream) File.OpenRead(path);
        string end = new StreamReader(stream).ReadToEnd();
        if (!File.Exists(filePath))
        {
          Settings.Default.Save();
          if (!File.Exists(filePath))
          {
            int num = (int) MessageBox.Show("Unable to create user.config", "ERROR", MessageBoxButtons.OK);
            return;
          }
        }
        File.WriteAllText(filePath, end);
        stream.Close();
      }
      Settings.Default.ApplicationVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      Settings.Default.Reload();
      Settings.Default.Save();
      CustomCodes.Default.Reload();
      box.Default.Reload();
    }

    private void codeOnOffToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Settings.Default.codeon = !Settings.Default.codeon;
      if (this.splitContainer1.Panel2Collapsed)
        return;
      this.PreviewButton.PerformClick();
    }

    private void enhancedCaretToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Settings.Default.eCaret == 0)
      {
        Form1.CreateCaret(this.textBox.Handle, IntPtr.Zero, 5, 20);
        Form1.ShowCaret(this.textBox.Handle);
        Settings.Default.eCaret = 5;
      }
      else
      {
        Form1.CreateCaret(this.textBox.Handle, IntPtr.Zero, 0, 20);
        Form1.ShowCaret(this.textBox.Handle);
        Settings.Default.eCaret = 0;
      }
    }

    private void keystrokeCombosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.KSC == null)
      {
        this.KSC = new KeystrokeCombosDialog();
        this.KSC.Visible = true;
        this.KSC.Size = Settings.Default.KSCFrmSize;
        this.KSC.Location = Settings.Default.KSCFrmLocation;
        Settings.Default.KSCFrmEnabled = true;
        Settings.Default.KSCFrmShow = true;
        this.KSC.Show();
        if (this.WindowState == FormWindowState.Maximized)
          return;
        this.textBox.Focus();
      }
      else
      {
        this.KSC.Visible = false;
        this.KSC.Hide();
        this.KSC = (KeystrokeCombosDialog) null;
        Settings.Default.KSCFrmEnabled = false;
        Settings.Default.KSCFrmShow = false;
      }
    }

    private static class GlobalClass
    {
      private static string m_globalVar = "";

      public static string GlobalVar
      {
        get => Form1.GlobalClass.m_globalVar;
        set => Form1.GlobalClass.m_globalVar = value;
      }
    }
  }
}
