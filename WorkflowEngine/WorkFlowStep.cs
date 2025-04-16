namespace ProposalOrchestrator.WorkflowEngine
{
    public abstract class WorkFlowStep
    {
        public abstract Task ExecuteAsync(WorkflowContext context);
        public virtual bool ShouldExecute(WorkflowContext context) => true;
    }
}
