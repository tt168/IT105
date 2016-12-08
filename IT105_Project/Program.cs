// IT Fdn Class Project
// Write a program to keep track of some inventory items as shown below.
// Limited database size, did not include dynamic array module nor check
// correct input formats i.e. numbers and charactors.
// 
// 

using System;
struct ItemData
{
    public int itemIDNo;
    public string sDescription;
    public double dblPricePerItem;
    public int iQuantityOnHand;
    public double dblOurCostPerItem;
    public double dblValueOfItem;
}


class MyInventory
{
    public static void Main()
    {
        // use an interger to keep track of the count of items in your inventory					
        int icount = 1;
        int x = 0;
        int optx =0; 
        // create an array of your ItemData struct
        ItemData[] itemprop = new ItemData[10];
        
        // use a never ending loop that shows the user what options they can select 
        while (optx != 5)
        {
            // as long as no one Quits, continue the inventory update

            // in that loop, show what user can select from the list
            Console.WriteLine("\n\n");
            Console.WriteLine("1. Add an item");        //item 1
            Console.WriteLine("2. Change an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items in the database");
            Console.WriteLine("5. Quit /n");
            Console.WriteLine("Please choose an option from above list (1, 2, 3, 4, 5):");

            // read the user's input and then create what case it falls
            string strx = Console.ReadLine();   // read user's input	

            optx = int.Parse(strx); // convert the given string to integer to match our case types shown below

            Console.WriteLine(); // provide an extra blank line on screen

        switch (optx)
        {
            case 1:	// add an item to the list if this option is selected
                {
                    Console.WriteLine("Please enter an item ID No.:");    //enter item no itemprop[].itemIDno
                    string iIDno = Console.ReadLine();
                    itemprop[x].itemIDNo = int.Parse(iIDno);

                    Console.WriteLine("Please enter item Description : ");    //enter item description itemprop[].sDescription
                    itemprop[x].sDescription = Console.ReadLine();

                    Console.WriteLine("Please enter item price : ");   //enter item price itemprop[].dblPricePerItem
                    string price = Console.ReadLine();
                    itemprop[x].dblPricePerItem = double.Parse(price);

                        
                    Console.WriteLine("Please enter Quantity On hand: ");   //enter item quanity on hand itemprop[].iQuantityOnHand
                    string qty = Console.ReadLine();
                    itemprop[x].iQuantityOnHand = int.Parse(qty);

                        
                    Console.WriteLine("Please enter item Cost : ");   //enter item cost itemprop[].dblOurCostPerItem
                    string cost = Console.ReadLine();
                    itemprop[x].dblOurCostPerItem = double.Parse(cost);

                    icount++;
                    x++;
                    optx = 0;
                    break;
                }

            case 2: //change items in the list if this option is selected
                {
                    Console.Write("Please enter an item ID No:");
                    string strchgid = Console.ReadLine();
                    int chgid = int.Parse(strchgid);
                    bool fFound = false;

                    for ( x = 0; x < icount; x++)
                    {
                        if (itemprop[x].itemIDNo == chgid)
                        {
                            fFound = true;
                                // code to show what has to happen if the item in the list is found

                                Console.WriteLine("Change an item ID No.:");    //change no itemprop[].itemIDno
                                string iIDno = Console.ReadLine();
                                itemprop[x].itemIDNo = int.Parse(iIDno);

                                Console.WriteLine("Change item Description: ");    //change item description itemprop[].sDescription
                                itemprop[x].sDescription = Console.ReadLine();

                                Console.WriteLine("Change item price: ");   //change item price itemprop[].dblPricePerItem
                                string price = Console.ReadLine();
                                itemprop[x].dblPricePerItem = double.Parse(price);


                                Console.WriteLine("Change Quantity On hand: ");   //change item quanity on hand itemprop[].iQuantityOnHand
                                string qty = Console.ReadLine();
                                itemprop[x].iQuantityOnHand = int.Parse(qty);


                                Console.WriteLine("Change item Cost: ");   //change item cost itemprop[].dblOurCostPerItem
                                string cost = Console.ReadLine();
                                itemprop[x].dblOurCostPerItem = double.Parse(cost);
                                // reset the count to show a new count for your list
                                //icount++;
                                // (Note: your list is now increased by one item)
                                //x++;
                            }
                    }

                    if (!fFound) // and if not found
                    {
                        Console.WriteLine("Item {0} not found", chgid);
                    }

                    break;
                }

            case 3: //delete items in the list if this option is selected
                {
                    Console.Write("Please enter an item ID No for deletion: ");
                    string strnewid = Console.ReadLine();
                    int newid = int.Parse(strnewid);
                    bool fDeleted = false;

                    for ( x = 0; x < icount; x++)
                    {
                        if (itemprop[x].itemIDNo == newid)
                        {
                            fDeleted = true;
                                // delete the item if you found it
                                //int n = icount; //note the current number of items

                                if (x < icount - 1) //see if is last item in an array
                                {
                                    while (x <= icount - 1)  //moving everyone one spot over, OK with small database.
                                    {
                                        itemprop[x].itemIDNo = itemprop[x + 1].itemIDNo;
                                        itemprop[x].sDescription = itemprop[x + 1].sDescription;
                                        itemprop[x].dblPricePerItem = itemprop[x + 1].dblPricePerItem;
                                        itemprop[x].iQuantityOnHand = itemprop[x + 1].iQuantityOnHand;
                                        itemprop[x].dblOurCostPerItem = itemprop[x + 1].dblOurCostPerItem;
                                        itemprop[x].dblValueOfItem = itemprop[x + 1].dblValueOfItem;
                                        x++;
                                    }                                
                                }
                                // reset the count to show a new count for your list 
                                icount--;
                                //(Note: your list is now reduced by one item)
                                x--;
                          }
                    }

                    if (fDeleted) // hint the user that you deleted the requested item
                    {
                        Console.WriteLine("\n Item deleted");
                    }
                    else // if did not find it, hint the user that you did not find it in your list
                    {
                        Console.WriteLine("Item {0} not found", newid);
                    }
                    break;
                }

            case 4:	 //list all items in current database if this option is selected
                {
                    Console.WriteLine("Item#  ItemID  Description           Price  QOH  Cost  Value");
                    Console.WriteLine("-----  ------  --------------------  -----  ---  ----  -----");

                    // code in this block. Use the above line format as a guide for printing or displaying the items in your list right under it
                    for ( x = 0; x < icount-1; x++)
                       {
                            int iPIDNo = itemprop[x].itemIDNo;   //these are extra work
                            string sDesp = itemprop[x].sDescription;  //these are extra work
                            double dblPrices = itemprop[x].dblPricePerItem;  //these are extra work
                            int iQty = itemprop[x].iQuantityOnHand;  //these are extra work
                            double dblCost = itemprop[x].dblOurCostPerItem;  //these are extra work
                            itemprop[x].dblValueOfItem = (double)iQty * itemprop[x].dblPricePerItem;  
                            double dblValue = itemprop[x].dblValueOfItem; //these are extra work

                            Console.WriteLine("{0,-6} {1,-7} {2,-21} {3,-6} {4,-4} {5,-6} {6:C}", x, iPIDNo, sDesp, dblPrices, iQty, dblCost, dblValue);
                        }
                        optx = 0;
                        break;
                }


            case 5: //quit the program if this option is selected
                {
                    Console.Write("Are you sure that you want to quit(y/n)?");
                    string strresp = Console.ReadLine();

                    if (strresp =="n" || strresp =="N")
                    {
                        optx = 0;   //as long as it is not 5, the process is not breaking	
                    }
                 }
                 break;

            default:
                {
                    Console.Write("Invalid Option, try again");
                    break;
                }
        }
    }
}
}