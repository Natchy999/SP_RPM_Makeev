using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_dasdasdas
{
    internal class Program
    {
        class Creature
        {
            public string Name { get; set; }
            // Присвоение атрибута Name если производный класс использует конструктор без параметров
            public Creature()
            {
                Name = "DEFAULT";
                Console.WriteLine("Нет имени - было поставлено имя по умолчанию");
            }
            // Присвоение атрибута Name
            public Creature(string name)
            {
                Name = name;
            }
            // Вывод атрибута Name
            public virtual void Info_get()
            {
                Console.WriteLine($"Имя: {Name}");
            }
            public virtual void Info_change(string name) { 
                string OldName = Name; 
                Name = name;
                Console.WriteLine($"Было изменено имя \"{OldName}\" на \"{Name}\"");
            }
        }
        class Uma : Creature
        {
            public int Speed, Stamina, Power, Guts, Wit;
            // Конструктор с дополнительными атрибутами, включая базовый Name
            public Uma(string name, int speed, int stamina, int power, int guts, int wit) : base(name)
            {
                Speed = speed;
                Stamina = stamina;
                Power = power;
                Guts = guts;
                Wit = wit;
            }
            // Вывод всех атрибутов, в том числе базовый Name
            public override void Info_get()
            {
                Console.WriteLine($"Имя: {Name}\nСтаты:\n\tСкорость - {Speed}\n\tВыносливость - {Stamina}\n\tСила - {Power}\n\tВоля - {Guts}\n\tУм - {Wit}\n");
            }
            public override void Info_change(string name)
            {
                string OldName = base.Name;

                base.Info_change(name);
            }
        }
        static void Main(string[] args)
        {
            Uma Daiwa = new Uma("Дайва Скарлет", 966, 465, 760, 311, 380);
            Daiwa.Info_get();
            Uma Vodka = new Uma("Водка", 1032, 313, 840, 250, 455);
            Vodka.Info_get();
        }
    }
}
