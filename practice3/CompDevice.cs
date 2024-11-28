using System;
using System.Collections.Generic;
namespace practice3
{
    public class CompEquipment : IComparable<CompEquipment>, IComparer<CompEquipment>, ICloneable
    {
        protected string brand;
        protected string cpu_brand;
        protected int ram;
        protected int price;

        public CompEquipment(string brand = "Неизвестный", string cpu_brand = "Неизвестный", int ram = 0, int price = 0)
        {
            this.brand = brand;
            this.cpu_brand = cpu_brand;
            this.ram = ram;
            this.price = price;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Бренд: {this.brand}");
            Console.WriteLine($"Бренд процессора: {this.cpu_brand}");
            Console.WriteLine($"Объем оперативной памяти (Гб): {this.ram}");
            Console.WriteLine($"Цена (Руб.): {this.price}");
        }

        public string GetBrand()
        {
            return this.brand;
        }
        public string GetCpuBrand()
        {
            return this.cpu_brand;
        }
        public int GetRam()
        {
            return this.ram;
        }

        public int GetPrice()
        {
            return this.price;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public void SetCpuBrand(string cpu_brand)
        {
            this.cpu_brand = cpu_brand;
        }

        public void SetRam(int ram)
        {
            this.ram = ram;
        }

        public void SetPrice(int price)
        {
            this.price = price;
        }

        public int CompareTo(CompEquipment other)
        {
            if (other == null) return 1;
            return this.price.CompareTo(other.price);
        }

        public int Compare(CompEquipment x, CompEquipment y)
        {
            if (x == null) return -1;
            if (y == null) return 1;
            return x.price.CompareTo(y.price);
        }

        public object Clone()
        {
            return new CompEquipment(this.brand, this.cpu_brand, this.ram, this.price);
        }
    }
}