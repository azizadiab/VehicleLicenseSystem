using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project_Final
{
    public class clsUtil
    {
        public static string GenertateGUID()
        {

            // Generate a new GUID
            Guid newGuid = Guid.NewGuid();

            // convert the GUID to a string
            return newGuid.ToString();

        }



        public static string ReplaceFileNameWithGUID(string SourFile)
        {
            string fileName = SourFile;
            FileInfo fi= new FileInfo(fileName);
            string extn = fi.Extension;
            return GenertateGUID() + extn;

        }
      public static bool GreateFolderIfDoesExits(string FolderPath)
        {

            if(!Directory.Exists(FolderPath))
            {
                try
                {
                    // If it doesn't exist, create the folder
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }catch(Exception ex)
                {
                    MessageBox.Show("Error", ex.Message);
                    return false;
                }
              
              
            }
            return true;
        }


        public static bool CopyImageToPRojectImagesFolder(string SourceFile)
        {
            string DestinationFolder = @"C:\DVID-People-Images\";
            if(!GreateFolderIfDoesExits(DestinationFolder))
            {
                return false;
            }
            string DestiinationFile = DestinationFolder + ReplaceFileNameWithGUID(SourceFile);
            try

            {
                File.Copy(SourceFile, DestiinationFile, true);
            }
            catch(IOException ex)
            {
                MessageBox.Show("ERror");
                return false;
            }
            SourceFile = DestiinationFile;
            return true;
        }

    }
}
