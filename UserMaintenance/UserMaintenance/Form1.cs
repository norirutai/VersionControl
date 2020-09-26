﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
           
            label2.Text = Resource1.FirstName;
            button1.Text = Resource1.Add;
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID_";
            listBox1.DisplayMember = "Fullname";
            
            button2.Text = Resource1.Text;
            button3.Text = Resource1.Text2;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = textBox2.Text,

            };
            users.Add(u);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var t = new User()
            { FullName = (string)listBox1.SelectedItem };
            users.Remove(t);
        }
    }
}
