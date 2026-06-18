namespace OrderManagement.Models
{
    public class Order
    {
        public string OrderNo { get; set; }
        public string CustomerNo { get; set; }
        public string DateEntered { get; set; }
        public string State { get; set; }
        public string Objkey { get; set; }
    }
}