using System;

namespace BankingApp
{
    public class Transcation
    {
        public Transcation(decimal amount, DateTime date, string note)
        {
            Amount = amount;
            TranscationDate = date;
            Note = note;
        }

        public decimal Amount { get; set; }
        public DateTime TranscationDate { get; set; }
        public string Note { get; set; }
    }
}
