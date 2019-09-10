namespace DrawingTemplateRuleLib
{
    partial class NewSheetCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sheetNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.orientationComboBox = new System.Windows.Forms.ComboBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sheetSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sheetFormatsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bordersComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.titleBlocksComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.titleBlockPlacementComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.newSheetFormatNameTxtBox = new System.Windows.Forms.TextBox();
            this.createNewSheetFormatChkBox = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.excludeFromPrintChkBox = new System.Windows.Forms.CheckBox();
            this.excludeFromCountChkBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CreateNewSheetButton = new System.Windows.Forms.Button();
            this.ModifyCurrentSheet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // sheetNameTextBox
            // 
            this.sheetNameTextBox.Location = new System.Drawing.Point(98, 19);
            this.sheetNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sheetNameTextBox.Name = "sheetNameTextBox";
            this.sheetNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.sheetNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sheet Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.orientationComboBox);
            this.panel1.Controls.Add(this.heightTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.widthTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sheetSizeComboBox);
            this.panel1.Location = new System.Drawing.Point(9, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 178);
            this.panel1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 128);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Orientation";
            // 
            // orientationComboBox
            // 
            this.orientationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orientationComboBox.FormattingEnabled = true;
            this.orientationComboBox.Items.AddRange(new object[] {
            "Landscape",
            "Portrait"});
            this.orientationComboBox.Location = new System.Drawing.Point(10, 146);
            this.orientationComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.orientationComboBox.Name = "orientationComboBox";
            this.orientationComboBox.Size = new System.Drawing.Size(115, 21);
            this.orientationComboBox.TabIndex = 7;
            this.orientationComboBox.SelectedIndexChanged += new System.EventHandler(this.orientationComboBox_SelectedIndexChanged);
            // 
            // heightTextBox
            // 
            this.heightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.heightTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.heightTextBox.Location = new System.Drawing.Point(10, 72);
            this.heightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(58, 20);
            this.heightTextBox.TabIndex = 5;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(10, 108);
            this.widthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(58, 20);
            this.widthTextBox.TabIndex = 6;
            this.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sheet Size";
            // 
            // sheetSizeComboBox
            // 
            this.sheetSizeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.sheetSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sheetSizeComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.sheetSizeComboBox.FormattingEnabled = true;
            this.sheetSizeComboBox.Location = new System.Drawing.Point(10, 25);
            this.sheetSizeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.sheetSizeComboBox.Name = "sheetSizeComboBox";
            this.sheetSizeComboBox.Size = new System.Drawing.Size(115, 21);
            this.sheetSizeComboBox.TabIndex = 2;
            this.sheetSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.sheetSizeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sheet Settings";
            // 
            // sheetFormatsComboBox
            // 
            this.sheetFormatsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sheetFormatsComboBox.FormattingEnabled = true;
            this.sheetFormatsComboBox.Location = new System.Drawing.Point(24, 84);
            this.sheetFormatsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.sheetFormatsComboBox.Name = "sheetFormatsComboBox";
            this.sheetFormatsComboBox.Size = new System.Drawing.Size(175, 21);
            this.sheetFormatsComboBox.TabIndex = 3;
            this.sheetFormatsComboBox.SelectedIndexChanged += new System.EventHandler(this.sheetFormatsComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sheet Formats";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bordersComboBox
            // 
            this.bordersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bordersComboBox.FormattingEnabled = true;
            this.bordersComboBox.Location = new System.Drawing.Point(9, 34);
            this.bordersComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.bordersComboBox.Name = "bordersComboBox";
            this.bordersComboBox.Size = new System.Drawing.Size(191, 21);
            this.bordersComboBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Borders";
            // 
            // titleBlocksComboBox
            // 
            this.titleBlocksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleBlocksComboBox.FormattingEnabled = true;
            this.titleBlocksComboBox.Location = new System.Drawing.Point(9, 90);
            this.titleBlocksComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleBlocksComboBox.Name = "titleBlocksComboBox";
            this.titleBlocksComboBox.Size = new System.Drawing.Size(191, 21);
            this.titleBlocksComboBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Title Blocks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Title Block Placement";
            // 
            // titleBlockPlacementComboBox
            // 
            this.titleBlockPlacementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleBlockPlacementComboBox.FormattingEnabled = true;
            this.titleBlockPlacementComboBox.Location = new System.Drawing.Point(9, 146);
            this.titleBlockPlacementComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.titleBlockPlacementComboBox.Name = "titleBlockPlacementComboBox";
            this.titleBlockPlacementComboBox.Size = new System.Drawing.Size(191, 21);
            this.titleBlockPlacementComboBox.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.titleBlockPlacementComboBox);
            this.panel2.Controls.Add(this.bordersComboBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.titleBlocksComboBox);
            this.panel2.Location = new System.Drawing.Point(152, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 178);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(25, 140);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 217);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(25, 388);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 130);
            this.panel4.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.newSheetFormatNameTxtBox);
            this.panel6.Controls.Add(this.createNewSheetFormatChkBox);
            this.panel6.Location = new System.Drawing.Point(175, 22);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 82);
            this.panel6.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "New Sheet Format Name";
            // 
            // newSheetFormatNameTxtBox
            // 
            this.newSheetFormatNameTxtBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newSheetFormatNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.newSheetFormatNameTxtBox.Location = new System.Drawing.Point(5, 56);
            this.newSheetFormatNameTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.newSheetFormatNameTxtBox.Name = "newSheetFormatNameTxtBox";
            this.newSheetFormatNameTxtBox.Size = new System.Drawing.Size(175, 20);
            this.newSheetFormatNameTxtBox.TabIndex = 1;
            // 
            // createNewSheetFormatChkBox
            // 
            this.createNewSheetFormatChkBox.AutoSize = true;
            this.createNewSheetFormatChkBox.Location = new System.Drawing.Point(2, 2);
            this.createNewSheetFormatChkBox.Margin = new System.Windows.Forms.Padding(2);
            this.createNewSheetFormatChkBox.Name = "createNewSheetFormatChkBox";
            this.createNewSheetFormatChkBox.Size = new System.Drawing.Size(148, 17);
            this.createNewSheetFormatChkBox.TabIndex = 0;
            this.createNewSheetFormatChkBox.Text = "Create New Sheet Format";
            this.createNewSheetFormatChkBox.UseVisualStyleBackColor = true;
            this.createNewSheetFormatChkBox.CheckedChanged += new System.EventHandler(this.createNewSheetFormatChkBox_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.excludeFromPrintChkBox);
            this.panel5.Controls.Add(this.excludeFromCountChkBox);
            this.panel5.Location = new System.Drawing.Point(9, 22);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 82);
            this.panel5.TabIndex = 0;
            // 
            // excludeFromPrintChkBox
            // 
            this.excludeFromPrintChkBox.AutoSize = true;
            this.excludeFromPrintChkBox.Location = new System.Drawing.Point(10, 46);
            this.excludeFromPrintChkBox.Margin = new System.Windows.Forms.Padding(2);
            this.excludeFromPrintChkBox.Name = "excludeFromPrintChkBox";
            this.excludeFromPrintChkBox.Size = new System.Drawing.Size(124, 17);
            this.excludeFromPrintChkBox.TabIndex = 1;
            this.excludeFromPrintChkBox.Text = "Exclude from printing";
            this.excludeFromPrintChkBox.UseVisualStyleBackColor = true;
            // 
            // excludeFromCountChkBox
            // 
            this.excludeFromCountChkBox.AutoSize = true;
            this.excludeFromCountChkBox.Location = new System.Drawing.Point(10, 13);
            this.excludeFromCountChkBox.Margin = new System.Windows.Forms.Padding(2);
            this.excludeFromCountChkBox.Name = "excludeFromCountChkBox";
            this.excludeFromCountChkBox.Size = new System.Drawing.Size(117, 17);
            this.excludeFromCountChkBox.TabIndex = 0;
            this.excludeFromCountChkBox.Text = "Exclude from count";
            this.excludeFromCountChkBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 380);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Options";
            // 
            // CreateNewSheetButton
            // 
            this.CreateNewSheetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewSheetButton.Location = new System.Drawing.Point(240, 532);
            this.CreateNewSheetButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateNewSheetButton.Name = "CreateNewSheetButton";
            this.CreateNewSheetButton.Size = new System.Drawing.Size(148, 30);
            this.CreateNewSheetButton.TabIndex = 19;
            this.CreateNewSheetButton.Text = "Create New Sheet";
            this.CreateNewSheetButton.UseVisualStyleBackColor = true;
            this.CreateNewSheetButton.Click += new System.EventHandler(this.CreateNewSheetButton_Click);
            // 
            // ModifyCurrentSheet
            // 
            this.ModifyCurrentSheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyCurrentSheet.Location = new System.Drawing.Point(35, 532);
            this.ModifyCurrentSheet.Margin = new System.Windows.Forms.Padding(2);
            this.ModifyCurrentSheet.Name = "ModifyCurrentSheet";
            this.ModifyCurrentSheet.Size = new System.Drawing.Size(163, 30);
            this.ModifyCurrentSheet.TabIndex = 21;
            this.ModifyCurrentSheet.Text = "Modify Current Sheet";
            this.ModifyCurrentSheet.UseVisualStyleBackColor = true;
            this.ModifyCurrentSheet.Click += new System.EventHandler(this.ModifyCurrentSheet_Click);
            // 
            // NewSheetCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(422, 581);
            this.Controls.Add(this.ModifyCurrentSheet);
            this.Controls.Add(this.CreateNewSheetButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sheetFormatsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sheetNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewSheetCreationForm";
            this.Text = "Sheet Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewSheetCreationForm_FormClosing);
            this.Load += new System.EventHandler(this.NewSheetCreationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sheetNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sheetSizeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sheetFormatsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bordersComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox titleBlocksComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox titleBlockPlacementComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newSheetFormatNameTxtBox;
        private System.Windows.Forms.CheckBox createNewSheetFormatChkBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox excludeFromPrintChkBox;
        private System.Windows.Forms.CheckBox excludeFromCountChkBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CreateNewSheetButton;
        private System.Windows.Forms.ComboBox orientationComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ModifyCurrentSheet;
    }
}