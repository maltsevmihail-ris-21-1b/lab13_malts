using OOP__lab10;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab12;

namespace lab13_malts
{
    enum AddMenu
    {
        Engine = 1,
        TurbojetEngine,
        InternalCombustionEngine,
        DiselEngine,
        Exit
    }

    public class MyCollection : CycledList<Engine>
    {
        public void Fill(int size)
        {
            for (int i = 0; i < size; i++)
            {
                int engineType = new Random().Next(1, 5);
                switch ((AddMenu)engineType)
                {
                    case AddMenu.Engine:
                        {
                            Add(new Engine().RandomInit());
                            break;
                        }
                    case AddMenu.InternalCombustionEngine:
                        {
                            Add(new InternalCombustionEngine().RandomInit());
                            break;
                        }
                    case AddMenu.DiselEngine:
                        {
                            Add(new DiselEngine().RandomInit());
                            break;
                        }
                    case AddMenu.TurbojetEngine:
                        {
                            Add(new TurbojetEngine().RandomInit());
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }

    }
}
