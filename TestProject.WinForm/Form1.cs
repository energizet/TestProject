using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.DB;
using TestProject.View.Models;

namespace TestProject.WinForm
{
	public partial class Form1 : Form
	{
		private GameController GameController { get; } = new();
		private IEnumerable<Game> Games { get; set; }

		public Form1()
		{
			InitializeComponent();
			dtbId.Visible = false;
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			await GameController.Developers.GetAll();
			Games = await GameController.GetAll();
			Update(Games);
		}

		private void bAdd_Click(object sender, EventArgs e)
		{

		}

		private void Update(IEnumerable<Game> list)
		{
			dataGridView1.Rows.Clear();
			foreach (var item in list)
			{
				dataGridView1.Rows.Add(item.Id, item.Name, item.Developer.Name);
			}
		}
	}
}
