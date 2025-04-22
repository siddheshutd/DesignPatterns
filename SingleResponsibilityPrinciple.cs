namespace C_;

public class SingleResponsibilityPrinciple
{
    class Laptop{
        string name;
        public double price;
        string model;

        public Laptop(string name, double price, string model){
            this.name = name;
            this.price = price;
            this.model = model;
        }
    }

    class LaptopInvoice{
        Laptop laptop;
        int quantity;

        public LaptopInvoice(Laptop laptop, int quantity){
            this.laptop = laptop;
            this.quantity = quantity;
        }

        //Responsibilty 1: Cost calculation
        public double CalculateCost(){
            return quantity*laptop.price;
        }

        //Responsibility 2: Printing Invoice
        //public void PrintInvoice() {
            //Prints the invoice
        //}
        
        //Responsibility 3: Saving to the DB
        //public void SaveToDB(){
            //Saves the invoice to DB
        //}
    }

    class InvoicePrinter{
        LaptopInvoice Invoice;
        public InvoicePrinter(LaptopInvoice invoice) {
            this.Invoice = invoice;
        }

        public void PrintInvoice(){
            Console.WriteLine($"Invoice Amount:{Invoice.CalculateCost()}");
        }
    }

    class InvoiceDAO{
        LaptopInvoice Invoice;
        public InvoiceDAO(LaptopInvoice invoice) {
            this.Invoice = invoice;
        }
        public void SaveToDB(){
            //Saving logic
        }
    }
}
