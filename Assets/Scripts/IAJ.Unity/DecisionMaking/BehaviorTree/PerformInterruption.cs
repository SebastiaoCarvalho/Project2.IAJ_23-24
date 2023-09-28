using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assets.Scripts.IAJ.Unity.DecisionMaking.BehaviorTree
{
    public class PerformInterruption : Task {

        private Interrupter _interrupter;
        private Result _desiredResult;

        public PerformInterruption(Interrupter interrupter, Result desiredResult) {
            _interrupter = interrupter;
            _desiredResult = desiredResult;
        }

        public override Result Run()
        {
            _interrupter.SetResult(_desiredResult);
            return Result.Success;
        }

    }
}