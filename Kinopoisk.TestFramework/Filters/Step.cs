using Kinopoisk.TestFramework.Steps;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.TestFramework.Filters
{
    [PSerializable]
    public class Step : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            ((BaseSteps)args.Instance).WaitLoadingPage();
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
          
        }

        public override void OnException(MethodExecutionArgs args)
        {

        }
    }
}
