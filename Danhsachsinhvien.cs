using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlysinhvien
{
    internal class Danhsachsinhvien
    {
        List<SinhVien> List = new List<SinhVien>();
        internal class SinhVien
        {
            private bool IsNumber(string input)
            {
                foreach (Char c in input)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }

            public static string ChuanhoaID(ref int input)
            {
                int n = 6;  //So chu so cua ID
                string temp = Convert.ToString(input);
                for (int i = 0; i < n - Convert.ToString(input).Length; i++)
                {
                    temp = "0" + temp;
                }
                return temp;
            }

            public static string ChuanhoaID(ref string input)
            {
                int n = 6;  //So chu so cua ID
                string temp = input;
                for (int i = 0; i < n - Convert.ToString(input).Length; i++)
                {
                    temp = "0" + temp;
                }
                return temp;
            }

            public static void Chuanhoaten(ref string temp)
            {
                string[] ten = temp.Split(" ");

            hoten:  //Nhap Ho va Ten
                for (int k = 0; k < ten.Length; k++)
                {
                    for (int i = 0; i < ten[k].Length; i++)
                    {

                        if (ten[k].Length > 0)
                        {
                            string temp1 = ten[k];
                            ten[k] = Convert.ToString(temp1[0]).ToUpper();
                            for (int j = 1; j < temp1.Length; j++)
                            {
                                ten[k] += Convert.ToString(temp1[j]).ToLower();
                            }
                        }
                    }
                }
                temp = "";
                for (int i = 0; i < ten.Length; i++)
                {
                    temp += ten[i];
                    if (i < ten.Length - 1 && ten[i] != "")
                    {
                        temp += " ";
                    }
                }
            }

            private string _id;
            public string ID
            {
                get { return _id; }
                set { _id = value; }
            }

            private string _name;
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            private string _gender;
            public string Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }

            private int _age;
            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }

            private double _C_sharp_point;
            public double C_sharp_point
            {
                get { return _C_sharp_point; }
                set { _C_sharp_point = value; }
            }
            private double _Unity_point;
            public double Unity_point
            {
                get { return _Unity_point; }
                set { _Unity_point = value; }
            }
            private double _3D_point;
            public double _3Dpoint
            {
                get { return _3D_point; }
                set { _3D_point = value; }
            }
            private double _avr_point;
            public double Avr_point
            {
                get { return _avr_point; }
                set { _avr_point = value; }
            }
            private string _xep_loai;
            public string Xep_loai
            {
                get { return _xep_loai; }
                set { _xep_loai = value; }
            }






            public void Diemtrungbinh()
            {
                _avr_point = (_C_sharp_point + _Unity_point + _3D_point) / 3;
                Console.WriteLine(_avr_point);
            }

            public void Xeploai()
            {
                _avr_point = (_C_sharp_point + _Unity_point + _3D_point) / 3;
                if (_avr_point >= 8)
                {
                    _xep_loai = "Gioi";
                }
                else if (_avr_point >= 6.5)
                {
                    _xep_loai = "Kha";
                }
                else if (_avr_point >= 5)
                {
                    _xep_loai = "Trung binh";
                }
                else
                {
                    _xep_loai = "Yeu";
                }
                Console.WriteLine(_xep_loai);
            }
            public void Nhapthongtin(int a)  //Nhap thong tin vao
            {

                _id = ChuanhoaID(ref a);
                Console.WriteLine("Nhap thong tin hoc vien moi");
                Console.WriteLine("-----------------------");
                Console.Write($"Ho ten: "); _name = Console.ReadLine();
                Chuanhoaten(ref _name);
                do
                {
                    Console.Write($"Gioi tinh (Nam/Nu/Khac): "); _gender = Console.ReadLine();
                }
                while (_gender != "Nam" && _gender != "Nu" && _gender != "Khac");

                {
                    string temp;
                    do
                    {
                        Console.Write($"Tuoi: "); temp = Console.ReadLine();

                    }
                    while (IsNumber(temp) == false);
                    _age = Convert.ToInt32(temp);
                }

                {
                    string temp;
                    int temp1;
                    do
                    {
                        Console.Write($"Diem C#: "); temp = Console.ReadLine();
                        temp1 = Convert.ToInt32(temp);
                    }
                    while (IsNumber(temp) == false || 0 > temp1 || 10 < temp1);
                    _C_sharp_point = Convert.ToInt32(temp);
                }

                {
                    string temp;
                    int temp1;
                    do
                    {
                        Console.Write($"Diem Unity: "); temp = Console.ReadLine();
                        temp1 = Convert.ToInt32(temp);
                    }
                    while (IsNumber(temp) == false || 0 > temp1 || 10 < temp1);
                    _Unity_point = Convert.ToInt32(temp);
                }

                {
                    string temp;
                    int temp1;
                    do
                    {
                        Console.Write($"Diem 3D: "); temp = Console.ReadLine();
                        temp1 = Convert.ToInt32(temp);
                    }
                    while (IsNumber(temp) == false || 0 > temp1 || 10 < temp1);
                    _3D_point = Convert.ToInt32(temp);
                }

                Diemtrungbinh();
                Xeploai();
            }


            public void Show()
            {
                Console.WriteLine($"Thong tin hoc vien ID {_id}");
                Console.WriteLine("-----------------------");
                Console.Write($"Ho ten: {_name}\n");
                Console.Write($"Gioi tinh: {_gender}\n");
                Console.Write($"Tuoi: {_age}\n");
                Console.Write($"Diem C#: {_C_sharp_point} \n");
                Console.Write($"Diem Unity: {_Unity_point} \n");
                Console.Write($"Diem 3D: {_3D_point} \n");
                Console.Write($"Diem Trung Binh: {_avr_point} \n");
                Console.Write($"Xep loai hoc luc: {_xep_loai} \n");
            }


        }


        public static int Search_ID(List<SinhVien> List, string input)  //Tim kiem vi tri cua ID trong List
        {
            int index;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].ID == input)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int Search_Name(List<SinhVien> List, string input)  //Tim kiem vi tri cua ID trong List
        {
            int index;
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Name == input)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void Update_ID(List<SinhVien> List, string input)
        {
            int index = Search_ID(List, input);
            List[index].Nhapthongtin(int.Parse(input));
        }
        public static void Delete_ID(List<SinhVien> List, string input)
        {
            int index = Search_ID(List, input);
            List.Remove(List[index]);
        }

        public static void Sapxep_avr_point(ref List<SinhVien> a)
        {




            for (int i = 0; i < a.Count - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < a.Count - i - 1; j++)
                {
                    if (a[j].Avr_point > a[j + 1].Avr_point)
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        public static void Hienthi_ten(List<SinhVien> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i].Name);
            }
        }
    }
}
