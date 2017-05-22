using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalaizerClass
{
    public class Class2
    {
        private static int erposition = 0;
        public static string expression = "";
        public static bool ShowMessege = false;

        //-----------------------------------------------------------

        public Class2(string exp)
        {
            expression = exp;
        }

        //------------------------------------------------------------------

        public static bool CheckCurrency()
        {
            try
            {
                if (expression.Length > Math.Pow(2, 16))
                {
                    ShowMessege = true;
                    expression = "error 07";
                    return false;
                }

                int Openbreckets = 0;
                for (int CurrentPos = 0; CurrentPos < expression.Length; CurrentPos++)
                {
                    if (expression[CurrentPos] == '(')
                        Openbreckets++;
                    else
                        if (expression[CurrentPos] == ')')
                        if (Openbreckets > 0)
                            Openbreckets--;
                        else
                        {
                            ShowMessege = true;
                            expression = "error 01";
                            return false;
                        }

                }

                if (Openbreckets != 0)
                {
                    ShowMessege = true;
                    expression = "error 01";
                    return false;
                }
                return true;
            }
            catch
            {
                ShowMessege = true;
                expression = "error 01";
                return false;
            }
        }

        //----------------------------------------------------------------------------------------------

        private static string Format()
        {

            try
            {

                expression = expression.Replace(" ", string.Empty);
                int CurrentPos = 0;
                while (CurrentPos < expression.Length)
                {

                    switch (expression[CurrentPos])
                    {
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                bool b3 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 0)
                                        if (expression[CurrentPos - 1].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                    if ((expression[CurrentPos + 1].ToString() == ")") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "*") || (expression[CurrentPos + 1].ToString() == "/") || (expression[CurrentPos + 1].ToString() == "+") || (expression[CurrentPos + 1].ToString() == "-"))
                                        b3 = true;
                                if ((CurrentPos > 0) && (!b1))
                                {
                                    if ((expression[CurrentPos - 2].ToString() == "d") || (expression[CurrentPos - 2].ToString() == "(") || (expression[CurrentPos - 2].ToString() == "+") || (expression[CurrentPos - 2].ToString() == "-") || (expression[CurrentPos - 2].ToString() == "*") || (expression[CurrentPos - 2].ToString() == "/") || (expression[CurrentPos - 2].ToString() == "m") || (expression[CurrentPos - 2].ToString() == "p"))
                                        b1 = true;
                                }
                                if ((b3 || CurrentPos == expression.Length - 1) && (b1 || CurrentPos == 0))
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                if ((b2 || CurrentPos == expression.Length - 1) && (b1 || CurrentPos == 0))
                                {
                                    CurrentPos++;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 02 at " + CurrentPos.ToString();

                                    return expression;

                                }
                            }

                        //----------------------------------------------------------

                        case '+':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 0)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                // ---
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 02 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if ((b2 || CurrentPos == expression.Length - 1) && (b1 || CurrentPos == 0))
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //-----------------------------------------------------------------------------------------------------------

                        case '-':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }

                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //----------------------------------------------------------------------------------------------------------

                        case '/':
                        case '*':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //----------------------------------------------------------------------------------------------------------

                        case '(':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (CurrentPos > 0)
                                {
                                    if ((expression[CurrentPos - 2].ToString() == "(") || (expression[CurrentPos - 2].ToString() == "*") || (expression[CurrentPos - 2].ToString() == "/") || (expression[CurrentPos - 2].ToString() == "+") || (expression[CurrentPos - 2].ToString() == "-") || (expression[CurrentPos - 2].ToString() == "d") || (expression[CurrentPos - 2].ToString() == "m") || (expression[CurrentPos - 2].ToString() == "p"))
                                        b1 = true;
                                }
                                else b1 = true;

                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //-----------------------------------------------------------------------------                  

                        case ')':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == ")") || (expression[CurrentPos + 1].ToString() == "*") || (expression[CurrentPos + 1].ToString() == "/") || (expression[CurrentPos + 1].ToString() == "+") || (expression[CurrentPos + 1].ToString() == "-") || (expression[CurrentPos + 1].ToString() == "m"))
                                        b2 = true;
                                }
                                else b2 = true;
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }

                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //----------------------------------------------------------------------------------------------------------  

                        case 'm':
                        case 'p':
                            {
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if (expression[CurrentPos + 1] == 'o')
                                    {
                                        bool b1 = false;
                                        bool b2 = false;
                                        if (!((CurrentPos + 3) >= expression.Length))
                                        {
                                            if (expression[CurrentPos + 1] == 'o' && expression[CurrentPos + 2] == 'd')
                                            { }
                                            else
                                            {
                                                ShowMessege = true;
                                                expression = "Error 02 at " + CurrentPos.ToString();
                                                return expression;
                                            }
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 05";
                                            return expression;
                                        }

                                        for (int i = 0; i < 10; i++)
                                        {
                                            if (expression[CurrentPos + 3].ToString() == i.ToString())
                                                b2 = true;
                                            if (CurrentPos > 1)
                                                if (expression[CurrentPos - 2].ToString() == i.ToString())
                                                    b1 = true;
                                        }

                                        if ((expression[CurrentPos + 3].ToString() == "(") || (expression[CurrentPos + 3].ToString() == "m") || (expression[CurrentPos + 3].ToString() == "p"))
                                            b2 = true;

                                        if (CurrentPos > 0)
                                        {
                                            if (expression[CurrentPos - 2].ToString() == ")")
                                                b1 = true;
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 03";
                                            return expression;
                                        }

                                        if (b2 && b1)
                                        {
                                            expression = expression.Insert(CurrentPos + 3, " ");
                                            CurrentPos += 4;
                                            break;
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                    }
                                    //----------------------------------------------------
                                    else
                                    {
                                        bool b1 = false;
                                        bool b2 = false;
                                        //bool b3 = false;
                                        if (CurrentPos == 0)
                                        {
                                            b1 = true;
                                        }
                                        for (int i = 0; i < 10; i++)
                                        {
                                            if (CurrentPos < expression.Length - 1)
                                                if (expression[CurrentPos + 1].ToString() == i.ToString())
                                                {
                                                    b2 = true;
                                                    break;
                                                }
                                        }
                                        if ((CurrentPos < expression.Length - 1) && (!b2))
                                            if ((expression[CurrentPos + 1].ToString() == "("))
                                                b2 = true;
                                        if ((CurrentPos > 0) && (!b1))
                                        {
                                            if ((expression[CurrentPos - 2].ToString() == "d") || (expression[CurrentPos - 2].ToString() == "(") || (expression[CurrentPos - 2].ToString() == "+") || (expression[CurrentPos - 2].ToString() == "-") || (expression[CurrentPos - 2].ToString() == "*") || (expression[CurrentPos - 2].ToString() == "/"))
                                                b1 = true;
                                        }
                                        if ((b2) && (b1))
                                        {
                                            expression = expression.Insert(CurrentPos + 1, " ");
                                            CurrentPos += 2;
                                            break;
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                    }
                                }
                                break;
                            }

                        //----------------------------------------------------------------------------------------------------------  

                        default:
                            ShowMessege = true;
                            expression = "error 02 at " + CurrentPos.ToString();
                            return expression;
                    }
                }
                expression = expression.Trim();
                return expression;
            }
            catch
            {
                ShowMessege = true;
                return expression = "error 06";
            }
        }

        //-----------------------------------------------------------------------------------------------------

 
        public static string Estimate()
        {
            if (!CheckCurrency())
            {
                return expression; ;
            }
            expression = Format();
            if (ShowMessege)
            {
                ShowMessege = false;
                return expression;
            }

            return expression;
        }
    }
}
