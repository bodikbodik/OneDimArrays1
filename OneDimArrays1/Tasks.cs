namespace OneDimArrays1
{
    public static class Tasks
    {
        public static int Task1(int[] array, int a)
        {
            int result = 0;
            for (int i = 0 ; i < array.Length; i++)
                

            {
                if (array[i] > a) 
                {
                    
                    result  += array[i];
                }
            }
            

            return result;
        }

        public static int Task2(int[] array)
        {
            int result = 0;
            foreach (int i in array)
            {
                if (i < 0)
                {
                    result +=i;
                }
            }

            return result;
        }

        public static int Task3(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array [i] % 2 ==0 && i % 2 == 0)
                {
                   result += array[i];
                }
               
                
            }
            

            return result;
        }
    }
}
