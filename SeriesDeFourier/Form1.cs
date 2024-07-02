using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesDeFourier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            seleccionFuncion.SelectedIndex = 1;
            DrawFourierSeries(100, 4 * Math.PI, 100,2,2);
        }
        private void DrawFourierSeries(int nTerms, double period, int nPoints, int A, int selecionada)
        {
            var model = new PlotModel { Title = "Serie de Fourier" };
            var series = new LineSeries();
            var series1 = new LineSeries();

            double[] xValues = Enumerable.Range(0, nPoints).Select(i => i * period / nPoints).ToArray();

            if (selecionada == 1)
            {
                foreach (double x in xValues)
                {
                    double y = FourierSeries(x, nTerms,A);
                    series.Points.Add(new DataPoint(x, y));
                }
                model.Series.Add(series);
                foreach (double x in xValues)
                {
                    double y = -FourierSeries(x, nTerms, A);
                    series1.Points.Add(new DataPoint(x, y));
                }
                model.Series.Add(series1);
            }
            else if(selecionada == 2)
            {
                foreach (double x in xValues)
                {
                    double y = FourierSeries1(x, nTerms, A);
                    series.Points.Add(new DataPoint(x, y));
                }
                model.Series.Add(series);
                foreach (double x in xValues)
                {
                    double y = -FourierSeries1(x, nTerms, A);
                    series1.Points.Add(new DataPoint(x, y));
                }
                model.Series.Add(series1);
            }
                


            plotView2.Model = model;
        }

        private double FourierSeries(double x, int nTerms,int A)
        {
            double an = 0;
            double a0 = A / Math.PI;
            //double bn = 0; al ser 0 los comentamos para ahorrar memoria
            double a1 = (A / 2) * Math.Cos(x);
            double sum = a0+a1;//se agrega a1 por el limite de an
            for (int n = 2; n <= nTerms; n++)
            {
                an = (2*A*Math.Cos(n*Math.PI/2)) / (Math.PI*(1-Math.Pow(n,2)));
                //sum += bn * Math.Sin(n * x); al ser 0 los comentamos para ahorrar memoria
                sum += an * Math.Cos(n * x);
            }
            return sum;
        }
        private double FourierSeries1(double x, int nTerms, int A)
        {
            double an = 0;
            double a0 = A / 2;
            //double bn = 0; al ser 0 los comentamos para ahorrar memoria
            double sum = a0;
            for (int n = 1; n <= nTerms; n++)
            {
                an = (2 * A * (1 - Math.Pow(-1, n))) / (Math.Pow(n * Math.PI, 2));
                //sum += bn * Math.Sin(n * x); al ser 0 los comentamos para ahorrar memoria
                sum += an * Math.Cos(n * x);
            }
            return sum;
        }
        private double FourierSeries2(double x, int nTerms, int A)
        {
            double an = 0;
            double a0 = A / 2;
            //double bn = 0; al ser 0 los comentamos para ahorrar memoria
            double sum = a0 ;
            for (int n = 1; n <= nTerms; n++)
            {
                an = (2 * A * (1-Math.Pow(-1,n))) / (Math.Pow(n*Math.PI, 2));
                //sum += bn * Math.Sin(n * x); al ser 0 los comentamos para ahorrar memoria
                sum += an * Math.Cos(n * x);
            }
            return sum;
        }
        private double FourierSeries3(double x, int nTerms, int A)
        {
            double an = 0;
            double a0 = A / Math.PI;
            //double bn = 0; al ser 0 los comentamos para ahorrar memoria
            double a1 = (A / 2) * Math.Cos(x);
            double sum = a0 + a1;//se agrega a1 por el limite de an
            for (int n = 2; n <= nTerms; n++)
            {
                an = ((2 * A * Math.Cos(n * Math.PI / 2)) / (Math.PI * (1 - Math.Pow(n, 2))));
                //sum += bn * Math.Sin(n * x); al ser 0 los comentamos para ahorrar memoria
                sum += an * Math.Cos(n * x);
            }
            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nTerms = int.Parse(nterminosText.Text);
            double periodo = double.Parse(periodoText.Text);
            int nPoints = int.Parse(nPointsText.Text);
            int A = int.Parse(AText.Text);
            int selecionada = int.Parse(seleccionFuncion.Text);
            DrawFourierSeries(nTerms, periodo * Math.PI, nPoints,A,selecionada);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plotView2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
