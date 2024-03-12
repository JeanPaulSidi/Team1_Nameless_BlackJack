using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nameless_BlackJack
{
    public class Card
    {
        private int _pointvalue;
        private string _imagepath;

        public Card(int PointValue, string ImagePath) 
        {
            _pointvalue = PointValue;
            _imagepath = ImagePath;
        }

        public int PointValue 
        {
            get { return _pointvalue; }
            set { _pointvalue = value; }
        }

        public string ImagePath 
        {
            get { return _imagepath; }
            set { _imagepath = value; }
        }
    }
}
