namespace Abstract_Factory
{
    public class LessonTypes
    {
        public abstract class LessonType
        {
            public abstract int TypeCost();
            public abstract string TypeDiscribe();
        }

        public class OnlineClass : LessonType
        {
            public override int TypeCost()
            {
                return 20;
            }

            public override string TypeDiscribe()
            {
                return "線上課程";
            }
        }

        public class InPersonClass : LessonType
        {
            public override int TypeCost()
            {
                return 50;
            }

            public override string TypeDiscribe()
            {
                return "實體課程";
            }
        }

    }
}
