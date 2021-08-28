using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalFunctionsLibrary
{
    public class LogicalFunctions
    {
        /// <summary>
        /// Функиция Отрицание.
        /// Принимает одно булевое значение.
        /// </summary>
        /// <param name="arg1">булевое значение </param>
        /// <returns></returns>
        static public bool Denial(bool arg1)
        {
            if (arg1 == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Функция Конъюнкция.
        /// Принимает два булевых значения.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        static public bool Conjunction(bool arg1, bool arg2)
        {
            if (arg1 == false)
            {
                return false;
            }
            else if (arg2 == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Функиция Дизъюнкция. Принимает два булевых значения.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        static public bool Disjunction(bool arg1, bool arg2)
        {
            if (arg1 == true)
            {
                return true;
            }
            if (arg2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Функиция Исключающее или. Принимает два булевых значения.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        static public bool ExclusiveOr(bool arg1, bool arg2)
        {
            if (arg1 != arg2)
            {
                return false;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Функиция Импликация. Принимает два булевых значения.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        static public bool Implication(bool arg1, bool arg2)
        {
            if (Convert.ToInt32(arg1) <= Convert.ToInt32(arg2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Функция Эквивалентность. Принимает два булевых значения.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        static public bool Equivalence(bool arg1, bool arg2)
        {
            if (arg1 == arg2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Функция Штрих Шеффера. Принимает два булевых значения.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        static public bool SchaeffersStroke(bool arg1, bool arg2)
        {
            if (Conjunction(arg1, arg2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Функция Стрелка Пирса. Принимает два булевых значения.
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        static public bool PeircesArrow(bool arg1, bool arg2)
        {
            if (Disjunction(arg1, arg2))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
