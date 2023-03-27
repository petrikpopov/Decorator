using System;

namespace Decorator_27._03._2023
{
    public class Program
    {
        public abstract class Person
        {
            public string Name_Person { set; get; }

            public Person(string NP)
            {
                Name_Person = NP;
            }
            public abstract int Ataca();
            public abstract int Speed();
            public abstract int Health();
            public abstract int Protection();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Person person = new Elf();
            Person person1 = new Elf();
            Person person2 = new Elf();
            Person person3 = new Elf();
            Person person4 = new Elf();
            person = new Elf_Voin(person);
            person1 = new Elf_Mag(person1);
            person2 = new Elf_Arbalet(person2);
            person3 = new Gold_Elf(person3);
            person4 = new Good_elf(person4);

            Person person0 = new Human();
            Person person5 = new Human();
            person5 = new Human_Voin(person5);
            Person person6 = new Human();
            person6 = new Human_Mag(person6);
            Person person7 = new Human();
            person7 = new Human_Gold(person7);
            Person person8 = new Human();
            person8 = new Human_Arbalet(person8);
            Person person9 = new Human();
            person9 = new Good_human(person9);

            Console.WriteLine(person.Name_Person);
            Console.Write("Значения эльфа воина -->");
            Console.WriteLine(person.Ataca()+"\t"+person.Speed()+"\t"+person.Health()+"\t"+person.Protection());
            Console.Write("Значения эльфа мага -->");
            Console.WriteLine(person1.Ataca() + "\t" + person1.Speed() + "\t" + person1.Health() + "\t" + person1.Protection());
            Console.Write("Значения эльфа арбалетчика -->");
            Console.WriteLine(person2.Ataca() + "\t" + person2.Speed() + "\t" + person2.Health() + "\t" + person2.Protection());
            Console.Write("Значения золотого эльфа -->");
            Console.WriteLine(person3.Ataca() + "\t" + person3.Speed() + "\t" + person3.Health() + "\t" + person3.Protection());
            Console.Write("Значения доброго эльфа -->");
            Console.WriteLine(person4.Ataca() + "\t" + person4.Speed() + "\t" + person4.Health() + "\t" + person4.Protection());

            Console.WriteLine(person0.Name_Person);
            Console.Write("Значения человека воина -->");
            Console.WriteLine(person5.Ataca() + "\t" + person5.Speed() + "\t" + person5.Health() + "\t" + person5.Protection());
            Console.Write("Значения человека мага -->");
            Console.WriteLine(person6.Ataca() + "\t" + person6.Speed() + "\t" + person6.Health() + "\t" + person6.Protection());
            Console.Write("Значения золотого человека -->");
            Console.WriteLine(person7.Ataca() + "\t" + person7.Speed() + "\t" + person7.Health() + "\t" + person7.Protection());
            Console.Write("Значения человека арбалет -->");
            Console.WriteLine(person8.Ataca() + "\t" + person8.Speed() + "\t" + person8.Health() + "\t" + person8.Protection());
            Console.Write("Значения хорошего человека -->");
            Console.WriteLine(person9.Ataca() + "\t" + person9.Speed() + "\t" + person9.Health() + "\t" + person9.Protection());

        }
    }
}
