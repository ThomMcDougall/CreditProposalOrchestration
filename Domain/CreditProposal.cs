namespace ProposalOrchestrator.Domain
{
    public class CreditProposal
    {
        public Guid Id { get; set; }
        public string ProponentName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public int TermInMonths { get; set; }
        public string Status { get; set; } = "Pending";

        public void Approve() => Status = "Approved";
        public void Reject() => Status = "Rejected";
    }
}
