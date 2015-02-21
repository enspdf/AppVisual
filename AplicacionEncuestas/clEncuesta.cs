using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEncuestas
{
    public class clEncuesta
    {
        private List<string> _nombresRptasS1;
        public List<string> NombresControlesRptaS1
        {
            get
            {
                return _nombresRptasS1;
            }
            set
            {
                _nombresRptasS1 = value;
            }
        }

        private List<string> _nombreControlRptaS2;
        public List<string> NombreControRptaS2
        {
            get
            {
                return _nombreControlRptaS2;
            }
            set
            {
                _nombreControlRptaS2 = value;
            }
        }

        private List<string> _nombreControlRptasS3;
        public List<string> NombreControlRptasS3
        {
            get
            {
                return _nombreControlRptasS3;
            }
            set
            {
                _nombreControlRptasS3 = value;
            }
        }

        private List<string> _nombreControlRptasS4;
        public List<string> NombreControRptasS4
        {
            get
            {
                return _nombreControlRptasS4;
            }
            set
            {
                _nombreControlRptasS4 = value;
            }
        }
    }
}
