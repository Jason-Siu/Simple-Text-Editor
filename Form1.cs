using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // load the application
        }


        private void openToolStripButton_Click(object sender, EventArgs e) // open button click even
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) // if clicked
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(openFileDialog1.FileName); // open filw window
                if(openFileDialog1.FileName.Contains(".rtf")) // if file chosen if rtf
                {
                    richTextBox1.Rtf = reader.ReadToEnd();
                }
                else
                {
                    richTextBox1.Text = reader.ReadToEnd(); // if its txt extension
                }
                reader.Close(); // close stream
                Text = openFileDialog1.FileName;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) // save click button event
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) // if you clicked this button
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName); // initialize writer object
                if(saveFileDialog1.FileName.Contains(".rtf")) // if has extension rtf, save to rtf
                {
                    writer.Write(richTextBox1.Rtf);
                }
                else
                {
                    writer.Write(richTextBox1.Text); // else save as txt
                }
                writer.Close(); // close stream
                Text = saveFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e) // load file
        {
            Text = "Untitled"; // if you load text is untitled
        }

        private void newToolStripButton_Click(object sender, EventArgs e) // new file
        {
            Text = "Untitled"; // title is untitled
            richTextBox1.Text = ""; // clears box
            richTextBox1.Rtf = "";
            richTextBox1.Select();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e) // cut event
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e) // copy event
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e) // paste event
        {
            richTextBox1.Paste();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) // new file from the menu
        {
            Text = "Untitled";
            richTextBox1.Text = "";
            richTextBox1.Rtf = "";
            richTextBox1.Select();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // open from menu
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(openFileDialog1.FileName);
                if (openFileDialog1.FileName.Contains(".rtf"))
                {
                    richTextBox1.Rtf = reader.ReadToEnd();
                }
                else
                {
                    richTextBox1.Text = reader.ReadToEnd();
                }
                reader.Close();
                Text = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // save button click event
        {
            if(Text == "Untitled") // if it is named untitled
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName);
                    if (saveFileDialog1.FileName.Contains(".rtf"))
                    {
                        writer.Write(richTextBox1.Rtf);
                    }
                    else
                    {
                        writer.Write(richTextBox1.Text);
                    }
                    writer.Close();
                    Text = saveFileDialog1.FileName;
                }
            }
            else
            {
                try
                {
                    saveFileDialog1.FileName = Text;
                    System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName);

                    if (saveFileDialog1.FileName.Contains(".rtf"))
                    {
                        writer.Write(richTextBox1.Rtf);
                    }
                    else
                    {
                        writer.Write(richTextBox1.Text);
                    }
                    writer.Close();
                }
                catch(System.ArgumentException AE)
                {
                    MessageBox.Show("Error trying to save: " + AE.Message);
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(saveFileDialog1.FileName);
                if (saveFileDialog1.FileName.Contains(".rtf"))
                {
                    writer.Write(richTextBox1.Rtf);
                }
                else
                {
                    writer.Write(richTextBox1.Text);
                }
                writer.Close();
                Text = saveFileDialog1.FileName;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add more deleted code here pls
            try
            {
                FontDialog fd = new FontDialog();
                fd.Font = richTextBox1.SelectionFont;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fd.Font;
                }
            }
            catch(System.ArgumentException AE)
            {
                MessageBox.Show("Error: " + AE.Message);
            }
            
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog fd = new FontDialog();
                fd.Font = richTextBox1.SelectionFont;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fd.Font;
                }
            }
            catch (System.ArgumentException AE)
            {
                MessageBox.Show("Error: " + AE.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Jason Siu © 2017 Jason Siu", "About the Author", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Jason Siu © 2017 Jason Siu", "About the Author", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

    }
}
