using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inventor;
using System.Windows.Forms;

namespace DrawingTemplateRuleLib
{
    public class SheetSettings : DrawingTemplateRuleLib.ISheetSettings
    {
        private DrawingDocument drawDoc;
        //private Sheet createdSheet;
        private List<string> sheetSizesList;
        private List<string> sheetFormatsList;
        private List<string> borders;
        private List<string> titleBlocks;
        private List<string> titleBlockPlacement;
        private string sheetHeight;
        private string sheetWidth;
        private Sheet currentlyActiveSheet;
        private string sheetName;

        public Inventor.Application InventorApp { get; set; }

        public string SheetName 
        { 
            get
            {
                if(sheetName.Contains(':'))
                {
                    int index = sheetName.IndexOf(":");
                    sheetName = sheetName.Remove(index );
                }
                return sheetName;
            }
            set { sheetName = value; }
        }

        public List<string> SheetSizesList 
        { 
            get
            {
                if(sheetSizesList.Count < 1)
                {
                    sheetSizesList.Add("A size");
                    sheetSizesList.Add("B size");
                    sheetSizesList.Add("C size");
                    sheetSizesList.Add("D size");
                    sheetSizesList.Add("E size");
                    sheetSizesList.Add("F size");
                    sheetSizesList.Add("A0 size");
                    sheetSizesList.Add("A1 size");
                    sheetSizesList.Add("A2 size");
                    sheetSizesList.Add("A3 size");
                    sheetSizesList.Add("A4 size");
                    sheetSizesList.Add("Custom sheet size (inches)");
                    sheetSizesList.Add("Custom sheet size (mm)");
                    //sheetSizesList.Add("9x12 (inches)");
                    //sheetSizesList.Add("12x18 (inches)");
                    //sheetSizesList.Add("18x24 (inches)");
                    //sheetSizesList.Add("24x36 (inches)");
                    //sheetSizesList.Add("36x48 (inches)");
                    //sheetSizesList.Add("30x42 (inches)");
                }
                return sheetSizesList;
            }
        }

        public string SheetHeight 
        { 
            get
            {
                switch(SelectedSheetSize)
                {
                    case "A size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "8.5" : "11.0";
                        break;
                    case "B size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "11.0" : "17.0";
                        break;
                    case "C size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "17.0" : "22.0";
                        break;
                    case "D size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "22.0" : "34.0";
                        break;
                    case "E size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "34.0" : "44.0";
                        break;
                    case "F size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "28.0" : "40.0";
                        break;
                    case "A0 size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "841.0" : "1189.0";
                        break;
                    case "A1 size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "594.0" : "841.0";
                        break;
                    case "A2 size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "420.0" : "594.0";
                        break;
                    case "A3 size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "297.0" : "420.0";
                        break;
                    case "A4 size":
                        sheetHeight = (SelectedOrientation.Equals("Landscape")) ? "210.0" : "297.0";
                        break;
                }
                
                return sheetHeight;
            }
            set
            {
                sheetHeight = value;
            }
        }

        public string SheetWidth 
        { 
            get
            {
                switch(SelectedSheetSize)
                {
                    case "A size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "11.0" : "8.5";
                        break;
                    case "B size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "17.0" : "11.0";
                        break;
                    case "C size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "22.0" : "17.0";
                        break;
                    case "D size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "34.0" : "22.0";
                        break;
                    case "E size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "44.0" : "34.0";
                        break;
                    case "F size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "40.0" : "28.0";
                        break;
                    case "A0 size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "1189.0" : "841.0";
                        break;
                    case "A1 size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "841.0" : "594.0";
                        break;
                    case "A2 size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "594.0" : "420.0";
                        break;
                    case "A3 size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "420.0" : "297.0";
                        break;
                    case "A4 size":
                        sheetWidth = (SelectedOrientation.Equals("Landscape")) ? "297.0" : "210.0";
                        break;
                }
                
                return sheetWidth;
            }
            set
            { sheetWidth = value; }
        }

        public string SelectedSheetSize { get; set; }
        public string SelectedOrientation { get; set; }
        public string SelectedBorder { get; set; }
        public string SelectedTitleBlock { get; set; }
        public string SelectedTitleBlockPlacement { get; set; }
        public string SelectedSheetFormat { get; set; }
        public bool AddNewSheetFormat { get; set; }
        public string NewSheetFormatName { get; set; }

