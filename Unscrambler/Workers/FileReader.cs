using System;
using System.IO;


namespace scrabbleMoreAble.Workers
{
    class FileReader
    {
        public string[] Output { get; private set; }


        public void Read(string path)
        {
            try
            {
                Output = File.ReadAllLines(path);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                System.Windows.Forms.MessageBox.Show("File  reader error./n"+ex.Message);
            }
        }
    }
}
