namespace GuvenliAlimSatim.Business
{
    public class SendSMS
    {
        public int SMS()
        {
            Random random = new Random();
            int smsReference = random.Next(100000, 1000000);
            return smsReference;
        }
    }
}