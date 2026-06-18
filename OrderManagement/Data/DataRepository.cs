using System.Collections.Generic;
using OrderManagement.Models;


namespace OrderManagement.Data
{
    public static class DataRepository
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer { CustomerId = "M0001", Name = "A FIRMASI", CreationDate = "14.12.2023", AssociationNo = "1111111110", Objkey = "5BE612F41D6C47C286CB4C3F34FEA3A6" },
            new Customer { CustomerId = "M0011", Name = "B FIRMASI", CreationDate = "6.10.2022", AssociationNo = "1111111111", Objkey = "EDE9D7D4F5B845E68EC538AE483B985D" },
            new Customer { CustomerId = "M0045", Name = "C FIRMASI", CreationDate = "8.09.2022", AssociationNo = "1111111112", Objkey = "F1592890C33C4F49A011E243D6F54E4C" },
            new Customer { CustomerId = "M0051", Name = "D FIRMASI", CreationDate = "7.04.2023", AssociationNo = "1111111113", Objkey = "46F4FFDEC0954DDA82AEF51423F5A0E4" },
            new Customer { CustomerId = "M0527", Name = "E FIRMASI", CreationDate = "27.05.2022", AssociationNo = "1111111114", Objkey = "26408E8A1222428EAD428597964D07C8" },
            new Customer { CustomerId = "M1000", Name = "F FIRMASI", CreationDate = "9.09.2022", AssociationNo = "1111111115", Objkey = "CCBC980B8F1C437D8F7609267D978DCB" },
            new Customer { CustomerId = "M1010", Name = "G FIRMASI", CreationDate = "20.10.2022", AssociationNo = "1111111116", Objkey = "317AD23F639A4F658F2F24E24A26ACA6" },
            new Customer { CustomerId = "M1100", Name = "H FIRMASI", CreationDate = "10.10.2022", AssociationNo = "1111111117", Objkey = "9E386F772ACE4BEB835721ED332BAAC6" },
            new Customer { CustomerId = "M1111", Name = "I FIRMASI", CreationDate = "11.10.2022", AssociationNo = "1111111118", Objkey = "32F2D15399EB448E9C010E5AE8FC7FCF" },
            new Customer { CustomerId = "M2809", Name = "J FIRMASI", CreationDate = "28.09.2022", AssociationNo = "1111111119", Objkey = "3E86D587B0064084A616526CDED779DF" }
        };

        public static List<Supplier> Suppliers = new List<Supplier>
        {
            new Supplier { SupplierId = "T0001", Name = "X FIRMASI", CreationDate = "11.05.2022", AssociationNo = "2111111110", Objkey = "9574CC2040504AC2BF229082667FDA99" },
            new Supplier { SupplierId = "T0002", Name = "Y FIRMASI", CreationDate = "17.05.2022", AssociationNo = "2111111111", Objkey = "F72196C9A6A640798B1A1ADA25AA997A" },
            new Supplier { SupplierId = "T0003", Name = "C FIRMASI", CreationDate = "5.06.2022", AssociationNo = "1111111112", Objkey = "7C08BB84FE894A8393BE364E1434A4CF" },
            new Supplier { SupplierId = "T0004", Name = "D FIRMASI", CreationDate = "6.06.2022", AssociationNo = "1111111113", Objkey = "E75ACEB05E254CA194C967BBE140675C" },
            new Supplier { SupplierId = "T0011", Name = "Z FIRMASI", CreationDate = "27.05.2022", AssociationNo = "2111111114", Objkey = "6A6A8D4954044C6382337DAF7B9175F7" },
            new Supplier { SupplierId = "T0017", Name = "N FIRMASI", CreationDate = "27.05.2022", AssociationNo = "1111111119", Objkey = "FB4FBDEA279340AEAE0597435523DB6B" }
        };

        public static List<Order> Orders = new List<Order>
        {
            new Order { OrderNo = "*1079", CustomerNo = "M0527", DateEntered = "27.05.2022 07:09", State = "Planned", Objkey = "5624F7F82128422F888D61231253D095" },
            new Order { OrderNo = "*1087", CustomerNo = "M0527", DateEntered = "31.05.2022 00:07", State = "Cancelled", Objkey = "C7A73B68CE394149B61C07C4B42551F4" },
            new Order { OrderNo = "*1174", CustomerNo = "M0527", DateEntered = "24.06.2022 04:37", State = "Invoiced/Closed", Objkey = "0558C529B7EB4F88A3FB729EF42B699B" },
            new Order { OrderNo = "*1201", CustomerNo = "M0527", DateEntered = "29.06.2022 06:55", State = "Delivered", Objkey = "914A5250F14E4E7C9A2952F81F727313" },
            new Order { OrderNo = "*1207", CustomerNo = "M0527", DateEntered = "4.07.2022 03:33", State = "Released", Objkey = "0BCF04EF680246B9B55F2C9C52C870E1" },
            new Order { OrderNo = "*1345", CustomerNo = "M1000", DateEntered = "9.09.2022 04:03", State = "Invoiced/Closed", Objkey = "BBE4A0F7CAD24711ABF90AFF14D4A8E5" },
            new Order { OrderNo = "*1351", CustomerNo = "M1000", DateEntered = "9.09.2022 06:36", State = "Released", Objkey = "FD3B3AEFA24147B182D9E1F5A5733D29" },
            new Order { OrderNo = "*1407", CustomerNo = "M2809", DateEntered = "28.09.2022 07:19", State = "Picked", Objkey = "E4E41F9A7E29463C9F55A1F3C3CC7548" },
            new Order { OrderNo = "*1458", CustomerNo = "M1111", DateEntered = "11.10.2022 07:35", State = "Reserved", Objkey = "266554BB0FFC49E382495149DBE56DD2" },
            new Order { OrderNo = "*1489", CustomerNo = "M1111", DateEntered = "18.10.2022 04:14", State = "Blocked", Objkey = "B2A9E87EB8D842D787BB5CDA89903264" },
            new Order { OrderNo = "*455551", CustomerNo = "M1000", DateEntered = "6.11.2023 09:36", State = "Partially Delivered", Objkey = "1DA14BC89CB74F11AF8F1AA61353A652" }
        };
    }
}