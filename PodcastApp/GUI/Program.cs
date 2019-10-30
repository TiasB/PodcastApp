using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Services;
using GUI.Services;

namespace GUI
{
    class Program
    {
        //private static readonly IDataService<string[,]> _dataService;
        //    //private static readonly IPresentationService<string[,]> _presentationService;

        //    static Program()
        //    //{
        //    //    _dataService = new RealDataService("artwork.json");
        //    //    _presentationService = new PresentationService();
        //    }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        //}
    }
    }


