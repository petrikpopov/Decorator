using System;
using static Decorator_27._03._2023.Program;

namespace Decorator_27._03._2023
{
    public class Elf : Person
    {
        public Elf() : base("Герой эльф")
        {

        }
        public override int Ataca()
        { return 5; }
        public override int Speed()
        { return 5; }
        public override int Health()
        { return 5; }
        public override int Protection()
        { return 5; }
    }
    public class ElfDecorator : Elf
    {
        protected Person person;

        public ElfDecorator(Person p)
        {
            person = p;
        }
    }
    public class Elf_Voin : ElfDecorator
    {
        public Elf_Voin(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 20; }
        public override int Speed()
        { return person.Speed() - 10; }
        public override int Health()
        { return person.Health() + 100; }
        public override int Protection()
        { return person.Protection() + 20; }
    }
    public class Elf_Mag : ElfDecorator
    {
        public Elf_Mag(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 20; }
        public override int Speed()
        { return person.Speed() - 10; }
        public override int Health()
        { return person.Health() + 50; }
        public override int Protection()
        { return person.Protection() + 10; }
    }
    public class Elf_Arbalet : ElfDecorator
    {
        public Elf_Arbalet(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 20; }
        public override int Speed()
        { return person.Speed() + 10; }
        public override int Health()
        { return person.Health() + 50; }
        public override int Protection()
        { return person.Protection() + 10; }
    }
    public class Gold_Elf: ElfDecorator
    {
        public Gold_Elf(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 70; }
        public override int Speed()
        { return person.Speed() + 20; }
        public override int Health()
        { return person.Health() +0; }
        public override int Protection()
        { return person.Protection() + 0; }
    }
    public class Good_elf : ElfDecorator
    {
        public Good_elf(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 50; }
        public override int Speed()
        { return person.Speed() + 30; }
        public override int Health()
        { return person.Health() +100; }
        public override int Protection()
        { return person.Protection() + 30; }
    }
}
