namespace CompositeDP
{
    public class SysFile : IFile
    {
        private string filename { get; set; }

        public SysFile(string filename)
        {
            this.filename = filename;
        }

        public void GetName()
        {
            System.Console.WriteLine("Filename: " + filename);
        } 
    }
}
