using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResxFileExporter;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public ResXResourceSet resxSet;
    public ResourceReader resourceReader;

    private void CheckFile(string filename)
    {
        try
        {
            try
            {
                resxSet = new ResXResourceSet(filename);
                button2.Enabled = true;
                listBox1.Items.Clear();
                foreach (DictionaryEntry entry in resxSet)
                {
                    listBox1.Items.Add(entry.Key);
                }
            }
            catch
            {
                resourceReader = new ResourceReader(filename);
                button2.Enabled = true;
                listBox1.Items.Clear();
                foreach (DictionaryEntry entry in resourceReader)
                {
                    listBox1.Items.Add(entry.Key);
                }
            }
        }
        catch (ArgumentException)
        {
            MessageBox.Show("The selected file is not a valid resx or resources file!");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}");
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            label2.Text = openFileDialog1.FileName;
            CheckFile(openFileDialog1.FileName);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var obj = resxSet?.GetObject((string)listBox1.SelectedItem);
        saveFileDialog1.FileName = (string)listBox1.SelectedItem;
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            if (obj is byte[] bytes)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, bytes);
                label2.Text = "Exported!";
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("The selected item is not a valid byte array!");
            }
        }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        button2.Enabled = true;
        label2.Text = (string)listBox1.SelectedItem;
    }

    private void Form1_DragDrop(object sender, DragEventArgs e)
    {
        var files = (string[])e.Data.GetData(DataFormats.FileDrop);
        if (files.Length == 1)
        {
            CheckFile(files[0]);
        }
        else
        {
            MessageBox.Show("Please drop only one file!");
        }
    }

    private void Form1_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Copy;
    }
}
