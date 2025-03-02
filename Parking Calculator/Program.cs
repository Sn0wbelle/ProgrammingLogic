using System;

class ParkingCalculator
{
    static double CalculateParkingCost(int hours)
    {
        double totalCost;
        
        if (hours <= 3)
        {
            totalCost = 2.00;
        }
        else
        {
            totalCost = 2.00 + (hours - 3) * 0.50;
        }
        
        if (totalCost > 10.00)
        {
            totalCost = 10.00;
        }
        
        return totalCost;
    }
    
    static void Main()
    {
        int numCustomers;
        
        Console.Write("Enter the number of customers: ");
        numCustomers = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= numCustomers; i++)
        {
            Console.Write($"Enter hours parked for customer {i}: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            
            double totalCost = CalculateParkingCost(hours);
            
            Console.WriteLine($"Total parking cost for customer {i}: ${totalCost:F2}\n");
        }
    }
}
