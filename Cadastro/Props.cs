using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Props
    {
        private string? Name;
        private decimal Old;

        private decimal biNamber;
        private double Heigh;

        public string _Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public decimal _Old
        {
            get
            {
                return Old;
            }
            set
            {
               Old = value;
            }
        }


        public decimal _biNamber
        {
            get
            {
                return biNamber;
            }
            set
            {
                biNamber = value;
            }
        }


        public double _Heigh
        {
            get
            {
                return Heigh;
            }
            set
            {
                Heigh = value;
            }
        }



    }
}