        public string CurrentSheetFormat { get; set; }

        public List<string> SheetFormatsList 
        { 
            get
            {
                if(sheetFormatsList.Count < 1)
                {
                    foreach(Inventor.SheetFormat sheetFormat in drawDoc.SheetFormats)
                    {
                        sheetFormatsList.Add(sheetFormat.Name);
                        
                    }
                    sheetFormatsList.Add(@"*New Custom Sheet Format*");
                }
                sheetFormatsList.Sort();
                return sheetFormatsList; 
            }
            set
            {
                sheetFormatsList = value;
            }
        }

        public List<string> Borders 
        { 
            get
            {
                foreach(BorderDefinition bD in drawDoc.BorderDefinitions)
                {
                    borders.Add(bD.Name);
                }
                borders.Sort();
                return borders;
            }
        }

        public List<string> TitleBlocks 
        { 
            get
            {
                foreach(Inventor.TitleBlockDefinition tb in drawDoc.TitleBlockDefinitions)
                {
                    titleBlocks.Add(tb.Name);
                }

                titleBlocks.Sort();
                return titleBlocks;
            }
        }

        public List<string> TitleBlockPlacement 
        { 
            get
            {
                return titleBlockPlacement;
            }
        }

        public bool ExcludeFromCount { get; set; }
        public bool ExcludeFromPrinting { get; set; }

