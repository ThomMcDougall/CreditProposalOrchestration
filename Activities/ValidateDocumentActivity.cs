using ProposalOrchestrator.Domain;

namespace ProposalOrchestrator.Activities
{
    public class ValidateDocumentActivity
    {
        public Task<bool> ExecuteAsync(CreditProposal creditProposal)
        {
            Console.WriteLine("📄 Validating documents...");
            return Task.FromResult(true);
        }
    }
}