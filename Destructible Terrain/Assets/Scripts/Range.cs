using UnityEngine;

namespace DTerrain
{
    ///<summary>
    ///Range represents a single range: [min;max]
    ///</summary>
    public class Range
    {
        public int Min;
        public int Max;

        public int Length { 
            get
            {
                int len = Mathf.Abs(Max - Min);
                if (len <= 0) return 0;
                else return len;
            } 
        }

        public bool isWithin(int point)
        {
            return point <= Max && point >= Min;
        }

        public Range(int a, int b)
        {
            Min = a;
            Max = b;
        }

        public Range(Range r)
        {
            Min = r.Min;
            Max = r.Max;
        }

        public static Range operator +(Range r, int a)
        {
            return new Range(r.Min + a, r.Max + a);
        }

        public static Range operator -(Range r, int a)
        {
            return new Range(r.Min - a, r.Max - a);
        }

    }
}