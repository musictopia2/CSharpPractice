namespace CSharpPracticeLibrary.Integration01Sections01To06.Exercise10;
public class PaymentDetails
{
    public int Matched { get; set; }
    public int Short { get; set; }
    public int Overpaid { get; set; }
    public decimal Shortage { get; set; }
    public decimal Overpayment { get; set; }
    public decimal TotalExpected { get; set; }
    public decimal TotalActual { get; set; }
}