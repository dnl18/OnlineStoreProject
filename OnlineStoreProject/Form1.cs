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


namespace FinalFinal_RosaAdey_GonzalezDanielSec080
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            comb_items.Items.Clear();
            comb_items.Items.Add("Iphone 6 Cover Negro");
            comb_items.Items.Add("Iphone 6 Cover Verde");
            comb_items.Items.Add("Iphone 6 Cover Violeta");
            comb_items.Items.Add("Iphone 7 Cover Verde");
            comb_items.Items.Add("Iphone 7 Cover Violeta");
            comb_items.Items.Add("Iphone 7 Cover Negro");
            comb_items.Items.Add("Iphone 8 Cover Negro");
            comb_items.Items.Add("Iphone 8 Cover Violeta");
            comb_items.Items.Add("Iphone 8 Cover Verde");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            comb_items.Items.Clear();
            comb_items.Items.Add("Samsung Galaxy J7 Cover Violeta");
            comb_items.Items.Add("Samsung Galaxy J7 Cover Verde");
            comb_items.Items.Add("Samsung Galaxy J7 Cover Negro");
            comb_items.Items.Add("Samsung Galaxy Note 8 Cover Violeta");
            comb_items.Items.Add("Samsung Galaxy Note 8 Cover Negro");
            comb_items.Items.Add("Samsung Galaxy Note 8 Cover Verde");
            comb_items.Items.Add("Samsung Galaxy S8 Active Cover Violeta");
            comb_items.Items.Add("Samsung Galaxy S8 Active Cover Azul");
            comb_items.Items.Add("Samsung Galaxy S8 Active Cover Verde");



        }
        
        private void comb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            fstream myfiles;

            myfiles.open("libros.txt", fstream::app);

            if (comb_items.SelectedItem.ToString() == "Iphone 6 Cover Negro")
            {
                txt_price.Text = "10";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 6 Cover Negro" << endl;
                }

                myfiles.close();
            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 6 Cover Verde")
            {
                txt_price.Text = "10";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 6 Cover Verde" << endl;
                }

                myfiles.close();
            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 6 Cover Violeta")
            {
                txt_price.Text = "10";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 6 Cover Violeta" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 7 Cover Verde")
            {
                txt_price.Text = "20";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 7 Cover Verde" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 7 Cover Violeta")
            {
                txt_price.Text = "20";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 7 Cover Violeta" << endl;

                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 7 Cover Negro")
            {
                txt_price.Text = "20";

                txt_price.Text = "20";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 7 Cover Negro" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 8 Cover Negro")
            {
                txt_price.Text = "30";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 8 Cover Negro" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 8 Cover Violeta")
            {
                txt_price.Text = "30";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 8 Cover Violeta" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Iphone 8 Cover Verde")
            {
                txt_price.Text = "30";

                if (myfiles.is_open())
                {
                    myfiles << "Iphone 8 Cover Verde" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy J7 Cover Violeta")
            {
                txt_price.Text = "15";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy J7 Cover Violeta" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy J7 Cover Verde")
            {
                txt_price.Text = "15";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy J7 Cover Verde" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy J7 Cover Negro")
            {
                txt_price.Text = "15";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy J7 Cover Negro" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy Note 8 Cover Violeta")
            {
                txt_price.Text = "25";


                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy Note 8 Cover Violeta" << endl;
                }

                myfiles.close();
            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy Note 8 Cover Negro")
            {
                txt_price.Text = "25";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy Note 8 Cover Negro" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy Note 8 Cover Verde")
            {
                txt_price.Text = "25";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy Note 8 Cover Verde" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy S8 Active Cover Violeta")
            {
                txt_price.Text = "30";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy S8 Active Cover Violeta" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy S8 Active Cover Azul")
            {
                txt_price.Text = "30";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy S8 Active Cover Azul" << endl;
                }

                myfiles.close();

            }
            else if (comb_items.SelectedItem.ToString() == "Samsung Galaxy S8 Active Cover Verde")
            {
                txt_price.Text = "30";

                if (myfiles.is_open())
                {
                    myfiles << "Samsung Galaxy S8 Active Cover Verde" << endl;
                }

                myfiles.close();
            }
            else
            {
                txt_price.Text = "0";
            }

            txt_total.Text = "";
            txt_qty.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = comb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);

            listView1.Items.Add(lvi);

            txt_subtotal.Text = (Convert.ToInt16(txt_subtotal.Text) + Convert.ToInt16(txt_total.Text)).ToString();
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_subtotal.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txt_subtotal.Text = (Convert.ToInt16(txt_subtotal.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();

                    }
                }
            }
        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            Form Inventory = new Inventory();
            

            Inventory.Show();
            

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
