using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_13
{
    class Building
    {

        private const double Tolerance = 0.0001;    
        private string address;     
        private double length;    
        private double width;       
        private double height;      


        public string Address       
        {
            get { return address; }
            set
            {
                if (value != null && value != address)          
                    address = value;

            }
        }
        public double Length        
        {
            get { return length; }
            set
            {
                if (Math.Abs(value - length) > Tolerance)    
                    length = value;

            }
        }
        public double Width        
        {
            get { return width; }
            set
            {
                if (Math.Abs(value - width) > Tolerance)        
                    width = value;
            }
        }
        public double Height       
        {
            get { return height; }
            set
            {
                if (Math.Abs(value - height) > Tolerance)      
                    height = value;
            }
        }

        public Building(string address, double length, double width, double height)  
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
            Console.ReadKey();
        }

        public string Print()
        {
            return $"Адрес здания:{address}\nДлина здания:{length}\nШирина здания:{width}Высота здания:{height}";


        }
    }
}
