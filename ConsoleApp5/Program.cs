//--------------------------------------------------------------------------------------------
// tekrarlanmayanlari capa ver

//int[] arr = { 2, 7, 3, 14, 8, 2, 3, 7 };
//for (int i = 0; i < arr.Length; i++)
//{
//    bool tekrarVar = false;

//    for (int j = 0; j < arr.Length; j++)
//    {
//        if (i != j && arr[i] == arr[j])
//        {
//            tekrarVar = true;
//            break;
//        }
//    }

//    if (!tekrarVar)
//    {
//        Console.Write(arr[i] + " ");
//    }
//}


//---------------------------------------------------------------------------------
// arrayda her elementden nece denedir?

//int[] arr = { 2, 5, 9, 2};
//int[] arrcopy = new int[arr.Length];

//for (int i = 0; i < arr.Length; i++)
//{
//    arrcopy[i] = arr[i];
//}
//foreach (int item in arrcopy)
//{
//    Console.WriteLine(item);
//}


//-----------------------------------------------------------------------------------------------


int[] arr = { 2, 5, 9, 2, 2, 11, 5 };

foreach (int element in arr)
{
    int count = 0;

    foreach (int innerElement in arr)
    {
        if (element == innerElement)
        {
            count++;
        }
    }

    Console.WriteLine($"{element}: {count} dəfə");
}