using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_13
{
    class MultiBuilding
    {
        sealed class MultiBuilding : Building
        {
            private uint stageCount;      
            public uint StageCount
            {
                get { return stageCount; }
                set
                {
                    if (value != stageCount)
                        stageCount = value;
                }
            }
            public MultiBuilding(uint stageCount, string address, double length, double width, double height) 
                : base(address, length, width, height)

            {
                this.stageCount = stageCount;
            }

            public string Print()
            {

                return $"Этажность:{stageCount}\n{base.Print()}";

            }
        }
    }
}
