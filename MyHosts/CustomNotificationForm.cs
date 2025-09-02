using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyHosts
{
  public class CustomNotificationForm : Form
  {
    private Label label;
    private Timer timer;

    public CustomNotificationForm(Form parentForm)
    {
      InitializeComponent();

      Owner = parentForm;

      InitializeTimer();
    }

    private void InitializeComponent()
    {
      this.label = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label
      // 
      this.label.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label.Location = new System.Drawing.Point(0, 0);
      this.label.Name = "label";
      this.label.Size = new System.Drawing.Size(360, 60);
      this.label.TabIndex = 0;
      this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label.Click += new System.EventHandler(this.label_Click);
      // 
      // CustomNotificationForm
      // 
      this.ClientSize = new System.Drawing.Size(360, 60);
      this.Controls.Add(this.label);
      this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "CustomNotificationForm";
      this.Opacity = 0.9D;
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.TopMost = false;
      this.ResumeLayout(false);
    }

    private void InitializeTimer()
    {
      timer = new Timer();

      timer.Tick += Timer_Tick;
    }

    private void InitializeWindowHandling()
    {
      // Simple approach: just set up the owner relationship
      // The notification will behave as a child of the owner form
    }

    private Color BorderColor = Color.FromArgb(233, 236, 239); // 自定义边框颜色

    void SetBorderColor(Color borderColor)
    {
      BorderColor = borderColor;

      SetStyle(ControlStyles.ResizeRedraw, true); // 启用重绘以实现自定义边框效果
    }

    protected override void OnPaint(PaintEventArgs e)
    {
      base.OnPaint(e);

      ControlPaint.DrawBorder(e.Graphics, ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      timer.Stop();

      Hide();
    }

    public void Primary(string message, int durationInSeconds = 5)
    {
      Show(message, Color.FromArgb(207, 226, 255), Color.FromArgb(10, 88, 202), Color.FromArgb(158, 197, 254), durationInSeconds);
    }

    public void Secondary(string message, int durationInSeconds = 5)
    {
      Show(message, Color.FromArgb(248, 249, 250), Color.FromArgb(233, 236, 239), Color.FromArgb(108, 117, 125), durationInSeconds);
    }

    public void Success(string message, int durationInSeconds = 5)
    {
      Show(message, Color.FromArgb(211, 231, 221), Color.FromArgb(20, 108, 67), Color.FromArgb(163, 207, 187), durationInSeconds);
    }

    public void Danger(string message)
    {
      Show(message, Color.FromArgb(248, 215, 218), Color.FromArgb(176, 42, 55), Color.FromArgb(241, 174, 181), 0);
    }

    public void Warning(string message)
    {
      Show(message, Color.FromArgb(255, 243, 205), Color.FromArgb(153, 116, 4), Color.FromArgb(255, 230, 156), 0);
    }

    public void Info(string message, int durationInSeconds = 3)
    {
      Show(message, Color.FromArgb(207, 244, 252), Color.FromArgb(8, 121, 144), Color.FromArgb(158, 234, 249), durationInSeconds);
    }

    public void Show(string message, Color backColor, Color textColor, Color borderColor, int durationInSeconds = 5)
    {
      SetBorderColor(borderColor);

      label.Text = message;
      label.BackColor = backColor;
      label.ForeColor = textColor;

      Show();

      int formWidth = Width;
      //int formHeight = Height;

      Location = new Point(Owner.Location.X + (Owner.Width - formWidth) / 2, Owner.Location.Y + 100);

      if (durationInSeconds > 0)
      {
        timer.Interval = durationInSeconds * 1000;
        timer.Start();
      }
    }

    private void label_Click(object sender, EventArgs e)
    {
      timer.Stop();
      Hide();
    }
  }
}
