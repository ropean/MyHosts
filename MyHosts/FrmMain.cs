using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyHosts
{
  public partial class FrmMain : Form
  {
    CustomNotificationForm NotificationForm { get; set; }

    public FrmMain()
    {
      InitializeComponent();

      NotificationForm = new CustomNotificationForm(this);

      LoadHosts();

      NotificationForm.Primary("Init hosts successfully.");
    }

    //void TxtURL_KeyPress(object sender, KeyPressEventArgs e)
    //{
    //  if (e.KeyChar == '\r')
    //  {
    //    btnAddNew_Click(null, null);
    //  }
    //}

    private void FrmMain_ClientSizeChanged(object sender, EventArgs e)
    {
      txtHostContent.Location.Offset(10, topPanel.Height + 10);

      txtHostContent.Width = this.Width - 50;

      txtHostContent.Height = this.Height - topPanel.Height - 60;
    }

    //static void ShowMessageBoxWithIcon(string message)
    //{
    //  MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    //}

    public void DoAdd(string ip, string domain)
    {
      try
      {
        var newConfig = $"{ip} {domain}";

        var config = newConfig + Environment.NewLine + txtHostContent.Text;

        WriteHosts(config);
      }
      catch (Exception exc)
      {
        NotificationForm.Danger(exc.Message);
      }
    }

    public void DoReplace(string find, string replace)
    {
      try
      {
        var config = txtHostContent.Text.Replace(find, replace);

        WriteHosts(config);
      }
      catch (Exception exc)
      {
        NotificationForm.Danger(exc.Message);
      }
    }

    private void LoadHosts()
    {
      try
      {
        txtHostContent.Text = Utility.ReadTextFile(txtHostPath.Text);
      }
      catch (Exception exc)
      {
        NotificationForm.Danger(exc.Message);
      }
    }

    void WriteHosts(string config)
    {
      Utility.WriteTextFileWithSharedMode(txtHostPath.Text, config);

      LoadHosts();
    }

    private void btnReload_Click(object sender, EventArgs e)
    {
      LoadHosts();

      NotificationForm.Info("Reload hosts successfully.");
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        var config = txtHostContent.Text;

        WriteHosts(config);

        NotificationForm.Success("Save hosts successfully.");
      }
      catch (Exception exc)
      {
        NotificationForm.Danger(exc.Message);
      }
    }

    void btnAddNew_Click(object sender, EventArgs e)
    {
      new FrmEdit(this, EditMode.Add).ShowDialog();
    }

    private void btnReplace_Click(object sender, EventArgs e)
    {
      new FrmEdit(this, EditMode.Replace).ShowDialog();
    }
  }
}