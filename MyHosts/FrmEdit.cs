using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHosts
{
  public partial class FrmEdit : Form
  {
    readonly FrmMain frmMain;

    CustomNotificationForm NotificationForm { get; set; }

    public FrmEdit(FrmMain frmMain, EditMode editMode)
    {
      InitializeComponent();

      this.frmMain = frmMain;

      NotificationForm = new CustomNotificationForm(this);

      switch (editMode)
      {
        case EditMode.Add:
          btnAddNew.Visible = true;
          btnReplace.Visible = false;

          AddPlaceholderText(txtIP, "An IP or a url (will be parsed to IP).");
          AddPlaceholderText(txtInput, "A domain or a url (will be parsed to domain).");

          this.Text = "Add new hosts recoreds";
          break;
        case EditMode.Replace:
          btnAddNew.Visible = false;
          btnReplace.Visible = true;

          AddPlaceholderText(txtIP, "Find");
          AddPlaceholderText(txtInput, "Replace");

          this.Text = "Find and replace hosts recoreds";
          break;
      }
    }

    // 添加提示性文字到文本框的方法
    private void AddPlaceholderText(TextBox textBox, string placeholderText)
    {
      if (textBox.Tag != null && textBox.Tag.Equals("PlaceholderAdded"))
      {
        return; // 如果已经添加过提示性文字，直接返回
      }

      textBox.Text = placeholderText;
      textBox.ForeColor = SystemColors.GrayText; // 设置灰色字体颜色

      textBox.Enter += (sender, e) =>
      {
        if (textBox.Text == placeholderText)
        {
          textBox.Text = "";
          textBox.ForeColor = SystemColors.WindowText; // 恢复正常字体颜色
        }
      };

      textBox.Leave += (sender, e) =>
      {
        if (string.IsNullOrWhiteSpace(textBox.Text))
        {
          textBox.Text = placeholderText;
          textBox.ForeColor = SystemColors.GrayText; // 设置灰色字体颜色
        }
      };

      textBox.Tag = "PlaceholderAdded"; // 添加标记，防止重复添加事件处理程序
    }

    private void btnReplace_Click(object sender, EventArgs e)
    {
      var input1 = txtIP.GetText();

      if (string.IsNullOrEmpty(input1))
      {
        NotificationForm.Info($"Nothing to do...");

        return;
      }

      frmMain.DoReplace(input1, txtInput.GetText());
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
      var input1 = txtIP.GetText();

      var input2 = txtInput.GetText();

      if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
      {
        NotificationForm.Warning("Both textboxes require input.");

        return;
      }

      if (Utility.TryValidateIP(input1, out string ip) == false)
      {
        NotificationForm.Warning($"Invalid IP: {input1}");

        return;
      }

      if (Utility.TryValidateDomain(input2, out string domain) == false)
      {
        NotificationForm.Info($"Invalid domain: {input2}");

        return;
      }

      frmMain.DoAdd(ip, domain);
    }
  }

  public enum EditMode
  {
    Add,
    Replace
  }

  public static class WinExtensions
  {
    public static string GetText(this TextBox textBox)
    {
      if (textBox.ForeColor == SystemColors.GrayText)
      {
        return null;
      }

      return textBox.Text.Trim();
    }
  }
}
