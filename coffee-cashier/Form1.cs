namespace coffee_cashier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {
            //Jika menu yang dipilih Kopi Espresso
            if (coffeeOrder.SelectedItem.ToString() == "Espresso")
            {
                float coffeePrices1 = 0;
                if (coffeeSize.SelectedItem.ToString() == "Medium")
                {
                    coffeePrices1 = float.Parse(quantityOrder.Text) * 10000;
                }
                else
                {
                    coffeePrices1 = float.Parse(quantityOrder.Text) * (10000 + 3000);
                }
                List<string> selectedToppings1 = new List<string>();
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    selectedToppings1.Add(itemChecked.ToString());
                }
                string toppings1 = string.Join(",", selectedToppings1);

                float toppingsPrice1 = 0;
                //Menambahkan harga toppings
                if (selectedToppings1.Contains("Bubble"))
                {
                    toppingsPrice1 = toppingsPrice1 + 3000;
                }
                if (selectedToppings1.Contains("Grass Jelly"))
                {
                    toppingsPrice1 = toppingsPrice1 + 3500;
                }
                if (selectedToppings1.Contains("Nata de Coco"))
                {
                    toppingsPrice1 = toppingsPrice1 + 2500;
                }
                if (selectedToppings1.Contains("Whipped Cream"))
                {
                    toppingsPrice1 = toppingsPrice1 + 1000;
                }
                if (selectedToppings1.Contains("Choco Chip"))
                {
                    toppingsPrice1 = toppingsPrice1 + 1500;
                }
                if (selectedToppings1.Contains("Oreo"))
                {
                    toppingsPrice1 = toppingsPrice1 + 2000;
                }

                paymentOrder.Text = (coffeePrices1 + toppingsPrice1).ToString();
                dataGridView1.Rows.Add(coffeeOrder.Text, coffeeSize.Text, sugarLevelOrder.Text, iceLevelOrder.Text, toppings1, quantityOrder.Text, paymentOrder.Text);
            }

            //Jika menu yang dipiih Kopi Latte
            if (coffeeOrder.SelectedItem.ToString() == "Latte")
            {
                float coffeePrices2 = 0;
                if (coffeeSize.SelectedItem.ToString() == "Medium")
                {
                    coffeePrices2 = float.Parse(quantityOrder.Text) * 15000;
                }
                else
                {
                    coffeePrices2 = float.Parse(quantityOrder.Text) * (15000 + 3000);
                }
                List<string> selectedToppings2 = new List<string>();
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    selectedToppings2.Add(itemChecked.ToString());
                }
                string toppings2 = string.Join(",", selectedToppings2);

                Int64 toppingsPrice2 = 0;
                //Menambahkan harga toppings
                if (selectedToppings2.Contains("Bubble"))
                {
                    toppingsPrice2 = toppingsPrice2 + 3000;
                }
                if (selectedToppings2.Contains("Grass Jelly"))
                {
                    toppingsPrice2 = toppingsPrice2 + 3500;
                }
                if (selectedToppings2.Contains("Nata de Coco"))
                {
                    toppingsPrice2 = toppingsPrice2 + 2500;
                }
                if (selectedToppings2.Contains("Whipped Cream"))
                {
                    toppingsPrice2 = toppingsPrice2 + 1000;
                }
                if (selectedToppings2.Contains("Choco Chip"))
                {
                    toppingsPrice2 = toppingsPrice2 + 1500;
                }
                if (selectedToppings2.Contains("Oreo"))
                {
                    toppingsPrice2 = toppingsPrice2 + 2000;
                }

                paymentOrder.Text = (coffeePrices2 + toppingsPrice2).ToString();
                dataGridView1.Rows.Add(coffeeOrder.Text, coffeeSize.Text, sugarLevelOrder.Text, iceLevelOrder.Text, toppings2, quantityOrder.Text, paymentOrder.Text);
            }

            //Jika menu yang dipilih Kopi Cappuccino
            if (coffeeOrder.SelectedItem.ToString() == "Cappuccino")
            {
                float coffeePrices3 = 0;
                if (coffeeSize.SelectedItem.ToString() == "Medium")
                {
                    coffeePrices3 = float.Parse(quantityOrder.Text) * 12000;
                }
                else
                {
                    coffeePrices3 = float.Parse(quantityOrder.Text) * (12000 + 3000);
                }
                List<string> selectedToppings3 = new List<string>();
                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    selectedToppings3.Add(itemChecked.ToString());
                }
                string toppings3 = string.Join(",", selectedToppings3);

                Int64 toppingsPrice3 = 0;
                //Menambahkan harga toppings
                if (selectedToppings3.Contains("Bubble"))
                {
                    toppingsPrice3 = toppingsPrice3 + 3000;
                }
                if (selectedToppings3.Contains("Grass Jelly"))
                {
                    toppingsPrice3 = toppingsPrice3 + 3500;
                }
                if (selectedToppings3.Contains("Nata de Coco"))
                {
                    toppingsPrice3 = toppingsPrice3 + 2500;
                }
                if (selectedToppings3.Contains("Whipped Cream"))
                {
                    toppingsPrice3 = toppingsPrice3 + 1000;
                }
                if (selectedToppings3.Contains("Choco Chip"))
                {
                    toppingsPrice3 = toppingsPrice3 + 1500;
                }
                if (selectedToppings3.Contains("Oreo"))
                {
                    toppingsPrice3 = toppingsPrice3 + 2000;
                }

                paymentOrder.Text = (coffeePrices3 + toppingsPrice3).ToString();
                dataGridView1.Rows.Add(coffeeOrder.Text, coffeeSize.Text, sugarLevelOrder.Text, iceLevelOrder.Text, toppings3, quantityOrder.Text, paymentOrder.Text);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            coffeeOrder.Text = "";
            coffeeSize.Text = "";
            sugarLevelOrder.Text = "";
            iceLevelOrder.Text = "";
            quantityOrder.Text = "";
            paymentOrder.Text = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}