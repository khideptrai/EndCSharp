using System.Collections;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

public class Program
{

    public static void Main(string[] args)
    {
        Dictionary<int, Student> StudentList = new Dictionary<int, Student>();
        while (true)
        {
            int option;
            Console.WriteLine("Please select an option:");
            Console.WriteLine("==========================================");
            Console.WriteLine("  1. Insert new student...");
            Console.WriteLine("  2. Display all student list...");
            Console.WriteLine("  3. Calculator average mark....");
            Console.WriteLine("  4. Find student...");
            Console.WriteLine("  5. Exit");
            Console.WriteLine("==========================================");
            Console.Write("Option: ");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Student st = new Student();
                    Console.Write("Input Student Id:   ");
                    st.StudID = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Student name:   ");
                    st.StudName = Console.ReadLine();
                    Console.Write("Input Student gender:   ");
                    st.StudGender = Console.ReadLine();
                    Console.Write("Input Student age:   ");
                    st.StudAge = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input Student class:   ");
                    st.StudClass = Console.ReadLine();
                    Console.WriteLine("Input Student mark:   ");
                    Console.Write("       intput mark 1:   ");
                    st[0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("       intput mark 2:   ");
                    st[1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("       intput mark 3:   ");
                    st[2] = Convert.ToInt32(Console.ReadLine());
                    StudentList.Add(st.StudID, st);
                    break;
                case 2:
                    foreach (var item in StudentList)
                    {
                        item.Value.Print();
                    }
                    break;
                case 3:
                    foreach (var item in StudentList)
                    {
                        item.Value.CalAvg();
                        item.Value.Print();
                    }
                    break;
                case 4:
                    FindStudent(StudentList);
                    break;
                case 5:
                    return;
            }
        }

    }

    private static void FindStudent(Dictionary<int, Student> StudentList)
    {
        int select;
        Console.WriteLine("Please select an option:");
        Console.WriteLine("==========================================");
        Console.WriteLine("  1. Find by id...");
        Console.WriteLine("  2. Find by name....");
        Console.WriteLine("  3. Find by class...");
        Console.WriteLine("==========================================");
        Console.Write("Option: ");
        select = Convert.ToInt32(Console.ReadLine());
        switch (select)
        {
            case 1:
                int id;
                Console.Write("Input id: ");
                id = Convert.ToInt32(Console.ReadLine());
                if (!StudentList.ContainsKey(id))
                {
                    Console.WriteLine("Khong tim thay id nay");
                }
                else
                {
                    foreach (var item in StudentList)
                    {
                        if (item.Key == id)
                        {
                            item.Value.Print();
                        }
                    }
                }
                break;

            case 2:
                string name;
                Console.Write("Input name: ");
                name = Console.ReadLine();
                bool check = false;
                foreach (var item in StudentList)
                {
                    if (item.Value.StudName.Contains(name))
                    {
                        check = true;
                        item.Value.Print();
                    }
                }
                if (!check)
                {
                    Console.WriteLine("Khong tim thay ten nay!!");
                }
                break;
            case 3:
                string Class;
                Console.Write("Input Class: ");
                Class = Console.ReadLine();
                bool CheckClass = false;
                foreach (var item in StudentList)
                {
                    if (item.Value.StudClass.Equals(Class))
                    {
                        CheckClass = true;
                        item.Value.Print();
                    }
                }
                if (!CheckClass)
                {
                    Console.WriteLine("Khong tim thay lop nay!!");
                }
                break;
        }
    }
}