using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Medium
{
    public class ContainerWithMostWaterSolution
    {
        public int MaxArea(int[] height)
        {

            var area = 0;
            for (int i = 0; i < height.Length; i++)
            {

                var x = height[i];

                for (int j = i + 1; j < height.Length; j++)
                {
                    var y = height[j];
                    var tempX = x;
                    if (x <= y)
                    {
                        var currentArea = (j - i) * x;
                        if (currentArea > area)
                        {
                            area = currentArea;

                        }
                    }
                    else
                    {
                        while (tempX >= y)
                        {
                            if (tempX <= y)
                            {

                                var currentArea = (j - i) * tempX;
                                if (currentArea > area)
                                {
                                    area = currentArea;

                                }

                                break;

                            }


                            tempX--;
                        }

                    }



                }


            }

            return area;
        }
    }
}
