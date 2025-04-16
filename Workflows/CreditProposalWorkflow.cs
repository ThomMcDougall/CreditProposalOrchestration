using ProposalOrchestrator.Activities;
using ProposalOrchestrator.WorkflowEngine;

namespace ProposalOrchestrator.Workflows
{
    public class CreditProposalWorkflow
    {
        public static Workflow Create()
        {
            return new Workflow()
                .AddStep(new ValidateProposalStep());
        }
    }
}
