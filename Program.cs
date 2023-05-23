using System;

namespace Quanlysinhvien;
public class Program
{
    static void Main(string[] args)
    {
        {
            List<Danhsachsinhvien.SinhVien> List = new List<Danhsachsinhvien.SinhVien>();
            int count = 1;
            int n = 1;


            while (n < 10)
            {

                switch (n)
                {
                    case 1:
                        {

                            Danhsachsinhvien.SinhVien a = new Danhsachsinhvien.SinhVien();
                            Console.WriteLine("Nhap ID Sinh vien muon cap nhat thong tin: ");

                            a.Nhapthongtin(count);
                            List.Add(a);
                            count++;
                            Console.Clear();
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("Nhap ID Sinh vien can tim: ");
                            string input = Console.ReadLine();
                            int id = Convert.ToInt32(input);
                            Console.Clear();
                            List[id - 1].Show();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("- An 1 neu muon tim kiem theo ID");
                            Console.WriteLine("- An 2 neu muon tim kiem theo ten");
                            int a = int.Parse(Console.ReadLine());
                            switch (a)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Nhap ID Sinh vien can tim kiem: ");
                                        string input = Console.ReadLine();
                                        Console.Clear();
                                        int index = Danhsachsinhvien.Search_ID(List, input);
                                        if (index != -1)
                                        {
                                            List[index].Show();
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Nhap ten Sinh vien can tim kiem: ");
                                        string input = Console.ReadLine();
                                        Console.Clear();
                                        int index = Danhsachsinhvien.Search_Name(List, input);
                                        if (index != -1)
                                        {
                                            List[index].Show();
                                        }
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Nhap ID Sinh vien can cap nhat: ");
                            string input = Console.ReadLine();
                            int id = Convert.ToInt32(input);
                            Danhsachsinhvien.Update_ID(List, input);
                            Console.Clear();
                            break;

                        }
                    case 5:
                        {
                            Console.WriteLine("Nhap ID Sinh vien can xoa: ");
                            string input = Console.ReadLine();
                            int id = Convert.ToInt32(input);
                            Danhsachsinhvien.Delete_ID(List, input);
                            Console.Clear();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Nhap ID Sinh vien can xoa: ");
                            string input = Console.ReadLine();
                            Danhsachsinhvien.Delete_ID(List, input);
                            Console.Clear();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine($"So luong sinh vien: {List.Count}");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Sap xep theo diem trung binh: ");
                            var a = List;
                            for (int i = 0; i < a.Count; i++)
                            {
                                a.Add(List[i]);
                            }
                            Danhsachsinhvien.Sapxep_avr_point(ref a);
                            Danhsachsinhvien.Hienthi_ten(a);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Hien thi ten sinh vien: ");
                            Danhsachsinhvien.Hienthi_ten(List);
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("Sap xep theo ten: ");
                            var a = List;
                            for (int i = 0; i < a.Count; i++)
                            {
                                a.Add(List[i]);
                            }
                            Danhsachsinhvien.Sapxep_avr_point(ref a);
                            break;
                        }

                };
                Console.WriteLine("Ban co muon tiep tuc?");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Chon mot hanh dong muon lam:");
                Console.WriteLine("- An 1 neu muon dien thong tin");
                Console.WriteLine("- An 2 neu muon xem lai thong tin");
                Console.WriteLine("- An 3 neu tim kiem thong tin");
                Console.WriteLine("- An 4 neu muon dung lai");
                Console.WriteLine("- An 5 neu muon xoa 1 sinh vien");
                Console.WriteLine("- An 6 neu muon xem so luong sinh vien");
                Console.WriteLine("- An 7 neu tim kiem thong tin");
                Console.WriteLine("- An 8 neu muon sap xep theo diem trung binh");
                Console.WriteLine("- An 9 neu muon hien thi danh sach ten sinh vien");

                n = int.Parse(Console.ReadLine());
                Console.Clear();
            }



        }
    }
}
