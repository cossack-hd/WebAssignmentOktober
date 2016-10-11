using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        WebProjOctDBEntities myDataBase = new WebProjOctDBEntities();

        public Form1()
        {
            InitializeComponent();

            disableControls(true);

            displayItems();
        }

        private void disableControls(bool val)
        {
            tbxTitle.ReadOnly = val;
            tbxText.ReadOnly = val;
            tbxImageLink.ReadOnly = val;
            btnApply.Enabled = val;
        }

        private void emptyTextBoxes()
        {
            tbxTitle.Text = string.Empty;
            tbxText.Text = string.Empty;
            tbxImageLink.Text = string.Empty;
        }


        private void displayItems()
        {
            lbxItems.Items.Clear();
            foreach (var item in myDataBase.personalDatas)
            {
                lbxItems.Items.Add(item);
            }

            lbxItems.DisplayMember = "title";
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxItems.SelectedIndex != -1)
            {
                personalData selectedData = new personalData();

                selectedData = (personalData)lbxItems.SelectedItem;

                tbxTitle.Text = selectedData.title;
                tbxText.Text = selectedData.text;
                tbxImageLink.Text = selectedData.imagelink;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            disableControls(false);
            emptyTextBoxes();
            btnApply.Enabled = true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            disableControls(true);
            emptyTextBoxes();
            lbxItems.SelectedIndex = -1;

            myDataBase.SaveChanges();

            displayItems();
        }
    }
}
