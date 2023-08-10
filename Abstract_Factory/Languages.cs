using static Abstract_Factory.LessonTypes;

namespace Abstract_Factory
{
    public abstract class Language
    {
        public LessonType type;
        public void SetType(LessonType type)
        {
            this.type = type;
        }
        public LessonType getType()
        {
            return type;
        }

        public int getTotal()
        {
            return ProgramCost() + this.type.TypeCost();
        }

        public abstract int ProgramCost();
        public abstract string Discribe();
        public string Confirm() //感覺應該移到別的地方
        {
            return $"This is your {Discribe()} , the way you take class is by {type.TypeDiscribe()}, 總共是 {getTotal()}元";
        }
    }

    public class Java : Language
    {
        public override int ProgramCost()
        {
            return 100;
        }

        public override string Discribe()
        {
            return "Java Program";
        }
    }
    public class CSharp : Language
    {
        public override int ProgramCost()
        {
            return 200;
        }

        public override string Discribe()
        {
            return "CSharp Program";
        }
    }

    public class Pthyon : Language
    {
        public override int ProgramCost()
        {
            return 300;
        }

        public override string Discribe()
        {
            return "Pthyon Program";
        }
    }
}
