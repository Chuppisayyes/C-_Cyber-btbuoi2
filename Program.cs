using System;

class Program
{
    static void Main()
    {
        #region Bài 1: Tính tổng các số trong mảng
        Console.WriteLine("Bài 1: Tính tổng các số trong mảng");
        int[] danhSachSo1 = { 20, 81, 97, 63, 72, 11, 20, 15, 35, 41, 20 };
        int tong = 0;
        for (int i = 0; i < danhSachSo1.Length; i++)
        {
            tong += danhSachSo1[i];
        }
        Console.WriteLine($"Tổng các số trong mảng: {tong}");
        #endregion

        #region Bài 2: Tìm hai số có tổng bằng target
        Console.WriteLine("Bài 2: Tìm hai số có tổng bằng target");
        int[] danhSachSo2 = { 2, 7, 11, 15 };
        int mucTieu = 9;
        bool timThay = false;
        for (int i = 0; i < danhSachSo2.Length; i++)
        {
            for (int j = i + 1; j < danhSachSo2.Length; j++)
            {
                if (danhSachSo2[i] + danhSachSo2[j] == mucTieu)
                {
                    Console.WriteLine($"Hai số có tổng bằng {mucTieu}: {danhSachSo2[i]} và {danhSachSo2[j]}");
                    timThay = true;
                    break;
                }
            }
            if (timThay) break;
        }
        if (!timThay) Console.WriteLine("Không tìm thấy hai số có tổng bằng target.");
        #endregion

        #region Bài 3: Loại bỏ phần tử trùng lặp khỏi mảng đã sắp xếp
        Console.WriteLine("Bài 3: Loại bỏ phần tử trùng lặp khỏi mảng đã sắp xếp");

        int[] danhSachSo3 = { 1, 1, 2, 2, 2, 3, 4, 4, 5 };
        List<int> mangKhongLap = new List<int>();

        for (int i = 0; i < danhSachSo3.Length; i++)
        {
            if (i == 0 || danhSachSo3[i] != danhSachSo3[i - 1])
            {
                mangKhongLap.Add(danhSachSo3[i]);
            }
        }

        Console.WriteLine($"Mảng sau loại phần trùng: {string.Join(", ", mangKhongLap)}");
        Console.WriteLine($"Độ dài mảng mới: {mangKhongLap.Count}");
        #endregion

        #region Bài 4: Tìm phần tử xuất hiện nhiều nhất
        Console.WriteLine("Bài 4: Tìm phần tử xuất hiện nhiều nhất");
        int[] danhSachSo4 = { 1, 1, 1, 2, 2, 3 };
        int[] demTanSo = new int[101];
        int tanSoCaoNhat = 0;

        for (int i = 0; i < danhSachSo4.Length; i++)
        {
            demTanSo[danhSachSo4[i]]++;
            if (demTanSo[danhSachSo4[i]] > tanSoCaoNhat)
            {
                tanSoCaoNhat = demTanSo[danhSachSo4[i]];
            }
        }

        Console.WriteLine("Phần tử xuất hiện nhiều nhất:");
        for (int i = 0; i < demTanSo.Length; i++)
        {
            if (demTanSo[i] == tanSoCaoNhat)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
        #endregion

        #region Bài 5: Lợi nhuận lớn nhất từ việc mua và bán cổ phiếu
        Console.WriteLine("Bài 5: Lợi nhuận lớn nhất từ việc mua và bán cổ phiếu");
        int[] giaCoPhieu = { 7, 1, 5, 3, 6, 4 };
        int loiNhuanToiDa = 0;
        int giaThapNhat = int.MaxValue;

        for (int i = 0; i < giaCoPhieu.Length; i++)
        {
            if (giaCoPhieu[i] < giaThapNhat)
            {
                giaThapNhat = giaCoPhieu[i];
            }
            else if (giaCoPhieu[i] - giaThapNhat > loiNhuanToiDa)
            {
                loiNhuanToiDa = giaCoPhieu[i] - giaThapNhat;
            }
        }
        Console.WriteLine($"Lợi nhuận lớn nhất: {loiNhuanToiDa}");
        #endregion
    }
}
