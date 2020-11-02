//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//////Написать программу для расчета площади стен в помещении, 
////на вход даются длина, ширина, высота (возможности нестандартной планировки,
////а также окна и двери в расчет не берем). Нужно вывести площадь поверхности стен.
//////Доработать программу в п.1 - добавить исключения (дверь, окно, проем) 
////для расчета только полезной площади.
//////Доработать программу в п.2 - по завершении расчета писать результаты в файл.

//namespace Dima_Zadaniy
//{
    
//    class Ploshad
//    {
//        public double dlina;
//        public double shirina;
//        public double visota;
//        public double S;              // площадь стен

//        public double vdoor;         // высота двери 
//        public double sdoor;        //   ширина  двери 
//        public double vwindow;      // высота окна 
//        public double swindow;     // ширина окна
//        public double S1;         // площадь окон и дверей
//        public double S2;         // полезная площадь

//        public Ploshad()
//        {
//        }
//        public Ploshad(int dlina, int shirina, int visota, double vdoor, double sdoor, double vwindow, double swindow)
//        {
//            this.dlina = dlina;
//            this.shirina = shirina;
//            this.visota = visota;

//            this.vdoor = vdoor;
//            this.sdoor = sdoor;
//            this.vwindow = vwindow;
//            this.swindow = swindow;    
          

//    }

       

//        public double SSteny(double dlina, double shirina, double visota)
//        {
//            S = 2 * (dlina + shirina) * visota;
           
//            return S;
//            Console.WriteLine(" Площадь стен" + S);
//        }
        
//        public double Sdoor_Window()
//        {
//            S1 = sdoor*vdoor+ vwindow*swindow;

//            return S1;

//            Console.WriteLine("Площадь окна и двери" + S1);

//        }
//        public double SPoleznay()
//        {
//            S2 = S - S1;
//            return S2;

//            Console.WriteLine("Полезная площадь" + S2);

//        }




//    }
//}
