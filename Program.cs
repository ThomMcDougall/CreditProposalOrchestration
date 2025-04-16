using ProposalOrchestrator.Workflows;

var workflow = CreditProposalWorkflow.Create();
await workflow.RunAsync();