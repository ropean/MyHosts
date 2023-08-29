namespace MyHosts
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.txtHostContent = new System.Windows.Forms.TextBox();
      this.topPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.txtHostPath = new System.Windows.Forms.TextBox();
      this.btnReload = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnAddNew = new System.Windows.Forms.Button();
      this.btnReplace = new System.Windows.Forms.Button();
      this.topPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtHostContent
      // 
      this.txtHostContent.BackColor = System.Drawing.SystemColors.Control;
      this.txtHostContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtHostContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHostContent.Location = new System.Drawing.Point(22, 68);
      this.txtHostContent.Margin = new System.Windows.Forms.Padding(10);
      this.txtHostContent.Multiline = true;
      this.txtHostContent.Name = "txtHostContent";
      this.txtHostContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtHostContent.Size = new System.Drawing.Size(600, 200);
      this.txtHostContent.TabIndex = 5;
      this.txtHostContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHostContent_KeyDown);
      // 
      // topPanel
      // 
      this.topPanel.BackColor = System.Drawing.Color.Transparent;
      this.topPanel.BackgroundImage = global::MyHosts.Properties.Resources.top_backgroud;
      this.topPanel.Controls.Add(this.txtHostPath);
      this.topPanel.Controls.Add(this.btnReload);
      this.topPanel.Controls.Add(this.btnSave);
      this.topPanel.Controls.Add(this.btnAddNew);
      this.topPanel.Controls.Add(this.btnReplace);
      this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.topPanel.Location = new System.Drawing.Point(0, 0);
      this.topPanel.Name = "topPanel";
      this.topPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
      this.topPanel.Size = new System.Drawing.Size(944, 55);
      this.topPanel.TabIndex = 0;
      // 
      // txtHostPath
      // 
      this.txtHostPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtHostPath.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
      this.txtHostPath.Location = new System.Drawing.Point(22, 12);
      this.txtHostPath.Margin = new System.Windows.Forms.Padding(2);
      this.txtHostPath.Name = "txtHostPath";
      this.txtHostPath.ReadOnly = true;
      this.txtHostPath.Size = new System.Drawing.Size(350, 29);
      this.txtHostPath.TabIndex = 0;
      this.txtHostPath.Text = "C:\\Windows\\System32\\drivers\\etc\\hosts";
      // 
      // btnReload
      // 
      this.btnReload.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReload.ForeColor = System.Drawing.Color.SteelBlue;
      this.btnReload.Location = new System.Drawing.Point(384, 12);
      this.btnReload.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
      this.btnReload.Name = "btnReload";
      this.btnReload.Size = new System.Drawing.Size(100, 30);
      this.btnReload.TabIndex = 1;
      this.btnReload.Text = "Reload";
      this.btnReload.UseVisualStyleBackColor = true;
      this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
      // 
      // btnSave
      // 
      this.btnSave.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
      this.btnSave.Location = new System.Drawing.Point(504, 12);
      this.btnSave.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(100, 30);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnAddNew
      // 
      this.btnAddNew.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddNew.ForeColor = System.Drawing.Color.Brown;
      this.btnAddNew.Location = new System.Drawing.Point(624, 12);
      this.btnAddNew.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
      this.btnAddNew.Name = "btnAddNew";
      this.btnAddNew.Size = new System.Drawing.Size(100, 30);
      this.btnAddNew.TabIndex = 3;
      this.btnAddNew.Text = "Add new";
      this.btnAddNew.UseVisualStyleBackColor = true;
      this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
      // 
      // btnReplace
      // 
      this.btnReplace.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReplace.ForeColor = System.Drawing.Color.DeepPink;
      this.btnReplace.Location = new System.Drawing.Point(744, 12);
      this.btnReplace.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
      this.btnReplace.Name = "btnReplace";
      this.btnReplace.Size = new System.Drawing.Size(100, 30);
      this.btnReplace.TabIndex = 4;
      this.btnReplace.Text = "Replace";
      this.btnReplace.UseVisualStyleBackColor = true;
      this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(944, 561);
      this.Controls.Add(this.txtHostContent);
      this.Controls.Add(this.topPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(960, 600);
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MyHosts";
      this.Load += new System.EventHandler(this.FrmMain_ClientSizeChanged);
      this.ClientSizeChanged += new System.EventHandler(this.FrmMain_ClientSizeChanged);
      this.topPanel.ResumeLayout(false);
      this.topPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    System.Windows.Forms.Button btnAddNew;
    System.Windows.Forms.TextBox txtHostContent;
    private System.Windows.Forms.FlowLayoutPanel topPanel;
    private System.Windows.Forms.Button btnReplace;
    private System.Windows.Forms.TextBox txtHostPath;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnReload;
  }
}

