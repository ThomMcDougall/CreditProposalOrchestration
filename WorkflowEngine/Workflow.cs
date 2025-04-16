namespace ProposalOrchestrator.WorkflowEngine
{
    public class Workflow
    {
        private readonly List<WorkFlowStep> _steps = new List<WorkFlowStep>();

        public Workflow AddStep(WorkFlowStep step)
        {
            _steps.Add(step);
            return this;
        }

        public async Task RunAsync()
        {
            var context = new WorkflowContext();

            foreach (var step in _steps)
            {
                if (context.HasFailed || context.IsComplete)
                    break;

                if (step.ShouldExecute(context))
                {
                    try
                    {
                        await step.ExecuteAsync(context);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[ERROR] Step failed: {ex.Message}");
                        context.HasFailed = true;
                    }
                }
            }
        }
    }
}
