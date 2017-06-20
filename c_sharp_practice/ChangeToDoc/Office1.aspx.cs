using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using Novacode;

namespace OfficeTestWeb
{
    public partial class Office1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var wordApp = new Word.Application();
            //var ExceldApp = new Excel.Application();

            //string appPath = @"C:\Users\tyho\Documents\GitHub\c_sharp_practice\c_sharp_practice\ChangeToDoc\";
            //string fileDir = @"Docs\";
            //string fileDocx = "1.docx";
            //string filePdf = "1.pdf";
            // string fileName = appPath + fileDir + fileDocx;
            //string fileName_new = appPath + fileDir + filePdf;

            //Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            //wordDocument = appWord.Documents.Open(fileName);
            //wordDocument.ExportAsFixedFormat(fileName_new, Word.WdExportFormat.wdExportFormatPDF);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CreateSampleDocument1();
        }

        public void CreateSampleDocument1()
        {
            //string fileName = @"C:\Users\tyho\Desktop\1.docx";
            string appPath = Request.PhysicalApplicationPath;
            string fileDir = @"Docs\";
            string fileDocx = "2.docx";
            string filePdf = "2.pdf";

            string fileName = appPath + fileDir + fileDocx;
            string fileName_new = appPath + fileDir + filePdf;

            //Novacode.Bookmark[] my = new Novacode.Bookmark[3];

            using (Novacode.DocX document = DocX.Load(fileName))
            {
                int i = 0;

                foreach (Novacode.Bookmark bookmark in document.Bookmarks)
                {
                    var bookmarks = document.Bookmarks[i].Name;

                    document.Bookmarks[bookmark.Name].SetText("(!!" + i.ToString() + "!!)");

                    i++;
                }
                //document.SaveAs(path2);
                document.Save();
            }

            //var wordApp = new Word.Application();
            //wordApp.Visible = true;
            //wordApp.Documents.Add();
            //wordApp.Selection.PasteSpecial(Link: true, DisplayAsIcon: true);

            //var wordApps = new Microsoft.Office.Interop.Word.Application();


            Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            wordDocument = appWord.Documents.Open(fileName);
            wordDocument.ExportAsFixedFormat(fileName_new, Word.WdExportFormat.wdExportFormatPDF);


            //string fileName = @"C:\Users\tyho\Desktop\1.docx";
            //// Load the document.
            //using (DocX document = DocX.Load(fileName))
            //{
            //    // Replace text in this document.

            //    document.Bookmarks["Test"].SetText("HELLO2");
            //    //document.ReplaceText("%Test%", "HELLO");

            //    // Save changes made to this document.
            //    document.Save();
            //} // Release this document from memory.
        }
        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }
    }

}