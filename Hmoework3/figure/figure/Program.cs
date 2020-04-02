using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figure
{
    interface Chart
    {
      
        bool  IsValidFigure();//assert if the chart is legal
        double GetArea();//Get the area
        void display();//show the type of the chart
    }
    class Rectangle:Chart
    {
        double length;
        double width;
        double area;
        public Rectangle(double length,double width)
        {
            this.length = length;
            this.width = width;
        }
        public bool  IsValidFigure()
        {
            if (this.length>0&&this.width>0) return true;
            else return false;
        }
        public double GetArea()
        {
            this.area = length * width;
            return this.area;
        }
        public void display()
        {
            if (this.IsValidFigure())
            {
                Console.WriteLine("This is a rectangle.");
            }
            else
            {
                Console.WriteLine("This is a illegal rectangle! Please input again!");
            }
        }
    }
    class Square:Chart
    {
        double edge;
        double area;
        public Square(double edge)
        {
            this.edge = edge;
        }
        public bool IsValidFigure()
        {
            if (this.edge > 0) return true;
            else return false;
        }
        public double GetArea()
        {
            this.area = this.edge * this.edge;
            return this.area;
        }
        public void display()
        {
            if (this.IsValidFigure())
            {
                Console.WriteLine("This is a square.");
            }
            else
            {
                Console.WriteLine("This is a illegal square! Please input again");
            }
        }
    }
    class Triangle : Chart
    {
        double[] edges = new double[3];
        double area;
        double edgemax;
        double edgemin;
        double lengthsum=0;
        public Triangle(double[] edges)
        {
            for(int i=0;i<=2;i++)
            {
                this.edges[i] = edges[i];
                lengthsum += edges[i];
            }
            this.edgemax = edges[0] >= edges[1] ? edges[0] : edges[1];
            this.edgemax = this.edgemax >= edges[2] ? this.edgemax : edges[2];//get the max length edge
            this.edgemin = edges[0] <= edges[1] ? edges[0] : edges[1];
            this.edgemin = this.edgemin <= edges[2] ? edgemin : edges[2];//get the min length edge

        }
        public bool IsValidFigure()
        {
            if (edgemin > 0 && 2*edgemax < lengthsum){
                return true;
            }
           else
            {
                return false;
            }
        }
        public double GetArea()
        {
            double helen;//海伦公式中的参数
            helen = lengthsum / 2;
            area =Math.Sqrt(helen*(helen - edges[0]) * (helen - edges[1]) * (helen - edges[2]));
            return this.area;
        }
        public void display()
        {
           if(this.IsValidFigure())
            {
                Console.WriteLine("This is a tirangle");
            }
            else
            {
                Console.WriteLine("This is a illegal triangle! Please input again!");
            }
        }

    }

    class ChartFactory
    {
        //静态工厂方法  
        public static Chart getChart(string[] stredges)
        {
            Chart chart = null;
            double[] edges = new double[stredges.Length];
            for (int i=0;i<stredges.Length;i++)
            {
                edges[i] = Convert.ToDouble(stredges[i]);

            }
            if(edges.Length == 3)
            {
                chart = new Triangle(edges);
                chart.display();
            }
            else if(edges.Length == 1 )
            {
                chart = new Square(edges[0]);
                chart.display();
            }
            else
            {
                chart = new Rectangle(edges[0], edges[1]);
                chart.display();
            }
            return chart;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chart chart;
            double totalArea=0;
            Console.WriteLine("请任意输入十组边长，边长间用空格隔开，每输入一组边长回车一次，边数为1-3，对应正方形，长方形，三角形");
            try
            {
                for (int i = 0; i <= 9; i++)
                {
                    string strline = Console.ReadLine();
                    string[] stredges = System.Text.RegularExpressions.Regex.Replace(strline.Trim(), @"[\s]+", " ").Split(" ".ToCharArray());
                    chart = ChartFactory.getChart(stredges);
                    if (!chart.IsValidFigure())
                    {
                        i--;
                    }
                    totalArea += chart.GetArea();
                }
                Console.WriteLine("10个图形的总面积为：", totalArea);
            }
            catch(Exception e)
            {
                Console.WriteLine("输入的边数不符合数量要求",e.Message);
            }
            }
    }
}
