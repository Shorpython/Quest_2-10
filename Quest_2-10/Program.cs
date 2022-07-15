int[] Odd_Array_get_from_range(int digit = 0)
{
    int[] Odd_Array = new int[digit];
    
    for(int i = 0; i < digit; i++)
    {
        if ((i % 2)== 0)
        {


            bool has_been_added = false;
            int checker = 0;

            while (has_been_added is false)
            {

                if (Odd_Array[checker] == 0)
                { 
                    Odd_Array[checker] = i; 
                    has_been_added = true; 
                }
                else 
                { checker++; 
                } 
            }
        }
    }
    return Odd_Array;
}

int[] myArr = Odd_Array_get_from_range(10);
foreach (int i in myArr) if (i != 0) Console.WriteLine(i);