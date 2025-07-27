using DVLD_Buisness;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project_Final
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;
        public static bool RememberUsernameAndPassword(string UserName)
        {
            try
            {
                //this will get the current project directory folder.
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Define the path to the text file where you want to save the data
                
                string FilePath = CurrentDirectory + "\\cred.txt";
              
                //incase the username is empty, delete the file
                if (UserName == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;

                }
               
                // Create a StreamWriter to write to the file
                using (StreamWriter write = new StreamWriter(FilePath))
                {
                    // Write the data to the file
                    write.WriteLine(UserName);
                    return true;
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error is Occurred {ex.Message}");
                return false;
            }

        }

        

        public static bool GetStoredCredential(ref string  UserName)
        {

            //this will get the stored username and password and will return true if found and false if not found.
            try

            {
                //gets the current project's directory
                string CurrentDircetory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath = CurrentDircetory + "cred.txt";
                // Check if the file exists before attempting to read it
                if(File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                   using (StreamReader Reader = new StreamReader(filePath))
                    {
                         string Line = Reader.ReadLine();
                     
                         Console.WriteLine(Line);

                        UserName = Line;

                        return true;

                    }
                        
                    }
      
                    return false;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;

            }
         

           }
    }
}
