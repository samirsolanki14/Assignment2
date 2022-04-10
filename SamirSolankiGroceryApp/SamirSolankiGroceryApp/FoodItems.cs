public class Fooditems 
{
    public int quantity{ get; set;}
    public int price{ get; set;}
    public int foodproductnumber{ get; set;}
    public string? foodname { get; set;}
    public string? fooddescription { get; set;}

    public int foodexpirydays{ get; set;}
    

    public void IncreaseQuantity()
    {
        if(quantity<20)
        quantity = quantity + 1;
    }

    public void DecreaseQuantity()
    {
        if(quantity>0)
        quantity = quantity - 1;
    }
}