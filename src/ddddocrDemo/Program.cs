using ddddocrsharp;
using System;
using System.IO;

namespace ddddocrDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Ocr!");

            dddddocr ddddocrDet = new dddddocr(det: true);

            dddddocr ddddocrnew = new dddddocr(det: false, old: false);

            dddddocr ddddocrold = new dddddocr(det: false, old: true);

            var bytesimg = File.ReadAllBytes("test1.jpg");

            var retpos = ddddocrDet.detection(bytesimg);
            Console.WriteLine(string.Format("目标检测识别到{0}个目标", retpos.Count));
            foreach (var pos in retpos)
            {
                Console.WriteLine(String.Join(",", pos));
            }

            var bytesword = File.ReadAllBytes("test2.jpg");
            var wordnew = ddddocrnew.classification(bytesword);

            Console.WriteLine(string.Format("新版模型识别到文字：{0}", wordnew));
            var wordold = ddddocrold.classification(bytesword);

            Console.WriteLine(string.Format("旧版模型识别到文字：{0}", wordold));

        }
    }
}
