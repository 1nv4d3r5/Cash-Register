using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*
 * Author: Sakar Panta
 * CS 354 P1
 * */

namespace cashRegister
{
    public partial class Form1 : Form
    {
        
        private ItemList myList;
        //private Double subTotal;
        private Double taxIncrd;
        private Double total;
        
        public Form1()
        {
            myList = new ItemList();
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Item it = new Item();


            try
            {
                int tq = int.Parse(txtQuantity.Text);
                try
                {
                    double up = Math.Round((double.Parse(txtPrice.Text)),2);
                    it.setName(txtName.Text);
                    it.setQuantity(tq);
                    it.setUnitprice(up);

                    myList.addToLast(it);

                    inputBox.Text = myList.displayList();
                    
                    //subTotal = subTotal + (tq * up);
                    taxIncrd = Math.Round((myList.getTotalQuantity() * (6.00 / 100.00)),2);
                    total = Math.Round( (myList.getTotalQuantity() + taxIncrd),2);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a valid price");
                    goto REDO2;//throw;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter a valid integer quantity");
                goto REDO1;//throw;
            }

            subLabel.Text = "$ "+Convert.ToString(myList.getTotalQuantity());
            taxLabel.Text = "$ "+Convert.ToString(taxIncrd);
            totalLabel.Text = "$ "+Convert.ToString(total);

            
            txtName.Clear();
            REDO1:
            txtQuantity.Clear();
            REDO2:
            txtPrice.Clear();
            

        }

        private void outputBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            inputBox.Clear();
            subLabel.Text = "";
            taxLabel.Text = "";
            totalLabel.Text = "";

            myList.clearList();
        }

        }
    }


