using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LilyMVC.Views
{
    internal class MainView
    {
        public class Display
        {
             
            /// Сума на сметката         
            public double Amount { get; set; }

            /// Процент за бакшиш           
            public double Percent { get; set; }
  
            /// Обща сума за плащане
            public double Total { get; set; }
            
            /// Сума за бакшиша         
            public double TipAmount { get; set; }
     
            /// Конструктор        
            public Display()
            {
                Amount = 0;
                Percent = 0;
                Total = 0;
                TipAmount = 0;
                GetValues();
            }
            
            /// Четене на входни данни от конзолата 
            public void GetValues()
            {
                Console.WriteLine("Enter the amount of the meal: ");
                this.Amount = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the percent you want to tip: ");
                this.Percent = double.Parse(Console.ReadLine());
            }
    
            /// Отпечатва изходни данни на конзолата 
            public void ShowTipAndTotal()
            {
                Console.WriteLine("You tip is: {0:C}", TipAmount);
                Console.WriteLine("The total will be {0:C}", Total);
            }
        }
    }
}
