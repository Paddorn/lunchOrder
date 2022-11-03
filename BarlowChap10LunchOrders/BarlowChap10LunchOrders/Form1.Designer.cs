namespace BarlowChap10LunchOrders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnSalad = new System.Windows.Forms.RadioButton();
            this.radBtnPizza = new System.Windows.Forms.RadioButton();
            this.radBtnBurger = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBoxFrenchFries = new System.Windows.Forms.CheckBox();
            this.chkBoxKMM = new System.Windows.Forms.CheckBox();
            this.chkBoxLTO = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOrderTotal = new System.Windows.Forms.TextBox();
            this.txtBoxTax = new System.Windows.Forms.TextBox();
            this.txtBoxSubTotal = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnSalad);
            this.groupBox1.Controls.Add(this.radBtnPizza);
            this.groupBox1.Controls.Add(this.radBtnBurger);
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Options";
            // 
            // radBtnSalad
            // 
            this.radBtnSalad.AutoSize = true;
            this.radBtnSalad.Location = new System.Drawing.Point(9, 75);
            this.radBtnSalad.Name = "radBtnSalad";
            this.radBtnSalad.Size = new System.Drawing.Size(91, 19);
            this.radBtnSalad.TabIndex = 2;
            this.radBtnSalad.TabStop = true;
            this.radBtnSalad.Text = "Salad - $4.95";
            this.radBtnSalad.UseVisualStyleBackColor = true;
            this.radBtnSalad.CheckedChanged += new System.EventHandler(this.radBtnSalad_CheckedChanged);
            // 
            // radBtnPizza
            // 
            this.radBtnPizza.AutoSize = true;
            this.radBtnPizza.Location = new System.Drawing.Point(11, 50);
            this.radBtnPizza.Name = "radBtnPizza";
            this.radBtnPizza.Size = new System.Drawing.Size(89, 19);
            this.radBtnPizza.TabIndex = 1;
            this.radBtnPizza.TabStop = true;
            this.radBtnPizza.Text = "Pizza - $5.95";
            this.radBtnPizza.UseVisualStyleBackColor = true;
            this.radBtnPizza.CheckedChanged += new System.EventHandler(this.radBtnPizza_CheckedChanged);
            // 
            // radBtnBurger
            // 
            this.radBtnBurger.AutoSize = true;
            this.radBtnBurger.Location = new System.Drawing.Point(11, 26);
            this.radBtnBurger.Name = "radBtnBurger";
            this.radBtnBurger.Size = new System.Drawing.Size(124, 19);
            this.radBtnBurger.TabIndex = 0;
            this.radBtnBurger.TabStop = true;
            this.radBtnBurger.Text = "Hamburger - $6.95";
            this.radBtnBurger.UseVisualStyleBackColor = true;
            this.radBtnBurger.CheckedChanged += new System.EventHandler(this.radBtnBurger_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBoxFrenchFries);
            this.groupBox2.Controls.Add(this.chkBoxKMM);
            this.groupBox2.Controls.Add(this.chkBoxLTO);
            this.groupBox2.Location = new System.Drawing.Point(284, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add-ons($0.75 Each)";
            // 
            // chkBoxFrenchFries
            // 
            this.chkBoxFrenchFries.AutoSize = true;
            this.chkBoxFrenchFries.Location = new System.Drawing.Point(12, 75);
            this.chkBoxFrenchFries.Name = "chkBoxFrenchFries";
            this.chkBoxFrenchFries.Size = new System.Drawing.Size(89, 19);
            this.chkBoxFrenchFries.TabIndex = 2;
            this.chkBoxFrenchFries.Text = "French Fries";
            this.chkBoxFrenchFries.UseVisualStyleBackColor = true;
            this.chkBoxFrenchFries.CheckedChanged += new System.EventHandler(this.chkBoxFrenchFries_CheckedChanged);
            // 
            // chkBoxKMM
            // 
            this.chkBoxKMM.AutoSize = true;
            this.chkBoxKMM.Location = new System.Drawing.Point(12, 50);
            this.chkBoxKMM.Name = "chkBoxKMM";
            this.chkBoxKMM.Size = new System.Drawing.Size(179, 19);
            this.chkBoxKMM.TabIndex = 1;
            this.chkBoxKMM.Text = "Ketchup, Mustard, and Mayo";
            this.chkBoxKMM.UseVisualStyleBackColor = true;
            this.chkBoxKMM.CheckedChanged += new System.EventHandler(this.chkBoxKMM_CheckedChanged);
            // 
            // chkBoxLTO
            // 
            this.chkBoxLTO.AutoSize = true;
            this.chkBoxLTO.Location = new System.Drawing.Point(12, 26);
            this.chkBoxLTO.Name = "chkBoxLTO";
            this.chkBoxLTO.Size = new System.Drawing.Size(166, 19);
            this.chkBoxLTO.TabIndex = 0;
            this.chkBoxLTO.Text = "Lettuce, Tomatoes, Onions";
            this.chkBoxLTO.UseVisualStyleBackColor = true;
            this.chkBoxLTO.CheckedChanged += new System.EventHandler(this.chkBoxLTO_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxOrderTotal);
            this.groupBox3.Controls.Add(this.txtBoxTax);
            this.groupBox3.Controls.Add(this.txtBoxSubTotal);
            this.groupBox3.Location = new System.Drawing.Point(57, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Taxes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subtotal:";
            // 
            // txtBoxOrderTotal
            // 
            this.txtBoxOrderTotal.Location = new System.Drawing.Point(109, 80);
            this.txtBoxOrderTotal.Name = "txtBoxOrderTotal";
            this.txtBoxOrderTotal.ReadOnly = true;
            this.txtBoxOrderTotal.Size = new System.Drawing.Size(100, 23);
            this.txtBoxOrderTotal.TabIndex = 3;
            // 
            // txtBoxTax
            // 
            this.txtBoxTax.Location = new System.Drawing.Point(109, 51);
            this.txtBoxTax.Name = "txtBoxTax";
            this.txtBoxTax.ReadOnly = true;
            this.txtBoxTax.Size = new System.Drawing.Size(100, 23);
            this.txtBoxTax.TabIndex = 1;
            // 
            // txtBoxSubTotal
            // 
            this.txtBoxSubTotal.Location = new System.Drawing.Point(109, 22);
            this.txtBoxSubTotal.Name = "txtBoxSubTotal";
            this.txtBoxSubTotal.ReadOnly = true;
            this.txtBoxSubTotal.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSubTotal.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(395, 160);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(89, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 372);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radBtnSalad;
        private RadioButton radBtnPizza;
        private RadioButton radBtnBurger;
        private GroupBox groupBox2;
        private CheckBox chkBoxFrenchFries;
        private CheckBox chkBoxKMM;
        private CheckBox chkBoxLTO;
        private GroupBox groupBox3;
        private TextBox txtBoxOrderTotal;
        private TextBox txtBoxTax;
        private TextBox txtBoxSubTotal;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnPlaceOrder;
        private Button btnExit;
    }
}