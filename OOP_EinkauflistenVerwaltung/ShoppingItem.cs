using System.Text.RegularExpressions;
using System.Windows;

namespace OOP_EinkauflistenVerwaltung
{
    class ShoppingItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public string AdditionalInfo { get; set; }
        int transitionIndex = 0;
        public ShoppingItem()
        {

        }
        public override string ToString()
        {
            return Name + " " + Price + " " + Quantity + " " + AdditionalInfo;
        }
        public bool isNumber(char c)
        {
            if (c == '0') return true;
            if (c == '1') return true;
            if (c == '2') return true;
            if (c == '3') return true;
            if (c == '4') return true;
            if (c == '5') return true;
            if (c == '6') return true;
            if (c == '7') return true;
            if (c == '8') return true;
            if (c == '9') return true;
            if (c == '.') return true;
            if (c == ',') return true;
            return false;
        }
        public bool CheckName(string Name)
        {
            if (Name == null || Name == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckPrice(string price)
        {
            var regexItem = new Regex("^[0-9 .]*$");

            if (regexItem.IsMatch(price))
            {
                return true;
            }
            else return false;
        }
        public bool CheckQuantity(string quantity)
        {
            string[] numbers = { };
            string [] type = { };
            for(int i = 0; i < quantity.Length; i++)
            {
                
            }
            for (int i = 0; i < quantity.Length; i++)
            {
                if (!isNumber(quantity[i]) && transitionIndex == -1)
                {
                    transitionIndex = i;
                }
            }
            return true;
        }
        public bool parseFromInputFields(string name, string price, string quantity, string infoText)
        {
           
            Name = name;
            Price = double.Parse(price);
            AdditionalInfo = infoText;

            int transitionIndex = -1;
            for(int i = 0; i < quantity.Length; i++)
            {
                if(!isNumber(quantity[i]) && transitionIndex == -1)
                {
                    transitionIndex = i;
                }
            }
            if(quantity == "")
            {
                this.Quantity = -1;
                this.AdditionalInfo = "";
            }
            if(transitionIndex < 0)
            {
                this.Quantity = double.Parse(quantity);
                this.AdditionalInfo = "";
            }
            else
            {
                this.Quantity = double.Parse(quantity.Substring(0, transitionIndex));
                this.AdditionalInfo = quantity.Substring(transitionIndex);
            }
            return true;
        }
    }

}
