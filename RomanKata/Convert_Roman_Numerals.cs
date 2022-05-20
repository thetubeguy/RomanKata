using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanKata
{
    public class Convert_Roman_Numerals
    {   
        struct decade_info { 
            public int Units;
            public int Tens;
            public int Hundreds;
            public int Thousands;
        }

        public string convert(int num_to_convert)
        {
            string output = "";
            decade_info my_decade_info = new decade_info();

            get_decades(num_to_convert, ref my_decade_info);

            if(my_decade_info.Thousands > 0) output += Get_Symbols(my_decade_info.Thousands, 'M', 'V', 'Q');
            if(my_decade_info.Hundreds > 0) output += Get_Symbols(my_decade_info.Hundreds, 'C', 'D', 'M');
            if (my_decade_info.Tens > 0) output += Get_Symbols(my_decade_info.Tens, 'X', 'L', 'C');
            if (my_decade_info.Units > 0) output += Get_Symbols(my_decade_info.Units, 'I', 'V', 'X');


            return output;   
        }
        
            
           
        private void get_decades(int value, ref decade_info this_decade_info )
        {
                
            value = fill_one_decade(value, ref this_decade_info.Thousands, 1000);
            value = fill_one_decade(value, ref this_decade_info.Hundreds, 100);
            value = fill_one_decade(value, ref this_decade_info.Tens, 10);
            this_decade_info.Units = value;
        }

        private int fill_one_decade(int value, ref int decade, int divider)
        {
            if (value >= decade)
            {
                decade = value / divider;
                value -= (decade * divider);

            }

            return value;
        }

        public string Get_Symbols(int value_to_convert, char unit_sym, char half_way_sym, char full_way_sym)
        {

            switch(value_to_convert)
            {
                case 1: return unit_sym.ToString();
                case 2: return String.Concat(unit_sym,unit_sym);
                case 3: return String.Concat(unit_sym, unit_sym, unit_sym);
                case 4: return String.Concat(unit_sym, half_way_sym);
                case 5: return half_way_sym.ToString();
                case 6: return String.Concat(half_way_sym, unit_sym);
                case 7: return String.Concat(half_way_sym, unit_sym, unit_sym);
                case 8: return String.Concat(half_way_sym, unit_sym, unit_sym, unit_sym);
                default: return String.Concat(unit_sym, full_way_sym);

            }


        }
        
    }
}
