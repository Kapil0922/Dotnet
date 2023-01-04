namespace BankManager;
using EGovernance;
public class BankManager{

 public delegate  void BankManager(double amount);   

public void BlockAccount(double Amount){
Console.WriteLine("In the Block Account");
}
public void SendEmail(double Amount){
Console.WriteLine("In the Send Email");
}
public void SendSMS(double Amount){
Console.WriteLine("In the Send SMS");
}
}
