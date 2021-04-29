using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PasswordManagement
{
    public class FileManagement
    {
        /// <summary>
        /// ファイルを読み込みます。
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string LoadFile(string path)
        {
            string data = null;

            if (!File.Exists(path))
            {
                throw new Exception("File not exist!");
            }

            using(StreamReader sr = new StreamReader(path))
            {
                data = sr.ReadToEnd();
            }

            return data;
        }
    }
}
