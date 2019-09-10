using System;
namespace DrawingTemplateRuleLib
{
    interface ISheetSettings
    {
        System.Collections.Generic.List<string> Borders { get; }
        void CreateNewSheet();
        string CurrentSheetFormat { get; set; }
        void Dispose();
        bool ExcludeFromCount { get; set; }
        bool ExcludeFromPrinting { get; set; }
        Inventor.Application InventorApp { get; set; }
        string SelectedOrientation { get; set; }
        string SelectedBorder { get; set; }
        string SelectedSheetSize { get; set; }
        string SelectedTitleBlock { get; set; }
        string SelectedTitleBlockPlacement { get; set; }
        System.Collections.Generic.List<string> SheetFormatsList { get; set; }
        string SheetHeight { get; set; }
        string SheetName { get; set; }
        System.Collections.Generic.List<string> SheetSizesList { get; }
        string SheetWidth { get; set; }
        System.Collections.Generic.List<string> TitleBlockPlacement { get; }
        System.Collections.Generic.List<string> TitleBlocks { get; }
        bool AddNewSheetFormat { get; set; }
        string SelectedSheetFormat { get; set; }
        void SetSheetToFormatStyle();
        string NewSheetFormatName { get; set; }
        void ModifyExistingSheet();

        void GetActiveSheetSettings();
    }
}
