using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<datarow> table = new List<datarow>
            {
                new datarow {
                    date = new DateTime(2020,08,14),
                    refid = 3310,
                    description = "Factura de contado 2019",
                    value = 17584
                },
                new datarow {
                    date = new DateTime(2020,08,17),
                    refid = 595,
                    description = "Recibo electronico de pago",
                    value = -39200
                },
                new datarow {
                    date = new DateTime(2020,08,24),
                    refid = 3380,
                    description = "Factura de contado 2019",
                    value = 13216
                },
                new datarow {
                    date = new DateTime(2020,08,26),
                    refid = 3414,
                    description = "Factura de contado 2019",
                    value = 17584
                },
                new datarow {
                    date = new DateTime(2020,08,27),
                    refid = 597,
                    description = "Recibo electronico de pago",
                    value = -17920
                },
                new datarow {
                    date = new DateTime(2020,08,31),
                    refid = 3466,
                    description = "Factura de contado 2019",
                    value = 17584
                },
            };

            foreach (var item in table)
            {
                Console.WriteLine($"{item.date} | {item.refid} | {item.description} | {item.value}");
            }

            table.Sort();
            Console.WriteLine("Ordenados por RefId");
            foreach (var item in table)
            {
                Console.WriteLine($"{item.date} | {item.refid} | {item.description} | {item.value}");
            }


            Console.ReadLine();
        }
    }

    class datarow : IComparable<datarow>
    {
        public int rowid { get; set; }
        public DateTime date { get; set; }
        public int refid{ get; set; }
        public string description { get; set; }
        public decimal value { get; set; }

        public int CompareTo(datarow compareDatarow)
        {
            // A null value means that this object is greater.
            if (compareDatarow == null)
                return 1;

            else
                return this.refid.CompareTo(compareDatarow.refid);
        }

    }
}
