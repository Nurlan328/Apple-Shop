namespace AppleShop.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int orderID { get; set; }
        public int ProductId { get; set; }
        public uint price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}