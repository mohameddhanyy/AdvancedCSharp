using AdvancedC_.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_.ExceptionExample
{
    internal class Service
    {
        private readonly static Random random = new Random();
        public void Start(Delivery delivery)
        {
            try
            {
                Processing(delivery);
                Shipping(delivery);
                OnTransit(delivery);
                Delivered(delivery);
            }
            catch (TransittingException e)
            {
                Console.WriteLine($"{e.Message} in Location {e.Location}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End");
            }

        }

        private void Processing(Delivery delivery)
        {
            FakeIt("Processing");
            //if (random.Next(1, 6) == 1)
            //{
            //    throw new Exception("an Error Happen in Processing Goods");
            //}
            delivery.Status = DeliveryStatus.PROCESSING;
        }
        private void Shipping(Delivery delivery)
        {
            FakeIt("Shipping");
            //if (random.Next(1, 6) == 1)
            //{
            //    throw new Exception("an Error Happen in Processing Goods");
            //}
            delivery.Status = DeliveryStatus.SHIPPING;
        }
        private void OnTransit(Delivery delivery)
        {
            FakeIt("On The Way");
            if (random.Next(1, 6) == 1)
            {
                throw new TransittingException(delivery,$"'{delivery.Address}'","an Error Happen in Processing Goods");
            }
            delivery.Status = DeliveryStatus.ONTRANSIT;
        }
        private void Delivered(Delivery delivery)
        {
            FakeIt("Delivered");
            delivery.Status = DeliveryStatus.DELIVERED;
        }

        private void FakeIt(string title)
        {
            switch (title)
            {
                case "Processing":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "Shipping":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "On The Way":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "Delivered":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.Write(title);
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine(".");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
