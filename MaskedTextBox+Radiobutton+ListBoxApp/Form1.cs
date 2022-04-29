using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox_Radiobutton_ListBoxApp
{
    public partial class MaskForm : Form
    {
        public MaskForm()
        {
            InitializeComponent();

            text_maskedTextBox.Enabled = false;
            DeleteMask_button.Enabled = false;
            ButtonEnableCheck();

            string[] masks = {"(999) 000 0000", "00/00/0000", "00:00", "90:00", "00/00/0000 90:00"};
            Mask_listBox.Items.AddRange(masks);

            ChooseMask_radioButton.CheckedChanged += Mask_radioButton_CheckedChanged;
            DeleteMask_radioButton.CheckedChanged += Mask_radioButton_CheckedChanged;
        }

        private void Mask_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ChooseMask_radioButton.Checked == true)
            {
                Mask_listBox.SelectedIndexChanged += ChooseMask_listBox_SelectedIndexChanged;
                Output_button.Click += Output_button_Click;
                DeleteMask_button.Enabled = false;
                Output_button.Text = "Вывод";
            }

            else if (DeleteMask_radioButton.Checked == true)
            {
                Mask_listBox.SelectedIndexChanged += DeleteMask_listBox_SelectedIndexChanged;
                Output_button.Enabled = false;
                DeleteMask_button.Enabled = true;
                DeleteMask_button.Click += Delete_button_Click;
            }
        }

        private void ButtonEnableCheck()
        {
            if (text_maskedTextBox.Enabled == false)
            {
                Output_button.Enabled = false;
            }
            else if (text_maskedTextBox.Enabled == true)
            {
                Output_button.Enabled = true;
            }
        }

        private void DeleteMask_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeleteMask_radioButton.Checked == true)
            {
                text_maskedTextBox.Enabled = false;
                text_maskedTextBox.Text = null;
                text_maskedTextBox.Mask = null;
            } 
        }

        private void ChooseMask_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChooseMask_radioButton.Checked == true)
            {
                text_maskedTextBox.Enabled = true;
                text_maskedTextBox.Mask = null;
                ButtonEnableCheck();

                text_maskedTextBox.Mask = Mask_listBox.SelectedItem.ToString();
            }
        }

        private void Output_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Маска: " + Mask_listBox.SelectedItem.ToString() + "\nТекст: " + text_maskedTextBox.Text.ToString());
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            string DeletedMask = Mask_listBox.SelectedItem.ToString();
            Mask_listBox.Items.Remove(DeletedMask);
            MessageBox.Show("Маска " + DeletedMask + " удалена.");
        }
    }
}
