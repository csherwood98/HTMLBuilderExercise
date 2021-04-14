using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace HTMLBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "world");
            WriteLine(builder.ToString());
        }
    }
}
