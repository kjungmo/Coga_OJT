using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

namespace LinkedListOnly
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private LinkedList linkedList = new LinkedList();

        private void createButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(createIndex.Text) || string.IsNullOrEmpty(createValue.Text))
            {
                if (string.IsNullOrEmpty(createIndex.Text))
                    MessageBox.Show("Index Needed!");
                else

                    MessageBox.Show("Value Needed!");
                displayMyLinkedList();
                createIndex.Text = "";
                createIndex.Text = "";
                return;
            }
            int index = Convert.ToInt32(createIndex.Text);
            string created = "";
            created += createValue.Text;
            linkedList.CreateLinkedList(created, index);
            displayMyLinkedList();
            createValue.Text = "";
            createIndex.Text = "";
            
            WriteLog("!@yes !@no 111");

        }

        private void readButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(readIndex.Text))
            {
                MessageBox.Show("Index NEEDED!");
                displayMyLinkedList();
                return;
            }

            int index = Convert.ToInt32(readIndex.Text);
            string read = "";
            readValue.Text = linkedList.ReadNode(index);
            read += readValue.Text;

            if (string.IsNullOrEmpty(read))
            {
                MessageBox.Show("Nothing to read, either Node is none or index is too large!");
                displayMyLinkedList();
                readValue.Text = "";
                readIndex.Text = "";
                return;
            }
            displayMyLinkedList();
            readIndex.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(updateIndex.Text) || string.IsNullOrEmpty(updateValue.Text))
            {
                if (string.IsNullOrEmpty(updateIndex.Text))
                    MessageBox.Show("Index NEEDED!");
                else
                    MessageBox.Show("Value NEEDED!");
                displayMyLinkedList();
                updateIndex.Text = "";
                updateValue.Text = "";
                return;
            }
            // if both values are input to the textbox
            string updated = updateValue.Text;
            int index = Convert.ToInt32(updateIndex.Text);
            if (linkedList.NumberOfNodes == 0 || index > linkedList.NumberOfNodes)
            {
                if (linkedList.NumberOfNodes == 0)
                    MessageBox.Show("There is no node!");
                else 
                    MessageBox.Show("Index inappropriate!");
                updateValue.Text = "";
                updateIndex.Text = "";
                return;
            }
            linkedList.UpdateNode(updated, index);
            displayMyLinkedList();
            updateValue.Text = "";
            updateIndex.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(deleteIndex.Text))
            {
                MessageBox.Show("Index NEEDED!");
                displayMyLinkedList();
                return;
            }

            int index = Convert.ToInt32(deleteIndex.Text);
            if (linkedList.NumberOfNodes == 0 || string.IsNullOrEmpty(deleteIndex.Text))
            {
                if (linkedList.NumberOfNodes == 0)
                    MessageBox.Show("No Nodes to delete!");
                else if (string.IsNullOrEmpty(deleteIndex.Text))
                    MessageBox.Show("Index NEEDED!");
                deleteIndex.Text = "";
                displayMyLinkedList();
                return;
            }
            linkedList.DeleteLinkedList(index);
            deleteIndex.Text = "";
            displayMyLinkedList();
        }

        

        private void displayMyLinkedList()
        {
            
            Node myNode = linkedList.HeadNode;
            showLinkedList.Items.Clear();
            showLinkedList.Items.Add(head);
            int counter = linkedList.NumberOfNodes;
            while (counter > 0)
            {
                showLinkedList.Items.Add(myNode.NodeData);
                myNode = myNode.NextNode;
                counter--;
            }
            showLinkedList.Items.Add(tail);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ko-KR");
                SetTextLanguage();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                SetTextLanguage();
            }
        }
        public string tail = "Tail";
        public string head = "Head";
        private void SetTextLanguage()
        {
            label4.Text = LinkedListOnly.Language.Resource.label4;
            label1.Text = LinkedListOnly.Language.Resource.label1;
            DeleteButton.Text = LinkedListOnly.Language.Resource.DeleteButton;
            updateButton.Text = LinkedListOnly.Language.Resource.updateButton;
            readButton.Text = LinkedListOnly.Language.Resource.readButton;
            createButton.Text = LinkedListOnly.Language.Resource.createButton;
            textBox1.Text = LinkedListOnly.Language.Resource.textBox1;
            head = LinkedListOnly.Language.Resource.head;
            tail = LinkedListOnly.Language.Resource.tail;
        }

        private void WriteLog(string something)
        {
            string pattern = @"!@([a-z, 0-9, A-Z])\w+";

            var match = Regex.Match(something, pattern);
            //Regex.Replace(something, pattern, m => LinkedListOnly.Language.Resource.ResourceManager.GetString(m.Value.Substring(2)));
            richTextBox1.Text += Regex.Replace(something, pattern, m => LinkedListOnly.Language.Resource.ResourceManager.GetString(m.Value.Substring(2))) + "\n";

        }
    }
}
