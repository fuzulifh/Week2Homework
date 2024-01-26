using System.Drawing;
using System;

namespace Week2Homework
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname, fathername, address;
            char gender;

            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Surname:");
            surname = Console.ReadLine();
            Console.WriteLine("Enter the Father's name:");
            fathername = Console.ReadLine();
            Console.WriteLine("Enter gender(M/W):");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter date of birth (Day/Month/Year):");
            DateTime birth_date = DateTime.Parse(Console.ReadLine());
            string formatted_bd = birth_date.ToString("dd/MM/yyyy");
            Console.WriteLine("Enter the Adress:");
            address = Console.ReadLine();

            TimeSpan age = DateTime.Now - birth_date;
            int years = (int)(age.TotalDays / 365.25);

            string cins;
            if (gender == 'W' || gender == 'M') { cins = "Son"; }
            else { cins = "Daughter"; }

            string period;
            if (11 > years) { period = "Childhood"; }
            else if (16 > years) { period = "Teenager"; }
            else if (18 > years) { period = "Early Youthless"; }
            else if (35 > years) { period = "Youth"; }
            else if (65 > years) { period = "Middle age"; }
            else { period = "Old"; }

            string note;
            if (period == "Youth") { note = "qeyde alınmışdır."; }
            else { note = "qeyde alınmamısdır."; }

            Console.WriteLine("Siz " + surname + ' ' + name + ' ' + fathername + ' ' + gender + ", " + formatted_bd + " doguldugunuz ucun hal-hazirda " + years + " yasiniz vardir. Azerbaycan qanunvericiliyine uygun olaraq " + period + " dovrunuzu yasayirsiniz. Bu is yerine sadece genclik doneminde olan sexsler muraciet ede bilerler. Bu telebi nezere alaraq sizin muracietiniz " + note);
        }
    }
}