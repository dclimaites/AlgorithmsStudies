using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStudies.SearchAlgorithms
{
    public class BinarySearch
    {
        /// <summary>
        /// Search a number in the array
        /// </summary>
        /// <param name="pSearch">Search number</param>
        /// <returns>Index of search number, if the number ins't in the array, return -1</returns>
        public int Find(int pSearch, int[] pNumberList)
        {
            return Find(pSearch, pNumberList, 0, pNumberList.Length - 1);
        }

        
        private int Find(int pSearch, int[] pNumberList, int pLeftIndex, int pRightIndex)
        {

            int currentIndex = (pLeftIndex + pRightIndex) / 2;

            if (pLeftIndex > pRightIndex)
            {
                //the array it scanned, but not find the number
                return -1;
            }
            else
            {
                if (pNumberList != null && pNumberList.Length > 0 && pNumberList[currentIndex] == pSearch)
                    return currentIndex;
                else
                {
                    if(pSearch > pNumberList[currentIndex])
                    {
                        pLeftIndex = currentIndex+ 1;
                    }
                    else
                    {
                        pRightIndex = currentIndex- 1;
                    }

                    return Find(pSearch, pNumberList, pLeftIndex, pRightIndex);
                }
            }
        }
    }
}
