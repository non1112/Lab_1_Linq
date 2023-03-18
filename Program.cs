using System;
using System.Text;

namespace Lab_1_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
          
            IContentData dc = new ContentData();
            
            IDataRequest id = new DataRequest(dc);

            IDataOutput dl = new DataOutput(id);

            IPassage ps = new Passage(dl);
            

            ps.Step();
           


        }
    }
}
