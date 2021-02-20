using System.IO;

namespace caesar_cipher.Io
{
    public static class Outputter
    {
        public static void ReadTextToFile(string content, string path) => File.WriteAllText(path, content);
    }
}