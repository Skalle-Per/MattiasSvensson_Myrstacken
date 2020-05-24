using System;
using System.Collections.Generic;
using System.Text;

namespace Myrstacken_Real_Deal
{
    class Myra
    {
        private string namn;
        private int ben;
        public static int antal = 0;

        //constructor
        public Myra(string aNamn, int aBen)
        {
            namn = aNamn;
            ben = aBen;
            antal++;
        }

        public string GetNamn()
        {
            return namn;
        }

        public void SetName(string nyttNamn)
        {
            namn = nyttNamn;
        }

        public int GetBen()
        {
            return ben;
        }

        public void SetBen(int nyBen)
        {
            ben = nyBen;
        }



        public int antalMyror() //static attribute.
        {
            return antal;
        }


    }

}
