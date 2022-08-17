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

        public List<T> sortList<T>(List<T> aList, int leftIndex, int rightIndex)
        {
        }//end sortList

        private static void sortListInternal<T>(List<T> aList, int left, int right)
        {
            if (left >= right)
            {
                return;
            }//end if

            int partition
        }//end sortListInternal

        private static void partitionInternal<T>(List<T> aList, int left, int right)
        {
            T partition = aList[right];

            //Stack items smaller than partition from left to right
        }//end partitionInternal
    }//end HelperClass
}