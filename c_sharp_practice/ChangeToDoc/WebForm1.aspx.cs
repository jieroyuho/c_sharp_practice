using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Novacode;  // Nuget: install Docx
using System.Diagnostics;
//using Word = Microsoft.Office.Interop.Word; //  Nuget: Microsoft.Office.Interop.Word
using Word = Microsoft.Office.Interop.Word;
using System.Net;
using System.IO;

namespace ChangeToDoc
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            string fileDocx = "3.docx";
            string filePdf = "3.pdf";

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
            wordDocument.Close();







            FileInfo fileInfo = new FileInfo(fileName_new);

            if (fileInfo.Exists)
            {
                Response.Clear();
                Response.AddHeader("Content-Disposition", "attachment; filename=" + fileInfo.Name);
                Response.AddHeader("Content-Length", fileInfo.Length.ToString());
                Response.ContentType = "application/octet-stream";
                Response.Flush();
                Response.TransmitFile(fileInfo.FullName);
                Response.End();
            }



            string filename = "myFile.txt";
            string disHeader = "Attachment; Filename=\"" + filename + "\"";
            Response.AppendHeader("Content-Disposition", disHeader);

            System.IO.FileInfo fileToDownload = new  System.IO.FileInfo("C:\\downloadJSP\\DownloadConv\\myFile.txt");
            Response.Flush();
            Response.WriteFile(fileToDownload.FullName);
    

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
        Microsoft.Office.Interop.Word.Document wordDocument;
        //public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        public void CreateSampleDocument2()
        {
            string fileName = @"C:\Users\tyho\Desktop\DocXExample.docx";
            string headlineText = "Constitution of the United States";
            string paraOne = ""
                + "We the People of the United States, in Order to form a more perfect Union, "
                + "establish Justice, insure domestic Tranquility, provide for the common defence, "
                + "promote the general Welfare, and secure the Blessings of Liberty to ourselves "
                + "and our Posterity, do ordain and establish this Constitution for the United "
                + "States of America.";

            // A formatting object for our headline:
            var headLineFormat = new Formatting();
            headLineFormat.FontFamily = new System.Drawing.FontFamily("Arial Black");
            headLineFormat.Size = 18D;
            headLineFormat.Position = 12;

            // A formatting object for our normal paragraph text:
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 10D;

            // Create the document in memory:
            var doc = DocX.Create(fileName);

            // Insert the now text obejcts;
            doc.InsertParagraph(headlineText, false, headLineFormat);
            doc.InsertParagraph(paraOne, false, paraFormat);

            // Save to the output directory:
            doc.Save();

            // Open in Word:
            Process.Start("WINWORD.EXE", fileName);
        }

        private DocX GetRejectionLetterTemplate()
        {
            // Adjust the path so suit your machine:
            string fileName = @"C:\Users\tyho\Desktop\DocXExample.docx";

            // Set up our paragraph contents:
            string headerText = "Rejection Letter";
            string letterBodyText = DateTime.Now.ToShortDateString();
            string paraTwo = ""
                + "Dear %APPLICANT%" + Environment.NewLine + Environment.NewLine
                + "I am writing to thank you for your resume. Unfortunately, your skills and "
                + "experience do not match our needs at the present time. We will keep your "
                + "resume in our circular file for future reference. Don't call us, "
                + "we'll call you. "

                + Environment.NewLine + Environment.NewLine
                + "Sincerely, "
                + Environment.NewLine + Environment.NewLine
                + "Jim Smith, Corporate Hiring Manager";

            // Title Formatting:
            var titleFormat = new Formatting();
            titleFormat.FontFamily = new System.Drawing.FontFamily("Arial Black");
            titleFormat.Size = 18D;
            titleFormat.Position = 12;

            // Body Formatting
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 10D;
            titleFormat.Position = 12;

            // Create the document in memory:
            var doc = DocX.Create(fileName);

            // Insert each prargraph, with appropriate spacing and alignment:
            Novacode.Paragraph title = doc.InsertParagraph(headerText, false, titleFormat);
            title.Alignment = Alignment.center;

            doc.InsertParagraph(Environment.NewLine);
            Novacode.Paragraph letterBody = doc.InsertParagraph(letterBodyText, false, paraFormat);
            letterBody.Alignment = Alignment.both;

            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(paraTwo, false, paraFormat);

            return doc;
        }

        private DocX GetDoc()
        {
            // Adjust the path so suit your machine:
            string fileName = @"C:\Users\tyho\Desktop\1.docx";

            // Set up our paragraph contents:
            string headerText = "Rejection Letter";
            string letterBodyText = DateTime.Now.ToShortDateString();
            string paraTwo = ""
                + "Dear %APPLICANT%" + Environment.NewLine + Environment.NewLine
                + "I am writing to thank you for your resume. Unfortunately, your skills and "
                + "experience do not match our needs at the present time. We will keep your "
                + "resume in our circular file for future reference. Don't call us, "
                + "we'll call you. "

                + Environment.NewLine + Environment.NewLine
                + "Sincerely, "
                + Environment.NewLine + Environment.NewLine
                + "Jim Smith, Corporate Hiring Manager";

            // Title Formatting:
            var titleFormat = new Formatting();
            titleFormat.FontFamily = new System.Drawing.FontFamily("Arial Black");
            titleFormat.Size = 18D;
            titleFormat.Position = 12;

            // Body Formatting
            var paraFormat = new Formatting();
            paraFormat.FontFamily = new System.Drawing.FontFamily("Calibri");
            paraFormat.Size = 10D;
            titleFormat.Position = 12;

            // Create the document in memory:
            var doc = DocX.Create(fileName);

            // Insert each prargraph, with appropriate spacing and alignment:
            Novacode.Paragraph title = doc.InsertParagraph(headerText, false, titleFormat);
            title.Alignment = Alignment.center;

            doc.InsertParagraph(Environment.NewLine);
            Novacode.Paragraph letterBody = doc.InsertParagraph(letterBodyText, false, paraFormat);
            letterBody.Alignment = Alignment.both;

            doc.InsertParagraph(Environment.NewLine);
            doc.InsertParagraph(paraTwo, false, paraFormat);

            return doc;
        }

        public void CreateRejectionLetter(string applicantField, string applicantName)
        {
            // We will need a file name for our output file (change to suit your machine):
            string fileNameTemplate = @"C:\Users\tyho\Desktop\DocXExample_Change.docx";

            // Let's save the file with a meaningful name, including the 
            // applicant name and the letter date:
            string outputFileName =
            string.Format(fileNameTemplate, applicantName, DateTime.Now.ToString("MM-dd-yy"));

            // Grab a reference to our document template:
            DocX letter = this.GetRejectionLetterTemplate();

            // Perform the replace:
            letter.ReplaceText(applicantField, applicantName);

            // Save as New filename:
            letter.SaveAs(outputFileName);

            // Open in word:
            Process.Start("WINWORD.EXE", "\"" + outputFileName + "\"");
        }
    }
}