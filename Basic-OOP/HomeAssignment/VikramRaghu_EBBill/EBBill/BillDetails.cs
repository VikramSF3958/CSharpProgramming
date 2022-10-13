using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBill;

    public class BillDetails
    {
        private int meterId = 1001;

        public String MeterID { get; set; }

        public String UserName { get; set; }

        public long PhoneNumeber { get; set; }

        public String MailId { get; set; }

        public int UnitsUsed { get; set; }

        public BillDetails()
        {

        }

        public BillDetails(String userName, long phoneNumber, String mailId, int unitsUsed)
        {   
            meterId++;
            MeterID  = "EB"+meterId;

            UserName = userName;
            PhoneNumeber = phoneNumber;
            MailId = mailId;
            UnitsUsed = unitsUsed;
        }

        public void CalculateAmount()
        {
            if(UnitsUsed < 100)
            {
                System.Console.WriteLine("Since, you consumed below 100units Its Free of COST !!");
            }
            else
            {
                if(UnitsUsed >= 100 && UnitsUsed < 200 )
                {
                    System.Console.WriteLine($"Amount to be paid: {3 * UnitsUsed}");
                }
                else
                {
                    if(UnitsUsed >= 200 && UnitsUsed < 400)
                    {
                        System.Console.WriteLine($"Amount to be paid: {5 * UnitsUsed }");
                    }
                    else
                    {
                        if(UnitsUsed >= 400)
                        {
                            System.Console.WriteLine($"Amount to be paid: {6 * UnitsUsed }");
                        }
                    }
                }
            }
        }
    }
