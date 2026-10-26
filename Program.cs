using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap3
{
    class Program
    {
       
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // 1. Nhập số lượng phần tử của mảng
                Console.Write("Nhập số lượng phần tử của mảng (n > 0): ");
                int n = int.Parse(Console.ReadLine());

                int[] arr = new int[n];

                // 2. Nhập từng phần tử vào mảng
                Console.WriteLine("\n--- Nhập các phần tử của mảng ---");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Nhập phần tử thứ arr[{i}]: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                // 3. Xuất mảng vừa nhập
                Console.Write("\nMảng vừa nhập: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();

                // 4. Tính toán bằng vòng lặp thủ công (Cơ bản)
                int tong = 0;
                int max = arr[0];
                int min = arr[0];

                for (int i = 0; i < n; i++)
                {
                    tong += arr[i]; // Cộng dồn các phần tử

                    if (arr[i] > max)
                    {
                        max = arr[i]; // Cập nhật giá trị lớn nhất
                    }

                    if (arr[i] < min)
                    {
                        min = arr[i]; // Cập nhật giá trị nhỏ nhất
                    }
                }

                // 5. In kết quả ra màn hình
                Console.WriteLine("\n--- KẾT QUẢ ---");
                Console.WriteLine($"Tổng của mảng: {tong}");
                Console.WriteLine($"Số nguyên lớn nhất trong mảng: {max}");
                Console.WriteLine($"Số nguyên nhỏ nhất trong mảng: {min}");
            }
        
    }
}
