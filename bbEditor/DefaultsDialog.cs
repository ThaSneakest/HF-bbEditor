// Decompiled with JetBrains decompiler
// Type: bbEditor.DefaultsDialog
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using bbEditor.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace bbEditor
{
  public class DefaultsDialog : Form
  {
    private IContainer components;
    private Label DDlabel1;
    private CheckBox caretCheckbox;
    private Label label1;
    private CheckBox codeCheckbox;
    private Label label2;
    private CheckBox fontCheckbox;
    private Label label3;
    private CheckBox fontColorCheckbox;
    private Label label4;
    private CheckBox locationCheckbox;
    private Label label5;
    private CheckBox splitscreenCheckbox;
    private Label label6;
    private CheckBox splitscreenPositionCheckbox;
    private Label label7;
    private CheckBox sizeCheckbox;
    private Label label8;
    private Button ResetDefaultsButton;
    private Button CancelResetButton;
    private Label DDlabel2;
    private CheckBox KSCFontCheckbox;
    private Label label9;
    private CheckBox KSCFontColorCheckbox;
    private Label label10;
    private CheckBox KSCLocationCheckbox;
    private Label label11;
    private CheckBox KSCSizeCheckbox;
    private Label label12;
    private CheckBox KSCVisibleCheckbox;
    private Label label13;

    public DefaultsDialog() => this.InitializeComponent();

    private void ResetDefaultsButton_Click(object sender, EventArgs e)
    {
      if (this.caretCheckbox.Checked)
        Settings.Default.eCaret = Defaults.Default.eCaret;
      if (this.codeCheckbox.Checked)
      {
        Settings.Default.codeon = Defaults.Default.codeon;
        if (!this.splitscreenCheckbox.Checked && !((Form1) this.ParentForm).splitContainer1.Panel2Collapsed)
          ((Form1) this.ParentForm).PreviewButton.PerformClick();
      }
      if (this.fontCheckbox.Checked)
        Settings.Default.Fstyle = Defaults.Default.Fstyle;
      if (this.fontColorCheckbox.Checked)
        Settings.Default.Fcolor = Defaults.Default.Fcolor;
      if (this.locationCheckbox.Checked)
        Settings.Default.FormLocation = Defaults.Default.FormLocation;
      if (this.splitscreenCheckbox.Checked)
        Settings.Default.Split1panel2collapsed = Defaults.Default.Split1panel2collapsed;
      if (this.splitscreenPositionCheckbox.Checked)
        Settings.Default.splitterposition = Defaults.Default.splitterposition;
      if (this.sizeCheckbox.Checked)
        Settings.Default.FormSize = Defaults.Default.FormSize;
      if (this.KSCFontCheckbox.Checked)
        Settings.Default.KSCFrmFont = Defaults.Default.KSCFrmFont;
      if (this.KSCFontColorCheckbox.Checked)
        Settings.Default.KSCFrmFontColor = Defaults.Default.KSCFrmFontColor;
      if (this.KSCLocationCheckbox.Checked)
        Settings.Default.KSCFrmLocation = Defaults.Default.KSCFrmLocation;
      if (this.KSCSizeCheckbox.Checked)
        Settings.Default.KSCFrmSize = Defaults.Default.KSCFrmSize;
      if (this.KSCVisibleCheckbox.Checked)
      {
        Settings.Default.KSCFrmEnabled = Defaults.Default.KSCFrmEnabled;
        Settings.Default.KSCFrmShow = Defaults.Default.KSCFrmShow;
      }
      this.ResetDefaultsButton.DialogResult = DialogResult.OK;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.DDlabel1 = new Label();
      this.caretCheckbox = new CheckBox();
      this.label1 = new Label();
      this.codeCheckbox = new CheckBox();
      this.label2 = new Label();
      this.fontCheckbox = new CheckBox();
      this.label3 = new Label();
      this.fontColorCheckbox = new CheckBox();
      this.label4 = new Label();
      this.locationCheckbox = new CheckBox();
      this.label5 = new Label();
      this.splitscreenCheckbox = new CheckBox();
      this.label6 = new Label();
      this.splitscreenPositionCheckbox = new CheckBox();
      this.label7 = new Label();
      this.sizeCheckbox = new CheckBox();
      this.label8 = new Label();
      this.ResetDefaultsButton = new Button();
      this.CancelResetButton = new Button();
      this.DDlabel2 = new Label();
      this.KSCFontCheckbox = new CheckBox();
      this.label9 = new Label();
      this.KSCFontColorCheckbox = new CheckBox();
      this.label10 = new Label();
      this.KSCLocationCheckbox = new CheckBox();
      this.label11 = new Label();
      this.KSCSizeCheckbox = new CheckBox();
      this.label12 = new Label();
      this.KSCVisibleCheckbox = new CheckBox();
      this.label13 = new Label();
      this.SuspendLayout();
      this.DDlabel1.Font = new Font("Tahoma", 11.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.DDlabel1.Location = new Point(16, 11);
      this.DDlabel1.Margin = new Padding(4, 0, 4, 0);
      this.DDlabel1.Name = "DDlabel1";
      this.DDlabel1.Size = new Size(160, 28);
      this.DDlabel1.TabIndex = 1;
      this.DDlabel1.Text = "Editor Settings";
      this.caretCheckbox.AutoSize = true;
      this.caretCheckbox.Location = new Point(12, 49);
      this.caretCheckbox.Margin = new Padding(4);
      this.caretCheckbox.Name = "caretCheckbox";
      this.caretCheckbox.Size = new Size(15, 14);
      this.caretCheckbox.TabIndex = 2;
      this.caretCheckbox.UseVisualStyleBackColor = true;
      this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(53, 49);
      this.label1.Margin = new Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(47, 16);
      this.label1.TabIndex = 16;
      this.label1.Text = "Caret";
      this.codeCheckbox.AutoSize = true;
      this.codeCheckbox.Location = new Point(12, 80);
      this.codeCheckbox.Margin = new Padding(4);
      this.codeCheckbox.Name = "codeCheckbox";
      this.codeCheckbox.Size = new Size(15, 14);
      this.codeCheckbox.TabIndex = 17;
      this.codeCheckbox.UseVisualStyleBackColor = true;
      this.label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(53, 80);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(101, 16);
      this.label2.TabIndex = 18;
      this.label2.Text = "Code Parsing";
      this.fontCheckbox.AutoSize = true;
      this.fontCheckbox.Location = new Point(12, 111);
      this.fontCheckbox.Margin = new Padding(4);
      this.fontCheckbox.Name = "fontCheckbox";
      this.fontCheckbox.Size = new Size(15, 14);
      this.fontCheckbox.TabIndex = 19;
      this.fontCheckbox.UseVisualStyleBackColor = true;
      this.label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(53, 111);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(47, 16);
      this.label3.TabIndex = 20;
      this.label3.Text = "Font";
      this.fontColorCheckbox.AutoSize = true;
      this.fontColorCheckbox.Location = new Point(12, 142);
      this.fontColorCheckbox.Margin = new Padding(4);
      this.fontColorCheckbox.Name = "fontColorCheckbox";
      this.fontColorCheckbox.Size = new Size(15, 14);
      this.fontColorCheckbox.TabIndex = 21;
      this.fontColorCheckbox.UseVisualStyleBackColor = true;
      this.label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(53, 142);
      this.label4.Margin = new Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new Size(79, 16);
      this.label4.TabIndex = 22;
      this.label4.Text = "Font Color";
      this.locationCheckbox.AutoSize = true;
      this.locationCheckbox.Location = new Point(12, 172);
      this.locationCheckbox.Margin = new Padding(4);
      this.locationCheckbox.Name = "locationCheckbox";
      this.locationCheckbox.Size = new Size(15, 14);
      this.locationCheckbox.TabIndex = 23;
      this.locationCheckbox.UseVisualStyleBackColor = true;
      this.label5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(53, 172);
      this.label5.Margin = new Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new Size(79, 16);
      this.label5.TabIndex = 24;
      this.label5.Text = "Location";
      this.splitscreenCheckbox.AutoSize = true;
      this.splitscreenCheckbox.Location = new Point(12, 203);
      this.splitscreenCheckbox.Margin = new Padding(4);
      this.splitscreenCheckbox.Name = "splitscreenCheckbox";
      this.splitscreenCheckbox.Size = new Size(15, 14);
      this.splitscreenCheckbox.TabIndex = 25;
      this.splitscreenCheckbox.UseVisualStyleBackColor = true;
      this.label6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(53, 203);
      this.label6.Margin = new Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new Size(97, 16);
      this.label6.TabIndex = 26;
      this.label6.Text = "Split Screen";
      this.splitscreenPositionCheckbox.AutoSize = true;
      this.splitscreenPositionCheckbox.Location = new Point(12, 234);
      this.splitscreenPositionCheckbox.Margin = new Padding(4);
      this.splitscreenPositionCheckbox.Name = "splitscreenPositionCheckbox";
      this.splitscreenPositionCheckbox.Size = new Size(15, 14);
      this.splitscreenPositionCheckbox.TabIndex = 27;
      this.splitscreenPositionCheckbox.UseVisualStyleBackColor = true;
      this.label7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(53, 234);
      this.label7.Margin = new Padding(4, 0, 4, 0);
      this.label7.Name = "label7";
      this.label7.Size = new Size(143, 16);
      this.label7.TabIndex = 28;
      this.label7.Text = "Split Screen Position";
      this.sizeCheckbox.AutoSize = true;
      this.sizeCheckbox.Location = new Point(12, 265);
      this.sizeCheckbox.Margin = new Padding(4);
      this.sizeCheckbox.Name = "sizeCheckbox";
      this.sizeCheckbox.Size = new Size(15, 14);
      this.sizeCheckbox.TabIndex = 29;
      this.sizeCheckbox.UseVisualStyleBackColor = true;
      this.label8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(53, 265);
      this.label8.Margin = new Padding(4, 0, 4, 0);
      this.label8.Name = "label8";
      this.label8.Size = new Size(47, 16);
      this.label8.TabIndex = 30;
      this.label8.Text = "Size";
      this.ResetDefaultsButton.Cursor = Cursors.Hand;
      this.ResetDefaultsButton.DialogResult = DialogResult.OK;
      this.ResetDefaultsButton.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
      this.ResetDefaultsButton.ForeColor = SystemColors.ControlText;
      this.ResetDefaultsButton.Location = new Point(43, 508);
      this.ResetDefaultsButton.Margin = new Padding(4);
      this.ResetDefaultsButton.Name = "ResetDefaultsButton";
      this.ResetDefaultsButton.Size = new Size(89, 25);
      this.ResetDefaultsButton.TabIndex = 31;
      this.ResetDefaultsButton.Text = "Reset";
      this.ResetDefaultsButton.TextImageRelation = TextImageRelation.TextBeforeImage;
      this.ResetDefaultsButton.UseVisualStyleBackColor = true;
      this.ResetDefaultsButton.Click += new EventHandler(this.ResetDefaultsButton_Click);
      this.CancelResetButton.Cursor = Cursors.Hand;
      this.CancelResetButton.DialogResult = DialogResult.Cancel;
      this.CancelResetButton.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold);
      this.CancelResetButton.Location = new Point(172, 508);
      this.CancelResetButton.Margin = new Padding(4);
      this.CancelResetButton.Name = "CancelResetButton";
      this.CancelResetButton.Size = new Size(89, 25);
      this.CancelResetButton.TabIndex = 32;
      this.CancelResetButton.Text = "Cancel";
      this.CancelResetButton.TextImageRelation = TextImageRelation.ImageBeforeText;
      this.CancelResetButton.UseVisualStyleBackColor = true;
      this.DDlabel2.Font = new Font("Tahoma", 11.25f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
      this.DDlabel2.Location = new Point(16, 311);
      this.DDlabel2.Margin = new Padding(4, 0, 4, 0);
      this.DDlabel2.Name = "DDlabel2";
      this.DDlabel2.Size = new Size(269, 28);
      this.DDlabel2.TabIndex = 33;
      this.DDlabel2.Text = "Keystroke Combo Dialog Settings";
      this.KSCFontCheckbox.AutoSize = true;
      this.KSCFontCheckbox.Location = new Point(12, 351);
      this.KSCFontCheckbox.Margin = new Padding(4);
      this.KSCFontCheckbox.Name = "KSCFontCheckbox";
      this.KSCFontCheckbox.Size = new Size(15, 14);
      this.KSCFontCheckbox.TabIndex = 34;
      this.KSCFontCheckbox.UseVisualStyleBackColor = true;
      this.label9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(53, 351);
      this.label9.Margin = new Padding(4, 0, 4, 0);
      this.label9.Name = "label9";
      this.label9.Size = new Size(47, 16);
      this.label9.TabIndex = 35;
      this.label9.Text = "Font";
      this.KSCFontColorCheckbox.AutoSize = true;
      this.KSCFontColorCheckbox.Location = new Point(12, 382);
      this.KSCFontColorCheckbox.Margin = new Padding(4);
      this.KSCFontColorCheckbox.Name = "KSCFontColorCheckbox";
      this.KSCFontColorCheckbox.Size = new Size(15, 14);
      this.KSCFontColorCheckbox.TabIndex = 36;
      this.KSCFontColorCheckbox.UseVisualStyleBackColor = true;
      this.label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(53, 382);
      this.label10.Margin = new Padding(4, 0, 4, 0);
      this.label10.Name = "label10";
      this.label10.Size = new Size(79, 16);
      this.label10.TabIndex = 37;
      this.label10.Text = "Font Color";
      this.KSCLocationCheckbox.AutoSize = true;
      this.KSCLocationCheckbox.Location = new Point(12, 412);
      this.KSCLocationCheckbox.Margin = new Padding(4);
      this.KSCLocationCheckbox.Name = "KSCLocationCheckbox";
      this.KSCLocationCheckbox.Size = new Size(15, 14);
      this.KSCLocationCheckbox.TabIndex = 38;
      this.KSCLocationCheckbox.UseVisualStyleBackColor = true;
      this.label11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(53, 412);
      this.label11.Margin = new Padding(4, 0, 4, 0);
      this.label11.Name = "label11";
      this.label11.Size = new Size(79, 16);
      this.label11.TabIndex = 39;
      this.label11.Text = "Location";
      this.KSCSizeCheckbox.AutoSize = true;
      this.KSCSizeCheckbox.Location = new Point(12, 443);
      this.KSCSizeCheckbox.Margin = new Padding(4);
      this.KSCSizeCheckbox.Name = "KSCSizeCheckbox";
      this.KSCSizeCheckbox.Size = new Size(15, 14);
      this.KSCSizeCheckbox.TabIndex = 40;
      this.KSCSizeCheckbox.UseVisualStyleBackColor = true;
      this.label12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(53, 443);
      this.label12.Margin = new Padding(4, 0, 4, 0);
      this.label12.Name = "label12";
      this.label12.Size = new Size(79, 16);
      this.label12.TabIndex = 41;
      this.label12.Text = "Size";
      this.KSCVisibleCheckbox.AutoSize = true;
      this.KSCVisibleCheckbox.Location = new Point(12, 474);
      this.KSCVisibleCheckbox.Margin = new Padding(4);
      this.KSCVisibleCheckbox.Name = "KSCVisibleCheckbox";
      this.KSCVisibleCheckbox.Size = new Size(15, 14);
      this.KSCVisibleCheckbox.TabIndex = 42;
      this.KSCVisibleCheckbox.UseVisualStyleBackColor = true;
      this.label13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(53, 474);
      this.label13.Margin = new Padding(4, 0, 4, 0);
      this.label13.Name = "label13";
      this.label13.Size = new Size(79, 16);
      this.label13.TabIndex = 43;
      this.label13.Text = "Visible";
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Wheat;
      this.ClientSize = new Size(296, 546);
      this.ControlBox = false;
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.KSCVisibleCheckbox);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.KSCSizeCheckbox);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.KSCLocationCheckbox);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.KSCFontColorCheckbox);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.KSCFontCheckbox);
      this.Controls.Add((Control) this.DDlabel2);
      this.Controls.Add((Control) this.CancelResetButton);
      this.Controls.Add((Control) this.ResetDefaultsButton);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.sizeCheckbox);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.splitscreenPositionCheckbox);
      this.Controls.Add((Control) this.label6);
      this.Controls.Add((Control) this.splitscreenCheckbox);
      this.Controls.Add((Control) this.label5);
      this.Controls.Add((Control) this.locationCheckbox);
      this.Controls.Add((Control) this.label4);
      this.Controls.Add((Control) this.fontColorCheckbox);
      this.Controls.Add((Control) this.label3);
      this.Controls.Add((Control) this.fontCheckbox);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.codeCheckbox);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.caretCheckbox);
      this.Controls.Add((Control) this.DDlabel1);
      this.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Margin = new Padding(3, 4, 3, 4);
      this.Name = nameof (DefaultsDialog);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Reset Defaults";
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}
