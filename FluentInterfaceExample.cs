using System.ComponentModel;

namespace FluentInterfaceExample
{
    public class FluentExample1: IFluentInterface
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void HiddenMethod1()
        {

        }

        public void VisibleMethod1()
        {

        }
    }

    public interface FluentExample2: IFluentInterface
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void HiddenMethod2()
        {

        }

        public void VisibleMethod2()
        {

        }
    }
}