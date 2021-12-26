using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String n = "";
        String m = "";
        string b = "";
        List<string> listss = new List<string>();
        List<string> list = new List<string>();
        List<int> lists = new List<int>();
        private void BtnOK_Click(object sender, EventArgs e)
        {
            string name = "";
            //Determines whether the text is empty
            if (txtName.Text.Trim() != null || txtName.Text.Trim() != "")
            {
                //Add the collection if it is not empty
                list.Add(txtName.Text.Trim());

                int[] Ints = new int[] { }; ;
                int ii;
                for (int i = 0; i < list.Count; i++)
                {
                    name = list[i] + ",";
                    var text = name.Split(new char[1] { 'j' });
                    foreach (var item in name)
                    {
                        if (int.TryParse(item.ToString(), out ii))
                        {
                                                
                                lists.Add(ii);     
                        }
                        else
                        {
                            listss.Add(item.ToString());
                        }

                    }
                    cobInt.DataSource = lists.OrderBy(d => d).ToList();
                    cmbString.DataSource = listss.OrderBy(d=>d).ToList();




                   
                }

            }

;
        }
    }
}

