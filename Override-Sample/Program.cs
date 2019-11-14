using System;
using System.Collections.Generic;

namespace Override_Sample
{

    public class MyFile 
    {
        public string Name { get; set; }
        public int Size { get; set; }

        public virtual void Open()
        {
            Console.WriteLine("Base class");
        }
    }

    public class video : MyFile
    {
        public override void Open()
        {
            base.Open();

            Console.WriteLine("I'm in Video");
        }
    }

    public class Pdf : MyFile
    {
        public override void Open()
        {
            base.Open();

            Console.Write("I'm in Pdf");
        }
    }

    public class Win
    {
        private List<MyFile> _files;

        public Win()
        {
            _files = new List<MyFile>();
        }

        public void Add(MyFile file)
        {
            _files.Add(file);
        }

        public void Open(MyFile file)
        {
            file.Open();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyFile pdf = new Pdf() { Name = "pdf1", Size = 2};
            MyFile video = new video { Name = "Video1", Size = 123 };

            Win w = new Win();
            w.Add(pdf);
            w.Add(video);
        }
    }
}
