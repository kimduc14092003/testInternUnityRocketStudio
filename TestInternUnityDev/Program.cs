/* ====================== Bài 1============================== */
void changeOrderOfArray(int[] arr, int offset)
{
    // kiểm tra biến offset
    if (offset < 0)
    {
        // lấy giá trị nguyên dương của offset để xác định số lần dịch chuyển thứ tự mảng
        offset = -offset;
        for (int i = 0; i < offset; i++)
        {
            //biến sub hỗ trợ việc xoay vòng thứ tự mảng
            int sub = arr[0];
            //vòng lặp qua tất cả phần tử mảng gán cho phần tử j=j+1
            for (int j = 0; j < arr.Length; j++)
            {
                if (j == (arr.Length - 1)) //gán giá trị sub cho phần tử cuối cùng của vòng lặp
                {
                    arr[j] = sub;
                }
                else arr[j] = arr[j + 1];
            }
        }

    }
    else if (offset > 0)
    {
        for (int i = 0; i < offset; i++)
        {
            //biến sub hỗ trợ việc xoay vòng thứ tự mảng
            int sub = arr[arr.Length - 1];
            //vòng lặp qua tất cả phần tử mảng gán cho phần tử j=j-1
            for (int j = arr.Length - 1; j >= 0; j--)
            {
                if (j == 0) //gán giá trị sub cho phần tử cuối cùng của vòng lặp
                {
                    arr[j] = sub;
                }
                else arr[j] = arr[j - 1];
            }
        }
    }
}
/*----------------------------------------------------------------------*/


/* ================== Bài 2============================================= */
int getLongestArray(int[] arr)
{
    //Khai báo biến trả về kích thước mảng con có độ dài lớn nhất
    int lengOfLongestArray = 0;
    //Khai báo biến lưu tạm kích thước mảng
    int count = 0;

    //sắp xếp mảng từ bé đến lớn
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }

    for (int i = 0; i < arr.Length; i++)
    {
        count = 1; // count =1 vì arr[0] = arr[0] 
        for (int j = i + 1; j < arr.Length; j++)
        {
            // So sánh giá trị phần tử thứ i so với các phần tử thứ j
            // Vì đã sắp xếp mảng từ bé đến lớn nên ta chỉ xét giá trị phần tử j > phần tử i là 1
            if (arr[i] == arr[j] || arr[i] == arr[j] - 1)
            {
                count++;
            }
            else break; // không thỏa mãn sẽ dừng vòng lặp
        }

        if (count > lengOfLongestArray)
        {
            lengOfLongestArray = count; //kích thước mảng mới > mảng cũ -> lưu giá trị mới 
        }
    }
    return lengOfLongestArray;
}
/*---------------------------------------------------------------*/

//====================== Kiểm thử=================================
Console.WriteLine("Bài 1:");
int[] arr = { 1, 2, 4, 5, 1, 1, 10, 2, 1, 3, 0, -5 };
int offset = 4;
changeOrderOfArray(arr, offset);
foreach (int i in arr)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n-------------------------------");
Console.WriteLine("Bài 2:");

Console.WriteLine( getLongestArray(arr));


