namespace Assignment1.Models
{
     // Define the enumeration
    public enum TechnicalInterest
    {
        IoT,
        Cognitive,
        Wearable,
        AR_VR

    }

    public class CompetitionInvite
    {
        public string Name { get; set; } = "";
        public string Email { get; set; }= "";
        public string PhoneNumber { get; set; } = "";
        public bool WillAttend { get; set; } = false;

        // New properties
        public string Address { get; set; } = "";
        public string TwitterAccount { get; set; } = "";  
        public TechnicalInterest Interest { get; set; }     
    }
}
