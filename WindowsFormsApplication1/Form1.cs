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
        bool editingMode = false;
        bool isAddingNewRecord = false;
        bool isEditingARecord = false;
        bool isRemovingARecord = false;

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
            lockListBox();

            disableControls(false);
            emptyTextBoxes();
            btnApply.Enabled = true;
            isAddingNewRecord = true;

        }

        private void lockListBox()
        {
            editingMode = true;
            lbxItems.Enabled = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            resetUIControllers();

            if (isAddingNewRecord)
            {
                personalData newData = new personalData();
                newData.title = tbxTitle.Text;
                newData.text = tbxText.Text;
                newData.imagelink = tbxImageLink.Text;

                myDataBase.personalDatas.Add(newData);
            }

            if (isRemovingARecord)
            {
                myDataBase.personalDatas.Remove((personalData)lbxItems.SelectedItem);
            }

            if (isEditingARecord)
            {
                personalData editedData = (personalData)lbxItems.SelectedItem;
                editedData.title = tbxTitle.Text;
                editedData.text = tbxText.Text;
                editedData.imagelink = tbxImageLink.Text;

            }

            myDataBase.SaveChanges();

            resetUIControllers();
            displayItems();

        }

        private void resetUIControllers()
        {
            disableControls(true);
            emptyTextBoxes();
            lbxItems.SelectedIndex = -1;
            displayItems();
            lbxItems.Enabled = true;
            editingMode = false;

            editingMode = false;
            isAddingNewRecord = false;
            isEditingARecord = false;
            isRemovingARecord = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            isEditingARecord = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            isRemovingARecord = true;
        }

        private void btnDebugAdd_Click(object sender, EventArgs e)
        {
            personalData newData = new personalData() { title = "test title dbg", text = "test txt dbg", imagelink = "test img lnk dbg" };
            myDataBase.personalDatas.Add(newData);
            myDataBase.SaveChanges();
            displayItems();

        }
    }
}
