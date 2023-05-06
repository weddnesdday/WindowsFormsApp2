using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                dataGridView1.RowCount = 15; 
                dataGridView1.ColumnCount = 15;
                int[,] matrix = new int[15, 15]; 
                Random rnd = new Random(); 

                
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < 15; j++)
                    {
                        matrix[i, j] = rnd.Next(-100, 100);
                        dataGridView1.Rows[i].Cells[j].Value = matrix[i, j].ToString(); 
                    }
                }

                int maxElement = matrix[0, 0]; 
                int maxRowIndex = 0;

               
                for (int i = 0; i < 15; i++)
                {
                    if (matrix[i, i] > maxElement)
                    {
                        maxElement = matrix[i, i];
                        maxRowIndex = i;
                    }
                }

                
                for (int j = 0; j < 15; j++)
                {
                    dataGridView1.Rows[maxRowIndex].Cells[j].Style.BackColor = Color.Yellow; 
                }

                textBox1.Text = "Максимальный элемент на главной диагонали: " + maxElement.ToString(); 
        }
    }
}

