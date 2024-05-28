/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/28/2024
 * Time: 2:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace openAndCloseRectangle
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
			// TO D O: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			lpix = panel1.Left;
			lpiy = panel1.Top;
		}
		
		
		public bool isclosed = true;
		public int lpix = 0;
		public int lpiy = 0;
		public bool wtch()
		{
			if(isclosed==true){isclosed=false;return isclosed;}
			else {isclosed=true;return isclosed;}
		}
		public bool gg()
		{
			int xi = 0;
			int yi = 0;
			if(wtch()==true)
			{
				xi=100;
				yi=200;
				
				while(xi>0 && yi>0)
				{
					panel1.BackColor = Color.FromArgb(255,255,255,255);
					//Thread.Sleep(1);
					panel1.Width = yi;
					panel1.Height = xi;
					xi--;
					yi-=2;
					panel1.Left+=2;
					panel1.Top=lpiy;
					panel1.BackColor = Color.FromArgb(yi,yi,yi,yi);
					//Thread.Sleep(1);
				}
				return false;
			}
			else
			{
				xi=1;
				yi=1;
				while(xi<100 && yi<200)
				{
					panel1.BackColor = Color.FromArgb(255,0,0,0);
					//Thread.Sleep(1);
					panel1.Width = yi;
					panel1.Height = xi;
					xi++;
					yi+=2;
					panel1.Left-=2;
					panel1.Top=lpiy;
					panel1.BackColor = Color.FromArgb(yi,yi,yi,yi);
					//Thread.Sleep(1);
				}
				return true;
			}
			return false;
		}
		int counter = 0;
		void Button1Click(object sender, EventArgs e)
		{
			gg();
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			counter++;
			Text = counter.ToString();
		}
		
		
		
	}
}
