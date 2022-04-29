namespace MaskedTextBox_Radiobutton_ListBoxApp
{
    partial class MaskForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Action_panel = new System.Windows.Forms.Panel();
            this.DeleteMask_radioButton = new System.Windows.Forms.RadioButton();
            this.ChooseMask_radioButton = new System.Windows.Forms.RadioButton();
            this.Action_label = new System.Windows.Forms.Label();
            this.MaskList_panel = new System.Windows.Forms.Panel();
            this.Mask_listBox = new System.Windows.Forms.ListBox();
            this.Text_label = new System.Windows.Forms.Label();
            this.text_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Output_button = new System.Windows.Forms.Button();
            this.DeleteMask_button = new System.Windows.Forms.Button();
            this.Action_panel.SuspendLayout();
            this.MaskList_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Action_panel
            // 
            this.Action_panel.Controls.Add(this.DeleteMask_radioButton);
            this.Action_panel.Controls.Add(this.ChooseMask_radioButton);
            this.Action_panel.Location = new System.Drawing.Point(12, 25);
            this.Action_panel.Name = "Action_panel";
            this.Action_panel.Size = new System.Drawing.Size(119, 50);
            this.Action_panel.TabIndex = 0;
            // 
            // DeleteMask_radioButton
            // 
            this.DeleteMask_radioButton.AutoSize = true;
            this.DeleteMask_radioButton.Location = new System.Drawing.Point(3, 26);
            this.DeleteMask_radioButton.Name = "DeleteMask_radioButton";
            this.DeleteMask_radioButton.Size = new System.Drawing.Size(102, 17);
            this.DeleteMask_radioButton.TabIndex = 1;
            this.DeleteMask_radioButton.TabStop = true;
            this.DeleteMask_radioButton.Text = "Удалить маску";
            this.DeleteMask_radioButton.UseVisualStyleBackColor = true;
            // 
            // ChooseMask_radioButton
            // 
            this.ChooseMask_radioButton.AutoSize = true;
            this.ChooseMask_radioButton.Location = new System.Drawing.Point(3, 3);
            this.ChooseMask_radioButton.Name = "ChooseMask_radioButton";
            this.ChooseMask_radioButton.Size = new System.Drawing.Size(103, 17);
            this.ChooseMask_radioButton.TabIndex = 0;
            this.ChooseMask_radioButton.TabStop = true;
            this.ChooseMask_radioButton.Text = "Выбрать маску";
            this.ChooseMask_radioButton.UseVisualStyleBackColor = true;
            // 
            // Action_label
            // 
            this.Action_label.AutoSize = true;
            this.Action_label.Location = new System.Drawing.Point(12, 9);
            this.Action_label.Name = "Action_label";
            this.Action_label.Size = new System.Drawing.Size(110, 13);
            this.Action_label.TabIndex = 1;
            this.Action_label.Text = "Выберите действие:";
            // 
            // MaskList_panel
            // 
            this.MaskList_panel.Controls.Add(this.Mask_listBox);
            this.MaskList_panel.Location = new System.Drawing.Point(12, 81);
            this.MaskList_panel.Name = "MaskList_panel";
            this.MaskList_panel.Size = new System.Drawing.Size(275, 113);
            this.MaskList_panel.TabIndex = 2;
            // 
            // Mask_listBox
            // 
            this.Mask_listBox.FormattingEnabled = true;
            this.Mask_listBox.Location = new System.Drawing.Point(3, 3);
            this.Mask_listBox.Name = "Mask_listBox";
            this.Mask_listBox.ScrollAlwaysVisible = true;
            this.Mask_listBox.Size = new System.Drawing.Size(269, 95);
            this.Mask_listBox.TabIndex = 0;
            // 
            // Text_label
            // 
            this.Text_label.AutoSize = true;
            this.Text_label.Location = new System.Drawing.Point(12, 197);
            this.Text_label.Name = "Text_label";
            this.Text_label.Size = new System.Drawing.Size(83, 13);
            this.Text_label.TabIndex = 3;
            this.Text_label.Text = "Введите текст:";
            // 
            // text_maskedTextBox
            // 
            this.text_maskedTextBox.Location = new System.Drawing.Point(15, 213);
            this.text_maskedTextBox.Name = "text_maskedTextBox";
            this.text_maskedTextBox.Size = new System.Drawing.Size(269, 20);
            this.text_maskedTextBox.TabIndex = 5;
            // 
            // Output_button
            // 
            this.Output_button.Location = new System.Drawing.Point(15, 249);
            this.Output_button.Name = "Output_button";
            this.Output_button.Size = new System.Drawing.Size(269, 35);
            this.Output_button.TabIndex = 6;
            this.Output_button.Text = "Вывод";
            this.Output_button.UseVisualStyleBackColor = true;
            // 
            // DeleteMask_button
            // 
            this.DeleteMask_button.Location = new System.Drawing.Point(15, 292);
            this.DeleteMask_button.Name = "DeleteMask_button";
            this.DeleteMask_button.Size = new System.Drawing.Size(269, 35);
            this.DeleteMask_button.TabIndex = 7;
            this.DeleteMask_button.Text = "Удалить маску";
            this.DeleteMask_button.UseVisualStyleBackColor = true;
            // 
            // MaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 339);
            this.Controls.Add(this.DeleteMask_button);
            this.Controls.Add(this.Output_button);
            this.Controls.Add(this.text_maskedTextBox);
            this.Controls.Add(this.Text_label);
            this.Controls.Add(this.MaskList_panel);
            this.Controls.Add(this.Action_label);
            this.Controls.Add(this.Action_panel);
            this.Name = "MaskForm";
            this.Text = "Форма выбора маски";
            this.Action_panel.ResumeLayout(false);
            this.Action_panel.PerformLayout();
            this.MaskList_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Action_panel;
        private System.Windows.Forms.RadioButton DeleteMask_radioButton;
        private System.Windows.Forms.RadioButton ChooseMask_radioButton;
        private System.Windows.Forms.Label Action_label;
        private System.Windows.Forms.Panel MaskList_panel;
        private System.Windows.Forms.ListBox Mask_listBox;
        private System.Windows.Forms.Label Text_label;
        private System.Windows.Forms.MaskedTextBox text_maskedTextBox;
        private System.Windows.Forms.Button Output_button;
        private System.Windows.Forms.Button DeleteMask_button;
    }
}

