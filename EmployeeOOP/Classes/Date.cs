using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeOOP.Classes
{
    public class Date
    {
        #region Fields/Campos

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods/Métodos

        //Método Constructor Sobrecargado
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = month;
            _day = day;
        }

        public override string ToString()
        {
            var dateConcatenated1 = _day + "/" + _month + "/" + _year; //Forma más arcaica y fea
            var dateConcatenated2 = $"{_day:00}/{_month:00}/{_year:0000}"; //Interpolación
            var dateConcatenated3 = String.Format("{0:00}/{1:00}/{2:0000}", _day, _month, _year); // Clase String.Format

            return dateConcatenated3;
        }

        #endregion
    }
}
