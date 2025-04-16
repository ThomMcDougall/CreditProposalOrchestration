namespace ProposalOrchestrator.WorkflowEngine
{
    public class WorkflowContext
    {
        public Guid WorkflowId { get; } = Guid.NewGuid();
        public Dictionary<string, object> Data { get; } = new Dictionary<string, object>();
        public bool IsComplete { get; set; } = false;
        public bool HasFailed { get; set; } = false;
    }
}
