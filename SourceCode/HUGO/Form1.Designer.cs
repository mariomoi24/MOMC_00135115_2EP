﻿namespace HUGO
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources =
        new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.panel1 = new System.Windows.Forms.Panel();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.panel1.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Black;
      this.panel1.Controls.Add(this.button4);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(209, 541);
      this.panel1.TabIndex = 0;
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.White;
      this.button4.Location = new System.Drawing.Point(58, 307);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(91, 23);
      this.button4.TabIndex = 3;
      this.button4.Text = "Administrador";
      this.button4.UseVisualStyleBackColor = false;
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.White;
      this.button3.Location = new System.Drawing.Point(58, 196);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(91, 23);
      this.button3.TabIndex = 2;
      this.button3.Text = "Producto";
      this.button3.UseVisualStyleBackColor = false;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.White;
      this.button1.Location = new System.Drawing.Point(58, 67);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(91, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Usuario ";
      this.button1.UseVisualStyleBackColor = false;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.Color.Purple;
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(209, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(586, 25);
      this.panel2.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.Color.Thistle;
      this.panel3.Controls.Add(this.label1);
      this.panel3.Controls.Add(this.pictureBox1);
      this.panel3.Location = new System.Drawing.Point(234, 31);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(94, 113);
      this.panel3.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.Thistle;
      this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold,
        System.Drawing.GraphicsUnit.Point, ((byte) (0)));
      this.label1.Location = new System.Drawing.Point(24, 72);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 23);
      this.label1.TabIndex = 3;
      this.label1.Text = "HUGO\r\n";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(21, 9);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(52, 50);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(795, 541);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.panel1.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
  }
}