        //Constructor
        public SheetSettings(Inventor.Application inventorApp, Document drawingDoc )
        {
            try
            {
                InventorApp = inventorApp;
                drawDoc = drawingDoc as DrawingDocument;
                if(drawDoc == null)
                {
                    throw new Exception("The Sheet Manager can only be used inside of a Drawing file.");
                }

                currentlyActiveSheet = drawDoc.ActiveSheet;

                sheetSizesList = new List<string>();
                sheetFormatsList = new List<string>();
                borders = new List<string>();
                titleBlocks = new List<string>();
                titleBlockPlacement = new List<string>();

                titleBlockPlacement.Add("Lower Left");
                titleBlockPlacement.Add("Lower Right");
                titleBlockPlacement.Add("Upper Right");
                titleBlockPlacement.Add("Upper Left");

                SheetName = currentlyActiveSheet.Name;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ModifyExistingSheet()
        {
            if(!CurrentSheetFormat.Equals(@"*New Custom Sheet Format*"))
            {
                ExistingSheetFromSheetFormat();
            }
            else if(!(SelectedSheetSize.Equals("Custom sheet size (inches)") ||
                SelectedSheetSize.Equals("Custom sheet size (mm)")))
            {
                ExistingSheetWithStandardSize();
            }
            else
            {
                ExistingSheetWithCustomSize();
            }
        }

        private void ExistingSheetWithCustomSize()
        {
            Sheet existingSheet = drawDoc.ActiveSheet;

            ConvertSheetSizeToInventorUnits();

            existingSheet.Height = Convert.ToDouble(SheetHeight);
            existingSheet.Width = Convert.ToDouble(SheetWidth);

            AddSheetMetaData(existingSheet);

            if(AddNewSheetFormat)
            {
                CreateNewSheetFormat(existingSheet);
            }
        }

        private void ExistingSheetWithStandardSize()
        {
            Sheet existingSheet = drawDoc.ActiveSheet;

            existingSheet.Size = GetDrawingSize();

            AddSheetMetaData(existingSheet);

            if(AddNewSheetFormat)
            {
                CreateNewSheetFormat(existingSheet);
            }
        }

        private void ExistingSheetFromSheetFormat()
        {
            Sheet existingSheet;
            string workspacePath = InventorApp.FileLocations.Workspace;
            SheetFormat sheetFormatForUse = GetSheetFormat();
            string modelForViewsPath = "";
            if(sheetFormatForUse.HasDrawingViews)
            {
                drawDoc.ActiveSheet.Delete();
                Inventor.FileDialog fileDialog;
                this.InventorApp.CreateFileDialog(out fileDialog);
                fileDialog.Filter = "Autodesk Inventor Files (*.ipt;*.iam;*.ipn)|"
                                        + "*.ipt;*.iam;*.ipn|"
                                        + "Autodesk Inventor Part Files (*.ipt)|*.ipt|"
                                        + "Autodesk Inventor Assembly Files (*.iam)|*.iam|"
                                        + "Autodesk Inventor Presentation Files (*.ipn)|*.ipn";
                fileDialog.FilterIndex = 1;
                fileDialog.DialogTitle = "Choose the Model File";
                fileDialog.InitialDirectory = workspacePath;
                fileDialog.CancelError = false;
                fileDialog.OptionsEnabled = false;
                fileDialog.MultiSelectEnabled = false;
                fileDialog.SuppressResolutionWarnings = true;
                fileDialog.ShowOpen();
                modelForViewsPath = fileDialog.FileName;

                if((String.IsNullOrEmpty(modelForViewsPath)))
                {
                    MessageBox.Show("No file selected.");
                    throw new Exception("No file selected");
                }
                existingSheet = drawDoc.Sheets.AddUsingSheetFormat(sheetFormatForUse,
                           Model: modelForViewsPath, SheetName: SheetName);
                AddSheetMetaData(existingSheet);
                //existingSheet.ExcludeFromCount = ExcludeFromCount;
                //existingSheet.ExcludeFromPrinting = ExcludeFromPrinting;
                //existingSheet.Name = SheetName;
            }
            else
            {
                existingSheet = drawDoc.ActiveSheet;
                existingSheet.Size = GetDrawingSize();
                AddSheetMetaData(existingSheet);
                //existingSheet.ExcludeFromCount = ExcludeFromCount;
                //existingSheet.ExcludeFromPrinting = ExcludeFromPrinting;
                //existingSheet.Name = SheetName;
            }
        }
        
        public void CreateNewSheet()
        {
            if(!CurrentSheetFormat.Equals(@"*New Custom Sheet Format*"))
            {
                NewSheetFromSheetFormat();
            }
            else if(!(SelectedSheetSize.Equals("Custom sheet size (inches)") ||
                SelectedSheetSize.Equals("Custom sheet size (mm)")))
            {
                NewSheetWithStandardSize();
            }
            else
            {
                NewSheetWithCustomSize();
            }
        }

        private void NewSheetWithCustomSize()
        {
            Sheet createdSheet = drawDoc.Sheets.Add(this.GetDrawingSize(), 
                this.GetPageOrientation());

            createdSheet.Height = Convert.ToDouble(SheetHeight);
            createdSheet.Width = Convert.ToDouble(SheetWidth);

            AddSheetMetaData(createdSheet);

            if(AddNewSheetFormat)
            {
                CreateNewSheetFormat(createdSheet);
            }
        }

        private void NewSheetWithStandardSize()
        {
            Sheet createdSheet = drawDoc.Sheets.Add(this.GetDrawingSize(), this.GetPageOrientation(),
            SheetName);

            AddSheetMetaData(createdSheet);

            if(AddNewSheetFormat)
            {
                CreateNewSheetFormat(createdSheet);
            }
        }

        private void NewSheetFromSheetFormat()
        {
            Sheet createdSheet;
            string workspacePath = InventorApp.FileLocations.Workspace;
            SheetFormat sheetFormatForUse = GetSheetFormat();
            string modelForViewsPath = "";
            if(sheetFormatForUse.HasDrawingViews)
            {
                Inventor.FileDialog fileDialog;
                this.InventorApp.CreateFileDialog(out fileDialog);
                fileDialog.Filter = "Autodesk Inventor Files (*.ipt;*.iam;*.ipn)|"
                                        + "*.ipt;*.iam;*.ipn|"
                                        + "Autodesk Inventor Part Files (*.ipt)|*.ipt|"
                                        + "Autodesk Inventor Assembly Files (*.iam)|*.iam|"
                                        + "Autodesk Inventor Presentation Files (*.ipn)|*.ipn";
                fileDialog.FilterIndex = 1;
                fileDialog.DialogTitle = "Choose the Model File";
                fileDialog.InitialDirectory = workspacePath;
                fileDialog.CancelError = false;
                fileDialog.OptionsEnabled = false;
                fileDialog.MultiSelectEnabled = false;
                fileDialog.SuppressResolutionWarnings = true;
                fileDialog.ShowOpen();
                modelForViewsPath = fileDialog.FileName;

                if((String.IsNullOrEmpty(modelForViewsPath)))
                {
                    MessageBox.Show("No file selected.");
                    throw new Exception("No file selected");
                }
                createdSheet = drawDoc.Sheets.AddUsingSheetFormat(sheetFormatForUse,
                           Model: modelForViewsPath, SheetName: SheetName);

                createdSheet.ExcludeFromCount = ExcludeFromCount;
                createdSheet.ExcludeFromPrinting = ExcludeFromPrinting;
                createdSheet.Name = (String.IsNullOrEmpty(SheetName)) ? "Sheet" : SheetName;
                createdSheet.Orientation = this.GetPageOrientation();
                createdSheet.Activate();
            }
            else
            {
                createdSheet = drawDoc.Sheets.AddUsingSheetFormat(sheetFormatForUse,
                SheetName: SheetName);

                createdSheet.ExcludeFromCount = ExcludeFromCount;
                createdSheet.ExcludeFromPrinting = ExcludeFromPrinting;
                createdSheet.Name = (String.IsNullOrEmpty(SheetName)) ? "Sheet" : SheetName;
                createdSheet.Orientation = this.GetPageOrientation();
                createdSheet.Activate();
            }
        }

        private void AddSheetMetaData(Sheet sheet)
        {
            if(sheet.TitleBlock != null)
            { sheet.TitleBlock.Delete(); }

            if(sheet.Border != null)
                sheet.Border.Delete();
            
            TitleBlockDefinition tempTitleBlockDef = GetTitleBlock();
            TitleBlockLocationEnum titleBlockLocation = GetTitleBlockLocation();

            string[] promptStrings = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", 
                "", "", "", "", "", "", "", "", "", "", "", "", "", ""};
            
            TitleBlock titleBlockForCreatedSheet =
                sheet.AddTitleBlock(tempTitleBlockDef, titleBlockLocation, promptStrings);

            if(SelectedBorder.Equals("Default Border"))
            {
                sheet.AddDefaultBorder();
            }
            else
            sheet.AddBorder(BorderDefinition: GetBorderDefinition(SelectedBorder));

            sheet.ExcludeFromCount = ExcludeFromCount;
            sheet.ExcludeFromPrinting = ExcludeFromPrinting;
            sheet.Name = SheetName;
            sheet.Orientation = this.GetPageOrientation();

            if(drawDoc.ActiveSheet != sheet)
                sheet.Activate();
        }

        private TitleBlockDefinition GetTitleBlock()
        {
            TitleBlockDefinition returnedTitleBlock = drawDoc.TitleBlockDefinitions[1];

            foreach(TitleBlockDefinition tD in drawDoc.TitleBlockDefinitions)
            {
                if(tD.Name.Equals(SelectedTitleBlock))
                {
                    returnedTitleBlock = tD;
                }
            }
            return returnedTitleBlock;
        }

        private object GetBorderDefinition(string SelectedBorder)
        {
            object returnedBorderDefinition = drawDoc.BorderDefinitions[1];
            
            foreach(BorderDefinition bd in drawDoc.BorderDefinitions)
            {
                if(bd.Name.Equals(SelectedBorder))
                {
                    returnedBorderDefinition = bd;
                }
            }
            if(returnedBorderDefinition == null)
            {
                DefaultBorder defaultBorder = drawDoc.ActiveSheet.AddDefaultBorder();
                returnedBorderDefinition = defaultBorder;
            }
            return returnedBorderDefinition;
        }

        private void CreateNewSheetFormat(Sheet sheetUsed)
        {
            NewSheetFormatName = (String.IsNullOrEmpty(NewSheetFormatName)) ? "New Sheet Format" :
                NewSheetFormatName;
            SheetFormat newSheetFormat = drawDoc.SheetFormats.Add(sheetUsed, NewSheetFormatName);
        }

        private SheetFormat GetSheetFormat()
        {
            SheetFormat sheetFormat = drawDoc.SheetFormats[CurrentSheetFormat];
            return sheetFormat;
        }

        private TitleBlockLocationEnum GetTitleBlockLocation()
        {
            TitleBlockLocationEnum myTitleBlockLocation;

            switch(SelectedTitleBlockPlacement)
            {
                case "Lower Right":
                    myTitleBlockLocation = TitleBlockLocationEnum.kBottomRightPosition;
                    break;
                case "Lower Left":
                    myTitleBlockLocation = TitleBlockLocationEnum.kBottomLeftPosition;
                    break;
                case "Upper Left":
                    myTitleBlockLocation = TitleBlockLocationEnum.kTopLeftPosition;
                    break;
                case "Upper Right":
                    myTitleBlockLocation = TitleBlockLocationEnum.kTopRightPosition;
                    break;
                default:
                    myTitleBlockLocation = TitleBlockLocationEnum.kBottomRightPosition;
                    break;
            }
            return myTitleBlockLocation;
        }

        private PageOrientationTypeEnum GetPageOrientation()
        {
            PageOrientationTypeEnum pageOrientation;
            pageOrientation = (SelectedOrientation.Equals("Portrait") ? 
                PageOrientationTypeEnum.kPortraitPageOrientation : 
                PageOrientationTypeEnum.kLandscapePageOrientation);

            return pageOrientation;
        }
        
        private DrawingSheetSizeEnum GetDrawingSize()
        {
            if(SelectedSheetSize.Equals("Custom sheet size (inches)") ||
                SelectedSheetSize.Equals("Custom sheet size (mm)"))
            {
                ConvertSheetSizeToInventorUnits();
                return DrawingSheetSizeEnum.kCustomDrawingSheetSize;
            }
            else
            {
                DrawingSheetSizeEnum sheetSizeToReturn;
                switch(SelectedSheetSize)
                {
                    case "A size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kADrawingSheetSize;
                        break;
                    case "B size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kBDrawingSheetSize;
                        break;
                    case "C size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kCDrawingSheetSize;
                        break;
                    case "D size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kDDrawingSheetSize;
                        break;
                    case "E size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kEDrawingSheetSize;
                        break;
                    case "F size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kFDrawingSheetSize;
                        break;
                    case "A0 size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kA0DrawingSheetSize;
                        break;
                    case "A1 size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kA1DrawingSheetSize;
                        break;
                    case "A2 size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kA2DrawingSheetSize;
                        break;
                    case "A3 size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kA3DrawingSheetSize;
                        break;
                    case "A4 size":
                        sheetSizeToReturn = DrawingSheetSizeEnum.kA4DrawingSheetSize;
                        break;
                    default:
                        sheetSizeToReturn = DrawingSheetSizeEnum.kADrawingSheetSize;
                        break;
                }
                return sheetSizeToReturn;
            }
        }

        private void ConvertSheetSizeToInventorUnits()
        {
            if(this.SelectedSheetSize.Equals("Custom sheet size (inches)"))
            {
                //if(String.IsNullOrEmpty(SheetHeight))
                //    SheetHeight = "8.5";
                //if(String.IsNullOrEmpty(SheetWidth))
                //    SheetWidth = "11";
                double height;
                double width;
                try
                {
                    height = Convert.ToDouble(SheetHeight);
                    width = Convert.ToDouble(SheetWidth);
                }
                catch(Exception)
                {
                    MessageBox.Show("Invalid input for Height or Width.");
                    throw;
                }
                
                height = height * 2.54;
                width = width * 2.54;

                SheetHeight = Convert.ToString(height);
                SheetWidth = Convert.ToString(width);
            }
            else if(SelectedSheetSize.Equals("Custom sheet size (mm)"))
            {
                //if(String.IsNullOrEmpty(SheetHeight))
                //    SheetHeight = "210";
                //if(String.IsNullOrEmpty(SheetWidth))
                //    SheetWidth = "297";

                double height;
                double width;

                try
                {
                    height = Convert.ToDouble(SheetHeight);
                    width = Convert.ToDouble(SheetWidth);
                }
                catch(Exception)
                {
                    MessageBox.Show("Invalid input for Height or Width.");
                    throw;
                }

                height = height * 0.1;
                width = width * 0.1;

                SheetHeight = Convert.ToString(height);
                SheetWidth = Convert.ToString(width);
            }
        }

        public void Dispose()
        {
            sheetFormatsList.Clear();
            sheetSizesList.Clear();
            sheetHeight = "";
            sheetWidth = "";
            SheetName = "";
            borders.Clear();
            titleBlocks.Clear();
            titleBlockPlacement.Clear();
        }

        public void SetSheetToFormatStyle()
        {
            SheetFormat activeFormat = drawDoc.SheetFormats[1];

            foreach(SheetFormat format in drawDoc.SheetFormats)
            {
                if(format.Name.Equals(SelectedSheetFormat))
                {
                    activeFormat = format;
                }
            }

            SelectedSheetSize = GetSheetSize(activeFormat.Size);
            SheetHeight = Convert.ToString(activeFormat.Height);
            SheetWidth = Convert.ToString(activeFormat.Width);
            SelectedOrientation = GetActiveOrientation(activeFormat.Orientation);
            SelectedTitleBlock = activeFormat.ReferencedTitleBlockDefinition.Name;
            SelectedTitleBlockPlacement = GetActiveTitleBlockPlacement
                (activeFormat.TitleBlockLocation);
            SelectedBorder = activeFormat.ReferencedBorderDefinition.Name;
        }

        private string GetActiveTitleBlockPlacement(TitleBlockLocationEnum titleBlockLocationEnum)
        {
            string currentTitleBlockLocation;

            switch(titleBlockLocationEnum)
            {
                case TitleBlockLocationEnum.kBottomLeftPosition:
                    currentTitleBlockLocation = "Lower Left";
                    break;
                case TitleBlockLocationEnum.kBottomRightPosition:
                    currentTitleBlockLocation = "Lower Right";
                    break;
                case TitleBlockLocationEnum.kTopLeftPosition:
                    currentTitleBlockLocation = "Upper Left";
                    break;
                case TitleBlockLocationEnum.kTopRightPosition:
                    currentTitleBlockLocation = "Upper Right";
                    break;
                default:
                    currentTitleBlockLocation = "Lower Right";
                    break;
            }
            return currentTitleBlockLocation;
        }

        private string GetActiveOrientation(PageOrientationTypeEnum pageOrientationTypeEnum)
        {
            string currentOrientation;

            switch(pageOrientationTypeEnum)
            {
                case PageOrientationTypeEnum.kDefaultPageOrientation:
                    currentOrientation = "Landscape";
                    break;
                case PageOrientationTypeEnum.kLandscapePageOrientation:
                    currentOrientation = "Landscape";
                    break;
                case PageOrientationTypeEnum.kPortraitPageOrientation:
                    currentOrientation = "Portrait";
                    break;
                default:
                    currentOrientation = "Landscape";
                    break;
            }
            return currentOrientation;
        }

        private string GetSheetSize(DrawingSheetSizeEnum drawingSheetSizeEnum)
        {
            string sheetSizeString;

            switch(drawingSheetSizeEnum)
            {
                case DrawingSheetSizeEnum.kA0DrawingSheetSize:
                    sheetSizeString = "A0 size";
                    break;
                case DrawingSheetSizeEnum.kA1DrawingSheetSize:
                    sheetSizeString = "A1 size";
                    break;
                case DrawingSheetSizeEnum.kA2DrawingSheetSize:
                    sheetSizeString = "A2 size";
                    break;
                case DrawingSheetSizeEnum.kA3DrawingSheetSize:
                    sheetSizeString = "A3 size";
                    break;
                case DrawingSheetSizeEnum.kA4DrawingSheetSize:
                    sheetSizeString = "A4 size";
                    break;
                case DrawingSheetSizeEnum.kADrawingSheetSize:
                    sheetSizeString = "A size";
                    break;
                case DrawingSheetSizeEnum.kBDrawingSheetSize:
                    sheetSizeString = "B size";
                    break;
                case DrawingSheetSizeEnum.kCDrawingSheetSize:
                    sheetSizeString = "C size";
                    break;
                case DrawingSheetSizeEnum.kCustomDrawingSheetSize:
                    sheetSizeString = "Custom sheet size (inches)";
                    break;
                case DrawingSheetSizeEnum.kDDrawingSheetSize:
                    sheetSizeString = "D size";
                    break;
                case DrawingSheetSizeEnum.kDefaultDrawingSheetSize:
                    sheetSizeString = "Custom sheet size (inches)";
                    break;
                case DrawingSheetSizeEnum.kEDrawingSheetSize:
                    sheetSizeString = "E size";
                    break;
                case DrawingSheetSizeEnum.kFDrawingSheetSize:
                    sheetSizeString = "F size";
                    break;
                default:
                    sheetSizeString = "Custom sheet size (inches)";
                    break;
            }
            return sheetSizeString;
        }


        public void GetActiveSheetSettings()
        {
            
                Sheet activeSheet = drawDoc.ActiveSheet;
                SelectedBorder = activeSheet.Border.Name;
                this.SelectedOrientation = this.GetActiveOrientation(activeSheet.Orientation);
                this.SelectedSheetSize = this.GetSheetSize(activeSheet.Size);
                this.SelectedTitleBlock = activeSheet.TitleBlock.Definition.Name;
                this.SelectedTitleBlockPlacement =
                    this.GetActiveTitleBlockPlacement(activeSheet.TitleBlock.Location);
            
            
        }
    }
}
