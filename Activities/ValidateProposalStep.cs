using ProposalOrchestrator.WorkflowEngine;

namespace ProposalOrchestrator.Activities
{
    public class ValidateProposalStep : WorkFlowStep
    {
        public override Task ExecuteAsync(WorkflowContext context)
        {
            Console.WriteLine("[STEP] Validating credit proposal...");

            context.Data["IsValid"] = true;
            return Task.CompletedTask;
        }
    }
}