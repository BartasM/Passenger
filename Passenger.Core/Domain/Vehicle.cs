 using System;
using System.Collections.Generic;
using System.Text;

namespace Passenger.Core.Domain
{
    public class Vehicle //ValueObject - czy potrzebuje go zmieniac? raczej nie? [zastanowic sie].
        //nie chce go aktualizować, tworzę i nie zmieniam.
    {
        public string Brand { get; protected set; }
        public string Name { get; protected set; }
        public int Seats { get; set; }
    

    public Vehicle(string brand, string name, int seats)
    {
        SetBrand(brand);
        SetName(name);
        SetSeats(seats);
    }

    private  void SetBrand(string brand)
    {
            if (string.IsNullOrWhiteSpace(brand))
            {
                throw new Exception("Please provide the valid data.");
            }
            if(Brand == brand)
            {
                return;
            }
            Brand = brand;    
    }
    private  void SetName(string setName)
    {
            if (string.IsNullOrWhiteSpace(setName))
            {
                throw new Exception("Please provide the valid data.");
            }
            if (Name == setName)
            {
                return;
            }
            Brand = setName;
        }

    private  int SetSeats(int seats)
    {
        return seats;
    }
}
}
