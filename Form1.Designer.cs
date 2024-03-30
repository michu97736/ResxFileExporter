namespace ResxFileExporter;

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
        label1 = new Label();
        openFileDialog1 = new OpenFileDialog();
        button1 = new Button();
        label2 = new Label();
        button2 = new Button();
        saveFileDialog1 = new SaveFileDialog();
        listBox1 = new ListBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(116, 21);
        label1.TabIndex = 0;
        label1.Text = "Select RESX file";
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // button1
        // 
        button1.Location = new Point(12, 33);
        button1.Name = "button1";
        button1.Size = new Size(75, 23);
        button1.TabIndex = 1;
        button1.Text = "Select file";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 71);
        label2.Name = "label2";
        label2.Size = new Size(37, 15);
        label2.TabIndex = 2;
        label2.Text = "Path: ";
        // 
        // button2
        // 
        button2.Enabled = false;
        button2.Location = new Point(12, 89);
        button2.Name = "button2";
        button2.Size = new Size(75, 23);
        button2.TabIndex = 3;
        button2.Text = "Export";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new Point(160, 9);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(120, 94);
        listBox1.TabIndex = 4;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(324, 153);
        Controls.Add(listBox1);
        Controls.Add(button2);
        Controls.Add(label2);
        Controls.Add(button1);
        Controls.Add(label1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "Form1";
        Text = "ResxFileExporter";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private OpenFileDialog openFileDialog1;
    private Button button1;
    private Label label2;
    private Button button2;
    private SaveFileDialog saveFileDialog1;
    private ListBox listBox1;
}