using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FileHandler
{
    public class FileHandler
    {
        string FilePath;

        public FileHandler(string FilePathParam)
        {
            this.FilePath = FilePathParam;
        }

        #region Methods

        #region Write Data

        public bool AppendData(string[] data, bool CreateNewFile)
        {
            try
            {
                using (var writer = new StreamWriter(new FileStream(FilePath, FileMode.Append, FileAccess.Write)))
                {
                    try
                    {
                        if (CreateNewFile)
                        {
                            CreateNewFile();
                            AppendData(data, CreateNewFile);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool OverwriteData(string[] data, bool CreateNewFile)
        {

        }

        private bool WriteDataToFile(StreamWriter writer, string[] data)
        {

        }

        #endregion

        #region Read Data

        #endregion

        #region Create New File

        private bool CreateNewFile()
        {

        }

        #endregion

        #endregion
    }
}
