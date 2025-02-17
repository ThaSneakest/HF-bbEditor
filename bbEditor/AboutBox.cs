// Decompiled with JetBrains decompiler
// Type: bbEditor.AboutBox
// Assembly: bbEditor, Version=1.0.4.4, Culture=neutral, PublicKeyToken=null
// MVID: 2136AA2D-CF4B-4944-8014-D1E6AD3B1BC0
// Assembly location: C:\Users\Colin\Desktop\Malware Removal Tools\bbEditor.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

#nullable disable
namespace bbEditor
{
  internal class AboutBox : Form
  {
    private IContainer components;
    private TableLayoutPanel tableLayoutPanel;
    private PictureBox AboutLogoPictureBox;
    private Label AboutLabelProductName;
    private Label AboutLabelVersion;
    private Label AboutLabelCopyright;
    private Label AboutLabelCompanyName;
    private TextBox AboutTextBoxDescription;
    private Button okButton;
    private Label commentsAboutLabel;
    private LinkLabel emailAboutLabel;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (AboutBox));
      this.tableLayoutPanel = new TableLayoutPanel();
      this.AboutLogoPictureBox = new PictureBox();
      this.AboutLabelProductName = new Label();
      this.AboutLabelVersion = new Label();
      this.AboutLabelCopyright = new Label();
      this.AboutLabelCompanyName = new Label();
      this.AboutTextBoxDescription = new TextBox();
      this.okButton = new Button();
      this.commentsAboutLabel = new Label();
      this.emailAboutLabel = new LinkLabel();
      this.tableLayoutPanel.SuspendLayout();
      ((ISupportInitialize) this.AboutLogoPictureBox).BeginInit();
      this.SuspendLayout();
      this.tableLayoutPanel.BackColor = Color.Wheat;
      this.tableLayoutPanel.ColumnCount = 2;
      this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.67797f));
      this.tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.32203f));
      this.tableLayoutPanel.Controls.Add((Control) this.AboutLogoPictureBox, 0, 0);
      this.tableLayoutPanel.Controls.Add((Control) this.AboutLabelProductName, 1, 0);
      this.tableLayoutPanel.Controls.Add((Control) this.AboutLabelVersion, 1, 1);
      this.tableLayoutPanel.Controls.Add((Control) this.AboutLabelCopyright, 1, 2);
      this.tableLayoutPanel.Controls.Add((Control) this.AboutLabelCompanyName, 1, 3);
      this.tableLayoutPanel.Controls.Add((Control) this.AboutTextBoxDescription, 1, 5);
      this.tableLayoutPanel.Controls.Add((Control) this.okButton, 1, 8);
      this.tableLayoutPanel.Controls.Add((Control) this.commentsAboutLabel, 1, 6);
      this.tableLayoutPanel.Controls.Add((Control) this.emailAboutLabel, 1, 7);
      this.tableLayoutPanel.Dock = DockStyle.Fill;
      this.tableLayoutPanel.Location = new Point(9, 9);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 9;
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.64949f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.64949f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.65217f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.65217f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 0.0f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18.63034f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18.76633f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
      this.tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29f));
      this.tableLayoutPanel.Size = new Size(295, 203);
      this.tableLayoutPanel.TabIndex = 1;
      this.AboutLogoPictureBox.BackColor = Color.Wheat;
      this.AboutLogoPictureBox.Image = (Image) componentResourceManager.GetObject("AboutLogoPictureBox.Image");
      this.AboutLogoPictureBox.Location = new Point(3, 3);
      this.AboutLogoPictureBox.Name = "AboutLogoPictureBox";
      this.tableLayoutPanel.SetRowSpan((Control) this.AboutLogoPictureBox, 7);
      this.AboutLogoPictureBox.Size = new Size(114, 119);
      this.AboutLogoPictureBox.TabIndex = 12;
      this.AboutLogoPictureBox.TabStop = false;
      this.AboutLabelProductName.Dock = DockStyle.Fill;
      this.AboutLabelProductName.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.AboutLabelProductName.Location = new Point(126, 0);
      this.AboutLabelProductName.Margin = new Padding(6, 0, 3, 0);
      this.AboutLabelProductName.MaximumSize = new Size(0, 17);
      this.AboutLabelProductName.Name = "AboutLabelProductName";
      this.AboutLabelProductName.Size = new Size(166, 17);
      this.AboutLabelProductName.TabIndex = 19;
      this.AboutLabelProductName.Text = "Product Name";
      this.AboutLabelProductName.TextAlign = ContentAlignment.MiddleLeft;
      this.AboutLabelVersion.Dock = DockStyle.Fill;
      this.AboutLabelVersion.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.AboutLabelVersion.Location = new Point(126, 23);
      this.AboutLabelVersion.Margin = new Padding(6, 0, 3, 0);
      this.AboutLabelVersion.MaximumSize = new Size(0, 17);
      this.AboutLabelVersion.Name = "AboutLabelVersion";
      this.AboutLabelVersion.Size = new Size(166, 17);
      this.AboutLabelVersion.TabIndex = 0;
      this.AboutLabelVersion.Text = "Version ";
      this.AboutLabelVersion.TextAlign = ContentAlignment.MiddleLeft;
      this.AboutLabelCopyright.Dock = DockStyle.Fill;
      this.AboutLabelCopyright.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.AboutLabelCopyright.Location = new Point(126, 46);
      this.AboutLabelCopyright.Margin = new Padding(6, 0, 3, 0);
      this.AboutLabelCopyright.MaximumSize = new Size(0, 17);
      this.AboutLabelCopyright.Name = "AboutLabelCopyright";
      this.AboutLabelCopyright.Size = new Size(166, 17);
      this.AboutLabelCopyright.TabIndex = 21;
      this.AboutLabelCopyright.Text = "Copyright";
      this.AboutLabelCopyright.TextAlign = ContentAlignment.MiddleLeft;
      this.AboutLabelCompanyName.Dock = DockStyle.Fill;
      this.AboutLabelCompanyName.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.AboutLabelCompanyName.Location = new Point(126, 69);
      this.AboutLabelCompanyName.Margin = new Padding(6, 0, 3, 0);
      this.AboutLabelCompanyName.MaximumSize = new Size(0, 17);
      this.AboutLabelCompanyName.Name = "AboutLabelCompanyName";
      this.AboutLabelCompanyName.Size = new Size(166, 17);
      this.AboutLabelCompanyName.TabIndex = 22;
      this.AboutLabelCompanyName.Text = "Company Name";
      this.AboutLabelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
      this.AboutTextBoxDescription.Anchor = AnchorStyles.Left;
      this.AboutTextBoxDescription.BackColor = Color.Wheat;
      this.AboutTextBoxDescription.BorderStyle = BorderStyle.None;
      this.AboutTextBoxDescription.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
      this.AboutTextBoxDescription.Location = new Point(126, 95);
      this.AboutTextBoxDescription.Margin = new Padding(6, 3, 3, 3);
      this.AboutTextBoxDescription.Multiline = true;
      this.AboutTextBoxDescription.Name = "AboutTextBoxDescription";
      this.AboutTextBoxDescription.ReadOnly = true;
      this.AboutTextBoxDescription.Size = new Size(166, 21);
      this.AboutTextBoxDescription.TabIndex = 23;
      this.AboutTextBoxDescription.TabStop = false;
      this.AboutTextBoxDescription.Text = "Description";
      this.AboutTextBoxDescription.WordWrap = false;
      this.okButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.okButton.Cursor = Cursors.Hand;
      this.okButton.DialogResult = DialogResult.Cancel;
      this.okButton.Location = new Point(217, 174);
      this.okButton.Name = "okButton";
      this.okButton.Size = new Size(75, 23);
      this.okButton.TabIndex = 24;
      this.okButton.Text = "&OK";
      this.commentsAboutLabel.Anchor = AnchorStyles.None;
      this.commentsAboutLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.commentsAboutLabel.Location = new Point(134, 120);
      this.commentsAboutLabel.Name = "commentsAboutLabel";
      this.commentsAboutLabel.Padding = new Padding(0, 5, 0, 0);
      this.commentsAboutLabel.Size = new Size(147, 24);
      this.commentsAboutLabel.TabIndex = 25;
      this.commentsAboutLabel.Text = "Questions or Comments?";
      this.emailAboutLabel.ActiveLinkColor = Color.Blue;
      this.emailAboutLabel.Anchor = AnchorStyles.None;
      this.emailAboutLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.emailAboutLabel.Location = new Point(140, 147);
      this.emailAboutLabel.Name = "emailAboutLabel";
      this.emailAboutLabel.Padding = new Padding(0, 3, 0, 0);
      this.emailAboutLabel.Size = new Size(134, 23);
      this.emailAboutLabel.TabIndex = 26;
      this.emailAboutLabel.TabStop = true;
      this.emailAboutLabel.Text = "noahdfear@msn.com";
      this.emailAboutLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.emailAboutLabel_LinkClicked);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Wheat;
      this.ClientSize = new Size(313, 221);
      this.Controls.Add((Control) this.tableLayoutPanel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (AboutBox);
      this.Padding = new Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "About";
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      ((ISupportInitialize) this.AboutLogoPictureBox).EndInit();
      this.ResumeLayout(false);
    }

    public AboutBox()
    {
      this.InitializeComponent();
      this.Text = string.Format("About {0}", (object) this.AssemblyTitle);
      this.AboutLabelProductName.Text = this.AssemblyProduct;
      this.AboutLabelVersion.Text = string.Format("Version {0}", (object) this.AssemblyVersion);
      this.AboutLabelCopyright.Text = this.AssemblyCopyright;
      this.AboutLabelCompanyName.Text = this.AssemblyCompany;
      this.AboutTextBoxDescription.Text = this.AssemblyDescription;
    }

    public string AssemblyTitle
    {
      get
      {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
        if (customAttributes.Length > 0)
        {
          AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute) customAttributes[0];
          if (assemblyTitleAttribute.Title != "")
            return assemblyTitleAttribute.Title;
        }
        return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
      }
    }

    public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

    public string AssemblyDescription
    {
      get
      {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyDescriptionAttribute), false);
        return customAttributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute) customAttributes[0]).Description;
      }
    }

    public string AssemblyProduct
    {
      get
      {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyProductAttribute), false);
        return customAttributes.Length == 0 ? "" : ((AssemblyProductAttribute) customAttributes[0]).Product;
      }
    }

    public string AssemblyCopyright
    {
      get
      {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
        return customAttributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute) customAttributes[0]).Copyright;
      }
    }

    public string AssemblyCompany
    {
      get
      {
        object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
        return customAttributes.Length == 0 ? "" : ((AssemblyCompanyAttribute) customAttributes[0]).Company;
      }
    }

    private void emailAboutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        Process.Start("mailto:noahdfear@msn.com?subject=bbEditor Feedback&body=Please do not change the subject line of this email.");
        this.okButton.PerformClick();
      }
      catch (Exception ex)
      {
        MessageBoxHelper.PrepToCenterMessageBoxOnForm((Form) this);
        int num = (int) MessageBox.Show("There does not appear to be a default email client installed on this machine.", "  " + ex.Message, MessageBoxButtons.OK);
      }
    }
  }
}
