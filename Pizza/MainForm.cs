/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 5:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pizza
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void DeluxeRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			cheeseCheckBox.Checked = true;
            BaconAndHamCheckBox.Checked = true;
            OnionsAndChiliCheckBox.Checked = true;
            
            this.PricetextBox.Text = "185";
            int price = Convert.ToInt16(PricetextBox.Text);
		}
		void SpecialRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			cheeseCheckBox.Checked = true;
            pepperCheckBox.Checked = true;
            BaconAndHamCheckBox.Checked = true;
            mushroomCheckBox.Checked = true;
            OnionsAndChiliCheckBox.Checked = true;
            
            this.PricetextBox.Text ="275";
            int price = Convert.ToInt16(PricetextBox.Text);
		}
		void PrimoRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			cheeseCheckBox.Checked = true;
            pepperCheckBox.Checked = true;
            BaconAndHamCheckBox.Checked = true;
            mushroomCheckBox.Checked = true;
            OnionsAndChiliCheckBox.Checked = true;
            TomatoAndPineappleCheckBox.Checked = true;
            salamiCheckBox.Checked = true;
            
            this.PricetextBox.Text = "350";
            int price = Convert.ToInt16(PricetextBox.Text);
		}
		void Button1Click(object sender, EventArgs e)
		{
			int price = Convert.ToInt16(PricetextBox.Text);
            int quantity = Convert.ToInt16(QuantitytextBox.Text);
            int totalamount = price * quantity;
            TotalAmounttextBox.Text = totalamount.ToString("F2");
		}
	}
}
