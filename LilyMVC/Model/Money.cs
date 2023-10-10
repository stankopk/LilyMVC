using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyMVC.Model
{
    internal class Money
    {
        private double amount;

        /// <summary>
        /// Сума
        /// </summary>
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be positive!");
                }
                amount = value;
            }
        }

        private double percent;

        /// <summary>
        /// Процент
        /// </summary>
        public double Percent
        {
            get { return percent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Must be positive!");
                }
                if (value > 1)
                {
                    percent = value / 100.0;
                }
                else
                {
                    percent = value;
                }
            }
        }


        /// <summary>
        /// Предефиниран консруктор
        /// </summary>
        public Tip(double amount, double percent)
        {
            this.Amount = amount;
            this.Percent = percent;
        }

        /// <summary>
        /// Конструктор по подразбиране
        /// </summary>
        public Tip() : this(0, 0)
        {
            ; ;
        }

        /// <summary>
        /// Калкулира сума на бакшиша
        /// </summary>
        public double CalculateTip()
        {
            return Amount * Percent;
        }

        /// <summary>
        /// Кaлкулира обща сума за плащане
        /// </summary>
        public double CalculateTotal()
        {
            return Amount + CalculateTip();
        }
    }
}
