namespace coffee_cashier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            coffeeOrder = new ComboBox();
            coffeeSize = new ComboBox();
            quantityOrder = new ComboBox();
            paymentOrder = new TextBox();
            dataGridView1 = new DataGridView();
            coffee = new DataGridViewTextBoxColumn();
            size = new DataGridViewTextBoxColumn();
            sugarLevel = new DataGridViewTextBoxColumn();
            iceLevel = new DataGridViewTextBoxColumn();
            toppings = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            payment = new DataGridViewTextBoxColumn();
            insert = new Button();
            Clear = new Button();
            iceLevelOrder = new ComboBox();
            sugarLevelOrder = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            checkedListBox1 = new CheckedListBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 45);
            label1.TabIndex = 0;
            label1.Text = "Coffee Cashier";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(71, 68);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 1;
            label2.Text = "Coffee:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(71, 112);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 2;
            label3.Text = "Size";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(71, 349);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 3;
            label4.Text = "Quantity:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(71, 391);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 4;
            label5.Text = "Payment:";
            // 
            // coffeeOrder
            // 
            coffeeOrder.AutoCompleteCustomSource.AddRange(new string[] { "Latte", "Cappuccino", "Chocolatte" });
            coffeeOrder.FormattingEnabled = true;
            coffeeOrder.Items.AddRange(new object[] { "Espresso", "Latte", "Cappuccino" });
            coffeeOrder.Location = new Point(197, 70);
            coffeeOrder.Name = "coffeeOrder";
            coffeeOrder.Size = new Size(175, 23);
            coffeeOrder.TabIndex = 5;
            // 
            // coffeeSize
            // 
            coffeeSize.AutoCompleteCustomSource.AddRange(new string[] { "Frapp", "Hot", "Iced" });
            coffeeSize.FormattingEnabled = true;
            coffeeSize.Items.AddRange(new object[] { "Medium", "Large" });
            coffeeSize.Location = new Point(197, 110);
            coffeeSize.Name = "coffeeSize";
            coffeeSize.Size = new Size(175, 23);
            coffeeSize.TabIndex = 6;
            // 
            // quantityOrder
            // 
            quantityOrder.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            quantityOrder.FormattingEnabled = true;
            quantityOrder.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            quantityOrder.Location = new Point(197, 351);
            quantityOrder.Name = "quantityOrder";
            quantityOrder.Size = new Size(175, 23);
            quantityOrder.TabIndex = 7;
            quantityOrder.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // paymentOrder
            // 
            paymentOrder.Location = new Point(197, 389);
            paymentOrder.Name = "paymentOrder";
            paymentOrder.Size = new Size(175, 23);
            paymentOrder.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { coffee, size, sugarLevel, iceLevel, toppings, quantity, payment });
            dataGridView1.Location = new Point(405, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(336, 196);
            dataGridView1.TabIndex = 9;
            // 
            // coffee
            // 
            coffee.HeaderText = "Coffee";
            coffee.Name = "coffee";
            // 
            // size
            // 
            size.HeaderText = "Size";
            size.Name = "size";
            // 
            // sugarLevel
            // 
            sugarLevel.HeaderText = "Sugar Level";
            sugarLevel.Name = "sugarLevel";
            // 
            // iceLevel
            // 
            iceLevel.HeaderText = "Ice Level";
            iceLevel.Name = "iceLevel";
            // 
            // toppings
            // 
            toppings.HeaderText = "Toppings";
            toppings.Name = "toppings";
            // 
            // quantity
            // 
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            // 
            // payment
            // 
            payment.HeaderText = "Payment";
            payment.Name = "payment";
            // 
            // insert
            // 
            insert.Location = new Point(481, 283);
            insert.Name = "insert";
            insert.Size = new Size(76, 23);
            insert.TabIndex = 10;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(596, 283);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 11;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // iceLevelOrder
            // 
            iceLevelOrder.AutoCompleteCustomSource.AddRange(new string[] { "Frapp", "Hot", "Iced" });
            iceLevelOrder.FormattingEnabled = true;
            iceLevelOrder.Items.AddRange(new object[] { "100%", "75%", "50%", "0%" });
            iceLevelOrder.Location = new Point(197, 188);
            iceLevelOrder.Name = "iceLevelOrder";
            iceLevelOrder.Size = new Size(175, 23);
            iceLevelOrder.TabIndex = 13;
            iceLevelOrder.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // sugarLevelOrder
            // 
            sugarLevelOrder.AutoCompleteCustomSource.AddRange(new string[] { "Frapp", "Hot", "Iced" });
            sugarLevelOrder.FormattingEnabled = true;
            sugarLevelOrder.Items.AddRange(new object[] { "100%", "75%", "50%", "0%" });
            sugarLevelOrder.Location = new Point(197, 147);
            sugarLevelOrder.Name = "sugarLevelOrder";
            sugarLevelOrder.Size = new Size(175, 23);
            sugarLevelOrder.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(71, 149);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 15;
            label6.Text = "Sugar Level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(71, 188);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 16;
            label7.Text = "Ice Level: ";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Bubble", "Grass Jelly", "Nata de Coco", "Whipped Cream", "Choco Chip", "Oreo" });
            checkedListBox1.Location = new Point(197, 224);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 112);
            checkedListBox1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(71, 224);
            label8.Name = "label8";
            label8.Size = new Size(79, 21);
            label8.TabIndex = 18;
            label8.Text = "Toppings: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(checkedListBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(sugarLevelOrder);
            Controls.Add(iceLevelOrder);
            Controls.Add(Clear);
            Controls.Add(insert);
            Controls.Add(dataGridView1);
            Controls.Add(paymentOrder);
            Controls.Add(quantityOrder);
            Controls.Add(coffeeSize);
            Controls.Add(coffeeOrder);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox coffeeOrder;
        private ComboBox coffeeSize;
        private ComboBox quantityOrder;
        private TextBox paymentOrder;
        private DataGridView dataGridView1;
        private Button insert;
        private Button Clear;
        private ComboBox iceLevelOrder;
        private ComboBox sugarLevelOrder;
        private Label label6;
        private Label label7;
        private CheckedListBox checkedListBox1;
        private DataGridViewTextBoxColumn coffee;
        private DataGridViewTextBoxColumn size;
        private DataGridViewTextBoxColumn sugarLevel;
        private DataGridViewTextBoxColumn iceLevel;
        private DataGridViewTextBoxColumn toppings;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn payment;
        private Label label8;
    }
}