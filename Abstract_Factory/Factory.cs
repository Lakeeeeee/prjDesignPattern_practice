using static Abstract_Factory.LessonTypes;

namespace Abstract_Factory
{
    public class Factory
    {
        public abstract class LessonFactory
        {
            public abstract Java MakeJavaLesson();
            public abstract CSharp MakeCSharpLesson();
        }

        public class OnlineFactory : LessonFactory
        {
            public override CSharp MakeCSharpLesson()
            {
                return new CSharpOnline() { type = new OnlineClass() };
            }

            public override Java MakeJavaLesson()
            {
                return new JavaOnline() { type = new OnlineClass() };
            }
        }
        public class InPersonFactory : LessonFactory
        {
            public override CSharp MakeCSharpLesson()
            {
                return new CSharpInPerson() { type = new InPersonClass() };
            }

            public override Java MakeJavaLesson()
            {
                return new JavaInPerson() { type = new InPersonClass() };
            }
        }
    }
}
