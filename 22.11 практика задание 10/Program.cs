using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11_практика_задание_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1;
            num1 = Interaction.InputBox("Введите число",
                "Ввод числа");
            int x = Convert.ToInt32(num1);
            int num = x;
            int num2 = x - 1;
            int num3 = x + 1;
            string res = "отве:" +num2 +num +num3;
            MessageBox.Show(res, "ответ");
        }
    }
}
