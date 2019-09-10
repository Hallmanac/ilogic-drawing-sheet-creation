using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingTemplateRuleLib
{
    public partial class NewSheetCreationForm : Form
    {
        public string ShowMyDialog;
        private Inventor.Application inventorApp;
        private ISheetSettings sheetSettings;
        
        public NewSheetCreationForm(Inventor.Application inventorApp, 
            Inventor.Document drawingDoc)
        {
            try
            {
                this.inventorApp = inventorApp;
                sheetSettings = new SheetSettings(inventorApp, drawingDoc);
                ShowMyDialog = "Constructor was called.";
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error Launching Sheet Manager", MessageBoxButtons.OK,
                       MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                this.Close();
            }
            InitializeComponent();
        }

        private void NewSheetCreationForm_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(500, 250);
        
            orientationComboBox.Text = orientationComboBox.Items[0] as string;
            sheetFormatsComboBox.DataSource = sheetSettings.SheetFormatsList;
            sheetSizeComboBox.DataSource = sheetSettings.SheetSizesList;
            bordersComboBox.DataSource = sheetSettings.Borders;
            titleBlocksComboBox.DataSource = sheetSettings.TitleBlocks;
            titleBlockPlacementComboBox.DataSource = sheetSettings.TitleBlockPlacement;

            try
            {
                sheetSettings.GetActiveSheetSettings();
                sheetSizeComboBox.SelectedItem = sheetSettings.SelectedSheetSize;
                bordersComboBox.SelectedItem = sheetSettings.SelectedBorder;
                titleBlocksComboBox.SelectedItem = sheetSettings.SelectedTitleBlock;
                titleBlockPlacementComboBox.SelectedItem = sheetSettings.SelectedTitleBlockPlacement;
                orientationComboBox.SelectedItem = sheetSettings.SelectedOrientation;
            }
            catch
            {
                orientationComboBox.Text = orientationComboBox.Items[0] as string;
                sheetFormatsComboBox.DataSource = sheetSettings.SheetFormatsList;
                sheetSizeComboBox.DataSource = sheetSettings.SheetSizesList;
                bordersComboBox.DataSource = sheetSettings.Borders;
                titleBlocksComboBox.DataSource = sheetSettings.TitleBlocks;
                titleBlockPlacementComboBox.DataSource = sheetSettings.TitleBlockPlacement;
            }
            //heightTextBox.Text = sheetSettings.SheetHeight;
            //widthTextBox.Text = sheetSettings.SheetWidth;            

            ChangeTextBoxToReadOnly(ref heightTextBox);
            ChangeTextBoxToReadOnly(ref widthTextBox);

            sheetNameTextBox.Text = sheetSettings.SheetName;
        }

        private void ChangeTextBoxToReadOnly(ref TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.ControlLight);
            textBox.ForeColor = System.Drawing.Color.FromKnownColor(KnownColor.InactiveCaptionText);
            textBox.ReadOnly = true;
            textBox.Enabled = false;
        }

        private void ChangeTextBoxToWriteable(ref TextBox textBox)
        {
            textBox.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.Window);
            textBox.ForeColor = System.Drawing.Color.FromKnownColor(KnownColor.WindowText);
            textBox.ReadOnly = false;
            textBox.Enabled = true;
        }

        private void createNewSheetFormatChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(this.createNewSheetFormatChkBox.Checked)
            {
                ChangeTextBoxToWriteable(ref newSheetFormatNameTxtBox);
                sheetSettings.AddNewSheetFormat = true;
            }
            else if(!createNewSheetFormatChkBox.Checked)
            {
                ChangeTextBoxToReadOnly(ref newSheetFormatNameTxtBox);
                newSheetFormatNameTxtBox.Text = "";
                sheetSettings.AddNewSheetFormat = false;
            }
        }

        private void sheetSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(sheetSizeComboBox.SelectedItem == null))
            {
                sheetSettings.SelectedSheetSize = (string)sheetSizeComboBox.SelectedItem;
                sheetSettings.SelectedOrientation = (string)orientationComboBox.SelectedItem;
                heightTextBox.Text = sheetSettings.SheetHeight;
                widthTextBox.Text = sheetSettings.SheetWidth;

                if((sheetSettings.SelectedSheetSize.Equals("Custom sheet size (inches)") ||
                    sheetSettings.SelectedSheetSize.Equals("Custom sheet size (mm)")))
                {
                    ChangeTextBoxToWriteable(ref heightTextBox);
                    ChangeTextBoxToWriteable(ref widthTextBox);
                }
                else if(!(heightTextBox.ReadOnly) || !(widthTextBox.ReadOnly))
                {
                    ChangeTextBoxToReadOnly(ref heightTextBox);
                    ChangeTextBoxToReadOnly(ref widthTextBox);
                } 
            }
        }

        private void orientationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sheetSettings.SelectedSheetSize = (string)sheetSizeComboBox.SelectedItem;
            sheetSettings.SelectedOrientation = (string)orientationComboBox.SelectedItem;
            heightTextBox.Text = sheetSettings.SheetHeight;
            widthTextBox.Text = sheetSettings.SheetWidth;
        }

        private void sheetFormatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sheetFormatsComboBox.SelectedItem != null)
            {
                if(!((string)sheetFormatsComboBox.SelectedItem).Equals(@"*New Custom Sheet Format*"))
                {
                    sheetSettings.SelectedSheetFormat = (string)sheetFormatsComboBox.SelectedItem;
                    sheetSettings.SetSheetToFormatStyle();
                    sheetSizeComboBox.SelectedItem = sheetSettings.SelectedSheetSize;
                    orientationComboBox.SelectedItem = sheetSettings.SelectedOrientation;
                    bordersComboBox.SelectedItem = sheetSettings.SelectedBorder;
                    titleBlocksComboBox.SelectedItem = sheetSettings.SelectedTitleBlock;
                    titleBlockPlacementComboBox.SelectedItem = 
                        sheetSettings.SelectedTitleBlockPlacement;
                    heightTextBox.Text = sheetSettings.SheetHeight;
                    widthTextBox.Text = sheetSettings.SheetWidth;
                    LockForm();
                }
                else 
                {
                    sheetSettings.SelectedSheetSize = "A size";
                    UnlockForm(); 
                }
            }
        }

        private void UnlockForm()
        {
            sheetSizeComboBox.Enabled = true;
            heightTextBox.Enabled = ((sheetSettings.SelectedSheetSize.Equals
                ("Custom sheet size (inches)") ||
                sheetSettings.SelectedSheetSize.Equals("Custom sheet size (mm)"))) ? true : false;
            widthTextBox.Enabled = ((sheetSettings.SelectedSheetSize.Equals
                ("Custom sheet size (inches)") ||
                sheetSettings.SelectedSheetSize.Equals("Custom sheet size (mm)"))) ? true : false;
            orientationComboBox.Enabled = true;
            bordersComboBox.Enabled = true;
            titleBlocksComboBox.Enabled = true;
            titleBlockPlacementComboBox.Enabled = true;
            createNewSheetFormatChkBox.Enabled = true;
        }

        private void LockForm()
        {
            sheetSizeComboBox.Enabled = false;
            heightTextBox.Enabled = false;
            widthTextBox.Enabled = false;
            orientationComboBox.Enabled = false;
            bordersComboBox.Enabled = false;
            titleBlocksComboBox.Enabled = false;
            titleBlockPlacementComboBox.Enabled = false;
            createNewSheetFormatChkBox.Enabled = false;
        }

        private void NewSheetCreationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sheetFormatsComboBox != null)
            {
                sheetFormatsComboBox.DataSource = null;
                sheetSizeComboBox.DataSource = null;
                bordersComboBox.DataSource = null;
                titleBlocksComboBox.DataSource = null;
                titleBlockPlacementComboBox.DataSource = null;
                heightTextBox.Text = "";
                widthTextBox.Text = "";
                sheetSettings.Dispose(); 
            }
        }

        private void CreateNewSheetButton_Click(object sender, EventArgs e)
        {
            sheetSettings.AddNewSheetFormat = createNewSheetFormatChkBox.Checked;
            sheetSettings.CurrentSheetFormat = (string)sheetFormatsComboBox.SelectedItem;
            sheetSettings.SelectedBorder = (string)bordersComboBox.SelectedItem;
            sheetSettings.SelectedOrientation = (string)orientationComboBox.SelectedItem;
            sheetSettings.SelectedTitleBlock = (string)titleBlocksComboBox.SelectedItem;
            sheetSettings.SelectedTitleBlockPlacement = 
                (string)titleBlockPlacementComboBox.SelectedItem;
            sheetSettings.SheetHeight = heightTextBox.Text;
            sheetSettings.SheetWidth = widthTextBox.Text;
            sheetSettings.SelectedSheetFormat = (string)sheetFormatsComboBox.SelectedItem;
            sheetSettings.SelectedSheetSize = (string)sheetSizeComboBox.SelectedItem;
            sheetSettings.NewSheetFormatName = newSheetFormatNameTxtBox.Text;
            sheetSettings.ExcludeFromCount = excludeFromCountChkBox.Checked;
            sheetSettings.ExcludeFromPrinting = excludeFromPrintChkBox.Checked;
            sheetSettings.SheetName = sheetNameTextBox.Text;
            try
            {
                sheetSettings.CreateNewSheet();
            }
            catch(Exception exception)
            {
                MessageBox.Show("An error occurred with the code for the Sheet Manager tool."
                    + "\nIf at all possible, please take a screen capture of this error message and send"
                    + " it to Brian Hall at the following email address:"
                    + "\nBHall@QubeItDesign.com\n\n*************************"
                    + exception.ToString());
                return;
            }
            this.Close();
        }

        private void ModifyCurrentSheet_Click(object sender, EventArgs e)
        {
            sheetSettings.AddNewSheetFormat = createNewSheetFormatChkBox.Checked;
            sheetSettings.CurrentSheetFormat = (string)sheetFormatsComboBox.SelectedItem;
            sheetSettings.SelectedBorder = (string)bordersComboBox.SelectedItem;
            sheetSettings.SelectedOrientation = (string)orientationComboBox.SelectedItem;
            sheetSettings.SelectedTitleBlock = (string)titleBlocksComboBox.SelectedItem;
            sheetSettings.SelectedTitleBlockPlacement =
                (string)titleBlockPlacementComboBox.SelectedItem;
            sheetSettings.SheetHeight = heightTextBox.Text;
            sheetSettings.SheetWidth = widthTextBox.Text;
            sheetSettings.SelectedSheetFormat = (string)sheetFormatsComboBox.SelectedItem;
            sheetSettings.SelectedSheetSize = (string)sheetSizeComboBox.SelectedItem;
            sheetSettings.NewSheetFormatName = newSheetFormatNameTxtBox.Text;
            sheetSettings.ExcludeFromCount = excludeFromCountChkBox.Checked;
            sheetSettings.ExcludeFromPrinting = excludeFromPrintChkBox.Checked;
            sheetSettings.SheetName = sheetNameTextBox.Text;
            try
            {
                sheetSettings.ModifyExistingSheet();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred with the code for the Sheet Manager tool."
                    + "\nIf at all possible, please take a screen capture of this error message and send"
                    + " it to Brian Hall at the following email address:"
                    + "\nBHall@QubeItDesign.com\n\n*************************"
                    + exception.ToString());
                return;
            }
            this.Close();
        }
    }
}
