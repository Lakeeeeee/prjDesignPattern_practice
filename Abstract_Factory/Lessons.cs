using static Abstract_Factory.LessonTypes;

namespace Abstract_Factory
{
    public class JavaOnline : Java
    {
        public JavaOnline()
        {
            SetType(new OnlineClass());
        }
    }

    public class JavaInPerson : Java
    {
        public JavaInPerson()
        {
            SetType(new InPersonClass());
        }
    }

    public class CSharpOnline : CSharp
    {
        public CSharpOnline()
        {
            SetType(new OnlineClass());
        }
    }
    public class CSharpInPerson : CSharp
    {
        public CSharpInPerson()
        {
            SetType(new InPersonClass());
        }
    }



}
