using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectorInit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = richTextBox1.Text.Trim();
            text = text.Replace("\n", "#");
            string[] res = text.Split('#');
            string resstr = "";
            //C++
            if (radioButton1.Checked)
            {
                for (int i = 0; i < res.Length; i++)
                {
                    resstr += "vector<" + comboBox1.Text + "> pa" + i + "=" + res[i].Replace('[', '{').Replace(']', '}') + ";\n";
                    if (checkBox1.Checked)
                    {

                        resstr += "ListNode* head" + i + " = new ListNode(pa" + i + "[0]);\n" + "ListNode* index" + i + " = head" + i + ";\n" + " for (int i = 1; i < pa" + i + ".size(); i++)\n" + "{" + " ListNode* list = new ListNode(pa0[i]);\n" + " index" + i + "->next = list;\n" + " index" + i + " = index" + i + i + i + "->next;\n" +
                                  "}\n";
                    }

                }



            }

            //Golang
            if (radioButton2.Checked)
            {
                for (int i = 0; i < res.Length; i++)
                {
                    resstr += " pa" + i + " :=[...]" + comboBox1.Text + "" + res[i].Replace('[', '{').Replace(']', '}') + "\n";

                    if (checkBox1.Checked)
                    {

                        resstr += "head" + i + ":= &ListNode{ Val: pa0[0],Next: nil}" + "\n" +
                        "index" + i + ":= head" + i + "\n" +
                        "for i:= 1; i < len(pa" + i + "); i++{" + "\n" +
                        " list:= &ListNode{ Val: pa" + i + "[i],Next: nil}" + "\n" +
                        " index" + i + ".Next = list" + "\n" +
                        " index" + i + " = index" + i + ".Next" + "\n" +
                        "}" + "\n";
                    }
                }

            }

            richTextBox2.Text = resstr;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "int";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
