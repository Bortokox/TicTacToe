
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class MainForm : Form
	{
		public MainForm()
			
		{
			InitializeComponent();
		}
		
		int count = 0;
		int p1score = 0;
		int p2score = 0;
		
		
		
		public void checkwinner(string symbol)
		{
			if(button1.Text == symbol && button2.Text == symbol && button3.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");	
			}
			else if(button4.Text == symbol && button5.Text == symbol && button6.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");
				
			}
			else if(button7.Text == symbol && button8.Text == symbol && button9.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");
				
			}
			else if(button1.Text == symbol && button4.Text == symbol && button7.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");
				
			}
			else if(button2.Text == symbol && button5.Text == symbol && button8.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");
				
			}
			else if(button3.Text == symbol && button6.Text == symbol && button9.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");
				
			}
			else if(button1.Text == symbol && button5.Text == symbol && button9.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");
				
			}
			else if(button3.Text == symbol && button5.Text == symbol && button7.Text == symbol)
			{
				MessageBox.Show(symbol+" Won the Game");
				
			}
			
		}
		public void scorecounter()
		{
			if(button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
			{
				p1score = p1score + 1;
				label6.Text = "" + p1score;
				
			}
			else if(button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
			{
				
				p1score = p1score + 1;
				label6.Text = "" + p1score;
			
			}
			else if(button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
			{
				p1score = p1score + 1;
				label6.Text = "" + p1score;
				
				
			}
			else if(button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
			{
				p1score = p1score + 1;
				label6.Text = "" + p1score;
				
				
			}
			else if(button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
			{
				p1score = p1score + 1;
				label6.Text = "" + p1score;
				
				
			}
			else if(button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
			{
				p1score = p1score + 1;
				label6.Text = "" + p1score;
				
			}
			else if(button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
			{
				p1score = p1score + 1;
				label6.Text = "" + p1score;
				
			}
			else if(button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
			{
				p1score = p1score + 1;
				label6.Text = "" + p1score;
				
				
			}
			else if(button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
			{
				
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
				
			}
			else if(button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
			{
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
				
			}
			else if(button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
			{
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
				
			}
			else if(button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
			{
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
				
			}
			else if(button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
			{
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
				
			}
			else if(button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
			{
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
				
			}
			else if(button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
			{
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
				
			}
			else if(button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
			{
		
				p2score = p2score + 1;
				label7.Text = "" + p2score ;
					
			}
		}
			
		
		public void fnsymbol(object senderobj)
		{
			string buttontxt=((Button)senderobj).Text;
			if(buttontxt == "")
			{
				if(count %2 == 0)
				{
					((Button)senderobj).Text = "O";
				}
				else
				{
					((Button)senderobj).Text = "X";
				}
				count ++;
				checkwinner("O");
				checkwinner("X");
				scorecounter();
			}
			else
			{
				MessageBox.Show("Incorrect Click");
			}
		}
			
		void Button1Click(object sender, EventArgs e)
			
		{
			fnsymbol(sender);
		}
		void Button2Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button3Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button4Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button5Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button6Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button7Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button8Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button9Click(object sender, EventArgs e)
		{
			fnsymbol(sender);
		}
		void Button10Click(object sender, EventArgs e)
		{
			button1.Text = "";
			button2.Text = "";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button6.Text = "";
			button7.Text = "";
			button8.Text = "";
			button9.Text = "";
		}
		
	}
}
