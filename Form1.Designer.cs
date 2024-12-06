namespace Combo_box_and_list_box_controls_demo;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        panel1 = new System.Windows.Forms.Panel();
        comboBox1 = new System.Windows.Forms.ComboBox();
        listBox1 = new System.Windows.Forms.ListBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(listBox1);
        panel1.Controls.Add(comboBox1);
        panel1.Location = new System.Drawing.Point(192, 54);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(409, 321);
        panel1.TabIndex = 0;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(77, 89);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(230, 28);
        comboBox1.TabIndex = 0;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(77, 182);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(222, 24);
        listBox1.TabIndex = 1;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(77, 57);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(212, 29);
        label1.TabIndex = 2;
        label1.Text = "Select City using ComboBox";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(77, 150);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(212, 29);
        label2.TabIndex = 3;
        label2.Text = "Select City using ListBox";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel1);
        Text = "Form1";
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label1;

    #endregion
}