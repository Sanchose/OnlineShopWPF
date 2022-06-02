using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_EinkauflistenVerwaltung
{
    //
    //
    //
    //
    //
    //Here working all without quantity + i done delete selected in listview 
    //
    //
    //
    //
    public partial class MainWindow : Window
    {
        ShoppingItem Shoper = new ShoppingItem();
        List<ShoppingItem> myItems = new List<ShoppingItem>();
        List<string> prices = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClickOK(object sender, RoutedEventArgs e)
        {
            ShoppingItem newItem = new ShoppingItem();
            if (Shoper.CheckName(lbl_Name.Text) == false)
            {
                MessageBox.Show("Enter Name");
            }
            if (Shoper.CheckPrice(lbl_Price.Text) == false)
            {
                MessageBox.Show("Wrong price");
            }
            if (Shoper.CheckQuantity(lbl_Quantity.Text) == false)
            {
                MessageBox.Show("Wrong Amount");
            }
            if (Shoper.CheckName(lbl_Name.Text) == true && Shoper.CheckPrice(lbl_Price.Text) == true)
            {
                myItems.Add(newItem);
                myList.Items.Add("Name:'" + lbl_Name.Text + "' Price: '" + lbl_Price.Text + "' Amount: '" + lbl_Quantity.Text + "' Aditional info: '" + lbl_AdditionalInfo.Text + "'");
                prices.Add(lbl_Price.Text);
            }
            else { }
            
        }
        public bool CheckQuantity()
        {
            return true;
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
        public void BtnClickDelete(object sender, RoutedEventArgs e)
        {
            lbl_Quantity.Text = ""; lbl_Name.Text = ""; lbl_Price.Text = ""; lbl_AdditionalInfo.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int price = 0;
            bool enprice=false;
            foreach (string i in prices)
            {
                if( i== null || i=="" )
                {
                    enprice=true;
                }
                else
                {
                    int mount = int.Parse(i);
                    price += mount;
                }
                
            }
            if (enprice == true)
            {
                pricess.Content = price + "Warning: No price specified for some items in the list!";
            }
            else
                pricess.Content = price;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            myList.Items.RemoveAt(myList.SelectedIndex);
        }
    }

}
