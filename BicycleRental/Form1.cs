using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BicycleRental.Model;
using System.Data.Entity;
using BicycleRental.Controller;

namespace BicycleRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void loadData()
        {

           

            using (var context = new DBConnection())
            {
                dataGridView1.DataSource = context.Bikes.Where(el => el.Rent != true).ToList();
                dataGridView2.DataSource = context.Rents.Select(x => new { x.RentId, x.RentDate, x.ReturnDate, Bike_BikeId = x.Bike.BikeId }).OrderByDescending(el=>el.RentId).ToList();
                dataGridView3.DataSource = context.Bikes.Where(el => el.Rent != false).ToList();
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void rentBike_Click(object sender, EventArgs e)
        {
            App.RentBike(NumberBike.Text);
            loadData();
        }

        private void AddBike_Click(object sender, EventArgs e)
        {
            // Montain 0 ,Road 1,Town 2
            BikeType typ = BikeType.Montain;
            switch (TypeBike.Text)
            {
                case "Montain": typ = BikeType.Montain; break;
                case "Road": typ = BikeType.Road; break;
                case "Town": typ = BikeType.Town; break;
            }
            App.MakeBike(NumberBike.Text, typ);
            loadData();
        }

        private void ReturnBike_Click(object sender, EventArgs e)
        {
            App.ReturnBike(NumberBike.Text);
            loadData();
        }

        private void RemoveBike_Click(object sender, EventArgs e)
        {
            App.RemoveBike(NumberBike.Text);
            loadData();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            try {
                NumberBike.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                TypeBike.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NumberBike.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
                TypeBike.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }
    }


}
