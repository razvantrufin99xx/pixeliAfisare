/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 5/28/2024
 * Time: 7:16 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace randomPixeliFundal
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
		public Graphics g;
		public Pen p = new Pen(Color.Black,1);
		public Brush b = new SolidBrush(Color.Black);
		public Font f;
		Random rnd = new Random();
		public void pixeli(int x1,int y1,int x2, int y2)
		{
			for(int i = x1 ; i < x2; i+=1)
			{
				for(int j = y1 ; j < y2; j+=1)
				{
					rnd = new Random();
				   // p = new Pen(Color.FromArgb(50,rnd.Next(0,255),rnd.Next(0,255),rnd.Next(0,255)),20);
					b = new SolidBrush(Color.FromArgb(100,rnd.Next(0,255),rnd.Next(0,255),rnd.Next(0,255)));
					            
				              
				   //g.DrawEllipse(p,j*2,i,10,10);
				   g.FillRectangle(b,j*2,i,1,1);
				}
			}
		}
		
		public void demoFundal()
		{
			int x = panel1.Width;
			int y = panel1.Height;
			
			pixeli(1,1,x/10,y/10);
				
			
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			f = this.Font;
			g = panel1.CreateGraphics();
		}
		void Button1Click(object sender, EventArgs e)
		{
			demoFundal();
		}
	}
}
