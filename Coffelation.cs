using System;

namespace UTS_PBO
{
    public class paymentdebit
    {
        public void hitungDebit(uint totalcost)
        {
            string bank;
            double costfee = 0;

            Console.WriteLine();

            // Choose the Bank Account
            Console.WriteLine("    This is the available bank account:");
            Console.WriteLine("    1. Mandiri");
            Console.WriteLine("    2. BCA");
            Console.WriteLine("    3. BRI");
            Console.WriteLine("    4. Other");
            Console.WriteLine();
            Console.WriteLine("    *If you choose other you'll get 2.5% bank fee");
            Console.WriteLine();
            Console.Write("    What would you choose? ");
            bank = Convert.ToString(Console.ReadLine());
            if (bank == "1" || bank == "2" || bank == "3" || bank == "Mandiri" || bank == "mandiri" || bank == "BCA" || bank == "bca" || bank == "BRI" || bank == "bri")
                {
                    Console.WriteLine();
                    Console.Write("    Enter your pin : ");
                    Console.ReadLine();
                    Console.WriteLine("    Thanks! Your payment is success.");
                }
            else
                {
                    Console.WriteLine();
                    Console.WriteLine("    Your total is Rp {0}",totalcost.ToString());
                    costfee = totalcost+(totalcost*0.025);
                    Console.WriteLine("    Within the bank fee you'll have to pay Rp {0}",costfee.ToString());
                    Console.WriteLine();
                    Console.Write("    Enter your pin : ");
                    Console.ReadLine();
                    Console.WriteLine("    Thanks! Your payment is success.");  
                }
        }      
    }

    public class Cashier
    {
        public void totalOutput(uint cost, string totalOrder)
        {
            string cashdebit, debit;
            uint tunai,kembalian = 0;

            // Total Output and Choose Payment Method
            Console.WriteLine();
            Console.WriteLine(" --------------------------------------------------------------- ");
            Console.WriteLine();
            Console.WriteLine("    Your current order is{0}", totalOrder);
            Console.WriteLine("    Total     : Rp {0}",cost.ToString());

            cd:
            Console.Write("    Are you paying with cash or debit? (Cash/Debit) : ");
            cashdebit = Convert.ToString(Console.ReadLine());
            if (cashdebit == "D" || cashdebit == "d" || cashdebit == "Debit" || cashdebit == "debit")
                {
                    paymentdebit pm = new paymentdebit ();
                    pm.hitungDebit(cost);
                }
            // Input Cash
            if (cashdebit == "C" || cashdebit == "c" || cashdebit == "cash" || cashdebit == "Cash")
                {
                    Console.Write("    Cash      : Rp ");
                    tunai = Convert.ToUInt32(Console.ReadLine());

                    // Processing the Change
                    kembalian = tunai-cost;

                    // Output change
                    if(cost>tunai)
                    {
                        Console.WriteLine("    Sorry, your cash isn't enough!");
                        Console.Write("    Do you want to change to debit instead? (Y/N) : ");
                        debit = Convert.ToString(Console.ReadLine());
                        if (debit == "Y" || debit == "y")
                            {
                                paymentdebit pm = new paymentdebit ();
                                pm.hitungDebit(cost);
                            }
                        else
                            {
                                Console.WriteLine("    Sorry then, we can't process your payment!");
                            }
                    }
                    else
                    {
                        Console.WriteLine("    Change    : Rp {0}",kembalian.ToString());
                    }
                }
            else
            {
                Console.WriteLine("    Sorry the payment method you choose is not available");
                Console.WriteLine("    Please make sure you choose the right payment method.");
                goto cd;
            }
            
        }
    }
        
