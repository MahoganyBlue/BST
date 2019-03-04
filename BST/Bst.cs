using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST
{
    public partial class Bst : Form
    {
        public Bst()
        {
            InitializeComponent();
            fillTree(); // fill tree on start
        }

        BinarySearchTree<int> intTree = new BinarySearchTree<int>();
        string trace = "";
        // fill tree with random values 1-500
        private void fillTree()
        {
            if (!intTree.IsEmpty())
            {
                Clear();
            }
                Random r = new Random(DateTime.Now.Millisecond);
            
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int randomInt = r.Next(1, 500);
                    intTree.Insert(randomInt);
                    trace += randomInt + " ";
                }
                catch (Exception)
                {
                    i = i - 1;
                    
                }
            }
            Display();
        }
        // clear intTree, trace, listbox and textBoxes
        private void Clear()
        {
            listBox.Items.Clear();
            intTree.MakeEmpty();
            trace = "";
            clearTextBoxes();
        }
        // clear all textBoxes
        private void clearTextBoxes()
        {
            textBoxFind.Clear();
            textBoxFindMax.Clear();
            textBoxFindMin.Clear();
            textBoxInsert.Clear();
            textBoxRemove.Clear();
            textBoxRoot.Clear();
        }
        // display tree and trace
        private void Display()
        {
            listBox.Items.Clear();
            listBox.Items.Add("The Order in which the elements were added to the Tree:");
            listBox.Items.Add(trace);
            listBox.Items.Add("A textual representation of the tree:");
            if ((!intTree.IsEmpty()))
            {
                listBox.Items.Add(intTree);
            }
        }
        // add field
        private void insertButton_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            try
            {
                x = Convert.ToInt32(textBoxInsert.Text);
                y = intTree.Find(x);
                if (!(y == x))
                {
                    intTree.Insert(x);
                    Display();
                    toolStripStatusLabel1.Text = "inserted: " + x;
                }
                else
                {
                    toolStripStatusLabel1.Text = "Number already exsists";
                }
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "No Number found";
            }
            clearTextBoxes();
        }
        // find biggest value
        private void findMaxButton_Click(object sender, EventArgs e)
        {
            textBoxFindMax.Text = ("Max:" + intTree.FindMax());
        }
        // find smallest value
        private void findMinButton_Click(object sender, EventArgs e)
        {
            textBoxFindMin.Text = ("min:" + intTree.FindMin());
        }
        // find root value of tree
        private void rootButton_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxRoot.Text = ("Root:" + intTree.Root.Element);
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "No Root";
            }
        }
        // fill array + clear textboxes        
        private void fillArrayButton_Click(object sender, EventArgs e)
        {
            fillTree();
            clearTextBoxes();
        }
        // find specifide field
        private void findButton_Click(object sender, EventArgs e)
        {
            int y = 0;
            int x;
            if (!string.IsNullOrWhiteSpace(textBoxFind.Text))
            {
                try
                {
                   y = intTree.Find(x = Convert.ToInt32(textBoxFind.Text));
                    if (y == x)
                    {
                        toolStripStatusLabel1.Text = "Found";
                    } else
                    {
                        toolStripStatusLabel1.Text = "Not found";
                    }
                }
                catch (Exception)
                {
                    toolStripStatusLabel1.Text = "error";
                }
            }
            clearTextBoxes();

        }
        // remove specifide field
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBoxRemove.Text)))
            {
                try
                {
                    intTree.Remove(Convert.ToInt32(textBoxRemove.Text));
                }
                catch (Exception)
                {
                    toolStripStatusLabel1.Text = "unable to remove";
                }
                Display();
                clearTextBoxes();
            }
            else
            {
                toolStripStatusLabel1.Text = "number not found";
            }
        }
        // clear all text from window
        private void makeEmptyButton_Click(object sender, EventArgs e)
        {
            Clear();
            clearTextBoxes();
        }
        // remove smallest value
        private void removeMinButton_Click(object sender, EventArgs e)
        {
            try
            {
                intTree.RemoveMin();
                Display();
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Error";
            }
        }
        // true or false, tree empty?
        private void isEmptyButton_Click(object sender, EventArgs e)
        {
            try
            {   // error from if statment used for if tree is blank
                if (intTree.Root.Element == null)
                {

                }
                toolStripStatusLabel1.Text = "false";
            }
            catch (Exception)
            {    // if error tree is blank its true
                toolStripStatusLabel1.Text = "true";
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
