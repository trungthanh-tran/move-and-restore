using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FindAndCopy
{
    public partial class Form1 : Form
    {
        private ArrayList latestHistory;
        public Form1()
        {
            InitializeComponent();

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
            listBox1.Show();
            dataGridView1.Hide();
            latestHistory = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog chooseSearchFolder = new FolderBrowserDialog();
            if (chooseSearchFolder.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    textBox2.Text = chooseSearchFolder.SelectedPath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Show();
            dataGridView1.Hide();
            latestHistory.Clear();
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Chưa chọn folder để search");
                return;
            }

            if (string.IsNullOrEmpty ((textBox3.Text).Trim()))
            {
                MessageBox.Show("Chưa chọn folder để copy");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Chưa nhập điều kiện");
                return;
            }
            renderList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = "";
            if (listBox1.SelectedItems.Count != 0)
            {
                for (int x = 0; x < listBox1.SelectedItems.Count; x++)
                {
                    string fullname = listBox1.SelectedItems[x].ToString();
                    string fileName = Path.GetFileName(fullname);
                    try
                    {
                        var desc = Path.Combine(textBox3.Text, fileName);
                        File.Move(fullname, desc);
                        s += fileName + ",";
                        InsertData(fullname, desc);
                    }
                    catch (System.IO.IOException e1)
                    {
                        MessageBox.Show("Không thể copy file " + fullname);
                        Console.WriteLine(e1.Message);
                    }
                }
            }
            MessageBox.Show("Đã copy các file: " + s + " tới thư mục: " + textBox3.Text);
            renderList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog chooseDestinationFolder = new FolderBrowserDialog();
            if (chooseDestinationFolder.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    textBox3.Text = chooseDestinationFolder.SelectedPath;
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            listBox1.Hide();
            dataGridView1.Show();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < latestHistory.Count; i++)
            {
                HistoryItem historyItem = latestHistory[i] as HistoryItem;
                dataGridView1.Rows.Add(new object[] {
                    historyItem.GetSrc(),
                    historyItem.GetDest(),
                    });
            }
        }


        private void InsertData(string src, string dest)
        {
            this.latestHistory.Add(new HistoryItem(src, dest));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.Rows.Clear();
            for (int i = 0; i < latestHistory.Count; i++)
            {
                HistoryItem historyItem = latestHistory[i] as HistoryItem;
                string src = historyItem.GetSrc();
                string dest = historyItem.GetDest();
                DialogResult dialogResult = MessageBox.Show("Bạn muốn khôi phục từ " + dest + " về đường dẫn cũ " + src, "Chắc chắn?", MessageBoxButtons.YesNoCancel); //Gets users input by showing the message box

                if (dialogResult == DialogResult.Yes) //Creates the yes function
                {
                    try
                    {
                        File.Move(dest, src);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Không thể di chuyển file  .\n\nError message: {ex.Message}\n\n" +
                            $"Details:\n\n{ex.StackTrace}");
                    }
                    latestHistory.RemoveAt(i--);
                }
            }
        }

        private void renderList()
        {
            listBox1.Items.Clear();
            DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(@"" + textBox2.Text);
            FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + textBox1.Text + "*", SearchOption.AllDirectories);
            label5.Text = filesInDir.Length.ToString();
            foreach (FileInfo foundFile in filesInDir)
            {
                string fullName = foundFile.FullName;
                listBox1.Items.Add(fullName);
            }
        }
    }

    class HistoryItem
    {
        private string src;
        private string dest;

        public HistoryItem (string src, string dest)
        {
            this.src = src;
            this.dest = dest;
        }

        public string GetSrc()
        {
            return src;
        }

        public void SetSrc(string src)
        {
            this.src = src;
        }

        public string GetDest()
        {
            return dest;
        }

        public string SetDest(string dest)
        {
            return this.dest = dest;
        }
    }
}
