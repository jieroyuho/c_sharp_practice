using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace OfficeTestWeb
{
    public partial class Office1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            var ExceldApp = new Excel.Application();

            string appPath = @"C:\Users\tyho\Documents\GitHub\c_sharp_practice\c_sharp_practice\ChangeToDoc\";
            string fileDir = @"Docs\";
            string fileDocx = "1.docx";
            string filePdf = "1.pdf";
             string fileName = appPath + fileDir + fileDocx;
            string fileName_new = appPath + fileDir + filePdf;

            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            wordDocument = appWord.Documents.Open(fileName);
            wordDocument.ExportAsFixedFormat(fileName_new, Word.WdExportFormat.wdExportFormatPDF);

        }

        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }
    }

}