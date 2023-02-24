using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Webtina.UI.Framework.Helper
{
    public static class DateTimeHelper
    {
        public static DateTime? ToMiladi(this object input)
        {
            try
            {
                if (input==null)
                    return null;
                string datetime = input.ToString();
                int[] startdatestring = datetime.Split('/').Select(n => Convert.ToInt32(n)).ToArray();
                DateTime date = new DateTime(startdatestring[0], startdatestring[1], startdatestring[2], new PersianCalendar());
                return date;
            }
            catch
            {
                return null;
            }
        }




        public static string ToPersian(this DateTime datetime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(datetime).ToString() + "/" +
                persianCalendar.GetMonth(datetime).ToString("0#") + "/" +
                persianCalendar.GetDayOfMonth(datetime).ToString("0#") + "-" + datetime.Hour.ToString("0#") + ":" + datetime.Minute.ToString("0#");
        }

        public static string ToShortPersian(this DateTime datetime)
        {
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                return persianCalendar.GetYear(datetime).ToString() + "/" +
                    persianCalendar.GetMonth(datetime).ToString("0#") + "/" +
                    persianCalendar.GetDayOfMonth(datetime).ToString("0#");
            }
            catch
            {
                return string.Empty;
            }
        } 

        public static string ToPersianWithNamedMonth(this DateTime datetime)
        {
            string retVal = string.Empty;
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                return persianCalendar.GetDayOfMonth(datetime).ToString() + " " +
                    PersianMonthName((byte)persianCalendar.GetMonth(datetime)) + " " +
                    persianCalendar.GetYear(datetime).ToString();
            }
            catch
            {
                retVal = string.Empty;
            }
            return retVal;
        }
        public static string ToPersianWithNamedMonth2(this DateTime datetime)
        {
            string retVal = string.Empty;
            try
            {
                PersianCalendar persianCalendar = new PersianCalendar();
                return persianCalendar.GetDayOfMonth(datetime).ToString() + " " +
                    PersianMonthName((byte)persianCalendar.GetMonth(datetime)) + " " + "ماه" + " " +
                    persianCalendar.GetYear(datetime).ToString();
            }
            catch
            {
                retVal = string.Empty;
            }
            return retVal;
        }
        public static string PersianMonthName(byte month)
        {
            string retVal = string.Empty;
            switch (month)
            {
                case 1:
                    retVal = "فروردین";
                    break;
                case 2:
                    retVal = "اردیبهشت";
                    break;
                case 3:
                    retVal = "خرداد";
                    break;
                case 4:
                    retVal = "تیر";
                    break;
                case 5:
                    retVal = "مرداد";
                    break;
                case 6:
                    retVal = "شهریور";
                    break;
                case 7:
                    retVal = "مهر";
                    break;
                case 8:
                    retVal = "آبان";
                    break;
                case 9:
                    retVal = "آذر";
                    break;
                case 10:
                    retVal = "دی";
                    break;
                case 11:
                    retVal = "بهمن";
                    break;
                case 12:
                    retVal = "اسفند";
                    break;
            }
            return retVal;
        }

        public static string PersianDayOfWeek(this DateTime datetime)
        {
            string retVal = string.Empty;

            switch (datetime.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    retVal = "جمعه";
                    break;
                case DayOfWeek.Monday:
                    retVal = "دوشنبه";
                    break;
                case DayOfWeek.Saturday:
                    retVal = "شنبه";
                    break;
                case DayOfWeek.Sunday:
                    retVal = "یکشنبه";
                    break;
                case DayOfWeek.Tuesday:
                    retVal = "سه شنبه";
                    break;
                case DayOfWeek.Thursday:
                    retVal = "پنجشنبه";
                    break;
                case DayOfWeek.Wednesday:
                    retVal = "چهارشنبه";
                    break;
                default:
                    break;
            }

            return retVal;
        }

        public static int PersianYear(this DateTime datetime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetYear(datetime);
        }
        public static string PersianMonth2(this DateTime datetime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return PersianMonthName((byte)persianCalendar.GetMonth(datetime)) + " " +
                persianCalendar.GetYear(datetime).ToString();
        }
        public static int PersianMonth(this DateTime datetime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetMonth(datetime);
        }
        public static int PersianDay(this DateTime datetime)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return persianCalendar.GetDayOfMonth(datetime);
        }
        public static string PersianTime(this DateTime datetime)
        {
            return datetime.Hour.ToString() + ":" + datetime.Minute.ToString();
        }



    }
}
