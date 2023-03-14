using System;
using System.Text;

namespace Lab_1_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
          
            ContentData dc = new ContentData();
            
            DataRequest id = new DataRequest(dc);

            DataLogic dl = new DataLogic(id);

            Passage ps = new Passage(dl);
            

            ps.Switch();
           


        }
    }
}
