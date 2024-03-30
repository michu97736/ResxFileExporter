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

    private void button1_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            label2.Text = openFileDialog1.FileName;
            try
            {
                resxSet = new ResXResourceSet(openFileDialog1.FileName);
                button2.Enabled = true;
                listBox1.Items.Clear();
                foreach (DictionaryEntry entry in resxSet)
                {
                    listBox1.Items.Add(entry.Key);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The selected file is not a valid resx file!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var obj = resxSet?.GetObject((string)listBox1.SelectedItem);
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
}
