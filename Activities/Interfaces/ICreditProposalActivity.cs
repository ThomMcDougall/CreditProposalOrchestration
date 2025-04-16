using ProposalOrchestrator.Domain;

namespace ProposalOrchestrator.Activities.Interfaces
{
    public interface ICreditProposalActivity
    {
        Task<bool> ExecuteAsync(CreditProposal creditProposal);
    }
}