using System;
class ArrayFill
{
        public static void Main()
    {
        int endingRowIndex = 4, endingColumnIndex = 4;                                  //Setting length of the Row/Column
        int[,] array = new int[endingRowIndex, endingColumnIndex];  
        SpiralFill(endingRowIndex, endingColumnIndex, array);                           //Calling method which fills the array
        for (int i = 0; i < endingRowIndex; i++)                                        //Printing array results
        {
            for (int j = 0; j < endingColumnIndex; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("\n");
        }
    }

    static void SpiralFill(int endingRowIndex, int endingColumnIndex, int[,] array)     //Method fills array with endingRowIndex and endingColumnIndex length
    {
        
        int initialValue = 1;                                                           // Initialize value to be filled in matrix 


        int startRowInd = 0, startColumnIndex = 0;                                      //Setting start Indexes
        while (startRowInd < endingRowIndex && startColumnIndex < endingColumnIndex)    
        {
                            
            for (int i = startColumnIndex; i < endingColumnIndex; ++i)                  //Printing the first row from the remaining rows
            {
                array[startRowInd, i] = initialValue++;
            }

            startRowInd++;

            for (int i = startRowInd; i < endingRowIndex; ++i)                          // Print the last column from the remaining columns
            {
                array[i, endingColumnIndex - 1] = initialValue++;
            }
            endingColumnIndex--;

            if (startRowInd < endingRowIndex)                                           //Print the last row from the remaining rows
            {
                for (int i = endingColumnIndex - 1; i >= startColumnIndex; --i)
                {
                    array[endingRowIndex - 1, i] = initialValue++;
                }
                endingRowIndex--;
            }

            if (startColumnIndex < endingColumnIndex)                                   //Print the first column from the remaining columns
            {
                for (int i = endingRowIndex - 1; i >= startRowInd; --i)
                {
                    array[i, startColumnIndex] = initialValue++;
                }
                startColumnIndex++;
            }
        }
    }


}
