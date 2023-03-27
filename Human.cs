using System;
using static Decorator_27._03._2023.Program;

namespace Decorator_27._03._2023
{
    public class Human : Person
    {
        public Human():base("Герой человек")
        { }
        public override int Ataca()
        { return 10; }
        public override int Speed()
        { return 10; }
        public override int Health()
        { return 10; }
        public override int Protection()
        { return 10; }
    }
    public class HumanDecorator: Human
    {
        Person person;

        public HumanDecorator(Person p)
        {
            person = p;
        }
        
    }
    public class Human_Voin : HumanDecorator
    {
        public Human_Voin(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 10 ; }
        public override int Speed()
        { return person.Speed() - 10; }
        public override int Health()
        { return person.Health() + 50; }
        public override int Protection()
        { return person.Protection() - 20; }
    }
    public class Human_Mag : HumanDecorator
    {
        public Human_Mag(Person p) : base(p)
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
    public class Human_Arbalet : HumanDecorator
    {
        public Human_Arbalet(Person p) : base(p)
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
    public class Human_Gold : HumanDecorator
    {
        public Human_Gold(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 70; }
        public override int Speed()
        { return person.Speed() + 20; }
        public override int Health()
        { return person.Health() + 0; }
        public override int Protection()
        { return person.Protection() + 0; }
    }
    public class Good_human : HumanDecorator
    {
        public Good_human(Person p) : base(p)
        {

        }
        public override int Ataca()
        { return person.Ataca() + 50; }
        public override int Speed()
        { return person.Speed() + 30; }
        public override int Health()
        { return person.Health() + 100; }
        public override int Protection()
        { return person.Protection() + 30; }
    }
}
