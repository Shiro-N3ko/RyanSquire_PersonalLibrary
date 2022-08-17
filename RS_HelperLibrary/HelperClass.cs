using System.Collections.Generic;

namespace RS_HelperLibrary
{
    public class HelperClass
    {
        public void formatTitle(string theTitle_)
        {
            Console.Write("\t\t\t");
            for (uint i = 0; i < theTitle_.Length; i++)
            {
                Console.Write("=");
            }//end for
            Console.Write($"\n\t\t\t{theTitle_}\n\t\t\t");
            for (uint i = 0; i < theTitle_.Length; i++)
            {
                Console.Write("=");
            }//end for
            Console.WriteLine();
        }//end formatTitle

        public bool checkNull<T>(T theVar)
        {
            try
            {
                if (theVar is null || theVar is "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                printError(ex);
                return false;
            }
        }//end checkNull

        public void printList<T>(List<T> aList)
        {
            try
            {
                for (int i = 0; i < aList.Count; i++)
                {
                    System.Console.WriteLine(aList.ElementAt(i));
                }//end for
            }
            catch (Exception ex)
            {
                printError(ex);
            }
        }//end printList

        public void printError<T>(T ex)
        {
            try
            {
                System.Console.WriteLine($"An Error Has Occured: {ex}");
            }
            catch (Exception e)
            {
                printError(e);
            }
        }//end printError

        public int getRandomNumBetween(int min, int max)
        {
            Random rng = new Random();
            return rng.Next(min, max + 1);
        }//end getRandomNumBetween (int)

        public double getRandomNumBetween(double min, double max)
        {
            Random rng = new Random();
            return rng.NextDouble() * (max - min) + min;
        }//end getRandomNumBetween (double)

        public float getRandomNumBetween(float min, float max)
        {
            Random rng = new Random();
            return rng.NextSingle() * (max - min) + min;
        }//end getRandomNumBetween (float)

        public bool checkEven(int aNum)
        {
            if (aNum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end checkEven(int)

        public bool checkEven(double aNum)
        {
            if (aNum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end checkEven(double)

        public bool checkEven(float aNum)
        {
            if (aNum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end checkEven(float)

        public bool checkEven(uint aNum)
        {
            if (aNum % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end checkEven(uint)

        public void sortList<T>(ref List<T> aList) where T : IComparable
        {
            sortListInternal(aList, 0, aList.Count - 1);
        }//end sortList

        private static void sortListInternal<T>(List<T> aList, int left, int right) where T : IComparable
        {
            if (left >= right)
            {
                return;
            }//end if

            int partition = partitionInternal(aList, left, right);

            sortListInternal(aList, left, partition - 1);
            sortListInternal(aList, partition + 1, right);
        }//end sortListInternal

        private static int partitionInternal<T>(List<T> aList, int left, int right) where T : IComparable
        {
            T partition = aList[right];

            //Stack items smaller than partition from left to right
            int swapIndex = left;
            for (int i = left; i < right; i++)
            {
                T item = aList[i];

                if (item.CompareTo(partition) <= 0)
                {
                    aList[i] = aList[swapIndex];
                    aList[swapIndex] = item;

                    swapIndex++;
                }//end if
            }//end for

            //put partition after all smaller items
            aList[right] = aList[swapIndex];
            aList[swapIndex] = partition;

            return right;
        }//end partitionInternal
    }//end HelperClass
}