using Kinopoisk.TestFramework.Steps;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace Kinopoisk.TestFramework.Filters
{
    [PSerializable]
    public class Step : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            ((BaseSteps)args.Instance).WorkPage.WaitPageLoading();
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
          
        }

        public override void OnException(MethodExecutionArgs args)
        {

        }
    }
}
