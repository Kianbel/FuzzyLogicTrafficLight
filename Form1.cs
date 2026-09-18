using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyLogicTrafficLight
{

    // 1. yellow light 
    // 2. separate go ug waiting time 
    // 3. inputs for lane 1 
    // 4. graph sa triangle 
    // 5. change to mamdani 

    public partial class Form1 : Form
    {
        Lane l1 = new Lane();
        Lane l2 = new Lane();
        bool l1Running = true;
        bool l2Running = false;

        bool l1StartWaitingTime = false;
        bool l2StartWaitingTime = false;

        double l1WaitingTime = 0.0;
        double l2WaitingTime = 0.0;

        List<Car> carsLane1 = new List<Car>();
        List<Car> carsLane2 = new List<Car>();
        Timer animationTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

            // Setup animation timer for c
            animationTimer.Interval = 16;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();

            l2WaitingTimeLabel.Text = "Waiting Time: 0";
            l1GoTimeLabel.Text = "Go Remaining Time: ";
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;

            int roadWidth = 75;

            float stopLineL1 = height / 2 + roadWidth / 2;
            float stopLineL2 = width / 2 - roadWidth / 2;

            float carSpacing = 15f;

            int l1CarsWaiting = 0;
            int l2CarsWaiting = 0;


            // Lane 1 cars
            for (int i = 0; i < carsLane1.Count; i++)
            {
                Car currentCar = carsLane1[i];
                bool canMove = true; // assume all cars are moving

                // 1. Stop at stop line
                if (!l1Running && currentCar.Y >= stopLineL1)
                {
                    if (currentCar.Y - currentCar.Speed < stopLineL1)
                    {
                        canMove = false;
                        l1StartWaitingTime = true;
                        l2StartWaitingTime = false;
                    }
                }

                // 2. Dont bump car infront
                if (i > 0)
                {
                    Car carAhead = carsLane1[i - 1];
                    if (currentCar.Y - currentCar.Speed < carAhead.Y + carAhead.Height + carSpacing)
                    {
                        canMove = false;
                    }
                }

                if (currentCar.Y < stopLineL1) l1CarsWaiting++;

                if (canMove) currentCar.Y -= currentCar.Speed;
            }

            // Lane 2 cars
            for (int i = 0; i < carsLane2.Count; i++)
            {
                Car currentCar = carsLane2[i];
                bool canMove = true;

                // 1. Stop at stop line
                if (!l2Running && currentCar.X + currentCar.Width <= stopLineL2)
                {
                    if (currentCar.X + currentCar.Width + currentCar.Speed > stopLineL2)
                    {
                        canMove = false;
                        l1StartWaitingTime = false;
                        l2StartWaitingTime = true;
                    }
                }

                // 2. Dont bump car infront
                if (i > 0)
                {
                    Car carAhead = carsLane2[i - 1];
                    if (currentCar.X + currentCar.Width + currentCar.Speed + carSpacing > carAhead.X)
                    {
                        canMove = false;
                    }
                }

                if (currentCar.X + currentCar.Width <= stopLineL2) l2CarsWaiting++;

                if (canMove) currentCar.X += currentCar.Speed;
            }

            carsLane1.RemoveAll(car => car.Y < -50);
            carsLane2.RemoveAll(car => car.X > width + 50);

            l1CarsWaitingLabel.Text = $"Cars Waiting: {l1CarsWaiting}";
            l2CarsWaitingLabel.Text = $"Cars Waiting: {l2CarsWaiting}";

            pictureBox1.Invalidate(); // same as refresh
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;

            Graphics g = e.Graphics;

            // Road and Pavement
            int roadWidth = 75;
            int pavementWidth = (int)(roadWidth * 1.5);

            Rectangle grass = new Rectangle(0, 0, width, height);
            g.FillRectangle(Brushes.Green, grass);
            Rectangle pavement1 = new Rectangle(width / 2 - pavementWidth / 2, 0, pavementWidth, height);
            Rectangle pavement2 = new Rectangle(0, height / 2 - pavementWidth / 2, width, pavementWidth);
            g.FillRectangle(Brushes.Gray, pavement1);
            g.FillRectangle(Brushes.Gray, pavement2);
            Rectangle road1 = new Rectangle(width / 2 - roadWidth / 2, 0, roadWidth, height);
            Rectangle road2 = new Rectangle(0, height / 2 - roadWidth / 2, width, roadWidth);
            g.FillRectangle(Brushes.Black, road1);
            g.FillRectangle(Brushes.Black, road2);
            g.DrawLine(Pens.White, width / 2, 0, width / 2, height);
            g.DrawLine(Pens.White, 0, height / 2, width, height / 2);
            Rectangle centerRoad = new Rectangle(width / 2 - roadWidth / 2, height / 2 - roadWidth / 2, roadWidth, roadWidth);
            g.FillRectangle(Brushes.Black, centerRoad);

            // Traffic Lights
            int baseWidth = 25;
            int baseHeight = baseWidth * 3;
            int baseMargin = baseWidth / 5;
            int lightWidth = baseWidth;
            int inbetweenLightPadding = baseWidth / 10;

            string redOn = "#ff0000";
            string redOff = "#450000";
            string greenOn = "#00d126";
            string greenOff = "#003b0b";

            string l1Red = "";
            string l1Green = "";
            string l2Red = "";
            string l2Green = "";

            if (l1Running)
            {
                l1Red = redOff;
                l1Green = greenOn;
                l2Red = redOn;
                l2Green = greenOff;
            }
            else if (l2Running)
            {
                l1Red = redOn;
                l1Green = greenOff;
                l2Red = redOff;
                l2Green = greenOn;
            }

            Brush l1RedColorBrush = new SolidBrush(ColorTranslator.FromHtml(l1Red));
            Brush l1GreenColorBrush = new SolidBrush(ColorTranslator.FromHtml(l1Green));
            Brush l2RedColorBrush = new SolidBrush(ColorTranslator.FromHtml(l2Red));
            Brush l2GreenColorBrush = new SolidBrush(ColorTranslator.FromHtml(l2Green));
            Brush yellowOffColorBrush = new SolidBrush(ColorTranslator.FromHtml("#3d3a00"));

            int base1X = width / 2 + roadWidth;
            int base1Y = height / 2 + roadWidth;
            Rectangle base1 = new Rectangle(base1X, base1Y, baseWidth + baseMargin * 2, baseHeight + baseMargin * 2 + inbetweenLightPadding * 2);
            g.FillRectangle(Brushes.Black, base1);
            Rectangle red1 = new Rectangle(base1X + baseMargin, base1Y + baseMargin, lightWidth, lightWidth);
            Rectangle yellow1 = new Rectangle(base1X + baseMargin, base1Y + baseMargin + lightWidth + inbetweenLightPadding, lightWidth, lightWidth);
            g.FillEllipse(yellowOffColorBrush, yellow1);
            Rectangle green1 = new Rectangle(base1X + baseMargin, base1Y + baseMargin + lightWidth * 2 + inbetweenLightPadding * 2, lightWidth, lightWidth);

            int base2X = width / 2 - pavementWidth - roadWidth / 2 - 10;
            int base2Y = height / 2 - baseWidth * 4;
            Rectangle base2 = new Rectangle(base2X, base2Y, baseHeight + baseMargin * 2 + inbetweenLightPadding * 2, baseWidth + baseMargin * 2);
            g.FillRectangle(Brushes.Black, base2);
            Rectangle green2 = new Rectangle(base2X + baseMargin, base2Y + baseMargin, lightWidth, lightWidth);
            Rectangle yellow2 = new Rectangle(base2X + baseMargin + lightWidth + inbetweenLightPadding, base2Y + baseMargin, lightWidth, lightWidth);
            g.FillEllipse(yellowOffColorBrush, yellow2);
            Rectangle red2 = new Rectangle(base2X + baseMargin + lightWidth * 2 + inbetweenLightPadding * 2, base2Y + baseMargin, lightWidth, lightWidth);

            // Traffic lights on/off colors
            g.FillEllipse(l1RedColorBrush, red1);
            g.FillEllipse(l1GreenColorBrush, green1);
            g.FillEllipse(l2RedColorBrush, red2);
            g.FillEllipse(l2GreenColorBrush, green2);

            // --- DRAW CARS ---
            foreach (Car c in carsLane1) c.Draw(g);
            foreach (Car c in carsLane2) c.Draw(g);
        }

        private void SwitchLanesRunning()
        {
            l1Running = !l1Running;
            l2Running = !l2Running;
            l1WaitingTime = 0;
            l2WaitingTime = 0;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int l1Car = 6;
            int l2Car = 0;
            

            double timeExtension = l1.GetTimeExtension(l1WaitingTime, l1Car); // seconds
            double standardTrafficLightTime = 10; // seconds

            int timeCounter = 0;
            Random random = new Random();
            int width = pictureBox1.ClientSize.Width;
            int height = pictureBox1.ClientSize.Height;
            int roadWidth = 75;

            int carWidth = 20;
            int carHeight = 35;
            int carSpawnMargin = 50;

            int spawnCarChance = 3;

            int yellowLightDelayMs = 300;

            while (true)
            {
                if (l1StartWaitingTime)
                {
                    l1WaitingTime++;
                    l1WaitingTimeLabel.Text = $"Waiting Time: {l1WaitingTime:F0}";
                }
                if(l2StartWaitingTime)
                {
                    l2WaitingTime++;
                    l2WaitingTimeLabel.Text = $"Waiting Time: {l2WaitingTime:F0}";
                }

                if (l1Running)
                {
                    if (timeCounter < standardTrafficLightTime + timeExtension)
                    {
                        timeCounter++;
                        l1GoTimeLabel.Text = $"Go Time Remaining: {(standardTrafficLightTime + timeExtension - timeCounter):F0}";
                        l1WaitingTimeLabel.Text = "Waiting Time: 0";

                        if (random.Next(10) < spawnCarChance)
                        {
                            l1Car++;
                            carsLane1.Add(new Car
                            {
                                X = width / 2 + (roadWidth / 4) - carWidth/2,
                                Y = height + carSpawnMargin,
                                Width = carWidth,
                                Height = carHeight,
                                Color = Color.Blue
                            });
                            // Console.WriteLine("l1Car++ : " + l1Car);
                        }
                        if (random.Next(10) < spawnCarChance)
                        {
                            l2Car++;
                            carsLane2.Add(new Car
                            {
                                X = -carSpawnMargin,
                                Y = height / 2 + (roadWidth / 4) - carWidth/2,
                                Width = carHeight,
                                Height = carWidth,
                                Color = Color.Red
                            });
                            // Console.WriteLine("l2Car++ : " + l2Car);
                        }

                        if (l1Car > 0)
                        {
                            if (timeCounter % 2 == 0) l1Car--;
                        }
                    }
                    else
                    {
                        // Console.WriteLine("l1 done running");
                        // Console.WriteLine("l2 has n cars: " + l2Car);
                        timeCounter = 0;
                        timeExtension = l2.GetTimeExtension(l2WaitingTime, l2Car);

                        l2WaitingTime = standardTrafficLightTime + timeExtension;

                        // Console.WriteLine($"l2 running for additional: {timeExtension} (total: {standardTrafficLightTime + timeExtension})");

                        SwitchLanesRunning();
                        l1WaitingTimeLabel.Text = "Waiting Time: 0";
                        l1GoTimeLabel.Text = "Go Time Remaining: 0";
                    }
                }
                else if (l2Running)
                {
                    if (timeCounter < standardTrafficLightTime + timeExtension)
                    {
                        timeCounter++;
                        l2GoTimeLabel.Text = $"Go Time Remaining: {(standardTrafficLightTime + timeExtension - timeCounter):F0}";
                        l2WaitingTimeLabel.Text = "Waiting Time: 0";

                        // Console.WriteLine("l2Running " + timeCounter);

                        if (random.Next(10) < spawnCarChance)
                        {
                            l1Car++;
                            // Spawn a vertical car at the bottom
                            carsLane1.Add(new Car
                            {
                                X = width / 2 + (roadWidth / 4) - 10,
                                Y = height + carSpawnMargin,
                                Width = 20,
                                Height = 35,
                                Color = Color.Blue
                            });
                            // Console.WriteLine("l1Car++ : " + l1Car);
                        }
                        if (random.Next(10) < spawnCarChance)
                        {
                            l2Car++;
                            carsLane2.Add(new Car
                            {
                                X = -carSpawnMargin,
                                Y = height / 2 + (roadWidth / 4) - carWidth/2,
                                Width = carHeight,
                                Height = carWidth,
                                Color = Color.Red
                            });
                            // Console.WriteLine("l2Car++ : " + l2Car);
                        }

                        if (l2Car > 0)
                        {
                            if (timeCounter % 2 == 0) l2Car--;
                        }
                    }
                    else
                    {
                        // Console.WriteLine("l2 done running");
                        // Console.WriteLine("l1 has n cars: " + l1Car);
                        timeCounter = 0;
                        timeExtension = l1.GetTimeExtension(l1WaitingTime, l1Car);
                        
                        l1WaitingTime = standardTrafficLightTime + timeExtension;

                        // Console.WriteLine($"l1 running for additional: {timeExtension} (total: {standardTrafficLightTime + timeExtension})");

                        SwitchLanesRunning();
                        l2WaitingTimeLabel.Text = "Waiting Time: 0";
                        l2GoTimeLabel.Text = "Go Time Remaining: 0";
                    }
                }

                await Task.Delay(500);
            }
        }
    }

    public class Car
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Speed { get; set; } = 3f; // Adjust this number for faster/slower cars
        public Color Color { get; set; }

        public void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), X, Y, Width, Height);
        }
    }

    public class Lane
    {
        public double GetTimeExtension(double waitingTime, int carQueue)
        {
            double briefWaitingTime = TriangularMembership(waitingTime, -15, 0, 15);
            double moderateWaitingTime = TriangularMembership(waitingTime, 10, 20, 30);
            double prolongedWaitingTime = TriangularMembership(waitingTime, 25, 37.5, 50);

            double shortCarQueue = TriangularMembership(carQueue, -6, 0, 6);
            double mediumCarQueue = TriangularMembership(carQueue, 4, 9.5, 15);
            double longCarQueue = TriangularMembership(carQueue, 12, 18.5, 25);

            double highRule = Math.Max(prolongedWaitingTime, longCarQueue);
            double moderateRule = Math.Min(moderateWaitingTime, mediumCarQueue);
            double lowRule = Math.Min(briefWaitingTime, shortCarQueue);

            double cShort = 10.0;
            double cMedium = 15.0;
            double cLong = 20.0;
            double numerator = (lowRule * cShort) + (moderateRule * cMedium) + (highRule * cLong);
            double denominator = highRule + moderateRule + lowRule;
            double centroid = 0.0;
            if (denominator > 0)
            {
                centroid = numerator / denominator;
            }
            return centroid;
        }

        private double TriangularMembership(double x, double a, double b, double c)
        {
            if (x <= a || x >= c)
                return 0.0;
            if (x == b)
                return 1.0;
            if (x > a && x < b)
                return (x - a) / (b - a);
            return (c - x) / (c - b);
        }
    }
}