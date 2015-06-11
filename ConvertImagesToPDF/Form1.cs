/*
// Debenu Quick PDF Library (Convert Images to PDF Sample)
//
// Visit product website for more information and trial download with license key:
// http://www.debenu.com/products/development/debenu-pdf-library/
//
// A trial or commercial license key is required to run this sample.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DebenuPDFLibraryDLL1115;

namespace ConvertImageToPDF
{
    public partial class frmMain : Form
    {
        // Debenu Quick PDF Library DLL Edition setup
        PDFLibrary DPL;
        int DPLVer = 1115;

        public frmMain()
        {
            InitializeComponent();

            // Different filename for 32-bit and 64-bit DLL
            string DLLprefix = "DebenuPDFLibraryDLL";
            string DLL64prefix = "DebenuPDFLibrary64DLL";

            string dllName;

            // Check to see if IntPtr size is 4.
            // If 4 then it's 32-bit, if 8 then
            // it is 64-bit.
            if (IntPtr.Size == 4)
            {
                dllName = DLLprefix + DPLVer.ToString("D4") + ".DLL"; // 32 bits 
            }
            else
            {
                dllName = DLL64prefix + DPLVer.ToString("D4") + ".DLL"; // 64 bits 
            }

            // Load the library
            DPL = new PDFLibrary(Application.StartupPath + @"\" + dllName);

            // Test unlock key, you can get a license key by downloading trial
			// of Debenu Quick PDF Library from (www.debenu.com) or by using
			// your commercial license key if you have purchased a license.
            if (DPL.UnlockKey("...insert_license_key_here...") == 0)
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Error]: Debenu Quick PDF Library could not be unlocked, please check your license key and try again.");
            }
            else
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Success]: Debenu Quick PDF Library was unlocked.");
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        // Set the output folder to the desktop as default
            textBoxSaveFiles.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        // Exit the application
            Close();
        }

        private void btnConvertImages_Click(object sender, EventArgs e)
        {
            // Check to see that user actually has any items in the list
            if (listBoxImages.Items.Count == 0)
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Error]: Please add one or more images to the list and try again.");
                return;
            }

            // Iterate through each image filename in the listbox
            bool bFail = false;
            foreach (string sImageFileName in listBoxImages.Items)
            {
                // Create a blank document
                DPL.NewDocument();

                // Load next image into memory
                int imageID = DPL.AddImageFromFile(sImageFileName, 0);

                // Check to see if image loaded successfully
                if (imageID == 0)
                {
                    txtBoxLog.AppendText(Environment.NewLine);
                    txtBoxLog.AppendText("> [Error]: Unable to load the file (" + sImageFileName + ").");

                    bFail = true;
                    continue;
                }
                
                // Select the load image, technically selected by default
                // after loading but selecting again to be safe
                DPL.SelectImage(imageID);

                // Get horizontal and vertical image resolution
                int dpix = DPL.ImageHorizontalResolution();
                int dpiy = DPL.ImageVerticalResolution();

                if (dpix == 0) dpix = 72;
                if (dpiy == 0) dpiy = 72;

                // Get width, height of image in points

                double ImageWidthInPoints = (double)DPL.ImageWidth() / dpix * 72.0; // assumming dpi units
                double ImageHeightInPoints = (double)DPL.ImageHeight() / dpiy * 72.0;

                // Set origin for drawing functions to top
                // left of page 0, 0
                DPL.SetOrigin(1);

                if(DPL.SetPageDimensions(ImageWidthInPoints, ImageHeightInPoints) ==0)
                {
                    txtBoxLog.AppendText(Environment.NewLine);
                    txtBoxLog.AppendText("> [Error]: Unable to process the page dimensions for the file (" + sImageFileName + ").");
                    bFail = true;
                    continue;
                }

                // Draw the image onto the document using the specified width/height
                if(DPL.DrawImage(0, 0, ImageWidthInPoints, ImageHeightInPoints) ==0)
                {
                    txtBoxLog.AppendText(Environment.NewLine);
                    txtBoxLog.AppendText("> [Error]: Unable to draw the image (" + sImageFileName + ") to the PDF file.");

                    bFail = true;
                    continue;
                }

                // Then do so using a .PDF extension instead of the image filename
                // in the output folder...
                string sPDFFileName = textBoxSaveFiles.Text + "\\" + Path.GetFileNameWithoutExtension(sImageFileName) + ".pdf";
                if (DPL.SaveToFile(sPDFFileName) == 0)
                {
                    txtBoxLog.AppendText(Environment.NewLine);
                    txtBoxLog.AppendText("> [Error]: The image " + Path.GetFileName(sImageFileName) + " could not be saved as a PDF file.");

                    bFail = true;
                    continue;
                }

                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Success]: The file (" + Path.GetFileName(sImageFileName) + ") was converted to PDF.");
            }

        // Let the user know that we're all finished and done
            if (bFail != true)
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Success]: Finished. The image(s) have been converted to PDF.");
            }
            else
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Error]: There was an issue converting some images.");
            }
        }
   
        
        private void btnLoadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.RestoreDirectory = false;
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Image Files (JPEG,GIF,BMP,PNG,WMF,EMF,TIFF)|*.jpg;*.jpeg;*.gif;*.bmp;*.png;*.tiff;*.wmf;*.emf";
            openFileDialog1.FilterIndex = 8;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            // Add the selected item to the listbox
                string[] sFileNames = openFileDialog1.FileNames;

                foreach (var item in sFileNames)
                {
                    listBoxImages.Items.Add(item);
                }
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            listBoxImages.Items.Remove(listBoxImages.SelectedItem);
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
            openFolderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            openFolderDialog.Description = "Select the output folder";

            if (openFolderDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSaveFiles.Text = openFolderDialog.SelectedPath;
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            // Check to see that user actually has any items in the list
            if (listBoxImages.Items.Count < 2) // you need at least 2 images in order to merge files
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Error]: You need at least 2 images in order to convert and merge.");

                return;
            }

            int iDocID = DPL.SelectedDocument(); // Get the ID of the first document

            // Iterate through each image filename in the listbox
            bool bFail = false;
            foreach (string sImageFileName in listBoxImages.Items)
            {
                // Create a blank document
                int iNewDocID = DPL.NewDocument();

                // Load the image into memory
                int imageID = DPL.AddImageFromFile(sImageFileName, 0);

                // Check to see if image loaded successfully into memory
                if (imageID == 0)
                {
                    txtBoxLog.AppendText(Environment.NewLine);
                    txtBoxLog.AppendText("> [Error]: Unable to load the file (" + sImageFileName + ").");

                    bFail = true;
                    continue;
                }

                // Select loaded image
                DPL.SelectImage(imageID);

                // Get horizontal and vertical resolution of image
                int dpix = DPL.ImageHorizontalResolution();
                int dpiy = DPL.ImageVerticalResolution();

                if (dpix == 0) dpix = 72;
                if (dpiy == 0) dpiy = 72;

                // Get page size and page width in points
                double ImageWidthInPoints = (double)DPL.ImageWidth() / dpix * 72.0; // assumming dpi units
                double ImageHeightInPoints = (double)DPL.ImageHeight() / dpiy * 72.0;

                // Set page origin (0,0) to top left of page
                DPL.SetOrigin(1);
                
                // Select page dimensions based on width/height of image in points
                if (DPL.SetPageDimensions(ImageWidthInPoints, ImageHeightInPoints) == 0)
                {
                    txtBoxLog.AppendText(Environment.NewLine);
                    txtBoxLog.AppendText("> [Error]: Unable to process the page dimensions for the file (" + sImageFileName + ").");

                    bFail = true;
                    continue;
                }

                // Draw the image onto the document using the specified width/height
                if (DPL.DrawImage(0, 0, ImageWidthInPoints, ImageHeightInPoints) == 0)
                {
                    txtBoxLog.AppendText(Environment.NewLine);
                    txtBoxLog.AppendText("> [Error]: Unable to draw the image (" + sImageFileName + ") onto the PDF file.");

                    bFail = true;
                    continue;
                }

                // Append the new document to the primary 
                DPL.SelectDocument(iDocID);
                DPL.MergeDocument(iNewDocID); // Note: the merge function also deletes the new document
            }

            // Delete the first page (blank) of the merged document as this was created by the first
            DPL.DeletePages(1, 1); // instance of Quick PDF Library

            // Now all documents have been merged 
            // with the primary document
            // So time to save it...
            if (DPL.SaveToFile(textBoxSaveFiles.Text + "\\merged_file.pdf") == 0) // Use the same folder, and a hard-coded filename
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Error]: Could not save the combined images as a PDF file.");

                bFail = true;
                return; // if that didn't work then forgetaboutit
            }

            // Let the user know that we're all finished and done
            if (bFail != true)
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Success]: The image(s) have been converted to PDF and merged into one PDF.");
            }
            else
            {
                txtBoxLog.AppendText(Environment.NewLine);
                txtBoxLog.AppendText("> [Error]: There was an issue during the converting, merging or saving process.");
            }
        }
    }
}