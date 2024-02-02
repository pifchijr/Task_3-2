using System;

namespace Task_32
{
    public abstract class ArrayBase
    {
        public dynamic value;

        public ArrayBase(int rows, int cols, bool fillByHand)
        {
            this.value = fillByHand ? this.FillByHand(rows, cols) : this.FillByRnd(rows, cols);
        }
        
        public abstract Array FillByHand(int rows, int cols);

        public abstract Array FillByRnd(int rows, int cols);

        public abstract void Output();

        public abstract float GetAverage();
    }
}