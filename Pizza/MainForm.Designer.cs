/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 5:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pizza
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton PrimoRadioButton;
		private System.Windows.Forms.RadioButton SpecialRadioButton;
		private System.Windows.Forms.RadioButton DeluxeRadioButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox salamiCheckBox;
		private System.Windows.Forms.CheckBox TomatoAndPineappleCheckBox;
		private System.Windows.Forms.CheckBox OnionsAndChiliCheckBox;
		private System.Windows.Forms.CheckBox mushroomCheckBox;
		private System.Windows.Forms.CheckBox BaconAndHamCheckBox;
		private System.Windows.Forms.CheckBox pepperCheckBox;
		private System.Windows.Forms.CheckBox cheeseCheckBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PricetextBox;
		private System.Windows.Forms.TextBox QuantitytextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TotalAmounttextBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.PrimoRadioButton = new System.Windows.Forms.RadioButton();
			this.SpecialRadioButton = new System.Windows.Forms.RadioButton();
			this.DeluxeRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.salamiCheckBox = new System.Windows.Forms.CheckBox();
			this.TomatoAndPineappleCheckBox = new System.Windows.Forms.CheckBox();
			this.OnionsAndChiliCheckBox = new System.Windows.Forms.CheckBox();
			this.mushroomCheckBox = new System.Windows.Forms.CheckBox();
			this.BaconAndHamCheckBox = new System.Windows.Forms.CheckBox();
			this.pepperCheckBox = new System.Windows.Forms.CheckBox();
			this.cheeseCheckBox = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.PricetextBox = new System.Windows.Forms.TextBox();
			this.QuantitytextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.TotalAmounttextBox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.PrimoRadioButton);
			this.groupBox1.Controls.Add(this.SpecialRadioButton);
			this.groupBox1.Controls.Add(this.DeluxeRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(44, 57);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(149, 128);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pizza";
			// 
			// PrimoRadioButton
			// 
			this.PrimoRadioButton.Location = new System.Drawing.Point(28, 84);
			this.PrimoRadioButton.Name = "PrimoRadioButton";
			this.PrimoRadioButton.Size = new System.Drawing.Size(104, 24);
			this.PrimoRadioButton.TabIndex = 2;
			this.PrimoRadioButton.TabStop = true;
			this.PrimoRadioButton.Text = "Primo";
			this.PrimoRadioButton.UseVisualStyleBackColor = true;
			this.PrimoRadioButton.CheckedChanged += new System.EventHandler(this.PrimoRadioButtonCheckedChanged);
			// 
			// SpecialRadioButton
			// 
			this.SpecialRadioButton.Location = new System.Drawing.Point(28, 53);
			this.SpecialRadioButton.Name = "SpecialRadioButton";
			this.SpecialRadioButton.Size = new System.Drawing.Size(104, 24);
			this.SpecialRadioButton.TabIndex = 1;
			this.SpecialRadioButton.TabStop = true;
			this.SpecialRadioButton.Text = "Special";
			this.SpecialRadioButton.UseVisualStyleBackColor = true;
			this.SpecialRadioButton.CheckedChanged += new System.EventHandler(this.SpecialRadioButtonCheckedChanged);
			// 
			// DeluxeRadioButton
			// 
			this.DeluxeRadioButton.Location = new System.Drawing.Point(28, 22);
			this.DeluxeRadioButton.Name = "DeluxeRadioButton";
			this.DeluxeRadioButton.Size = new System.Drawing.Size(116, 24);
			this.DeluxeRadioButton.TabIndex = 0;
			this.DeluxeRadioButton.TabStop = true;
			this.DeluxeRadioButton.Text = "Deluxe";
			this.DeluxeRadioButton.UseVisualStyleBackColor = true;
			this.DeluxeRadioButton.CheckedChanged += new System.EventHandler(this.DeluxeRadioButtonCheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.salamiCheckBox);
			this.groupBox2.Controls.Add(this.TomatoAndPineappleCheckBox);
			this.groupBox2.Controls.Add(this.OnionsAndChiliCheckBox);
			this.groupBox2.Controls.Add(this.mushroomCheckBox);
			this.groupBox2.Controls.Add(this.BaconAndHamCheckBox);
			this.groupBox2.Controls.Add(this.pepperCheckBox);
			this.groupBox2.Controls.Add(this.cheeseCheckBox);
			this.groupBox2.Location = new System.Drawing.Point(220, 26);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(232, 265);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Ingredients";
			// 
			// salamiCheckBox
			// 
			this.salamiCheckBox.Location = new System.Drawing.Point(31, 217);
			this.salamiCheckBox.Name = "salamiCheckBox";
			this.salamiCheckBox.Size = new System.Drawing.Size(104, 24);
			this.salamiCheckBox.TabIndex = 6;
			this.salamiCheckBox.Text = "Salami";
			this.salamiCheckBox.UseVisualStyleBackColor = true;
			// 
			// TomatoAndPineappleCheckBox
			// 
			this.TomatoAndPineappleCheckBox.Location = new System.Drawing.Point(31, 186);
			this.TomatoAndPineappleCheckBox.Name = "TomatoAndPineappleCheckBox";
			this.TomatoAndPineappleCheckBox.Size = new System.Drawing.Size(184, 24);
			this.TomatoAndPineappleCheckBox.TabIndex = 5;
			this.TomatoAndPineappleCheckBox.Text = "Tomato and Pineapple";
			this.TomatoAndPineappleCheckBox.UseVisualStyleBackColor = true;
			// 
			// OnionsAndChiliCheckBox
			// 
			this.OnionsAndChiliCheckBox.Location = new System.Drawing.Point(31, 155);
			this.OnionsAndChiliCheckBox.Name = "OnionsAndChiliCheckBox";
			this.OnionsAndChiliCheckBox.Size = new System.Drawing.Size(136, 24);
			this.OnionsAndChiliCheckBox.TabIndex = 4;
			this.OnionsAndChiliCheckBox.Text = "Onions and Chili";
			this.OnionsAndChiliCheckBox.UseVisualStyleBackColor = true;
			// 
			// mushroomCheckBox
			// 
			this.mushroomCheckBox.Location = new System.Drawing.Point(31, 124);
			this.mushroomCheckBox.Name = "mushroomCheckBox";
			this.mushroomCheckBox.Size = new System.Drawing.Size(104, 24);
			this.mushroomCheckBox.TabIndex = 3;
			this.mushroomCheckBox.Text = "Mushroom";
			this.mushroomCheckBox.UseVisualStyleBackColor = true;
			// 
			// BaconAndHamCheckBox
			// 
			this.BaconAndHamCheckBox.Location = new System.Drawing.Point(31, 93);
			this.BaconAndHamCheckBox.Name = "BaconAndHamCheckBox";
			this.BaconAndHamCheckBox.Size = new System.Drawing.Size(136, 24);
			this.BaconAndHamCheckBox.TabIndex = 2;
			this.BaconAndHamCheckBox.Text = "Bacon and Ham";
			this.BaconAndHamCheckBox.UseVisualStyleBackColor = true;
			// 
			// pepperCheckBox
			// 
			this.pepperCheckBox.Location = new System.Drawing.Point(31, 62);
			this.pepperCheckBox.Name = "pepperCheckBox";
			this.pepperCheckBox.Size = new System.Drawing.Size(104, 24);
			this.pepperCheckBox.TabIndex = 1;
			this.pepperCheckBox.Text = "Pepper";
			this.pepperCheckBox.UseVisualStyleBackColor = true;
			// 
			// cheeseCheckBox
			// 
			this.cheeseCheckBox.Location = new System.Drawing.Point(31, 31);
			this.cheeseCheckBox.Name = "cheeseCheckBox";
			this.cheeseCheckBox.Size = new System.Drawing.Size(104, 24);
			this.cheeseCheckBox.TabIndex = 0;
			this.cheeseCheckBox.Text = "Cheese";
			this.cheeseCheckBox.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 236);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Price:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Quantity:";
			// 
			// PricetextBox
			// 
			this.PricetextBox.Location = new System.Drawing.Point(114, 237);
			this.PricetextBox.Name = "PricetextBox";
			this.PricetextBox.Size = new System.Drawing.Size(79, 22);
			this.PricetextBox.TabIndex = 4;
			// 
			// QuantitytextBox
			// 
			this.QuantitytextBox.Location = new System.Drawing.Point(114, 265);
			this.QuantitytextBox.Name = "QuantitytextBox";
			this.QuantitytextBox.Size = new System.Drawing.Size(79, 22);
			this.QuantitytextBox.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(179, 323);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "Compute Now!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(40, 383);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Total Amount";
			// 
			// TotalAmounttextBox
			// 
			this.TotalAmounttextBox.Location = new System.Drawing.Point(146, 380);
			this.TotalAmounttextBox.Name = "TotalAmounttextBox";
			this.TotalAmounttextBox.Size = new System.Drawing.Size(100, 22);
			this.TotalAmounttextBox.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(478, 425);
			this.Controls.Add(this.TotalAmounttextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.QuantitytextBox);
			this.Controls.Add(this.PricetextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Pizza";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
