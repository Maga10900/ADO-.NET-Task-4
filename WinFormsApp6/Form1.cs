using System;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {


        public int s { get; set; } = -1;
        public Form1()
        {
            InitializeComponent();
            using (CarContex db = new())
            {
                listBox1.DataSource = db.Cars.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CarContex db = new())
            {

                if (MakeTxtBox.Text != string.Empty || SNumberTxtBox.Text != string.Empty || YearTxtBox.Text != string.Empty || ModelTxtBox.Text != string.Empty)
                {
                    Car car = new();
                    car.Marka = MakeTxtBox.Text;
                    car.Model = SNumberTxtBox.Text;
                    car.Year = int.Parse(YearTxtBox.Text);
                    car.stNum = ModelTxtBox.Text;
                    db.Cars.Add(car);
                    db.SaveChanges();
                    MessageBox.Show("Car is added");
                    MakeTxtBox.Text = string.Empty;
                    SNumberTxtBox.Text = string.Empty;
                    YearTxtBox.Text = string.Empty;
                    ModelTxtBox.Text = string.Empty;
                    listBox1.DataSource = db.Cars.ToList();
                }
                else
                {
                    MessageBox.Show("Fill All datas");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (CarContex db = new())
            {
                db.Cars.Remove(listBox1.SelectedItem as Car);
                db.SaveChanges();
                listBox1.DataSource = null;
                listBox1.DataSource = db.Cars;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (CarContex db = new())
            {
                Car uCar = listBox1.SelectedItem as Car;

                uCar.Marka = MakeTxtBox.Text;
                uCar.Model = ModelTxtBox.Text;
                uCar.Year = int.Parse(YearTxtBox.Text);
                uCar.stNum = SNumberTxtBox.Text;
                db.Cars.Update(uCar);
                db.SaveChanges();
                listBox1.DataSource = db.Cars.ToList();
                listBox1.Refresh();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car uCar = listBox1.SelectedItem as Car;
            MakeTxtBox.Text = uCar.Marka;
            ModelTxtBox.Text = uCar.Model;
            YearTxtBox.Text = uCar.Year.ToString();
            SNumberTxtBox.Text = uCar.stNum;

        }
    }
}
