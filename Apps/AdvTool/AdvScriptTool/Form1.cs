using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AdvScriptTool
{
    public partial class Form1 : Form
    {
        private List<AdvBaseClass> ndata = new List<AdvBaseClass>();
        private List<TextBox> SelectMsgLists = new List<TextBox>();
        private List<TextBox> SelectJmpLists = new List<TextBox>();
        private Dictionary<string, System.Action<string>> CommandLists = new Dictionary<string, Action<string>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectMsgLists.Add(SelectMessageTextBox1);
            SelectMsgLists.Add(SelectMessageTextBox2);
            SelectMsgLists.Add(SelectMessageTextBox3);
            SelectMsgLists.Add(SelectMessageTextBox4);
            SelectMsgLists.Add(SelectMessageTextBox5);
            SelectJmpLists.Add(SelectJmupTextBox1);
            SelectJmpLists.Add(SelectJmupTextBox2);
            SelectJmpLists.Add(SelectJmupTextBox3);
            SelectJmpLists.Add(SelectJmupTextBox4);
            SelectJmpLists.Add(SelectJmupTextBox5);
            CommandLists.Add("\"message\"", MessageDecode);
            CommandLists.Add("\"select\"", SelectDecode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageTextBox.Text = "テキストに文字を入れます\r\n改行は制御コードで";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var stw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.UTF8))
                {
                    foreach(string msg in listBox1.Items)
                    {
                        stw.WriteLine(msg);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var str = new StreamReader(openFileDialog1.FileName, Encoding.UTF8))
                {
                    listBox1.Items.Clear();
                    var msg = "";
                    while ((msg = str.ReadLine()) != null)
                    {
                        listBox1.Items.Add(msg);
                    }
                }
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("終了してよろしいですか？",
                "確認",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
            
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fnames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                listBox1.Items.Clear();
                foreach (var fname in fnames)
                {
                    //  拡張子を取得して小文字に変換する
                    var k = Path.GetExtension(fname).ToLower();
                    //  拡張子が「.txt」のもののみ表示する
                    if (k.Equals(".txt"))
                    {
                        var f = Path.GetFileName(fname);
                        listBox1.Items.Add(f);
                    }
                }
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// メッセージの登録
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MessageAgreeButton_Click(object sender, EventArgs e)
        {
            MessageClass messageClass = new MessageClass();
            messageClass.MessageSet(MessageTextBox.Text);
            var jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(messageClass);
            listBox1.Items.Add(jsonText);
        }

        private void SelectNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach(var i in Enumerable.Range(0, SelectMsgLists.Count))
            {
                SelectMsgLists[i].Visible = (i < SelectNumericUpDown.Value);
                SelectJmpLists[i].Visible = (i < SelectNumericUpDown.Value);
            }
        }

        private void SelectAgreeButton_Click(object sender, EventArgs e)
        {
            SelectClass selectClass = new SelectClass();
            selectClass.SelectSet(SelectMsgLists, SelectJmpLists, (int)SelectNumericUpDown.Value);
            var jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(selectClass);
            listBox1.Items.Add(jsonText);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  選択されていなければ何もしない
            if (listBox1.SelectedIndex < 0)
                return;
            var selectCommand = (string)listBox1.Items[listBox1.SelectedIndex];
            foreach(var cmd in CommandLists)
            {
                if (selectCommand.IndexOf(cmd.Key) > 0)
                {
                    cmd.Value(selectCommand);
                    break;
                }
            }
        }

        public void MessageDecode(string jsonText)
        {
            MessageClass messageClass = new MessageClass();
            messageClass = Newtonsoft.Json.JsonConvert.DeserializeObject<MessageClass>(jsonText);
            var msg = "";
            messageClass.msg.ForEach(x => msg += x + Environment.NewLine);
            MessageTextBox.Text = msg;
        }

        public void SelectDecode(string jsonText)
        {
            SelectClass selectClass = new SelectClass();
            selectClass = Newtonsoft.Json.JsonConvert.DeserializeObject<SelectClass>(jsonText);
            SelectNumericUpDown.Value = selectClass.count;
            foreach(var i in Enumerable.Range(0, selectClass.count))
            {
                SelectMsgLists[i].Text = selectClass.msg[i];
                SelectJmpLists[i].Text = selectClass.jump[i];
            }
        }
    }
}
