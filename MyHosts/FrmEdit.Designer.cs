
namespace MyHosts
{
  partial class FrmEdit
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdit));
      this.txtIP = new System.Windows.Forms.TextBox();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.btnAddNew = new System.Windows.Forms.Button();
      this.btnReplace = new System.Windows.Forms.Button();
      this.txtHolder = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // txtIP
      // 
      this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtIP.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
      this.txtIP.Location = new System.Drawing.Point(78, 76);
      this.txtIP.Margin = new System.Windows.Forms.Padding(2);
      this.txtIP.Name = "txtIP";
      this.txtIP.Size = new System.Drawing.Size(420, 29);
      this.txtIP.TabIndex = 1;
      // 
      // txtInput
      // 
      this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtInput.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
      this.txtInput.Location = new System.Drawing.Point(78, 133);
      this.txtInput.Margin = new System.Windows.Forms.Padding(2);
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(420, 29);
      this.txtInput.TabIndex = 2;
      this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
      // 
      // btnAddNew
      // 
      this.btnAddNew.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddNew.ForeColor = System.Drawing.Color.Brown;
      this.btnAddNew.Location = new System.Drawing.Point(398, 181);
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
      this.btnReplace.Location = new System.Drawing.Point(398, 181);
      this.btnReplace.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
      this.btnReplace.Name = "btnReplace";
      this.btnReplace.Size = new System.Drawing.Size(100, 30);
      this.btnReplace.TabIndex = 3;
      this.btnReplace.Text = "Replace";
      this.btnReplace.UseVisualStyleBackColor = true;
      this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
      // 
      // txtHolder
      // 
      this.txtHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtHolder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
      this.txtHolder.Location = new System.Drawing.Point(78, 25);
      this.txtHolder.Margin = new System.Windows.Forms.Padding(2);
      this.txtHolder.Name = "txtHolder";
      this.txtHolder.ReadOnly = true;
      this.txtHolder.Size = new System.Drawing.Size(420, 29);
      this.txtHolder.TabIndex = 0;
      this.txtHolder.Text = "Hosts example: 1.1.1.1 tobemvp.com";
      // 
      // FrmEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(597, 235);
      this.Controls.Add(this.btnReplace);
      this.Controls.Add(this.btnAddNew);
      this.Controls.Add(this.txtInput);
      this.Controls.Add(this.txtHolder);
      this.Controls.Add(this.txtIP);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmEdit";
      this.Opacity = 0.9D;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add new/Replace";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtIP;
    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnReplace;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtHolder;
  }
}