﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposalPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText(@"c:\test\test.txt",
                "문자열을 파일에 씁니다.");
        }
    }
}
