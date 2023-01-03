using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataType.CustomType;
using DataType.OOP;
using static DataType.OOP.NewBankAccount;


namespace DataType
{
    public struct Coords
    {
        public int x,y;
        public Coords(int p1, int p2) 
        {
            x = p1;
            y = p2;
        }
        public override string ToString()
        {
            return "Coord ("+ x + ","+y+")";
        }
    }
    public class MainDataType
    {
        public static void Main()
        {
            // SampleEnum();
            //Console.WriteLine("ini Sample class : ");
            //SampleClass();

            //Console.WriteLine("ini sample bank account : ");
            // SampleBank();

            //TransactionBankAccount();

            //InterestBank();

        }

        

        #region Interest Bank
        public static void InterestBank()
        {
            var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformanceMonthEndTransaction();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());

            var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformanceMonthEndTransaction();
            Console.WriteLine(savings.GetAccountHistory());

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformanceMonthEndTransaction();
            Console.WriteLine(lineOfCredit.GetAccountHistory());
        }
        #endregion
        #region Transaction BankAccount
        public static void TransactionBankAccount()
        {
            var account0 = new BankAccount("aziz", 1000);
            Console.WriteLine($"Account {account0.Number} was created for {account0.Owner} with {account0.Balance} initial Balance");
            //test for a negative balance.
            try
            {
                account0.MakeWithdrawal(750, DateTime.Now, "Attemp to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
                
            }
            
            try
            {
                account0.MakeWithdrawal(200, DateTime.Now, "Attemp to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());

            }
            
            try
            {
                account0.MakeDeposit(150, DateTime.Now, "Temen Balikin Utang");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
                

            }

            Console.WriteLine(account0.GetAccountHistory);


            //Test that the initial balances must be positive
            BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                
                return;

            }
        }
        #endregion
        #region Sample BankAccount
        public static void SampleBank()
        {


            var account0 = new BankAccount("Aziz", 100000000);
            Console.WriteLine($"Account {account0.Number} was created for {account0.Owner} with {account0.Balance} initial Balance");

            var account1 = new BankAccount("Masbro", 100000000);
            Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} initial Balance");

            var account2 = new BankAccount("MAsi", 100000000);
            Console.WriteLine($"Account {account2.Number} was created for {account2.Owner} with {account2.Balance} initial Balance");

            var account3 = new BankAccount("miska", 100000000);
            Console.WriteLine($"Account {account3.Number} was created for {account3.Owner} with {account3.Balance} initial Balance");
        }
    
        #endregion


        #region Sample Class
        public static void SampleClass()
        {
            SampleClass sampleClass;


            sampleClass = new SampleClass();
            Console.WriteLine("After call Cunstructor");
            Console.WriteLine("Sample class value: {0}",sampleClass.ToString());

            sampleClass = new SampleClass(3,6);
            Console.WriteLine("After call constructor with params");
            Console.WriteLine("Sample class value : {0}", sampleClass.ToString());

        }
        #endregion

        #region Sample enum Type
        public static void SampleEnum()
        {
            Type weekDays = typeof(EnumDays);
            foreach (var item in Enum.GetNames(weekDays))
            {
                Console.WriteLine("Days : {0}",item);
            }

            Type fieldModel = typeof(EnumFileMode);
            foreach (var item in Enum.GetNames(fieldModel))
            {
                Console.WriteLine("Field Mode : {0}", item);
            }

            Colors myColors = Colors.Red | Colors.Blue | Colors.Yellow;
            Console.WriteLine();
            Console.WriteLine("myColors holds a combination of colors. namely: {0}", myColors);
            Console.WriteLine("Color Red: {0},GetName : {1}",Colors.Red,Enum.GetName(Colors.Red));

            Console.WriteLine("Status Approved: {0}, Names: {1}", ApprovalStep.Approved, Enum.GetName(ApprovalStep.Approved));
        }
        #endregion
        #region Sample Coord
        public static void SampleCoord()
        {
            Coords point1 = new Coords(2, 5);
            Console.WriteLine("Point 1 : " + point1);

            Coords point2 = new Coords(5, 5);
            Console.WriteLine("Point 2 : " + point2);

        }
        #endregion


        #region Sample Data Type
        public static void Sample1()
        {
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 18, 21 };
            var query = from item in source
                        where item <= limit
                        select item;
            Console.WriteLine("Query Result :" + query);
            foreach (var item in query)
            {
                Console.WriteLine("item value:" + item);
            }
            var query2 = from item in source
                         where item % 2 == 1
                         select item;
            Console.WriteLine("Write item with odd");
            foreach (var item in query2)
            {
                Console.WriteLine("item value : " + item);
            }
            var query3 = from item in source
                         where item % 2 == 0
                         select item;
            Console.WriteLine("Write item with even");
            foreach (var item in query3)
            {
                Console.WriteLine("item value : " + item);
            }
            var query4 = from item in source
                         where item % 3 == 0
                         select item;
            Console.WriteLine("Write item with multiple 3");
            foreach (var item in query4)
            {
                Console.WriteLine("item value : " + item);
            }
        }
        #endregion
    }
}
