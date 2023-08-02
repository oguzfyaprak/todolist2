using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_Form
{
    public partial class Form1 : Form
    {
        private List<Todo> todoList = new List<Todo>();

        public Form1()
        {
            InitializeComponent();

            


            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string taskText = textBox1.Text;

            if (!string.IsNullOrEmpty(taskText))
            {
                Todo newTask = new Todo { TaskText = taskText };
                todoList.Add(newTask);

                UpdateListView();
                
               

                textBox1.Text = "";
            }
            else { MessageBox.Show("Lütfen bir değer giriniz."); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            todoList.Clear();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                
                int selectedIndex = listView1.SelectedIndices[0];
                if (selectedIndex >= 0 && selectedIndex < todoList.Count)
                {
                    todoList.RemoveAt(selectedIndex);
                    UpdateListView();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçiniz.");
            }

        }


        private void Değiştir_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                string newValue = textBox2.Text;

                if (!string.IsNullOrEmpty(newValue))
                {
                    
                    todoList[selectedIndex].TaskText = newValue;
                    UpdateListView();
                }
                else
                {
                    MessageBox.Show("Lütfen bir değer giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçiniz.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Görevler", 200);

        }

        

       

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public class Todo
        {
            public string TaskText { get; set; }
            public bool Completed { get; set; }
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            foreach (var task in todoList)
            {
                string[] row = { task.TaskText };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
                if (task.Completed) 
                {
                    satir.ForeColor = Color.Red;
                }
            }
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedIndex = listView1.SelectedIndices[0];
                todoList[selectedIndex].Completed = !todoList[selectedIndex].Completed;
                UpdateListView();
            }
        }
    }
}