    public class OrderMenu
    {
        public void OrderCoffe(uint cost, string totalOrder)
        {
            string pilihan, ulang, coldhot;
            string order = string.Empty;
            string Esp = string.Empty;
            byte quantity = 0;
            uint CAL=25000, CALEs=26000;
            uint Espresso=20000, EspressoEs=21000, Machiato=28000, MachiatoEs=29000;
            uint totalHarga = 0;

            transaksi :
            Console.WriteLine();
            Console.Write(" What menu would you choose : ");
            pilihan = Convert.ToString( Console.ReadLine ());

            // Input Espresso
            if (pilihan == "1" || pilihan == "Espresso" || pilihan == "espresso")
            {
            Console.Write(" How many? ");
            quantity = Convert.ToByte(Console.ReadLine());

            // Ice or Hot
            Console.Write(" Would you like your drink to be cold or hot? (C/H) : ");
            coldhot = Convert.ToString(Console.ReadLine());

            // Find Total
                if (coldhot == "C" || coldhot == "c" || coldhot == "Cold" || coldhot == "cold")
                {
                    totalHarga = EspressoEs*quantity;
                    Esp = " Ice Espresso";
                }
                if (coldhot == "H" || coldhot == "h" || coldhot == "hot" || coldhot == "Hot")
                {
                    totalHarga = Espresso*quantity;
                    Esp = " Hot Espresso";
                }
            order = Convert.ToString(quantity + Esp);
            Console.WriteLine(" You order {0}.",order);
            }

            // Input Americano
            if (pilihan == "2" || pilihan == "Americano" || pilihan == "americano")
            {
            Console.Write(" How many? ");
            quantity = Convert.ToByte(Console.ReadLine());

            // Ice or Hot
            Console.Write(" Would you like your drink to be cold or hot? (C/H) : ");
            coldhot = Convert.ToString(Console.ReadLine());

            // Find Total
                if (coldhot == "C" || coldhot == "c" || coldhot == "Cold" || coldhot == "cold") 
                {
                    totalHarga = CALEs*quantity;
                    Esp = " Ice Americano";
                }
                if (coldhot == "H" || coldhot == "h" || coldhot == "hot" || coldhot == "Hot")
                {
                    totalHarga = CAL*quantity;
                    Esp = " Hot Americano";
                }
            order = Convert.ToString(quantity + Esp);
            Console.WriteLine(" You order {0}.",order);
            }
            
            // Input Latte
            if (pilihan == "3" || pilihan == "latte" || pilihan == "Latte")
            {
            Console.Write(" How many? ");
            quantity = Convert.ToByte(Console.ReadLine());

            // Ice or Hot
            Console.Write(" Would you like your drink to be cold or hot? (C/H) : ");
            coldhot = Convert.ToString(Console.ReadLine());

            // Find Total
                if (coldhot == "C" || coldhot == "c" || coldhot == "Cold" || coldhot == "cold") 
                {
                    totalHarga = CALEs*quantity;
                    Esp = " Ice Latte";
                }
                if (coldhot == "H" || coldhot == "h" || coldhot == "hot" || coldhot == "Hot")
                {
                    totalHarga = CAL*quantity;
                    Esp = " Hot Latte";
                }
            order = Convert.ToString(quantity + Esp);
            Console.WriteLine(" You order {0}.",order);
            }

            // Input Capuccino
            if (pilihan == "4" || pilihan == "Capuccino" || pilihan == "capuccino")
            {
            Console.Write(" How many? ");
            quantity = Convert.ToByte(Console.ReadLine());

            // Ice or Hot
            Console.Write(" Would you like your drink to be cold or hot? (C/H) : ");
            coldhot = Convert.ToString(Console.ReadLine());

            // Find Total
                if (coldhot == "C" || coldhot == "c" || coldhot == "Cold" || coldhot == "cold") 
                {
                    totalHarga = CALEs*quantity;
                    Esp = " Ice Capuccino";
                }
                if (coldhot == "H" || coldhot == "h" || coldhot == "hot" || coldhot == "Hot")
                {
                    totalHarga = CAL*quantity;
                    Esp = " Hot Capuccino";
                }
            order = Convert.ToString(quantity + Esp);
            Console.WriteLine(" You order {0}.",order);
            }

            // Input Machiato
            if (pilihan == "5" || pilihan == "Machiato" || pilihan == "machiato")
            {
            Console.Write(" How many? ");
            quantity = Convert.ToByte(Console.ReadLine());

            // Ice or Hot
            Console.Write(" Would you like your drink to be cold or hot? (C/H) : ");
            coldhot = Convert.ToString(Console.ReadLine());

            // Find Total
                if (coldhot == "C" || coldhot == "c" || coldhot == "Cold" || coldhot == "cold")
                {
                    totalHarga = MachiatoEs*quantity;
                    Esp = " Ice Machiato";
                }
                if (coldhot == "H" || coldhot == "h" || coldhot == "hot" || coldhot == "Hot")
                {
                    totalHarga = Machiato*quantity;
                    Esp = " Hot Machiato";
                }
            order = Convert.ToString(quantity + Esp);
            Console.WriteLine(" You order {0}.",order);
            }

            cost = cost + totalHarga;
            totalOrder = totalOrder + ", " + order;

            Console.WriteLine();
            Console.WriteLine(" Your total is Rp {0}",cost.ToString());
            Console.WriteLine();
            // Repeating the transaction
            Console.Write(" Do you want to buy something else? [Y/N] : ");
            ulang = Convert.ToString(Console.ReadLine());
            if (ulang == "y" || ulang == "Y")
            goto transaksi;

            Cashier cs = new Cashier();
            cs.totalOutput(cost, totalOrder);
            
        }
    }
    public class Menu
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            uint cost = 0;
            string totalOrder = string.Empty;

            // Opening
            Console.WriteLine();
            Console.WriteLine(" **************************************************");  
            Console.WriteLine();
            Console.WriteLine("               Welcome to Coffelation! ");
            Console.WriteLine("  A place where you can enjoy your favorite coffe ");
            Console.WriteLine();
            Console.WriteLine("                    Happy order!~ ");
            Console.WriteLine();
            Console.WriteLine(" **************************************************");
            
            Console.WriteLine();
            Console.WriteLine("First of all, who's your name?");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("    Hello {0}, choose your menu! ", name);
            Console.WriteLine("    ——————————————————————————————————————— ");

            Console.WriteLine("    1. Espresso           = Rp 20.000 ");
            Console.WriteLine("    2. Americano          = Rp 25.000 ");
            Console.WriteLine("    3. Latte              = Rp 25.000 ");
            Console.WriteLine("    4. Capuccino          = Rp 25.000 ");
            Console.WriteLine("    5. Machiato           = Rp 28.000 ");
            Console.WriteLine();
            Console.WriteLine("    *You have to pay more Rp 1.000 ");
            Console.WriteLine("     if you choose your drink to be cold ");
            
            OrderMenu om = new OrderMenu();
            om.OrderCoffe(cost, totalOrder);
            Console.WriteLine();
            
            // Closing
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(" **********************************************************");
            Console.WriteLine();
            Console.WriteLine("             Thank you for your purchase! ");
            Console.WriteLine("          Hope you having a good day ahead ");
            Console.WriteLine("            Don't forget to come again <3 ");
            Console.WriteLine();
            Console.WriteLine("                   - Coffelation - ");
            Console.WriteLine();
            Console.WriteLine(" **********************************************************");

            Console.WriteLine();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
