using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace encuentra_objetivo
{
    public partial class Form1 : Form
    {
    /**
            int arriba = -10;
            int abajo = 10;
            int izquierda = -1;
            int derecha = 1;
            int arribaizquierda = -11;
            int arribaderecha = -9;
            int abajoizquierda = 9;
            int abajoderecha = 11;
     **/
        int arriba;
        int abajo;
        int izquierda;
        int derecha;
        int arribaizquierda;
        int arribaderecha;
        int abajoizquierda;
        int abajoderecha;
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acu=1;
            int fila = int.Parse(textBox1.Text);
            int columna = int.Parse(textBox2.Text);
            dataGridView1.ColumnCount = columna;
            dataGridView1.RowCount = fila;
            for(int i=0;i<fila;i++)
            {
                for (int j = 0; j <columna; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = acu;
                    acu++;
        
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int obstaculos = int.Parse(textBox3.Text);
            if (obstaculos > 0)
            {
                for (int i = 0; i < dataGridView1.RowCount - 0; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount - 0; j++)
                    {
                        Random aleatorio = new Random();
                        int num;
                        num = aleatorio.Next(1, 9);
                        if (num == 2)
                        {
                            if (obstaculos > 0)
                            {
                                dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Red;
                                obstaculos--;
                                MessageBox.Show(":"+num);
                            }
                        }
                        else
                        {
                            MessageBox.Show("nada");
                        }

                    }
                }
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int inicio = int.Parse(textBox4.Text);
            int fin = int.Parse(textBox5.Text);
            for (int i = 0; i < dataGridView1.RowCount - 0; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount - 0; j++)
                {
                    if (inicio ==Convert.ToInt32( dataGridView1.Rows[i].Cells[j].Value.ToString()))
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                        
                    }
                    if (fin == Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString()))
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.DarkBlue;

                    }
                }
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int acu=0;
            int  suma;
            acu = int.Parse(textBox4.Text);
            int[] lista=new int[100];
            for (int i = 0; i < dataGridView1.RowCount - 0; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount - 0; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Blue || dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Goldenrod)
                    {
                        acu = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                        MessageBox.Show("num:" + acu);
                        if (acu == Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString()))
                        {
                            arriba = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) - 10;
                            abajo = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) + 10;
                            izquierda = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) - 1;
                            derecha = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) + 1;

                            arribaizquierda = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) - 11;
                            arribaderecha = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) - 9;
                            abajoizquierda = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) + 9;
                            abajoderecha = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value) + 11;
                            MessageBox.Show("entro");
                            MessageBox.Show("arriba" + arriba + " abajo:" + abajo + " izquierda:" + izquierda + " derecha:" + derecha);
                            /*
                            for (int m = 0; m < 1; m++)   // Pedimos los datos
                            {
                                
                                lista[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
                            }
                            for (int n = 0; n < 1; n++)
                                suma = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value.ToString());

                            MessageBox.Show("suna:"+ suma);
                             * */

                        }
                    } 
                }
            }

            
            for (int a = 0; a < dataGridView1.RowCount - 0; a++)
            {
                for (int b = 0; b < dataGridView1.ColumnCount - 0; b++)
                {
                    if (arriba ==Convert.ToInt32( dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }
                    if (abajo == Convert.ToInt32(dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }
                    if (izquierda == Convert.ToInt32(dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }
                    if (derecha == Convert.ToInt32(dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }    
                    if (arribaizquierda == Convert.ToInt32(dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }
                    if (arribaderecha == Convert.ToInt32(dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }
                    if (abajoizquierda == Convert.ToInt32(dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }
                    if (abajoderecha == Convert.ToInt32(dataGridView1.Rows[a].Cells[b].Value))
                    {
                        dataGridView1.Rows[a].Cells[b].Style.BackColor = Color.Goldenrod;
                    }
                     
                }
                
               
            }
        }
    }
}
