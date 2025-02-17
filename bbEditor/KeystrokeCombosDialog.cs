// Decompiled with JetBrains decompiler
// Type: bbEditor.KeystrokeCombosDialog
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using bbEditor.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace bbEditor
{
  public class KeystrokeCombosDialog : Form
  {
    private IContainer components;
    private TextBox Frm2textBox;
    private FontDialog fontDialog1;
    private KeystrokeCombosDialog KSC;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (KeystrokeCombosDialog));
      this.Frm2textBox = new TextBox();
      this.fontDialog1 = new FontDialog();
      this.SuspendLayout();
      this.Frm2textBox.BackColor = Color.Wheat;
      this.Frm2textBox.Cursor = Cursors.IBeam;
      this.Frm2textBox.DataBindings.Add(new Binding("Font", (object) Settings.Default, "KSCFrmFont", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Frm2textBox.DataBindings.Add(new Binding("ForeColor", (object) Settings.Default, "KSCFrmFontColor", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Frm2textBox.Dock = DockStyle.Fill;
      this.Frm2textBox.Font = Settings.Default.KSCFrmFont;
      this.Frm2textBox.ForeColor = Settings.Default.KSCFrmFontColor;
      this.Frm2textBox.Location = new Point(0, 0);
      this.Frm2textBox.Multiline = true;
      this.Frm2textBox.Name = "Frm2textBox";
      this.Frm2textBox.ReadOnly = true;
      this.Frm2textBox.ScrollBars = ScrollBars.Both;
      this.Frm2textBox.ShortcutsEnabled = false;
      this.Frm2textBox.Size = new Size(260, 602);
      this.Frm2textBox.TabIndex = 1;
      this.Frm2textBox.TabStop = false;
      this.Frm2textBox.Text = componentResourceManager.GetString("Frm2textBox.Text");
      this.Frm2textBox.WordWrap = false;
      this.Frm2textBox.KeyDown += new KeyEventHandler(this.Frm2textBox_KeyDown);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(260, 602);
      this.ControlBox = false;
      this.Controls.Add((Control) this.Frm2textBox);
      this.DataBindings.Add(new Binding("Enabled", (object) Settings.Default, "KSCFrmEnabled", true, DataSourceUpdateMode.OnPropertyChanged));
      this.DataBindings.Add(new Binding("Location", (object) Settings.Default, "KSCFrmLocation", true, DataSourceUpdateMode.OnPropertyChanged));
      this.Enabled = Settings.Default.KSCFrmEnabled;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Location = Settings.Default.KSCFrmLocation;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (KeystrokeCombosDialog);
      this.Text = "Keystroke Combinations";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public KeystrokeCombosDialog() => this.InitializeComponent();

    private void Frm2textBox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F || e.Modifiers != (Keys.Control | Keys.Alt))
        return;
      FontDialog fontDialog = new FontDialog();
      fontDialog.ShowColor = true;
      fontDialog.Font = this.Frm2textBox.Font;
      fontDialog.Color = this.Frm2textBox.ForeColor;
      if (fontDialog.ShowDialog() == DialogResult.Cancel)
        return;
      this.Frm2textBox.Font = fontDialog.Font;
      this.Frm2textBox.ForeColor = fontDialog.Color;
      this.Frm2textBox.SelectionLength = 0;
    }
  }
}
