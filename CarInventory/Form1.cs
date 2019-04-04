using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CarInventory
{
    public partial class Form1 : Form
    {

        List<Car> cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string make = makeInput.Text;
            string colour = colourInput.Text;
            string year = yearInput.Text;
            string mileage = mileageInput.Text;

            Car c = new Car(make, colour, year, mileage);
            cars.Add(c);
            outputLabel.Text = "";

            for (int i = 0; i < cars.Count(); i++)
            {
                outputLabel.Text = outputLabel.Text + cars[i].make;
                outputLabel.Text = outputLabel.Text + " | " + cars[i].colour;
                outputLabel.Text = outputLabel.Text + " | " + cars[i].year;
                outputLabel.Text = outputLabel.Text + " | " + cars[i].mileage + "\n";
            }
            saveDB();
        }

        private void saveDB()
        {
            XmlWriter writer = XmlWriter.Create("Resources/cars.xml");
            writer.WriteStartElement("Cars");
            foreach (Car x in cars)
            {
                writer.WriteStartElement("Car");
                writer.WriteElementString("year", x.year);
                writer.WriteElementString("make", x.make);
                writer.WriteElementString("colour", x.colour);
                writer.WriteElementString("mileage", x.mileage);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
        }

        private void loadDB()
        {
            XmlReader reader = XmlReader.Create("Resources/cars.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {

                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
